using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Orbital;

public partial class FrmOrbital : Form
{
    public sealed class OrbitalSection : ConfigurationSection
    {
        public OrbitalSection()
        {
        }

        [ConfigurationProperty("documentFilePath",
            DefaultValue = null,
            IsRequired = false
            )]
        public string DocumentFilePath
        {
            get => (string) this["documentFilePath"];

            set => this["documentFilePath"] = value;
        }

        [ConfigurationProperty("left",
            DefaultValue = -1,
            IsRequired = false
            )]
        public int Left
        {
            get => (int) this["left"];

            set => this["left"] = value;
        }

        [ConfigurationProperty("top",
            DefaultValue = -1,
            IsRequired = false
            )]
        public int Top
        {
            get => (int) this["top"];

            set => this["top"] = value;
        }

        [ConfigurationProperty("width",
            DefaultValue = -1,
            IsRequired = false
            )]
        public int Width
        {
            get => (int) this["width"];

            set => this["width"] = value;
        }

        [ConfigurationProperty("height",
            DefaultValue = -1,
            IsRequired = false
            )]
        public int Height
        {
            get => (int) this["height"];

            set => this["height"] = value;
        }

        [ConfigurationProperty("maximized",
            DefaultValue = false,
            IsRequired = false
            )]
        public bool Maximized
        {
            get => (bool) this["maximized"];

            set => this["maximized"] = value;
        }
    }

    public const double VIEW_PORT_WIDTH = 400E9;
    public const float TIME_SCALE = 1000;
    public const int STEPS_PER_FRAME = 1;

    private Body selected;

    private readonly List<Body> bodies;

    private readonly Stopwatch watcher;

    private string backgroundFilePath;
    private Image background;
    private Bitmap path;

    private string imageFileName;

    private bool reset;
    private bool dragging;

    private Configuration config;

    private double viewPortWidth = VIEW_PORT_WIDTH;
    private float timeScale = TIME_SCALE;
    private int stepsPerFrame = STEPS_PER_FRAME;

    private bool drawPath;

    private string documentFilePath;

    private Rectangle unmaximizedBounds;

    public FrmOrbital()
    {
        InitializeComponent();

        watcher = new Stopwatch();

        background = null;

        bodies = new List<Body>();

        selected = null;

        reset = true;
        dragging = false;

        imageFileName = null;
        documentFilePath = null;
    }

    private void UpdateBodiesListBox()
    {
        lbBodies.Items.Clear();
        for (int i = 0; i < bodies.Count; i++)
            lbBodies.Items.Add(bodies[i]);
    }

    public float Transform(double input)
    {
        double scale = pbSimulation.ClientSize.Width / viewPortWidth;
        return (float) (input * scale);
    }

    public PointF Transform(Vector2D v)
    {
        float x = Transform(v.X) + pbSimulation.ClientSize.Width * 0.5F;
        float y = pbSimulation.ClientSize.Height * 0.5F - Transform(v.Y);
        return new PointF(x, y);
    }

    private void TmrTick_Tick(object sender, EventArgs e)
    {
        watcher.Stop();
        long dt = (long) (watcher.ElapsedMilliseconds * timeScale / stepsPerFrame);

        for (int counter = 0; counter < stepsPerFrame; counter++)
        {
            for (int i = 0; i < bodies.Count; i++)
            {
                Body body = bodies[i];
                body.BeginIteract(bodies, dt);
            }

            for (int i = 0; i < bodies.Count; i++)
            {
                Body body = bodies[i];
                body.Step(bodies, dt);
            }
        }

        if (selected != null)
            UpdateSelected(selected);

        pbSimulation.Invalidate();
        watcher.Reset();
        watcher.Start();
    }

    private void LblColor_DoubleClick(object sender, EventArgs e)
    {
        DialogResult dr = cdColorDialog.ShowDialog();
        if (dr == DialogResult.OK)
            lblColor.BackColor = cdColorDialog.Color;
    }

