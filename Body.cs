using System;
using System.Collections.Generic;
using System.Drawing;

namespace Orbital;

public class Body
{
#pragma warning disable CA2211 // Campos não constantes não devem ser visíveis
    public static double G = Consts.G;
#pragma warning restore CA2211 // Campos não constantes não devem ser visíveis

    private Vector2D rn;
    private Vector2D lastPos;
    private Vector2D origin;
    private Vector2D velocity;

    private Vector2D vn;
    private Vector2D k1r;
    private Vector2D k1v;
    private Vector2D k2r;
    private Vector2D k2v;
    private Vector2D k3r;
    private Vector2D k3v;
    private Vector2D k4r;
    private Vector2D k4v;

    private string imageFileName;

    public string Name
    {
        get;
        set;
    }

    public Vector2D InitialPosition
    {
        get;
        private set;
    }

    public Vector2D InitialVelocity
    {
        get;
        private set;
    }

    public Vector2D LastPosition
    {
        get
        {
            Vector2D result = lastPos;
            lastPos = origin;
            return result;
        }
    }

    public Vector2D Position
    {
        get => origin;

        set
        {
            origin = value;
            InitialPosition = value;
        }
    }

    public Vector2D Velocity
    {
        get => velocity;

        set
        {
            velocity = value;
            InitialVelocity = value;
        }
    }

    public double Mass
    {
        get;
        set;
    }

    public double Radius
    {
        get;
        set;
    }

    public string ImageFileName
    {
        get => imageFileName;

        set
        {
            imageFileName = value;
            Image = value != null ? Image.FromFile(value) : null;
        }
    }

    public Image Image
    {
        get;
        private set;
    }

    public Color Color
    {
        get;
        set;
    }

    public bool Enabled
    {
        get;
        set;
    }

    public bool Locked
    {
        get;
        set;
    }

    public Body(string name, Vector2D origin, Vector2D velocity, double mass, double radius, string imageFileName, Color color, bool enabled = true, bool locked = false)
    {
        Name = name;
        this.origin = origin;
        this.velocity = velocity;
        Mass = mass;
        Radius = radius;
        Color = color;
        Enabled = enabled;
        Locked = locked;

        ImageFileName = imageFileName;

        InitialPosition = origin;
        InitialVelocity = velocity;

        lastPos = origin;
    }

    public void BeginIteract(List<Body> bodies, float dt)
    {
        if (!Enabled || Locked)
            return;

        rn = origin;
        vn = velocity;

        // Aplicação do método de Runge-Kutta de quarta ordem

        float dt2 = dt / 2;

        k1r = vn;
        k1v = Acceleration(bodies, rn);

        k2r = vn + dt2 * k1v;
        k2v = Acceleration(bodies, rn + dt2 * k1r);

        k3r = vn + dt2 * k2v;
        k3v = Acceleration(bodies, rn + dt2 * k2r);

        k4r = vn + dt * k3v;
        k4v = Acceleration(bodies, rn + dt * k3r);
    }

    private Vector2D Acceleration(List<Body> bodies, Vector2D r)
    {
        Vector2D result = Vector2D.NULL_VECTOR;
        for (int i = 0; i < bodies.Count; i++)
        {
            Body other = bodies[i];
            if (other == this || !other.Enabled)
                continue;

            double d2 = r.DistanceSquareTo(other.rn);
            double d = Math.Sqrt(d2);
            result += other.Mass / d * (other.rn - r) / d2 * G;
        }

        return result;
    }

    public void Step(List<Body> bodies, float dt)
    {
        if (!Enabled || Locked)
            return;

        velocity = vn + (k1v + 2 * (k2v + k3v) + k4v) * dt / 6;
        origin = rn + (k1r + 2 * (k2r + k3r) + k4r) * dt / 6;
    }

    public void Reset()
    {
        origin = InitialPosition;
        velocity = InitialVelocity;
        lastPos = origin;
        rn = origin;
        vn = velocity;
    }

    public override string ToString()
    {
        return Name;
    }
}