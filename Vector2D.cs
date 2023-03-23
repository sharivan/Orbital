using System;
using System.Globalization;

namespace Orbital;

public readonly struct Vector2D
{
    public static readonly Vector2D NULL_VECTOR = new(0, 0);

    public double X
    {
        get;
    }

    public double Y
    {
        get;
    }

    public bool IsNull => X == 0 && Y == 0;

    public double Length => Math.Sqrt(LengthSquare);

    public double LengthSquare => X * X + Y * Y;

    public Vector2D Versor => !IsNull ? this / Length : NULL_VECTOR;

    public Vector2D(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double DistanceTo(Vector2D v)
    {
        return (this - v).Length;
    }

    public double DistanceSquareTo(Vector2D v)
    {
        return (this - v).LengthSquare;
    }

    public static Vector2D operator +(Vector2D v1, Vector2D v2)
    {
        return new Vector2D(v1.X + v2.X, v1.Y + v2.Y);
    }

    public static Vector2D operator -(Vector2D v1, Vector2D v2)
    {
        return new Vector2D(v1.X - v2.X, v1.Y - v2.Y);
    }

    public static Vector2D operator *(Vector2D v, double a)
    {
        return new Vector2D(v.X * a, v.Y * a);
    }

    public static Vector2D operator *(double a, Vector2D v)
    {
        return new Vector2D(a * v.X, a * v.Y);
    }

    public static Vector2D operator /(Vector2D v, double a)
    {
        return new Vector2D(v.X / a, v.Y / a);
    }

    public static double operator *(Vector2D v1, Vector2D v2)
    {
        return v1.X * v2.X + v1.Y * v2.Y;
    }

    public override string ToString()
    {
        return "(" + X.ToString(CultureInfo.InvariantCulture) + ", " + Y.ToString(CultureInfo.InvariantCulture) + ")";
    }
}