using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Configuration;
using System.IO;

namespace Orbital
{
    public partial class FrmOrbital : Form
    {
        public sealed class BodyConfigElement : ConfigurationElement
        {
            public BodyConfigElement()
            {
            }

            public BodyConfigElement(string name)
            {
                Name = name;
            }

            [ConfigurationProperty("name", IsRequired = true, IsKey = true)]
            public string Name
            {
                get
                {
                    return (string)this["name"];
                }

                set
                {
                    this["name"] = value;
                }
            }

            [ConfigurationProperty("image", 
                IsRequired = false,
                DefaultValue = null
                )]
            public string Image
            {
                get
                {
                    return (string)this["image"];
                }

                set
                {
                    this["image"] = value;
                }
            }

            [ConfigurationProperty("mass",
                IsRequired = false,
                DefaultValue = 0F
                )]
            public float Mass
            {
                get
                {
                    return (float)this["mass"];
                }

                set
                {
                    this["mass"] = value;
                }
            }

            [ConfigurationProperty("radius",
                IsRequired = true,
                DefaultValue = 0F
                )]
            public float Radius
            {
                get
                {
                    return (float)this["radius"];
                }

                set
                {
                    this["radius"] = value;
                }
            }

            [ConfigurationProperty("color",
                IsRequired = false,
                DefaultValue = 0
                )]
            public int Color
            {
                get
                {
                    return (int)this["color"];
                }

                set
                {
                    this["color"] = value;
                }
            }

            [ConfigurationProperty("islocked",
                IsRequired = false,
                DefaultValue = false
                )]
            public bool Locked
            {
                get
                {
                    return (bool)this["islocked"];
                }

                set
                {
                    this["islocked"] = value;
                }
            }

            [ConfigurationProperty("x",
                IsRequired = false,
                DefaultValue = 0F
                )]
            public float X
            {
                get
                {
                    return (float)this["x"];
                }

                set
                {
                    this["x"] = value;
                }
            }

            [ConfigurationProperty("y",
                IsRequired = false,
                DefaultValue = 0F
                )]
            public float Y
            {
                get
                {
                    return (float)this["y"];
                }

                set
                {
                    this["y"] = value;
                }
            }

            [ConfigurationProperty("vx",
                IsRequired = false,
                DefaultValue = 0F
                )]
            public float VX
            {
                get
                {
                    return (float)this["vx"];
                }

                set
                {
                    this["vx"] = value;
                }
            }

            [ConfigurationProperty("vy",
                IsRequired = false,
                DefaultValue = 0F
                )]
            public float VY
            {
                get
                {
                    return (float)this["vy"];
                }

                set
                {
                    this["vy"] = value;
                }
            }
        }

        public sealed class BodyCollection : ConfigurationElementCollection
        {
            public new BodyConfigElement this[string name]
            {
                get
                {
                    BodyConfigElement element;
                    if (IndexOf(name) < 0)
                    {
                        element = new BodyConfigElement(name);
                        BaseAdd(element);
                    }
                    else
                        element = (BodyConfigElement)BaseGet(name);

                    return element;
                }
            }

            public BodyConfigElement this[int index]
            {
                get 
                { 
                    return (BodyConfigElement)BaseGet(index);
                }
            }

            protected override string ElementName
            {
                get
                {
                    return "body";
                }
            }

            public int IndexOf(string name)
            {
                name = name.ToLower();

                for (int idx = 0; idx < base.Count; idx++)
                    if (this[idx].Name.ToLower() == name)
                        return idx;

                return -1;
            }

            public override ConfigurationElementCollectionType CollectionType
            {
                get
                {
                    return ConfigurationElementCollectionType.BasicMap;
                }
            }

            protected override ConfigurationElement CreateNewElement()
            {
                return new BodyConfigElement();
            }

            protected override object GetElementKey(ConfigurationElement element)
            {
                return ((BodyConfigElement)element).Name;
            }
            
            public void Clear()
            {
                BaseClear();
            }
        }

        public sealed class OrbitalSection : ConfigurationSection
        {
            public OrbitalSection()
            {
            }

            [ConfigurationProperty("backgroundFileName",
                DefaultValue = null,
                IsRequired = false
                )]
            public string BackgroundFileName
            {
                get
                {
                    return (string)this["backgroundFileName"];
                }

                set
                {
                    this["backgroundFileName"] = value;
                }
            }