    private string GenerateName()
    {
        string result = "body1";
        int counter = 1;
        for (int i = 0; i < bodies.Count; i++)
        {
            Body body = bodies[i];
            if (body.Name == result)
            {
                counter++;
                result = "body" + counter;
            }
        }

        return result;
    }

    private bool NameExist(string name)
    {
        for (int i = 0; i < bodies.Count; i++)
        {
            Body body = bodies[i];
            if (body.Name == name)
                return true;
        }

        return false;
    }

    private void BtnAdd_Click(object sender, EventArgs e)
    {
        double mass;
        double radius;
        double x;
        double y;
        double vx;
        double vy;

        string name = txtName.Text;
        if (name == "")
        {
            name = GenerateName();
        }
        else if (NameExist(name))
        {
            MessageBox.Show("Nome já existente. Por favor escolha um outro nome.");
            return;
        }

        try
        {
            mass = double.Parse(txtMass.Text, CultureInfo.InvariantCulture);
        }
        catch (FormatException)
        {
            MessageBox.Show("Formato inválido do valor da massa.");
            return;
        }

        try
        {
            radius = double.Parse(txtRadius.Text, CultureInfo.InvariantCulture);
        }
        catch (FormatException)
        {
            MessageBox.Show("Formato inválido do valor do raio.");
            return;
        }

        try
        {
            x = double.Parse(txtX.Text, CultureInfo.InvariantCulture);
        }
        catch (FormatException)
        {
            MessageBox.Show("Formato inválido do valor de x.");
            return;
        }

        try
        {
            y = double.Parse(txtY.Text, CultureInfo.InvariantCulture);
        }
        catch (FormatException)
        {
            MessageBox.Show("Formato inválido do valor de y.");
            return;
        }

        try
        {
            vx = double.Parse(txtVX.Text, CultureInfo.InvariantCulture);
        }
        catch (FormatException)
        {
            MessageBox.Show("Formato inválido do valor de vx.");
            return;
        }

        try
        {
            vy = double.Parse(txtVY.Text, CultureInfo.InvariantCulture);
        }
        catch (FormatException)
        {
            MessageBox.Show("Formato inválido do valor de vy.");
            return;
        }

        var body = new Body(name, new Vector2D(x, y), new Vector2D(vx, vy), mass, radius, imageFileName, lblColor.BackColor, chkEnabled.Checked, chkLocked.Checked);
        bodies.Add(body);
        lbBodies.Items.Add(body);
        pbSimulation.Invalidate();

        UpdateSelected(body);
    }

    private void PbSimulation_Paint(object sender, PaintEventArgs e)
    {
        var g = Graphics.FromImage(path);

        if (reset)
        {
            g.Clear(Color.Transparent);
            reset = false;
        }
        else if (tmrTick.Enabled)
        {
            for (int i = 0; i < bodies.Count; i++)
            {
                Body body = bodies[i];
                using var pen = new Pen(body.Color, 3);
                PointF p0 = Transform(body.LastPosition);
                PointF p = Transform(body.Position);

                try
                {
                    g.DrawLine(pen, p0, p);
                }
                catch (Exception)
                {
                }
            }
        }

        g = e.Graphics;

        if (background != null)
            g.DrawImage(background, 0, 0, pbSimulation.ClientSize.Width, pbSimulation.ClientSize.Height);
        else
            g.Clear(Color.Black);

        if (drawPath)
            g.DrawImage(path, 0, 0);

        for (int i = 0; i < bodies.Count; i++)
        {
            Body body = bodies[i];
            PointF p = Transform(body.Position);
            float radius = Transform(body.Radius);

            if (body.Image != null)
            {
                try
                {
                    g.DrawImage(body.Image, new RectangleF(p.X - radius / 2, p.Y - radius / 2, radius, radius));
                }
                catch (Exception)
                {
                }
            }
            else
            {
                using Brush brush = new SolidBrush(body.Color);
                try
                {
                    g.FillEllipse(brush, p.X - radius / 2, p.Y - radius / 2, radius, radius);
                }
                catch (Exception)
                {
                }
            }
        }
    }

