
namespace Orbital
{
    partial class FrmOptions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtStepsPerFrame = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTimeScale = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtViewPortWidth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBackgroundFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClearBackground = new System.Windows.Forms.Button();
            this.btnChangeBackground = new System.Windows.Forms.Button();
            this.chkDrawPath = new System.Windows.Forms.CheckBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtStepsPerFrame);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtTimeScale);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtViewPortWidth);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtG);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtBackgroundFilePath);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.btnClearBackground);
            this.groupBox4.Controls.Add(this.btnChangeBackground);
            this.groupBox4.Controls.Add(this.chkDrawPath);
            this.groupBox4.Location = new System.Drawing.Point(6, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(397, 209);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            // 
            // txtStepsPerFrame
            // 
            this.txtStepsPerFrame.Location = new System.Drawing.Point(214, 135);
            this.txtStepsPerFrame.Name = "txtStepsPerFrame";
            this.txtStepsPerFrame.Size = new System.Drawing.Size(175, 23);
            this.txtStepsPerFrame.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 15);
            this.label5.TabIndex = 49;
            this.label5.Text = "Passor por frame";
            // 
            // txtTimeScale
            // 
            this.txtTimeScale.Location = new System.Drawing.Point(214, 106);
            this.txtTimeScale.Name = "txtTimeScale";
            this.txtTimeScale.Size = new System.Drawing.Size(175, 23);
            this.txtTimeScale.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 15);
            this.label4.TabIndex = 47;
            this.label4.Text = "Escala de tempo";
            // 
            // txtViewPortWidth
            // 
            this.txtViewPortWidth.Location = new System.Drawing.Point(214, 48);
            this.txtViewPortWidth.Name = "txtViewPortWidth";
            this.txtViewPortWidth.Size = new System.Drawing.Size(175, 23);
            this.txtViewPortWidth.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 15);
            this.label3.TabIndex = 45;
            this.label3.Text = "Largura da visualização (metros)";
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(214, 19);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(175, 23);
            this.txtG.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 15);
            this.label2.TabIndex = 43;
            this.label2.Text = "G (constante da gravitação universal)";
            // 
            // txtBackgroundFilePath
            // 
            this.txtBackgroundFilePath.Location = new System.Drawing.Point(113, 77);
            this.txtBackgroundFilePath.Name = "txtBackgroundFilePath";
            this.txtBackgroundFilePath.Size = new System.Drawing.Size(170, 23);
            this.txtBackgroundFilePath.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 41;
            this.label1.Text = "Imagem de fundo";
            // 
            // btnClearBackground
            // 
            this.btnClearBackground.Location = new System.Drawing.Point(331, 77);
            this.btnClearBackground.Name = "btnClearBackground";
            this.btnClearBackground.Size = new System.Drawing.Size(58, 23);
            this.btnClearBackground.TabIndex = 9;
            this.btnClearBackground.Text = "Limpar";
            this.btnClearBackground.UseVisualStyleBackColor = true;
            this.btnClearBackground.Click += new System.EventHandler(this.btnClearBackground_Click);
            // 
            // btnChangeBackground
            // 
            this.btnChangeBackground.Location = new System.Drawing.Point(289, 77);
            this.btnChangeBackground.Name = "btnChangeBackground";
            this.btnChangeBackground.Size = new System.Drawing.Size(36, 23);
            this.btnChangeBackground.TabIndex = 8;
            this.btnChangeBackground.Text = "...";
            this.btnChangeBackground.UseVisualStyleBackColor = true;
            this.btnChangeBackground.Click += new System.EventHandler(this.btnChangeBackground_Click);
            // 
            // chkDrawPath
            // 
            this.chkDrawPath.AutoSize = true;
            this.chkDrawPath.Checked = true;
            this.chkDrawPath.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDrawPath.Location = new System.Drawing.Point(6, 174);
            this.chkDrawPath.Name = "chkDrawPath";
            this.chkDrawPath.Size = new System.Drawing.Size(170, 19);
            this.chkDrawPath.TabIndex = 7;
            this.chkDrawPath.Text = "Mostrar traçado das órbitas";
            this.chkDrawPath.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(169, 217);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(70, 30);
            this.btnApply.TabIndex = 44;
            this.btnApply.Text = "Aplicar";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(93, 217);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(70, 30);
            this.btnOk.TabIndex = 45;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(245, 217);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 30);
            this.btnCancel.TabIndex = 46;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmOptions
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(407, 255);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Opções";
            this.Load += new System.EventHandler(this.FrmOptions_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnClearBackground;
        private System.Windows.Forms.Button btnChangeBackground;
        private System.Windows.Forms.CheckBox chkDrawPath;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox txtBackgroundFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStepsPerFrame;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTimeScale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtViewPortWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.Label label2;
    }
}