            [ConfigurationProperty("drawPath",
                DefaultValue = true,
                IsRequired = false
                )]
            public bool DrawPath
            {
                get
                {
                    return (bool)this["drawPath"];
                }

                set
                {
                    this["drawPath"] = value;
                }
            }

            [ConfigurationProperty("g",
                DefaultValue = Consts.G,
                IsRequired = false
                )]
            public float G
            {
                get
                {
                    return (float)this["g"];
                }

                set
                {
                    this["g"] = value;
                }
            }

            [ConfigurationProperty("viewPortWidth",
                DefaultValue = VIEW_PORT_WIDTH,
                IsRequired = false
                )]
            public float ViewPortWidth
            {
                get
                {
                    return (float)this["viewPortWidth"];
                }

                set
                {
                    this["viewPortWidth"] = value;
                }
            }

            [ConfigurationProperty("bodies", IsDefaultCollection = true)]
            public BodyCollection Bodies
            {
                get
                {
                    return (BodyCollection)base["bodies"];
                }
            }
        }

        public const float VIEW_PORT_WIDTH = 400E9F;

        public const float TIME_SCALE = 1E3F;

        private Body selected;

        private List<Body> bodies;

        private Stopwatch watcher;

        private string backgroundFileName;
        private Image background;
        private Bitmap path;

        private string imageFileName;

        private bool reset;
        private bool dragging;

        private Configuration config;

        private float viewPortWidth = VIEW_PORT_WIDTH;

        public FrmOrbital()
        {
            InitializeComponent();

            watcher = new Stopwatch();

            background = null;

            //Body sun = new Body("sun", Vector2D.NULL_VECTOR, Vector2D.NULL_VECTOR, (float)Consts.SUN_MASS, SUN_RADIUS, Image.FromFile(@"resources\objects\Brightman Sun.png"), Color.Yellow);
            //Body earth = new Body("earth", new Vector2D((float)(Consts.DISTANCE_EARH_SUN), 0), new Vector2D(0, (float)Consts.EARH_SPEED), (float)Consts.EARH_MASS, EARTH_RADIUS, Image.FromFile(@"resources\objects\Chequer Milos Earth.png"), Color.Blue);
            //Body moon = new Body("moon", new Vector2D((float)(Consts.DISTANCE_EARH_SUN + Consts.DISTANCE_EARH_MOON), 0), new Vector2D(0, (float)(Consts.EARH_SPEED /*+ Consts.MOON_SPEED*/)), (float)Consts.MOON_MASS, EARTH_RADIUS, Image.FromFile(@"resources\objects\Planet Gebirge.png"), Color.Red);

            //Body star1 = new Body("star1", new Vector2D(-1E11F, 0), Vector2D.NULL_VECTOR, 1E30F, 5E10F, null, Color.Yellow, true);
            //Body star2 = new Body("star2", new Vector2D(+1E11F, 0), Vector2D.NULL_VECTOR, 1E30F, 5E10F, null, Color.Blue, true);
            //Body planet = new Body("planet", new Vector2D(0, 0), new Vector2D(+10000, +30000), 1E30F, 1E10F, null, Color.Green);

            bodies = new List<Body>();

            //bodies.Add(sun);
            //bodies.Add(earth);
            //bodies.Add(moon);

            //bodies.Add(star1);
            //bodies.Add(star2);
            //bodies.Add(planet);

            selected = null;

            path = new Bitmap(pbSimulation.ClientSize.Width, pbSimulation.ClientSize.Height);

            reset = true;
            dragging = false;

            imageFileName = null;
        }

        private void UpdateBodiesListBox()
        {
            lbBodies.Items.Clear();
            for (int i = 0; i < bodies.Count; i++)
                lbBodies.Items.Add(bodies[i]);
        }

        public float Transform(float input)
        {
            float scale = pbSimulation.ClientSize.Width / viewPortWidth;
            return input * scale;
        }

        public PointF Transform(Vector2D v)
        {
            float x = Transform(v.X) + pbSimulation.ClientSize.Width * 0.5F;
            float y = pbSimulation.ClientSize.Height * 0.5F - Transform(v.Y);
            return new PointF(x, y);
        }

        private void tmrTick_Tick(object sender, EventArgs e)
        {
            watcher.Stop();
            long dt = (long)(watcher.ElapsedMilliseconds * TIME_SCALE);

            for (int i = 0; i < bodies.Count; i++)
            {
                Body body = bodies[i];
                body.BeginIteract();
            }

            for (int i = 0; i < bodies.Count; i++)
            {
                Body body = bodies[i];
                body.Iteract(bodies, dt);
            }

            if (selected != null)
                UpdateSelected(selected);

            pbSimulation.Invalidate();
            watcher.Reset();
            watcher.Start();
        }

