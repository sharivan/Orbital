
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrbital));
            this.tmrTick = new System.Windows.Forms.Timer(this.components);
            this.cdColorDialog = new System.Windows.Forms.ColorDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tsToolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPlay = new System.Windows.Forms.ToolStripButton();
            this.tsbReset = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbOptions = new System.Windows.Forms.ToolStripButton();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pbSimulation = new System.Windows.Forms.PictureBox();
            this.pnlRightPanel = new System.Windows.Forms.Panel();
            this.gbBodies = new System.Windows.Forms.GroupBox();
            this.lbBodies = new System.Windows.Forms.ListBox();
            this.gbProperties = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkLocked = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
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
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMass = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSeparator = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuStrip = new System.Windows.Forms.MenuStrip();
            this.tsToolStrip.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSimulation)).BeginInit();
            this.pnlRightPanel.SuspendLayout();
            this.gbBodies.SuspendLayout();
            this.gbProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.msMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrTick
            // 
            this.tmrTick.Interval = 15;
            this.tmrTick.Tick += new System.EventHandler(this.tmrTick_Tick);
            // 
            // tsToolStrip
            // 
            this.tsToolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.tsbOpen,
            this.tsbSave,
            this.toolStripSeparator2,
            this.tsbPlay,
            this.tsbReset,
            this.toolStripSeparator1,
            this.tsbOptions});
            this.tsToolStrip.Location = new System.Drawing.Point(0, 24);
            this.tsToolStrip.Name = "tsToolStrip";
            this.tsToolStrip.Size = new System.Drawing.Size(1264, 39);
            this.tsToolStrip.TabIndex = 1;
            // 
            // tsbNew
            // 
            this.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbNew.Image")));
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(36, 36);
            this.tsbNew.Text = "Novo";
            this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // tsbOpen
            // 
            this.tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpen.Image")));
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(36, 36);
            this.tsbOpen.Text = "Abrir";
            this.tsbOpen.Click += new System.EventHandler(this.tsbOpen_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(36, 36);
            this.tsbSave.Text = "Salvar";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbPlay
            // 
            this.tsbPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPlay.Image = global::Orbital.Properties.Resources.play;
            this.tsbPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPlay.Name = "tsbPlay";
            this.tsbPlay.Size = new System.Drawing.Size(36, 36);
            this.tsbPlay.Text = "Play";
            this.tsbPlay.Click += new System.EventHandler(this.tsbPlay_Click);
            // 
            // tsbReset
            // 
            this.tsbReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbReset.Image = ((System.Drawing.Image)(resources.GetObject("tsbReset.Image")));
            this.tsbReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReset.Name = "tsbReset";
            this.tsbReset.Size = new System.Drawing.Size(36, 36);
            this.tsbReset.Text = "Reset";
            this.tsbReset.Click += new System.EventHandler(this.tsbReset_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbOptions
            // 
            this.tsbOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOptions.Image = ((System.Drawing.Image)(resources.GetObject("tsbOptions.Image")));
            this.tsbOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOptions.Name = "tsbOptions";
            this.tsbOptions.Size = new System.Drawing.Size(36, 36);
            this.tsbOptions.Text = "Opções";
            this.tsbOptions.Click += new System.EventHandler(this.tsbOptions_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pbSimulation);
            this.pnlMain.Controls.Add(this.pnlRightPanel);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 63);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1264, 618);
            this.pnlMain.TabIndex = 12;
            // 
            // pbSimulation
            // 
            this.pbSimulation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbSimulation.Location = new System.Drawing.Point(0, 0);
            this.pbSimulation.Name = "pbSimulation";
            this.pbSimulation.Size = new System.Drawing.Size(1017, 618);
            this.pbSimulation.TabIndex = 8;
            this.pbSimulation.TabStop = false;
            this.pbSimulation.Paint += new System.Windows.Forms.PaintEventHandler(this.pbSimulation_Paint);
            this.pbSimulation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbSimulation_MouseDown);
            this.pbSimulation.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbSimulation_MouseMove);
            this.pbSimulation.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbSimulation_MouseUp);
            this.pbSimulation.Resize += new System.EventHandler(this.pbSimulation_SizeChanged);
            // 
            // pnlRightPanel
            // 
            this.pnlRightPanel.Controls.Add(this.gbBodies);
            this.pnlRightPanel.Controls.Add(this.gbProperties);
            this.pnlRightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRightPanel.Location = new System.Drawing.Point(1017, 0);
            this.pnlRightPanel.Name = "pnlRightPanel";
            this.pnlRightPanel.Size = new System.Drawing.Size(247, 618);
            this.pnlRightPanel.TabIndex = 13;
            // 
            // gbBodies
            // 
            this.gbBodies.Controls.Add(this.lbBodies);
            this.gbBodies.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbBodies.Location = new System.Drawing.Point(0, 469);
            this.gbBodies.Name = "gbBodies";
            this.gbBodies.Size = new System.Drawing.Size(247, 149);
            this.gbBodies.TabIndex = 12;
            this.gbBodies.TabStop = false;
            this.gbBodies.Text = "Corpos";
            // 
            // lbBodies
            // 
            this.lbBodies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbBodies.FormattingEnabled = true;
            this.lbBodies.ItemHeight = 15;
            this.lbBodies.Location = new System.Drawing.Point(3, 19);
            this.lbBodies.Name = "lbBodies";
            this.lbBodies.Size = new System.Drawing.Size(241, 127);
            this.lbBodies.TabIndex = 12;
            this.lbBodies.SelectedIndexChanged += new System.EventHandler(this.lbBodies_SelectedIndexChanged);
            // 
            // gbProperties
            // 
            this.gbProperties.Controls.Add(this.txtName);
            this.gbProperties.Controls.Add(this.label1);
            this.gbProperties.Controls.Add(this.chkLocked);
            this.gbProperties.Controls.Add(this.btnAdd);
            this.gbProperties.Controls.Add(this.btnRemove);
            this.gbProperties.Controls.Add(this.btnUpdate);
            this.gbProperties.Controls.Add(this.txtVY);
            this.gbProperties.Controls.Add(this.label12);
            this.gbProperties.Controls.Add(this.txtVX);
            this.gbProperties.Controls.Add(this.label13);
            this.gbProperties.Controls.Add(this.txtY);
            this.gbProperties.Controls.Add(this.label10);
            this.gbProperties.Controls.Add(this.txtX);
            this.gbProperties.Controls.Add(this.label11);
            this.gbProperties.Controls.Add(this.pbImage);
            this.gbProperties.Controls.Add(this.label5);
            this.gbProperties.Controls.Add(this.lblColor);
            this.gbProperties.Controls.Add(this.label7);
            this.gbProperties.Controls.Add(this.txtRadius);
            this.gbProperties.Controls.Add(this.label8);
            this.gbProperties.Controls.Add(this.txtMass);
            this.gbProperties.Controls.Add(this.label9);
            this.gbProperties.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbProperties.Location = new System.Drawing.Point(0, 0);
            this.gbProperties.Name = "gbProperties";
            this.gbProperties.Size = new System.Drawing.Size(247, 469);
            this.gbProperties.TabIndex = 11;
            this.gbProperties.TabStop = false;
            this.gbProperties.Text = "Propriedades do Objeto";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(77, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(163, 23);
            this.txtName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nome";
            // 
            // chkLocked
            // 
            this.chkLocked.AutoSize = true;
            this.chkLocked.Location = new System.Drawing.Point(12, 393);
            this.chkLocked.Name = "chkLocked";
            this.chkLocked.Size = new System.Drawing.Size(67, 19);
            this.chkLocked.TabIndex = 27;
            this.chkLocked.Text = "Travado";
            this.chkLocked.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 427);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 33);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(168, 427);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(72, 33);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "Remover";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(90, 427);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(72, 33);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtVY
            // 
            this.txtVY.Location = new System.Drawing.Point(75, 355);
            this.txtVY.Name = "txtVY";
            this.txtVY.Size = new System.Drawing.Size(163, 23);
            this.txtVY.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 358);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 15);
            this.label12.TabIndex = 22;
            this.label12.Text = "VY";
            // 
            // txtVX
            // 
            this.txtVX.Location = new System.Drawing.Point(75, 326);
            this.txtVX.Name = "txtVX";
            this.txtVX.Size = new System.Drawing.Size(163, 23);
            this.txtVX.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 329);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 15);
            this.label13.TabIndex = 20;
            this.label13.Text = "VX";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(75, 295);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(163, 23);
            this.txtY.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "Y";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(75, 266);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(163, 23);
            this.txtX.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 269);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 15);
            this.label11.TabIndex = 16;
            this.label11.Text = "X";
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbImage.Location = new System.Drawing.Point(107, 160);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(100, 100);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 15;
            this.pbImage.TabStop = false;
            this.pbImage.DoubleClick += new System.EventHandler(this.pbImage_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Imagem";
            // 
            // lblColor
            // 
            this.lblColor.BackColor = System.Drawing.Color.Transparent;
            this.lblColor.Location = new System.Drawing.Point(77, 127);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(163, 23);
            this.lblColor.TabIndex = 13;
            this.lblColor.DoubleClick += new System.EventHandler(this.lblColor_DoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cor";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(77, 98);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(163, 23);
            this.txtRadius.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Raio";
            // 
            // txtMass
            // 
            this.txtMass.Location = new System.Drawing.Point(77, 69);
            this.txtMass.Name = "txtMass";
            this.txtMass.Size = new System.Drawing.Size(163, 23);
            this.txtMass.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Massa";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.mnuOpen,
            this.mnuSave,
            this.mnuSaveAs,
            this.mnuSeparator,
            this.mnuClose});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(61, 20);
            this.mnuFile.Text = "Arquivo";
            // 
            // mnuNew
            // 
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuNew.Size = new System.Drawing.Size(220, 22);
            this.mnuNew.Text = "Novo";
            this.mnuNew.Click += new System.EventHandler(this.mnuNew_Click);
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuOpen.Size = new System.Drawing.Size(220, 22);
            this.mnuOpen.Text = "Abrir";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuSave.Size = new System.Drawing.Size(220, 22);
            this.mnuSave.Text = "Salvar";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuSaveAs
            // 
            this.mnuSaveAs.Name = "mnuSaveAs";
            this.mnuSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.mnuSaveAs.Size = new System.Drawing.Size(220, 22);
            this.mnuSaveAs.Text = "Salvar como...";
            this.mnuSaveAs.Click += new System.EventHandler(this.mnuSaveAs_Click);
            // 
            // mnuSeparator
            // 
            this.mnuSeparator.Name = "mnuSeparator";
            this.mnuSeparator.Size = new System.Drawing.Size(220, 22);
            this.mnuSeparator.Text = "_";
            // 
            // mnuClose
            // 
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuClose.Size = new System.Drawing.Size(220, 22);
            this.mnuClose.Text = "Fechar";
            this.mnuClose.Click += new System.EventHandler(this.mnuClose_Click);
            // 
            // msMenuStrip
            // 
            this.msMenuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.msMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.msMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.msMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.msMenuStrip.Name = "msMenuStrip";
            this.msMenuStrip.Size = new System.Drawing.Size(1264, 24);
            this.msMenuStrip.TabIndex = 0;
            this.msMenuStrip.Text = "menuStrip1";
            // 
            // FrmOrbital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.tsToolStrip);
            this.Controls.Add(this.msMenuStrip);
            this.DoubleBuffered = true;
            this.Name = "FrmOrbital";
            this.Text = "Orbital";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmOrbital_FormClosing);
            this.Load += new System.EventHandler(this.FrmOrbital_Load);
            this.LocationChanged += new System.EventHandler(this.FrmOrbital_LocationChanged);
            this.SizeChanged += new System.EventHandler(this.FrmOrbital_SizeChanged);
            this.tsToolStrip.ResumeLayout(false);
            this.tsToolStrip.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSimulation)).EndInit();
            this.pnlRightPanel.ResumeLayout(false);
            this.gbBodies.ResumeLayout(false);
            this.gbProperties.ResumeLayout(false);
            this.gbProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.msMenuStrip.ResumeLayout(false);
            this.msMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

