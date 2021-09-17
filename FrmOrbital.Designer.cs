
namespace Orbital
{
    partial class FrmOrbital
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmrTick = new System.Windows.Forms.Timer(this.components);
            this.pbSimulation = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cdColorDialog = new System.Windows.Forms.ColorDialog();
            this.ofdOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtVY = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtVX = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pbSelectedImage = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSelectedColor = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSelectedRadius = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSelectedMass = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSimulation)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrTick
            // 
            this.tmrTick.Interval = 15;
            this.tmrTick.Tick += new System.EventHandler(this.tmrTick_Tick);
            // 
            // pbSimulation
            // 
            this.pbSimulation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSimulation.Location = new System.Drawing.Point(-1, 2);
            this.pbSimulation.Name = "pbSimulation";
            this.pbSimulation.Size = new System.Drawing.Size(1000, 1000);
            this.pbSimulation.TabIndex = 0;
            this.pbSimulation.TabStop = false;
            this.pbSimulation.SizeChanged += new System.EventHandler(this.pbSimulation_SizeChanged);
            this.pbSimulation.Paint += new System.Windows.Forms.PaintEventHandler(this.pbSimulation_Paint);
            this.pbSimulation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbSimulation_MouseDown);
            this.pbSimulation.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbSimulation_MouseMove);
            this.pbSimulation.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbSimulation_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnPlay);
            this.groupBox1.Location = new System.Drawing.Point(1009, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 60);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controles";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Location = new System.Drawing.Point(121, 22);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 32);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlay.Location = new System.Drawing.Point(6, 22);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(112, 32);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblColor);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.pbImage);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtRadius);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtMass);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(1009, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 290);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Novo Corpo";
            // 
            // lblColor
            // 
            this.lblColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColor.BackColor = System.Drawing.Color.Blue;
            this.lblColor.Location = new System.Drawing.Point(69, 85);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(163, 23);
            this.lblColor.TabIndex = 14;
            this.lblColor.DoubleClick += new System.EventHandler(this.lblColor_DoubleClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(69, 251);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 33);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pbImage
            // 
            this.pbImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbImage.Location = new System.Drawing.Point(100, 125);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(100, 100);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 7;
            this.pbImage.TabStop = false;
            this.pbImage.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Imagem";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cor";
            // 
            // txtRadius
            // 
            this.txtRadius.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRadius.Location = new System.Drawing.Point(69, 56);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(163, 23);
            this.txtRadius.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Raio";
            // 
            // txtMass
            // 
            this.txtMass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMass.Location = new System.Drawing.Point(69, 27);
            this.txtMass.Name = "txtMass";
            this.txtMass.Size = new System.Drawing.Size(163, 23);
            this.txtMass.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Massa";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnRemove);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Controls.Add(this.txtVY);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtVX);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtY);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtX);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.pbSelectedImage);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lblSelectedColor);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtSelectedRadius);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtSelectedMass);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(1009, 366);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(238, 636);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Propriedades do Objeto";
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Location = new System.Drawing.Point(121, 597);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(107, 33);
            this.btnRemove.TabIndex = 25;
            this.btnRemove.Text = "Remover";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(6, 597);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(107, 33);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtVY
            // 
            this.txtVY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVY.Location = new System.Drawing.Point(69, 339);
            this.txtVY.Name = "txtVY";
            this.txtVY.Size = new System.Drawing.Size(163, 23);
            this.txtVY.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 342);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 15);
            this.label12.TabIndex = 22;
            this.label12.Text = "VY";
            // 
            // txtVX
            // 
            this.txtVX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVX.Location = new System.Drawing.Point(69, 310);
            this.txtVX.Name = "txtVX";
            this.txtVX.Size = new System.Drawing.Size(163, 23);
            this.txtVX.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 313);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 15);
            this.label13.TabIndex = 20;
            this.label13.Text = "VX";
            // 
            // txtY
            // 
            this.txtY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtY.Location = new System.Drawing.Point(69, 269);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(163, 23);
            this.txtY.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Y";
            // 
            // txtX
            // 
            this.txtX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtX.Location = new System.Drawing.Point(69, 240);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(163, 23);
            this.txtX.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 243);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 15);
            this.label11.TabIndex = 16;
            this.label11.Text = "X";
            // 
            // pbSelectedImage
            // 
            this.pbSelectedImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSelectedImage.Location = new System.Drawing.Point(100, 117);
            this.pbSelectedImage.Name = "pbSelectedImage";
            this.pbSelectedImage.Size = new System.Drawing.Size(100, 100);
            this.pbSelectedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSelectedImage.TabIndex = 15;
            this.pbSelectedImage.TabStop = false;
            this.pbSelectedImage.DoubleClick += new System.EventHandler(this.pbSelectedImage_DoubleClick);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Imagem";
            // 
            // lblSelectedColor
            // 
            this.lblSelectedColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelectedColor.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectedColor.Location = new System.Drawing.Point(69, 77);
            this.lblSelectedColor.Name = "lblSelectedColor";
            this.lblSelectedColor.Size = new System.Drawing.Size(163, 23);
            this.lblSelectedColor.TabIndex = 13;
            this.lblSelectedColor.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblSelectedColor_MouseDoubleClick);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cor";
            // 
            // txtSelectedRadius
            // 
            this.txtSelectedRadius.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSelectedRadius.Location = new System.Drawing.Point(69, 48);
            this.txtSelectedRadius.Name = "txtSelectedRadius";
            this.txtSelectedRadius.Size = new System.Drawing.Size(163, 23);
            this.txtSelectedRadius.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Raio";
            // 
            // txtSelectedMass
            // 
            this.txtSelectedMass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSelectedMass.Location = new System.Drawing.Point(69, 19);
            this.txtSelectedMass.Name = "txtSelectedMass";
            this.txtSelectedMass.Size = new System.Drawing.Size(163, 23);
            this.txtSelectedMass.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Massa";
            // 
            // FrmOrbital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 1003);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbSimulation);
            this.DoubleBuffered = true;
            this.Name = "FrmOrbital";
            this.Text = "Orbital";
            ((System.ComponentModel.ISupportInitialize)(this.pbSimulation)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectedImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrTick;
        private System.Windows.Forms.PictureBox pbSimulation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog cdColorDialog;
        private System.Windows.Forms.OpenFileDialog ofdOpenFileDialog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pbSelectedImage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSelectedColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSelectedRadius;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSelectedMass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtVY;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtVX;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblColor;
    }
}

