
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
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrbital));
            tmrTick = new System.Windows.Forms.Timer(components);
            cdColorDialog = new System.Windows.Forms.ColorDialog();
            openFileDialog = new System.Windows.Forms.OpenFileDialog();
            tsToolStrip = new System.Windows.Forms.ToolStrip();
            tsbNew = new System.Windows.Forms.ToolStripButton();
            tsbOpen = new System.Windows.Forms.ToolStripButton();
            tsbSave = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            tsbPlay = new System.Windows.Forms.ToolStripButton();
            tsbReset = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            tsbOptions = new System.Windows.Forms.ToolStripButton();
            pnlMain = new System.Windows.Forms.Panel();
            pbSimulation = new System.Windows.Forms.PictureBox();
            pnlRightPanel = new System.Windows.Forms.Panel();
            gbBodies = new System.Windows.Forms.GroupBox();
            lbBodies = new System.Windows.Forms.ListBox();
            gbProperties = new System.Windows.Forms.GroupBox();
            chkEnabled = new System.Windows.Forms.CheckBox();
            txtName = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            chkLocked = new System.Windows.Forms.CheckBox();
            btnAdd = new System.Windows.Forms.Button();
            btnRemove = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            txtVY = new System.Windows.Forms.TextBox();
            label12 = new System.Windows.Forms.Label();
            txtVX = new System.Windows.Forms.TextBox();
            label13 = new System.Windows.Forms.Label();
            txtY = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            txtX = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            pbImage = new System.Windows.Forms.PictureBox();
            label5 = new System.Windows.Forms.Label();
            lblColor = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            txtRadius = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            txtMass = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            mnuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            mnuSeparator = new System.Windows.Forms.ToolStripMenuItem();
            mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            msMenuStrip = new System.Windows.Forms.MenuStrip();
            openObjectImageDialog = new System.Windows.Forms.OpenFileDialog();
            tsToolStrip.SuspendLayout();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) pbSimulation).BeginInit();
            pnlRightPanel.SuspendLayout();
            gbBodies.SuspendLayout();
            gbProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) pbImage).BeginInit();
            msMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // tmrTick
            // 
            tmrTick.Interval = 15;
            tmrTick.Tick += TmrTick_Tick;
            // 
            // openFileDialog
            // 
            openFileDialog.InitialDirectory = "saves";
            // 
            // tsToolStrip
            // 
            tsToolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            tsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsbNew, tsbOpen, tsbSave, toolStripSeparator2, tsbPlay, tsbReset, toolStripSeparator1, tsbOptions });
            tsToolStrip.Location = new System.Drawing.Point(0, 24);
            tsToolStrip.Name = "tsToolStrip";
            tsToolStrip.Size = new System.Drawing.Size(1264, 39);
            tsToolStrip.TabIndex = 1;
            // 
            // tsbNew
            // 
            tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbNew.Image = (System.Drawing.Image) resources.GetObject("tsbNew.Image");
            tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbNew.Name = "tsbNew";
            tsbNew.Size = new System.Drawing.Size(36, 36);
            tsbNew.Text = "Novo";
            tsbNew.Click += TsbNew_Click;
            // 
            // tsbOpen
            // 
            tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbOpen.Image = (System.Drawing.Image) resources.GetObject("tsbOpen.Image");
            tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbOpen.Name = "tsbOpen";
            tsbOpen.Size = new System.Drawing.Size(36, 36);
            tsbOpen.Text = "Abrir";
            tsbOpen.Click += TsbOpen_Click;
            // 
            // tsbSave
            // 
            tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbSave.Image = (System.Drawing.Image) resources.GetObject("tsbSave.Image");
            tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbSave.Name = "tsbSave";
            tsbSave.Size = new System.Drawing.Size(36, 36);
            tsbSave.Text = "Salvar";
            tsbSave.Click += TsbSave_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbPlay
            // 
            tsbPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbPlay.Image = Properties.Resources.play;
            tsbPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbPlay.Name = "tsbPlay";
            tsbPlay.Size = new System.Drawing.Size(36, 36);
            tsbPlay.Text = "Play";
            tsbPlay.Click += TsbPlay_Click;
            // 
            // tsbReset
            // 
            tsbReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbReset.Image = (System.Drawing.Image) resources.GetObject("tsbReset.Image");
            tsbReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbReset.Name = "tsbReset";
            tsbReset.Size = new System.Drawing.Size(36, 36);
            tsbReset.Text = "Reset";
            tsbReset.Click += TsbReset_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbOptions
            // 
            tsbOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsbOptions.Image = (System.Drawing.Image) resources.GetObject("tsbOptions.Image");
            tsbOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsbOptions.Name = "tsbOptions";
            tsbOptions.Size = new System.Drawing.Size(36, 36);
            tsbOptions.Text = "Opções";
            tsbOptions.Click += TsbOptions_Click;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(pbSimulation);
            pnlMain.Controls.Add(pnlRightPanel);
            pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlMain.Location = new System.Drawing.Point(0, 63);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new System.Drawing.Size(1264, 618);
            pnlMain.TabIndex = 12;
            // 
            // pbSimulation
            // 
            pbSimulation.Dock = System.Windows.Forms.DockStyle.Fill;
            pbSimulation.Location = new System.Drawing.Point(0, 0);
            pbSimulation.Name = "pbSimulation";
            pbSimulation.Size = new System.Drawing.Size(1017, 618);
            pbSimulation.TabIndex = 8;
            pbSimulation.TabStop = false;
            pbSimulation.Paint += PbSimulation_Paint;
            pbSimulation.MouseDown += PbSimulation_MouseDown;
            pbSimulation.MouseMove += PbSimulation_MouseMove;
            pbSimulation.MouseUp += PbSimulation_MouseUp;
            pbSimulation.Resize += PbSimulation_SizeChanged;
            // 
            // pnlRightPanel
            // 
            pnlRightPanel.Controls.Add(gbBodies);
            pnlRightPanel.Controls.Add(gbProperties);
            pnlRightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            pnlRightPanel.Location = new System.Drawing.Point(1017, 0);
            pnlRightPanel.Name = "pnlRightPanel";
            pnlRightPanel.Size = new System.Drawing.Size(247, 618);
            pnlRightPanel.TabIndex = 13;
            // 
            // gbBodies
            // 
            gbBodies.Controls.Add(lbBodies);
            gbBodies.Dock = System.Windows.Forms.DockStyle.Right;
            gbBodies.Location = new System.Drawing.Point(0, 469);
            gbBodies.Name = "gbBodies";
            gbBodies.Size = new System.Drawing.Size(247, 149);
            gbBodies.TabIndex = 12;
            gbBodies.TabStop = false;
            gbBodies.Text = "Corpos";
            // 
            // lbBodies
            // 
            lbBodies.Dock = System.Windows.Forms.DockStyle.Fill;
            lbBodies.FormattingEnabled = true;
            lbBodies.ItemHeight = 15;
            lbBodies.Location = new System.Drawing.Point(3, 19);
            lbBodies.Name = "lbBodies";
            lbBodies.Size = new System.Drawing.Size(241, 127);
            lbBodies.TabIndex = 12;
            lbBodies.SelectedIndexChanged += LbBodies_SelectedIndexChanged;
            // 
            // gbProperties
            // 
            gbProperties.Controls.Add(chkEnabled);
            gbProperties.Controls.Add(txtName);
            gbProperties.Controls.Add(label1);
            gbProperties.Controls.Add(chkLocked);
            gbProperties.Controls.Add(btnAdd);
            gbProperties.Controls.Add(btnRemove);
            gbProperties.Controls.Add(btnUpdate);
            gbProperties.Controls.Add(txtVY);
            gbProperties.Controls.Add(label12);
            gbProperties.Controls.Add(txtVX);
            gbProperties.Controls.Add(label13);
            gbProperties.Controls.Add(txtY);
            gbProperties.Controls.Add(label10);
            gbProperties.Controls.Add(txtX);
            gbProperties.Controls.Add(label11);
            gbProperties.Controls.Add(pbImage);
            gbProperties.Controls.Add(label5);
            gbProperties.Controls.Add(lblColor);
            gbProperties.Controls.Add(label7);
            gbProperties.Controls.Add(txtRadius);
            gbProperties.Controls.Add(label8);
            gbProperties.Controls.Add(txtMass);
            gbProperties.Controls.Add(label9);
            gbProperties.Dock = System.Windows.Forms.DockStyle.Top;
            gbProperties.Location = new System.Drawing.Point(0, 0);
            gbProperties.Name = "gbProperties";
            gbProperties.Size = new System.Drawing.Size(247, 469);
            gbProperties.TabIndex = 11;
            gbProperties.TabStop = false;
            gbProperties.Text = "Propriedades do Objeto";
            // 
            // chkEnabled
            // 
            chkEnabled.AutoSize = true;
            chkEnabled.Checked = true;
            chkEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            chkEnabled.Location = new System.Drawing.Point(14, 393);
            chkEnabled.Name = "chkEnabled";
            chkEnabled.Size = new System.Drawing.Size(81, 19);
            chkEnabled.TabIndex = 29;
            chkEnabled.Text = "Habilitado";
            chkEnabled.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(77, 40);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(163, 23);
            txtName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(14, 43);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(40, 15);
            label1.TabIndex = 28;
            label1.Text = "Nome";
            // 
            // chkLocked
            // 
            chkLocked.AutoSize = true;
            chkLocked.Location = new System.Drawing.Point(171, 393);
            chkLocked.Name = "chkLocked";
            chkLocked.Size = new System.Drawing.Size(67, 19);
            chkLocked.TabIndex = 27;
            chkLocked.Text = "Travado";
            chkLocked.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(12, 427);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(72, 33);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += BtnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Enabled = false;
            btnRemove.Location = new System.Drawing.Point(168, 427);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new System.Drawing.Size(72, 33);
            btnRemove.TabIndex = 11;
            btnRemove.Text = "Remover";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += BtnRemove_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new System.Drawing.Point(90, 427);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(72, 33);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Atualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += BtnUpdate_Click;
            // 
            // txtVY
            // 
            txtVY.Location = new System.Drawing.Point(75, 355);
            txtVY.Name = "txtVY";
            txtVY.Size = new System.Drawing.Size(163, 23);
            txtVY.TabIndex = 8;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(12, 358);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(21, 15);
            label12.TabIndex = 22;
            label12.Text = "VY";
            // 
            // txtVX
            // 
            txtVX.Location = new System.Drawing.Point(75, 326);
            txtVX.Name = "txtVX";
            txtVX.Size = new System.Drawing.Size(163, 23);
            txtVX.TabIndex = 7;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(12, 329);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(21, 15);
            label13.TabIndex = 20;
            label13.Text = "VX";
            // 
            // txtY
            // 
            txtY.Location = new System.Drawing.Point(75, 295);
            txtY.Name = "txtY";
            txtY.Size = new System.Drawing.Size(163, 23);
            txtY.TabIndex = 6;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(12, 298);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(14, 15);
            label10.TabIndex = 18;
            label10.Text = "Y";
            // 
            // txtX
            // 
            txtX.Location = new System.Drawing.Point(75, 266);
            txtX.Name = "txtX";
            txtX.Size = new System.Drawing.Size(163, 23);
            txtX.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(12, 269);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(14, 15);
            label11.TabIndex = 16;
            label11.Text = "X";
            // 
            // pbImage
            // 
            pbImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            pbImage.Location = new System.Drawing.Point(107, 160);
            pbImage.Name = "pbImage";
            pbImage.Size = new System.Drawing.Size(100, 100);
            pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pbImage.TabIndex = 15;
            pbImage.TabStop = false;
            pbImage.DoubleClick += PbImage_DoubleClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(13, 200);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(51, 15);
            label5.TabIndex = 14;
            label5.Text = "Imagem";
            // 
            // lblColor
            // 
            lblColor.BackColor = System.Drawing.Color.Transparent;
            lblColor.Location = new System.Drawing.Point(77, 127);
            lblColor.Name = "lblColor";
            lblColor.Size = new System.Drawing.Size(163, 23);
            lblColor.TabIndex = 13;
            lblColor.DoubleClick += LblColor_DoubleClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(14, 135);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(26, 15);
            label7.TabIndex = 12;
            label7.Text = "Cor";
            // 
            // txtRadius
            // 
            txtRadius.Location = new System.Drawing.Point(77, 98);
            txtRadius.Name = "txtRadius";
            txtRadius.Size = new System.Drawing.Size(163, 23);
            txtRadius.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(14, 101);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(30, 15);
            label8.TabIndex = 10;
            label8.Text = "Raio";
            // 
            // txtMass
            // 
            txtMass.Location = new System.Drawing.Point(77, 69);
            txtMass.Name = "txtMass";
            txtMass.Size = new System.Drawing.Size(163, 23);
            txtMass.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(14, 72);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(40, 15);
            label9.TabIndex = 8;
            label9.Text = "Massa";
            // 
            // saveFileDialog
            // 
            saveFileDialog.InitialDirectory = "saves";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuNew, mnuOpen, mnuSave, mnuSaveAs, mnuSeparator, mnuClose });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new System.Drawing.Size(61, 20);
            mnuFile.Text = "Arquivo";
            // 
            // mnuNew
            // 
            mnuNew.Name = "mnuNew";
            mnuNew.ShortcutKeys =  System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N;
            mnuNew.Size = new System.Drawing.Size(220, 22);
            mnuNew.Text = "Novo";
            mnuNew.Click += MnuNew_Click;
            // 
            // mnuOpen
            // 
            mnuOpen.Name = "mnuOpen";
            mnuOpen.ShortcutKeys =  System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O;
            mnuOpen.Size = new System.Drawing.Size(220, 22);
            mnuOpen.Text = "Abrir";
            mnuOpen.Click += MnuOpen_Click;
            // 
            // mnuSave
            // 
            mnuSave.Name = "mnuSave";
            mnuSave.ShortcutKeys =  System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S;
            mnuSave.Size = new System.Drawing.Size(220, 22);
            mnuSave.Text = "Salvar";
            mnuSave.Click += MnuSave_Click;
            // 
            // mnuSaveAs
            // 
            mnuSaveAs.Name = "mnuSaveAs";
            mnuSaveAs.ShortcutKeys =  System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.S;
            mnuSaveAs.Size = new System.Drawing.Size(220, 22);
            mnuSaveAs.Text = "Salvar como...";
            mnuSaveAs.Click += MnuSaveAs_Click;
            // 
            // mnuSeparator
            // 
            mnuSeparator.Name = "mnuSeparator";
            mnuSeparator.Size = new System.Drawing.Size(220, 22);
            mnuSeparator.Text = "_";
            // 
            // mnuClose
            // 
            mnuClose.Name = "mnuClose";
            mnuClose.ShortcutKeys =  System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q;
            mnuClose.Size = new System.Drawing.Size(220, 22);
            mnuClose.Text = "Fechar";
            mnuClose.Click += MnuClose_Click;
            // 
            // msMenuStrip
            // 
            msMenuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            msMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuFile });
            msMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            msMenuStrip.Location = new System.Drawing.Point(0, 0);
            msMenuStrip.Name = "msMenuStrip";
            msMenuStrip.Size = new System.Drawing.Size(1264, 24);
            msMenuStrip.TabIndex = 0;
            msMenuStrip.Text = "menuStrip1";
            // 
            // openObjectImageDialog
            // 
            openObjectImageDialog.InitialDirectory = "resources\\objects";
            // 
            // FrmOrbital
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1264, 681);
            Controls.Add(pnlMain);
            Controls.Add(tsToolStrip);
            Controls.Add(msMenuStrip);
            DoubleBuffered = true;
            Name = "FrmOrbital";
            Text = "Orbital";
            FormClosing += FrmOrbital_FormClosing;
            Load += FrmOrbital_Load;
            LocationChanged += FrmOrbital_LocationChanged;
            SizeChanged += FrmOrbital_SizeChanged;
            tsToolStrip.ResumeLayout(false);
            tsToolStrip.PerformLayout();
            pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) pbSimulation).EndInit();
            pnlRightPanel.ResumeLayout(false);
            gbBodies.ResumeLayout(false);
            gbProperties.ResumeLayout(false);
            gbProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) pbImage).EndInit();
            msMenuStrip.ResumeLayout(false);
            msMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer tmrTick;
        private System.Windows.Forms.ColorDialog cdColorDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStrip tsToolStrip;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbPlay;
        private System.Windows.Forms.ToolStripButton tsbReset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbOptions;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.PictureBox pbSimulation;
        private System.Windows.Forms.Panel pnlRightPanel;
        private System.Windows.Forms.GroupBox gbProperties;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkLocked;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtVY;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtVX;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbBodies;
        private System.Windows.Forms.ListBox lbBodies;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuNew;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveAs;
        private System.Windows.Forms.ToolStripMenuItem mnuSeparator;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.MenuStrip msMenuStrip;
        private System.Windows.Forms.CheckBox chkEnabled;
        private System.Windows.Forms.OpenFileDialog openObjectImageDialog;
    }
}

