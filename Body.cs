using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Orbital
{
    public class Body
    {
        private Vector2D initialPos;
        private Vector2D initialVel;

        private Vector2D lastPos;
        private Vector2D pos;
        private Vector2D vel;

        private float mass;
        private float radius;

        private Image image;
        private Color color;

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
                return lastPos;
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

        public float Mass
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

        public float Radius
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

        public Image Image
        {
            get
            {
                return image;
            }

            set
            {
                image = value;
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

        public Body(Vector2D pos, Vector2D vel, float mass, float radius, Image image, Color color)
        {
            this.pos = pos;
            this.vel = vel;
            this.mass = mass;
            this.radius = radius;
            this.image = image;
            this.color = color;

            initialPos = pos;
            initialVel = vel;

            lastPos = pos;
        }

        public void Iteract(List<Body> bodies, float dt)
        {
            Vector2D F = Vector2D.NULL_VECTOR;
            for (int i = 0; i < bodies.Count; i++)
            {
                Body other = bodies[i];
                if (other == this)
                    continue;

                double d = pos.DistanceTo(other.pos);
                Vector2D dir = (other.pos - pos).Versor;
                float f = (float)((double) Consts.G * mass * other.mass / (d * d));
                F += f * dir;
            }

            Vector2D a = F / mass;

            vel += a * dt;

            lastPos = pos;
            pos += vel * dt;
        }

        public void Reset()
        {
            pos = initialPos;
            vel = initialVel;
        }
    }
}