    private void UpdateSelected(Body body)
    {
        selected = body;

        if (selected != null)
        {
            txtName.Text = body.Name;
            txtMass.Text = body.Mass.ToString(CultureInfo.InvariantCulture);
            txtRadius.Text = body.Radius.ToString(CultureInfo.InvariantCulture);
            lblColor.BackColor = body.Color;
            imageFileName = body.ImageFileName;
            pbImage.Image = body.Image;
            txtX.Text = body.Position.X.ToString(CultureInfo.InvariantCulture);
            txtY.Text = body.Position.Y.ToString(CultureInfo.InvariantCulture);
            txtVX.Text = body.Velocity.X.ToString(CultureInfo.InvariantCulture);
            txtVY.Text = body.Velocity.Y.ToString(CultureInfo.InvariantCulture);
            chkEnabled.Checked = body.Enabled;
            chkLocked.Checked = body.Locked;
            btnUpdate.Enabled = !tmrTick.Enabled;
            btnRemove.Enabled = !tmrTick.Enabled;
            lbBodies.SelectedItem = selected;
        }
        else
        {
            txtName.Text = "";
            txtMass.Text = "";
            txtRadius.Text = "";
            lblColor.BackColor = Color.Transparent;
            imageFileName = null;
            pbImage.Image = null;
            txtX.Text = "";
            txtY.Text = "";
            txtVX.Text = "";
            txtVY.Text = "";
            chkEnabled.Checked = true;
            chkLocked.Checked = false;
            btnUpdate.Enabled = false;
            btnRemove.Enabled = false;
            lbBodies.SelectedItem = null;
        }
    }

    private void PbSimulation_MouseDown(object sender, MouseEventArgs e)
    {
        int x = e.X;
        int y = e.Y;

        for (int i = 0; i < bodies.Count; i++)
        {
            Body body = bodies[i];
            PointF p = Transform(body.Position);
            float radius = Transform(body.Radius);

            double dx = x - p.X;
            double dy = y - p.Y;
            if (Math.Sqrt(dx * dx + dy * dy) <= radius)
            {
                dragging = true;
                UpdateSelected(body);
                return;
            }
        }

        UpdateSelected(null);
    }

    private void PbSimulation_MouseMove(object sender, MouseEventArgs e)
    {
        if (dragging)
        {

        }
    }

    private void PbSimulation_MouseUp(object sender, MouseEventArgs e)
    {
        if (dragging)
        {
            dragging = false;
        }
    }

    private void BtnRemove_Click(object sender, EventArgs e)
    {
        if (selected != null)
        {
            bodies.Remove(selected);
            lbBodies.Items.Remove(selected);
            UpdateSelected(null);
            pbSimulation.Invalidate();
        }
    }

    private void BtnUpdate_Click(object sender, EventArgs e)
    {
        if (selected == null)
            return;

        string name = txtName.Text;
        if (name == "")
        {
            name = GenerateName();
        }
        else if (name != selected.Name && NameExist(name))
        {
            MessageBox.Show("Nome já existente. Por favor escolha um outro nome.");
            return;
        }

        double mass;
        double radius;
        double x;
        double y;
        double vx;
        double vy;

        try
        {
            mass = double.Parse(txtMass.Text, CultureInfo.InvariantCulture);
        }
        catch (FormatException)
        {
            MessageBox.Show("Formato inválido do valor da massa.");
            return;
        }

        try
        {
            radius = double.Parse(txtRadius.Text, CultureInfo.InvariantCulture);
        }
        catch (FormatException)
        {
            MessageBox.Show("Formato inválido do valor do raio.");
            return;
        }

        try
        {
            x = double.Parse(txtX.Text, CultureInfo.InvariantCulture);
        }
        catch (FormatException)
        {
            MessageBox.Show("Formato inválido do valor de x.");
            return;
        }

        try
        {
            y = double.Parse(txtY.Text, CultureInfo.InvariantCulture);
        }
        catch (FormatException)
        {
            MessageBox.Show("Formato inválido do valor de y.");
            return;
        }

        try
        {
            vx = double.Parse(txtVX.Text, CultureInfo.InvariantCulture);
        }
        catch (FormatException)
        {
            MessageBox.Show("Formato inválido do valor de vx.");
            return;
        }

        try
        {
            vy = double.Parse(txtVY.Text, CultureInfo.InvariantCulture);
        }
        catch (FormatException)
        {
            MessageBox.Show("Formato inválido do valor de vy.");
            return;
        }

        selected.Name = name;
        selected.Mass = mass;
        selected.Radius = radius;
        selected.Color = lblColor.BackColor;
        selected.ImageFileName = imageFileName;
        selected.Position = new Vector2D(x, y);
        selected.Velocity = new Vector2D(vx, vy);
        selected.Enabled = chkEnabled.Checked;
        selected.Locked = chkLocked.Checked;

        int index = lbBodies.Items.IndexOf(selected);
        lbBodies.Items[index] = selected;

        pbSimulation.Invalidate();
    }

