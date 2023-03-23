using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace Orbital;

public partial class FrmOptions : Form
{
    public delegate void ApplyEvent(FrmOptions sender);

    private bool loaded;

    private double g;
    private double viewPortWidth;
    private bool drawPath;
    private string backgroundFilePath;
    private float timeScale;
    private int stepsPerFrame;

    public event ApplyEvent OnApply;

    public double G
    {
        get => g;

        set
        {
            g = value;

            if (loaded)
                txtG.Text = value.ToString(CultureInfo.InvariantCulture);
        }
    }

    public double ViewPortWidth
    {
        get => viewPortWidth;

        set
        {
            viewPortWidth = value;

            if (loaded)
                txtViewPortWidth.Text = value.ToString(CultureInfo.InvariantCulture);
        }
    }

    public bool DrawPath
    {
        get => drawPath;

        set
        {
            drawPath = value;

            if (loaded)
                chkDrawPath.Checked = value;
        }
    }

    public string BackgroundFilePath
    {
        get => backgroundFilePath;

        set
        {
            backgroundFilePath = value;

            if (loaded)
                txtBackgroundFilePath.Text = value ?? "";
        }
    }

    public float TimeScale
    {
        get => timeScale;

        set
        {
            timeScale = value;

            if (loaded)
                txtTimeScale.Text = value.ToString(CultureInfo.InvariantCulture);
        }
    }

    public int StepsPerFrame
    {
        get => stepsPerFrame;

        set
        {
            stepsPerFrame = value;

            if (loaded)
                txtStepsPerFrame.Text = value.ToString();
        }
    }

    public FrmOptions()
    {
        loaded = false;
        InitializeComponent();
    }

    private void FrmOptions_Load(object sender, EventArgs e)
    {
        loaded = true;

        txtG.Text = g.ToString(CultureInfo.InvariantCulture);
        txtViewPortWidth.Text = viewPortWidth.ToString(CultureInfo.InvariantCulture);
        txtBackgroundFilePath.Text = backgroundFilePath ?? "";
        txtTimeScale.Text = timeScale.ToString(CultureInfo.InvariantCulture);
        txtStepsPerFrame.Text = stepsPerFrame.ToString();
        chkDrawPath.Checked = drawPath;
    }

    private void Apply()
    {
        double g;
        double viewPortWidth;
        string backgroundFilePath;
        float timeScale;
        int stepsPerFrame;

        try
        {
            g = double.Parse(txtG.Text, CultureInfo.InvariantCulture);
        }
        catch (FormatException)
        {
            MessageBox.Show("Formato inválido do valor de G.");
            return;
        }

        try
        {
            viewPortWidth = double.Parse(txtViewPortWidth.Text, CultureInfo.InvariantCulture);
        }
        catch (FormatException)
        {
            MessageBox.Show("Formato inválido do valor da largura da câmera.");
            return;
        }

        string newBackgroundFilePath = txtBackgroundFilePath.Text;
        try
        {
            if (newBackgroundFilePath is not null and not "")
            {
                Image.FromFile(newBackgroundFilePath);
                backgroundFilePath = newBackgroundFilePath;
            }
            else
            {
                backgroundFilePath = null;
            }
        }
        catch (FileNotFoundException)
        {
            MessageBox.Show("Arquivo de imagem de fundo '" + newBackgroundFilePath + "' não encontrado.");
            return;
        }
        catch (Exception e)
        {
            MessageBox.Show("Erro ao carregar a imagem de fundo (" + e.Message + ").");
            return;
        }

        try
        {
            timeScale = float.Parse(txtTimeScale.Text, CultureInfo.InvariantCulture);
        }
        catch (FormatException)
        {
            MessageBox.Show("Formato inválido do valor da escala de tempo.");
            return;
        }

        try
        {
            stepsPerFrame = int.Parse(txtStepsPerFrame.Text);
        }
        catch (FormatException)
        {
            MessageBox.Show("Formato inválido do valor do número de passos por frame.");
            return;
        }

        this.g = g;
        this.viewPortWidth = viewPortWidth;
        this.backgroundFilePath = backgroundFilePath;
        this.timeScale = timeScale;
        this.stepsPerFrame = stepsPerFrame;

        drawPath = chkDrawPath.Checked;

        OnApply(this);
    }

    private void BtnApply_Click(object sender, EventArgs e)
    {
        Apply();
    }

    private void BtnCancel_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void BtnOk_Click(object sender, EventArgs e)
    {
        Apply();
        Close();
    }

    private void BtnChangeBackground_Click(object sender, EventArgs e)
    {
        DialogResult dr = openBackgroundImageDialog.ShowDialog();
        if (dr == DialogResult.OK)
            txtBackgroundFilePath.Text = openBackgroundImageDialog.FileName;
    }

    private void BtnClearBackground_Click(object sender, EventArgs e)
    {
        txtBackgroundFilePath.Text = "";
    }
}