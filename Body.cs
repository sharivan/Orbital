using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Orbital
{
    public class Body
    {
        public static double G = Consts.G;

        private string name;

        private Vector2D initialPos;
        private Vector2D initialVel;

        private Vector2D rn;
        private Vector2D lastPos;
        private Vector2D pos;

        private Vector2D vn;
        private Vector2D vel;

        private double mass;
        private double radius;

        private string imageFileName;
        private Image image;
        private Color color;

        private bool locked;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public Vector2D InitialPosition
        {
            get
            {
                return initialPos;
            }
        }

        public Vector2D InitialVelocity
        {
            get
            {
                return initialVel;
            }
        }

        public Vector2D LastPosition
        {
            get
            {
                Vector2D result = lastPos;
                lastPos = pos;
                return result;
            }
        }

        public Vector2D Position
        {
            get
            {
                return pos;
            }

            set
            {
                pos = value;
                initialPos = value;
            }
        }

        public Vector2D Velocity
        {
            get
            {
                return vel;
            }

            set
            {
                vel = value;
                initialVel = value;
            }
        }

        public double Mass
        {
            get
            {
                return mass;
            }

            set
            {
                mass = value;
            }
        }

        public double Radius
        {
            get
            {
                return radius;
            }

            set
            {
                radius = value;
            }
        }

        public string ImageFileName
        {
            get
            {
                return imageFileName;
            }

            set
            {
                imageFileName = value;
                image = value != null ? Image.FromFile(value) : null;
            }
        }

        public Image Image
        {
            get
            {
                return image;
            }
        }

        public Color Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }

        public bool Locked
        {
            get
            {
                return locked;
            }

            set
            {
                locked = value;
            }
        }

        public Body(string name, Vector2D pos, Vector2D vel, double mass, double radius, string imageFileName, Color color, bool locked = false)
        {
            this.name = name;
            this.pos = pos;
            this.vel = vel;
            this.mass = mass;
            this.radius = radius;
            this.color = color;
            this.locked = locked;

            ImageFileName = imageFileName;

            initialPos = pos;
            initialVel = vel;

            lastPos = pos;
        }

        public void BeginIteract()
        {
            rn = pos;
            vn = vel;
        }

        private Vector2D Acceleration(List<Body> bodies, Vector2D r)
        {
            Vector2D result = Vector2D.NULL_VECTOR;
            for (int i = 0; i < bodies.Count; i++)
            {
                Body other = bodies[i];
                if (other == this)
                    continue;
                
                double d2 = r.DistanceSquareTo(other.rn);
                double d = Math.Sqrt(d2);
                result += other.mass / d * (other.rn - r) / d2 * G;
            }

            return result;
        }

        public void Step(List<Body> bodies, float dt)
        {
            if (locked)
                return;

            // Aplicação do método de Runge-Kutta de quarta ordem

            float dt2 = dt / 2;

            Vector2D k1r = vn;
            Vector2D k1v = Acceleration(bodies, rn);

            Vector2D k2r = vn + dt2 * k1v;
            Vector2D k2v = Acceleration(bodies, rn + dt2 * k1r);

            Vector2D k3r = vn + dt2 * k2v;
            Vector2D k3v = Acceleration(bodies, rn + dt2 * k2r);

            Vector2D k4r = vn + dt * k3v;
            Vector2D k4v = Acceleration(bodies, rn + dt * k3r);

            pos = rn + (k1r + 2 * (k2r + k3r) + k4r) * dt / 6;
            vel = vn + (k1v + 2 * (k2v + k3v) + k4v) * dt / 6;
        }

        public void Reset()
        {
            pos = initialPos;
            vel = initialVel;
            lastPos = pos;
            rn = pos;
            vn = vel;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