    private void PbSimulation_SizeChanged(object sender, EventArgs e)
    {
        path.Dispose();
        path = new Bitmap(pbSimulation.Width, pbSimulation.Height);

        pbSimulation.Invalidate();
    }

    private void LbBodies_SelectedIndexChanged(object sender, EventArgs e)
    {
        int index = lbBodies.SelectedIndex;
        if (index == -1)
            return;

        var body = lbBodies.Items[index] as Body;
        UpdateSelected(body);
    }

    private bool ChangeBackground(string fileName, bool showMessageOnException = true, bool invalidate = true)
    {
        try
        {
            backgroundFilePath = fileName;
            background = fileName is not null and not "" ? Image.FromFile(fileName) : null;

            if (invalidate)
                pbSimulation.Invalidate();

            return true;
        }
        catch (FileNotFoundException)
        {
            if (showMessageOnException)
                MessageBox.Show("Arquivo de imagem de fundo '" + fileName + "' não encontrado.");
        }
        catch (Exception e)
        {
            if (showMessageOnException)
                MessageBox.Show("Erro ao carregar a imagem de fundo (" + e.Message + ").");
        }

        return false;
    }

    private void FrmOrbital_Load(object sender, EventArgs e)
    {
        path = new Bitmap(pbSimulation.ClientSize.Width, pbSimulation.ClientSize.Height);

        config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        if (config.Sections["OrbitalSection"] is not OrbitalSection section)
        {
            section = new OrbitalSection();
            config.Sections.Add("OrbitalSection", section);
            config.Save();
        }

        int left = section.Left;
        int top = section.Top;
        int width = section.Width;
        int height = section.Height;

        unmaximizedBounds = new Rectangle(left >= 0 ? left : Left, top >= 0 ? top : Top, width > 0 ? width : Width, height > 0 ? height : Height);

        bool maximized = section.Maximized;

        Location = unmaximizedBounds.Location;
        Size = unmaximizedBounds.Size;

        if (maximized)
            WindowState = FormWindowState.Maximized;

        documentFilePath = section.DocumentFilePath;
        if (documentFilePath is not null and not "")
            Open(documentFilePath);
    }

    private void FrmOrbital_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (config.Sections["OrbitalSection"] is not OrbitalSection section)
        {
            section = new OrbitalSection();
            config.Sections.Add("OrbitalSection", section);
        }

        if (WindowState == FormWindowState.Maximized)
        {
            section.Left = unmaximizedBounds.Left;
            section.Top = unmaximizedBounds.Top;
            section.Width = unmaximizedBounds.Width;
            section.Height = unmaximizedBounds.Height;
            section.Maximized = true;
        }
        else
        {
            section.Left = Left;
            section.Top = Top;
            section.Width = Width;
            section.Height = Height;
            section.Maximized = false;
        }