        private void lblColor_DoubleClick(object sender, EventArgs e)
        {
            DialogResult dr = cdColorDialog.ShowDialog();
            if (dr == DialogResult.OK)
                lblColor.BackColor = cdColorDialog.Color;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (tmrTick.Enabled)
            {
                watcher.Stop();
                tmrTick.Enabled = false;
                btnPlay.Text = "Play";
                btnAdd.Enabled = true;
            }
            else
            {
                watcher.Reset();
                watcher.Start();
                tmrTick.Enabled = true;
                btnPlay.Text = "Pause";
                btnAdd.Enabled = false;
            }

            UpdateSelected(selected);
        }

        private void btnReset_Click(object sender, EventArgs e)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            float mass;
            float radius;
            float x;
            float y;
            float vx;
            float vy;

            string name = txtName.Text;
            if (name == "")
                name = GenerateName();
            else if (NameExist(name))
            {
                MessageBox.Show("Nome já existente. Por favor escolha um outro nome.");
                return;
            }

            try
            {
                mass = float.Parse(txtMass.Text, CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato inválido do valor da massa.");
                return;
            }

            try
            {
                radius = float.Parse(txtRadius.Text, CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato inválido do valor do raio.");
                return;
            }

            try
            {
                x = float.Parse(txtX.Text, CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato inválido do valor de x.");
                return;
            }

            try
            {
                y = float.Parse(txtY.Text, CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato inválido do valor de y.");
                return;
            }

            try
            {
                vx = float.Parse(txtVX.Text, CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato inválido do valor de vx.");
                return;
            }

            try
            {
                vy = float.Parse(txtVY.Text, CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato inválido do valor de vy.");
                return;
            }

            Body body = new Body(name, new Vector2D(x, y), new Vector2D(vx, vy), mass, radius, imageFileName, lblColor.BackColor);
            bodies.Add(body);
            lbBodies.Items.Add(body);
            pbSimulation.Invalidate();

            UpdateSelected(body);
        }

        private void pbSimulation_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = Graphics.FromImage(path);


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
                    using (Pen pen = new Pen(body.Color, 3))
                    {
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
            }

            g = e.Graphics;

            if (background != null)
                g.DrawImage(background, 0, 0, pbSimulation.ClientSize.Width, pbSimulation.ClientSize.Height);
            else
                g.Clear(Color.Black);

            if (chkShowPath.Checked)
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
                    using (Brush brush = new SolidBrush(body.Color))
                    {
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
                chkLocked.Checked = false;
                btnUpdate.Enabled = false;
                btnRemove.Enabled = false;
                lbBodies.SelectedItem = null;
            }
        }

        private void pbSimulation_MouseDown(object sender, MouseEventArgs e)
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

        private void pbSimulation_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {

            }
        }

        private void pbSimulation_MouseUp(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                dragging = false;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (selected != null)
            {
                bodies.Remove(selected);
                lbBodies.Items.Remove(selected);
                UpdateSelected(null);
                pbSimulation.Invalidate();
            }    
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selected == null)
                return;

            string name = txtName.Text;
            if (name == "")
                name = GenerateName();
            else if (name != selected.Name && NameExist(name))
            {
                MessageBox.Show("Nome já existente. Por favor escolha um outro nome.");
                return;
            }

            float mass;
            float radius;
            float x;
            float y;
            float vx;
            float vy;

            try
            {
                mass = float.Parse(txtMass.Text, CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato inválido do valor da massa.");
                return;
            }

            try
            {
                radius = float.Parse(txtRadius.Text, CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato inválido do valor do raio.");
                return;
            }

            try
            {
                x = float.Parse(txtX.Text, CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato inválido do valor de x.");
                return;
            }

            try
            {
                y = float.Parse(txtY.Text, CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato inválido do valor de y.");
                return;
            }

            try
            {
                vx = float.Parse(txtVX.Text, CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato inválido do valor de vx.");
                return;
            }

            try
            {
                vy = float.Parse(txtVY.Text, CultureInfo.InvariantCulture);
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
            selected.Locked = chkLocked.Checked;

            int index = lbBodies.Items.IndexOf(selected);
            lbBodies.Items[index] = selected;

            pbSimulation.Invalidate();
        }

        private void pbSimulation_SizeChanged(object sender, EventArgs e)
        {
            path.Dispose();
            path = new Bitmap(pbSimulation.Width, pbSimulation.Height);

            pbSimulation.Invalidate();
        }

        private void pbSelectedImage_DoubleClick(object sender, EventArgs e)
        {
            DialogResult dr = ofdOpenFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                try
                {
                    imageFileName = ofdOpenFileDialog.FileName;
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

        private void lblSelectedColor_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogResult dr = cdColorDialog.ShowDialog();
            if (dr == DialogResult.OK)
                lblColor.BackColor = cdColorDialog.Color;
        }

        private void lbBodies_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbBodies.SelectedIndex;
            if (index == -1)
                return;

            Body body = lbBodies.Items[index] as Body;
            UpdateSelected(body);
        }

        private void ChangeBackground(string fileName)
        {
            try
            {
                backgroundFileName = fileName;
                background = fileName != null && fileName != "" ? Image.FromFile(fileName) : null;
                pbSimulation.Invalidate();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Arquivo de imagem de fundo '" + fileName + "' não encontrado.");
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao carregar a imagem de fundo (" + e.Message + ").");
            }
        }

        private void FrmOrbital_Load(object sender, EventArgs e)
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            OrbitalSection section = config.Sections["OrbitalSection"] as OrbitalSection;
            if (section == null)
            {
                section = new OrbitalSection();
                config.Sections.Add("OrbitalSection", section);
                config.Save();
            }

            ChangeBackground(section.BackgroundFileName);

            chkShowPath.Checked = section.DrawPath;

            Body.G = section.G;
            txtG.Text = Body.G.ToString(CultureInfo.InvariantCulture);

            viewPortWidth = section.ViewPortWidth;
            txtViewPortWidth.Text = viewPortWidth.ToString(CultureInfo.InvariantCulture);

            BodyCollection collection = section.Bodies;
            foreach (BodyConfigElement element in collection)
            {
                string imageFileName = element.Image;
                try
                {
                    Image.FromFile(imageFileName);
                }
                catch (Exception)
                {
                    imageFileName = null;
                }

                Body body = new Body(element.Name, new Vector2D(element.X, element.Y), new Vector2D(element.VX, element.VY), element.Mass, element.Radius, imageFileName, Color.FromArgb(element.Color), element.Locked);
                bodies.Add(body);
            }

            UpdateBodiesListBox();
        }

        private void FrmOrbital_FormClosing(object sender, FormClosingEventArgs e)
        {
            OrbitalSection section = config.Sections["OrbitalSection"] as OrbitalSection;
            if (section == null)
            {
                section = new OrbitalSection();
                config.Sections.Add("OrbitalSection", section);               
            }

            section.BackgroundFileName = backgroundFileName;
            section.DrawPath = chkShowPath.Checked;
            section.G = Body.G;
            section.ViewPortWidth = viewPortWidth;

            BodyCollection collection = section.Bodies;
            collection.Clear();
            for (int i = 0; i < bodies.Count; i++)
            {
                Body body = bodies[i];
                BodyConfigElement element = collection[body.Name];
                element.Mass = body.Mass;
                element.Radius = body.Radius;
                element.Image = body.ImageFileName;
                element.Color = body.Color.ToArgb();
                element.Locked = body.Locked;

                Vector2D pos = body.InitialPosition;
                element.X = pos.X;
                element.Y = pos.Y;

                Vector2D vel = body.InitialVelocity;
                element.VX = vel.X;
                element.VY = vel.Y;
            }

            config.Save();
        }

        private void btnChangeBackground_Click(object sender, EventArgs e)
        {
            DialogResult dr = ofdOpenFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
                ChangeBackground(ofdOpenFileDialog.FileName);
        }

        private void btnClearBackground_Click(object sender, EventArgs e)
        {
            ChangeBackground(null);
        }

        private void btnConstantsApply_Click(object sender, EventArgs e)
        {
            try
            {
                Body.G = float.Parse(txtG.Text, CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato inválido do valor de G.");
            }

            try
            {
                viewPortWidth = float.Parse(txtViewPortWidth.Text, CultureInfo.InvariantCulture);
                pbSimulation.Invalidate();
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato inválido do valor da largura da câmera.");
            }
        }
    }
}
