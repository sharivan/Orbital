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

namespace Orbital
{
    public partial class FrmOrbital : Form
    {
        public const float VIEW_PORT_WIDTH = 400E9F;
        public const float VIEW_PORT_HEIGHT = 400E9F;

        public const float TIME_SCALE = 1E3F;

        public const float SUN_RADIUS = 7E10F;
        public const float EARTH_RADIUS = 2E10F;

        private Body sun;
        private Body earth;
        private Body moon;

        private Body selected;

        private List<Body> bodies;

        private Stopwatch watcher;

        private Image background;
        private Bitmap path;

        private bool reset;
        private bool dragging;

        public FrmOrbital()
        {
            InitializeComponent();

            watcher = new Stopwatch();            

            background = Image.FromFile(@"resources\background\Starfield1L.jpg");

            sun = new Body(Vector2D.NULL_VECTOR, Vector2D.NULL_VECTOR, (float) Consts.SUN_MASS, SUN_RADIUS, Image.FromFile(@"resources\objects\Brightman Sun.png"), Color.Yellow);
            earth = new Body(new Vector2D((float)(Consts.DISTANCE_EARH_SUN), 0), new Vector2D(0, (float)Consts.EARH_SPEED), (float)Consts.EARH_MASS, EARTH_RADIUS, Image.FromFile(@"resources\objects\Chequer Milos Earth.png"), Color.Blue);
            moon = new Body(new Vector2D((float)(Consts.DISTANCE_EARH_SUN + Consts.DISTANCE_EARH_MOON), 0), new Vector2D(0, (float)(Consts.EARH_SPEED + 10)), (float)Consts.MOON_MASS, EARTH_RADIUS, Image.FromFile(@"resources\objects\Planet Gebirge.png"), Color.Red);

            bodies = new List<Body>();
            //bodies.Add(sun);
            //bodies.Add(earth);
            //bodies.Add(moon);

            selected = null;

            path = new Bitmap(pbSimulation.ClientSize.Width, pbSimulation.ClientSize.Height);

            reset = true;
            dragging = false;
        }

        public int Transform(float input)
        {
            float scale = pbSimulation.ClientSize.Width / VIEW_PORT_WIDTH;
            return (int)(input * scale);
        }

        public Point Transform(Vector2D v)
        {
            int x = Transform(v.X) + pbSimulation.ClientSize.Width / 2;
            int y = pbSimulation.ClientSize.Height / 2 - Transform(v.Y);
            return new Point(x, y);
        }

        public void AddBody(Vector2D pos, Vector2D vel, float mass, float radius, Image image, Color color)
        {
            Body body = new Body(pos, vel, mass, radius, image, color);
            bodies.Add(body);
            pbSimulation.Invalidate();
        }

        private void tmrTick_Tick(object sender, EventArgs e)
        {
            watcher.Stop();
            long dt = watcher.ElapsedMilliseconds;

            for (int i = 0; i < bodies.Count; i++)
            {
                Body body = bodies[i];
                body.Iteract(bodies, dt * TIME_SCALE);
            }

            pbSimulation.Invalidate();
            watcher.Reset();
            watcher.Start();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            DialogResult dr = ofdOpenFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
                pbImage.Image = Image.FromFile(ofdOpenFileDialog.FileName);
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
            }
            else
            {
                watcher.Reset();
                watcher.Start();
                tmrTick.Enabled = true;
                btnPlay.Text = "Pause";
            }
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            float mass;
            float radius;
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

            AddBody(Vector2D.NULL_VECTOR, Vector2D.NULL_VECTOR, mass, radius, pbImage.Image, lblColor.BackColor);
        }

        private void pbSimulation_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = Graphics.FromImage(path);

            if (tmrTick.Enabled)
            {
                if (reset)
                {
                    g.Clear(Color.Transparent);
                    reset = false;
                }
                else
                {
                    for (int i = 0; i < bodies.Count; i++)
                    {
                        Body body = bodies[i];
                        using (Pen pen = new Pen(body.Color))
                        {
                            Point p0 = Transform(body.LastPosition);
                            Point p = Transform(body.Position);

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
            }

            g = e.Graphics;

            g.DrawImage(background, 0, 0, pbSimulation.ClientSize.Width, pbSimulation.ClientSize.Height);
            g.DrawImage(path, 0, 0);

            for (int i = 0; i < bodies.Count; i++)
            {
                Body body = bodies[i];
                Point p = Transform(body.Position);
                int radius = Transform(body.Radius);

                if (body.Image != null)
                {
                    g.DrawImage(body.Image, new Rectangle(p.X - radius / 2, p.Y - radius / 2, radius, radius));
                }
                else
                {
                    using (Brush brush = new SolidBrush(body.Color))
                    {
                        g.FillEllipse(brush, p.X - radius / 2, p.Y - radius / 2, radius, radius);
                    }
                }
            }
        }

        private void UpdateSelected(Body body)
        {
            selected = body;

            if (selected != null)
            {
                txtSelectedMass.Text = body.Mass.ToString(CultureInfo.InvariantCulture);
                txtSelectedRadius.Text = body.Radius.ToString(CultureInfo.InvariantCulture);
                lblSelectedColor.BackColor = body.Color;
                pbSelectedImage.Image = body.Image;
                txtX.Text = body.Position.X.ToString(CultureInfo.InvariantCulture);
                txtY.Text = body.Position.Y.ToString(CultureInfo.InvariantCulture);
                txtVX.Text = body.Velocity.X.ToString(CultureInfo.InvariantCulture);
                txtVY.Text = body.Velocity.Y.ToString(CultureInfo.InvariantCulture);
            }
            else
            {
                txtSelectedMass.Text = "";
                txtSelectedRadius.Text = "";
                lblSelectedColor.BackColor = Color.Transparent;
                pbSelectedImage.Image = null;
                txtX.Text = "";
                txtY.Text = "";
                txtVX.Text = "";
                txtVY.Text = "";
            }
        }

        private void pbSimulation_MouseDown(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;

            for (int i = 0; i < bodies.Count; i++)
            {
                Body body = bodies[i];
                Point p = Transform(body.Position);
                int radius = Transform(body.Radius);

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
                UpdateSelected(null);
                pbSimulation.Invalidate();
            }    
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selected == null)
                return;

            float mass;
            float radius;
            float x;
            float y;
            float vx;
            float vy;

            try
            {
                mass = float.Parse(txtSelectedMass.Text, CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato inválido do valor da massa.");
                return;
            }

            try
            {
                radius = float.Parse(txtSelectedRadius.Text, CultureInfo.InvariantCulture);
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

            selected.Mass = mass;
            selected.Radius = radius;
            selected.Color = lblSelectedColor.BackColor;
            selected.Image = pbSelectedImage.Image;
            selected.Position = new Vector2D(x, y);
            selected.Velocity = new Vector2D(vx, vy);

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
                pbSelectedImage.Image = Image.FromFile(ofdOpenFileDialog.FileName);
        }

        private void lblSelectedColor_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogResult dr = cdColorDialog.ShowDialog();
            if (dr == DialogResult.OK)
                lblSelectedColor.BackColor = cdColorDialog.Color;
        }
    }
}
