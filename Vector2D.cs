using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Orbital
{
    public struct Vector2D
    {
        public static readonly Vector2D NULL_VECTOR = new Vector2D(0, 0);

        private float x; // abscissa
        private float y; // ordenada

        public float X
        {
            get
            {
                return x;
            }
        }

        public float Y
        {
            get
            {
                return y;
            }
        }

        public bool IsNull
        {
            get
            {
                return x == 0 && y == 0;
            }
        }

        public float Length
        {
            get
            {
                return (float) Math.Sqrt((double) x * x + (double) y * y);
            }
        }

        public Vector2D Versor
        {
            get
            {
                return !IsNull ? this / Length : NULL_VECTOR;
            }
        }

        public Vector2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public float DistanceTo(Vector2D v)
        {
            return (this - v).Length;
        }

        public static Vector2D operator +(Vector2D v1, Vector2D v2)
        {
            return new Vector2D(v1.x + v2.x, v1.y + v2.y);
        }

        public static Vector2D operator -(Vector2D v1, Vector2D v2)
        {
            return new Vector2D(v1.x - v2.x, v1.y - v2.y);
        }

        public static Vector2D operator *(Vector2D v, float a)
        {
            return new Vector2D(v.x * a, v.y * a);
        }

        public static Vector2D operator *(float a, Vector2D v)
        {
            return new Vector2D(a * v.x, a * v.y);
        }

        public static Vector2D operator /(Vector2D v, float a)
        {
            return new Vector2D(v.x / a, v.y / a);
        }

        public static float operator *(Vector2D v1, Vector2D v2)
        {
            return v1.x * v2.x + v1.y - v2.y;
        }

        public override string ToString()
        {
            return "(" + x.ToString(CultureInfo.InvariantCulture) + ", " + y.ToString(CultureInfo.InvariantCulture) + ")";
        }
    }
}