        section.DocumentFilePath = documentFilePath;
        config.Save();
    }

    private void BtnChangeBackground_Click(object sender, EventArgs e)
    {
        DialogResult dr = openFileDialog.ShowDialog();
        if (dr == DialogResult.OK)
            ChangeBackground(openFileDialog.FileName);
    }

    private void BtnClearBackground_Click(object sender, EventArgs e)
    {
        ChangeBackground(null);
    }

    private void PbImage_DoubleClick(object sender, EventArgs e)
    {
        DialogResult dr = openObjectImageDialog.ShowDialog();
        if (dr == DialogResult.OK)
        {
            try
            {
                imageFileName = openObjectImageDialog.FileName;
                pbImage.Image = Image.FromFile(imageFileName);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Arquivo de imagem '" + imageFileName + "' não encontrado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a imagem (" + ex.Message + ").");
            }
        }
    }

    private void TsbReset_Click(object sender, EventArgs e)
    {
        reset = true;

        for (int i = 0; i < bodies.Count; i++)
        {
            Body body = bodies[i];
            body.Reset();
        }

        watcher.Reset();
        watcher.Start();

        pbSimulation.Invalidate();
    }

    private void TsbPlay_Click(object sender, EventArgs e)
    {
        if (tmrTick.Enabled)
        {
            watcher.Stop();
            tmrTick.Enabled = false;
            tsbPlay.Text = "Play";
            tsbPlay.Image = Properties.Resources.play;
            btnAdd.Enabled = true;
        }
        else
        {
            watcher.Reset();
            watcher.Start();
            tmrTick.Enabled = true;
            tsbPlay.Text = "Pause";
            tsbPlay.Image = Properties.Resources.pause;
            btnAdd.Enabled = false;
        }

        UpdateSelected(selected);
    }

    private void OptionsApply(FrmOptions sender)
    {
        Body.G = sender.G;
        viewPortWidth = sender.ViewPortWidth;
        drawPath = sender.DrawPath;
        timeScale = sender.TimeScale;
        stepsPerFrame = sender.StepsPerFrame;
        ChangeBackground(sender.BackgroundFilePath);
        pbSimulation.Invalidate();
    }

    private void TsbOptions_Click(object sender, EventArgs e)
    {
        var options = new FrmOptions
        {
            G = Body.G,
            ViewPortWidth = viewPortWidth,
            DrawPath = drawPath,
            BackgroundFilePath = backgroundFilePath,
            TimeScale = timeScale,
            StepsPerFrame = stepsPerFrame
        };

        options.OnApply += OptionsApply;
        options.Show();
    }

    private void New(bool invalidate = true)
    {
        documentFilePath = null;
        bodies.Clear();
        Body.G = Consts.G;
        viewPortWidth = VIEW_PORT_WIDTH;
        drawPath = true;
        reset = true;

        UpdateSelected(null);
        UpdateBodiesListBox();
        ChangeBackground(null, false, invalidate);

        if (invalidate)
            pbSimulation.Invalidate();
    }

    public static Image OpenImageFile(string fileName, bool showMessageOnException)
    {
        try
        {
            return fileName is not null and not "" ? Image.FromFile(fileName) : null;
        }
        catch (FileNotFoundException)
        {
            if (showMessageOnException)
                MessageBox.Show("Arquivo de imagem '" + fileName + "' não encontrado.");
        }
        catch (Exception e)
        {
            if (showMessageOnException)
                MessageBox.Show("Erro ao carregar a imagem (" + e.Message + ").");
        }

        return null;
    }

    private void Open()
    {
        DialogResult dr = openFileDialog.ShowDialog();
        if (dr == DialogResult.OK)
            Open(openFileDialog.FileName);
    }

    private void Open(string fileName)
    {
        New(false);

        documentFilePath = fileName;

        var document = new XmlDocument();
        document.Load(fileName);

        XmlNode orbital = document.SelectSingleNode("orbital");
        if (orbital == null)
            return;

        XmlNode options = orbital.SelectSingleNode("options");
        if (options != null)
        {
            XmlNode drawPath = options.Attributes.GetNamedItem("drawPath");
            if (drawPath != null)
            {
                try
                {
                    this.drawPath = bool.Parse(drawPath.Value);
                }
                catch (Exception)
                {
                    this.drawPath = true;
                }
            }
            else
            {
                this.drawPath = true;
            }

            XmlNode g = options.Attributes.GetNamedItem("G");
            if (g != null)
            {
                try
                {
                    Body.G = double.Parse(g.Value, CultureInfo.InvariantCulture);
                }
                catch (Exception)
                {
                    Body.G = Consts.G;
                }
            }
            else
            {
                Body.G = Consts.G;
            }

            XmlNode viewPortWidth = options.Attributes.GetNamedItem("viewPortWidth");
            if (g != null)
            {
                try
                {
                    this.viewPortWidth = double.Parse(viewPortWidth.Value, CultureInfo.InvariantCulture);
                }
                catch (Exception)
                {
                    this.viewPortWidth = VIEW_PORT_WIDTH;
                }
            }
            else
            {
                this.viewPortWidth = VIEW_PORT_WIDTH;
            }

            XmlNode backgroundFilePath = options.Attributes.GetNamedItem("backgroundFilePath");
            if (backgroundFilePath != null)
            {
                if (!ChangeBackground(backgroundFilePath.Value, false, false))
                    this.backgroundFilePath = null;
            }
            else
            {
                this.backgroundFilePath = null;
            }

            XmlNode timeScale = options.Attributes.GetNamedItem("timeScale");
            if (timeScale != null)
            {
                try
                {
                    this.timeScale = float.Parse(timeScale.Value, CultureInfo.InvariantCulture);
                }
                catch (Exception)
                {
                    this.timeScale = TIME_SCALE;
                }
            }
            else
            {
                this.timeScale = TIME_SCALE;
            }

            XmlNode stepsPerFrame = options.Attributes.GetNamedItem("stepsPerFrame");
            if (stepsPerFrame != null)
            {
                try
                {
                    this.stepsPerFrame = int.Parse(stepsPerFrame.Value);
                }
                catch (Exception)
                {
                    this.stepsPerFrame = STEPS_PER_FRAME;
                }
            }
            else
            {
                this.stepsPerFrame = STEPS_PER_FRAME;
            }
        }

        XmlNode bodies = orbital.SelectSingleNode("bodies");
        if (bodies != null)
        {
            XmlNodeList bodyList = bodies.SelectNodes("body");
            foreach (XmlNode bodyElement in bodyList)
            {
                string name;
                double x;
                double y;
                double vx;
                double vy;
                double mass;
                double radius;
                string imageFileName;
                Color color;
                bool enabled;
                bool locked;

                XmlNode nodeName = bodyElement.Attributes.GetNamedItem("name");
                if (nodeName != null)
                {
                    try
                    {
                        name = nodeName.Value;
                        if (NameExist(name))
                            name = GenerateName();
                    }
                    catch (Exception)
                    {
                        name = GenerateName();
                    }
                }
                else
                {
                    name = GenerateName();
                }

                XmlNode nodeX = bodyElement.Attributes.GetNamedItem("x");
                if (nodeX != null)
                {
                    try
                    {
                        x = double.Parse(nodeX.Value, CultureInfo.InvariantCulture);
                    }
                    catch (Exception)
                    {
                        x = 0;
                    }
                }
                else
                {
                    x = 0;
                }

                XmlNode nodeY = bodyElement.Attributes.GetNamedItem("y");
                if (nodeY != null)
                {
                    try
                    {
                        y = double.Parse(nodeY.Value, CultureInfo.InvariantCulture);
                    }
                    catch (Exception)
                    {
                        y = 0;
                    }
                }
                else
                {
                    y = 0;
                }

                XmlNode nodeVX = bodyElement.Attributes.GetNamedItem("vx");
                if (nodeX != null)
                {
                    try
                    {
                        vx = double.Parse(nodeVX.Value, CultureInfo.InvariantCulture);
                    }
                    catch (Exception)
                    {
                        vx = 0;
                    }
                }
                else
                {
                    vx = 0;
                }

                XmlNode nodeVY = bodyElement.Attributes.GetNamedItem("vy");
                if (nodeVY != null)
                {
                    try
                    {
                        vy = double.Parse(nodeVY.Value, CultureInfo.InvariantCulture);
                    }
                    catch (Exception)
                    {
                        vy = 0;
                    }
                }
                else
                {
                    vy = 0;
                }

                XmlNode nodeMass = bodyElement.Attributes.GetNamedItem("mass");
                if (nodeMass != null)
                {
                    try
                    {
                        mass = double.Parse(nodeMass.Value, CultureInfo.InvariantCulture);
                    }
                    catch (Exception)
                    {
                        mass = 0;
                    }
                }
                else
                {
                    mass = 0;
                }

                XmlNode nodeRadius = bodyElement.Attributes.GetNamedItem("radius");
                if (nodeRadius != null)
                {
                    try
                    {
                        radius = double.Parse(nodeRadius.Value, CultureInfo.InvariantCulture);
                    }
                    catch (Exception)
                    {
                        radius = 0;
                    }
                }
                else
                {
                    radius = 0;
                }

                XmlNode nodeImageFileName = bodyElement.Attributes.GetNamedItem("imageFileName");
                if (nodeImageFileName != null)
                {
                    try
                    {
                        imageFileName = nodeImageFileName.Value;
                        if (OpenImageFile(imageFileName, false) == null)
                            imageFileName = null;
                    }
                    catch (Exception)
                    {
                        imageFileName = null;
                    }
                }
                else
                {
                    imageFileName = null;
                }

                XmlNode nodeColor = bodyElement.Attributes.GetNamedItem("color");
                if (nodeColor != null)
                {
                    try
                    {
                        color = Color.FromArgb(int.Parse(nodeColor.Value));
                    }
                    catch (Exception)
                    {
                        color = Color.Yellow;
                    }
                }
                else
                {
                    color = Color.Yellow;
                }

                XmlNode nodeEnabled = bodyElement.Attributes.GetNamedItem("enabled");
                if (nodeEnabled != null)
                {
                    try
                    {
                        enabled = bool.Parse(nodeEnabled.Value);
                    }
                    catch (Exception)
                    {
                        enabled = true;
                    }
                }
                else
                {
                    enabled = true;
                }

                XmlNode nodeLocked = bodyElement.Attributes.GetNamedItem("locked");
                if (nodeLocked != null)
                {
                    try
                    {
                        locked = bool.Parse(nodeLocked.Value);
                    }
                    catch (Exception)
                    {
                        locked = false;
                    }
                }
                else
                {
                    locked = false;
                }

                var body = new Body(name, new Vector2D(x, y), new Vector2D(vx, vy), mass, radius, imageFileName, color, enabled, locked);
                this.bodies.Add(body);
            }

            UpdateBodiesListBox();
        }

        pbSimulation.Invalidate();
    }

    private void Save(bool newFile = false)
    {
        if (newFile || documentFilePath == null || documentFilePath == "")
        {
            DialogResult dr = saveFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
                Save(saveFileDialog.FileName);
        }
        else
        {
            Save(documentFilePath);
        }
    }

    private void Save(string fileName)
    {
        documentFilePath = fileName;

        var document = new XmlDocument();

        XmlElement orbital = document.CreateElement("orbital");

        XmlElement options = document.CreateElement("options");

        XmlAttribute drawPath = document.CreateAttribute("drawPath");
        drawPath.Value = this.drawPath.ToString();
        options.Attributes.Append(drawPath);

        XmlAttribute backgroundFilePath = document.CreateAttribute("backgroundFilePath");
        backgroundFilePath.Value = this.backgroundFilePath ?? "";
        options.Attributes.Append(backgroundFilePath);

        XmlAttribute g = document.CreateAttribute("G");
        g.Value = Body.G.ToString(CultureInfo.InvariantCulture);
        options.Attributes.Append(g);

        XmlAttribute viewPortWidth = document.CreateAttribute("viewPortWidth");
        viewPortWidth.Value = this.viewPortWidth.ToString(CultureInfo.InvariantCulture);
        options.Attributes.Append(viewPortWidth);

        XmlAttribute timeScale = document.CreateAttribute("timeScale");
        timeScale.Value = this.timeScale.ToString(CultureInfo.InvariantCulture);
        options.Attributes.Append(timeScale);

        XmlAttribute stepsPerFrame = document.CreateAttribute("stepsPerFrame");
        stepsPerFrame.Value = this.stepsPerFrame.ToString();
        options.Attributes.Append(stepsPerFrame);

        orbital.AppendChild(options);

        XmlElement bodies = document.CreateElement("bodies");

        for (int i = 0; i < this.bodies.Count; i++)
        {
            Body body = this.bodies[i];

            XmlElement bodyElement = document.CreateElement("body");

            XmlAttribute name = document.CreateAttribute("name");
            name.Value = body.Name;
            bodyElement.Attributes.Append(name);

            XmlAttribute mass = document.CreateAttribute("mass");
            mass.Value = body.Mass.ToString(CultureInfo.InvariantCulture);
            bodyElement.Attributes.Append(mass);

            XmlAttribute radius = document.CreateAttribute("radius");
            radius.Value = body.Radius.ToString(CultureInfo.InvariantCulture);
            bodyElement.Attributes.Append(radius);

            XmlAttribute x = document.CreateAttribute("x");
            x.Value = body.InitialPosition.X.ToString(CultureInfo.InvariantCulture);
            bodyElement.Attributes.Append(x);

            XmlAttribute y = document.CreateAttribute("y");
            y.Value = body.InitialPosition.Y.ToString(CultureInfo.InvariantCulture);
            bodyElement.Attributes.Append(y);

            XmlAttribute vx = document.CreateAttribute("vx");
            vx.Value = body.InitialVelocity.X.ToString(CultureInfo.InvariantCulture);
            bodyElement.Attributes.Append(vx);

            XmlAttribute vy = document.CreateAttribute("vy");
            vy.Value = body.InitialVelocity.Y.ToString(CultureInfo.InvariantCulture);
            bodyElement.Attributes.Append(vy);

            XmlAttribute imageFileName = document.CreateAttribute("imageFileName");
            imageFileName.Value = body.ImageFileName;
            bodyElement.Attributes.Append(imageFileName);

            XmlAttribute color = document.CreateAttribute("color");
            color.Value = body.Color.ToArgb().ToString();
            bodyElement.Attributes.Append(color);

            XmlAttribute enabled = document.CreateAttribute("enabled");
            enabled.Value = body.Enabled.ToString();
            bodyElement.Attributes.Append(enabled);

            XmlAttribute locked = document.CreateAttribute("locked");
            locked.Value = body.Locked.ToString();
            bodyElement.Attributes.Append(locked);

            bodies.AppendChild(bodyElement);
        }

        orbital.AppendChild(bodies);

        document.AppendChild(orbital);

        document.Save(fileName);
    }

    private void TsbOpen_Click(object sender, EventArgs e)
    {
        Open();
    }

    private void TsbSaveAs_Click(object sender, EventArgs e)
    {

    }

    private void TsbNew_Click(object sender, EventArgs e)
    {
        New();
    }

    private void MnuNew_Click(object sender, EventArgs e)
    {
        New();
    }

    private void MnuOpen_Click(object sender, EventArgs e)
    {
        Open();
    }

    private void MnuSave_Click(object sender, EventArgs e)
    {
        Save();
    }

    private void MnuSaveAs_Click(object sender, EventArgs e)
    {
        Save(true);
    }

    private void MnuClose_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void TsbSave_Click(object sender, EventArgs e)
    {
        Save(false);
    }

    private void FrmOrbital_SizeChanged(object sender, EventArgs e)
    {
        if (WindowState != FormWindowState.Maximized)
            unmaximizedBounds.Size = Size;
    }

    private void FrmOrbital_LocationChanged(object sender, EventArgs e)
    {
        if (WindowState != FormWindowState.Maximized)
            unmaximizedBounds.Location = Location;
    }
}