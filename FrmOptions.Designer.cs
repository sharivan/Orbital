
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
            groupBox4 = new System.Windows.Forms.GroupBox();
            txtStepsPerFrame = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            txtTimeScale = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtViewPortWidth = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txtG = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtBackgroundFilePath = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            btnClearBackground = new System.Windows.Forms.Button();
            btnChangeBackground = new System.Windows.Forms.Button();
            chkDrawPath = new System.Windows.Forms.CheckBox();
            btnApply = new System.Windows.Forms.Button();
            btnOk = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            openBackgroundImageDialog = new System.Windows.Forms.OpenFileDialog();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtStepsPerFrame);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(txtTimeScale);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(txtViewPortWidth);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(txtG);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(txtBackgroundFilePath);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(btnClearBackground);
            groupBox4.Controls.Add(btnChangeBackground);
            groupBox4.Controls.Add(chkDrawPath);
            groupBox4.Location = new System.Drawing.Point(6, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new System.Drawing.Size(397, 209);
            groupBox4.TabIndex = 14;
            groupBox4.TabStop = false;
            // 
            // txtStepsPerFrame
            // 
            txtStepsPerFrame.Location = new System.Drawing.Point(214, 135);
            txtStepsPerFrame.Name = "txtStepsPerFrame";
            txtStepsPerFrame.Size = new System.Drawing.Size(175, 23);
            txtStepsPerFrame.TabIndex = 50;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(6, 143);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(96, 15);
            label5.TabIndex = 49;
            label5.Text = "Passor por frame";
            // 
            // txtTimeScale
            // 
            txtTimeScale.Location = new System.Drawing.Point(214, 106);
            txtTimeScale.Name = "txtTimeScale";
            txtTimeScale.Size = new System.Drawing.Size(175, 23);
            txtTimeScale.TabIndex = 48;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 114);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(93, 15);
            label4.TabIndex = 47;
            label4.Text = "Escala de tempo";
            // 
            // txtViewPortWidth
            // 
            txtViewPortWidth.Location = new System.Drawing.Point(214, 48);
            txtViewPortWidth.Name = "txtViewPortWidth";
            txtViewPortWidth.Size = new System.Drawing.Size(175, 23);
            txtViewPortWidth.TabIndex = 46;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 56);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(177, 15);
            label3.TabIndex = 45;
            label3.Text = "Largura da visualização (metros)";
            // 
            // txtG
            // 
            txtG.Location = new System.Drawing.Point(214, 19);
            txtG.Name = "txtG";
            txtG.Size = new System.Drawing.Size(175, 23);
            txtG.TabIndex = 44;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 27);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(202, 15);
            label2.TabIndex = 43;
            label2.Text = "G (constante da gravitação universal)";
            // 
            // txtBackgroundFilePath
            // 
            txtBackgroundFilePath.Location = new System.Drawing.Point(113, 77);
            txtBackgroundFilePath.Name = "txtBackgroundFilePath";
            txtBackgroundFilePath.Size = new System.Drawing.Size(170, 23);
            txtBackgroundFilePath.TabIndex = 42;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 80);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(102, 15);
            label1.TabIndex = 41;
            label1.Text = "Imagem de fundo";
            // 
            // btnClearBackground
            // 
            btnClearBackground.Location = new System.Drawing.Point(331, 77);
            btnClearBackground.Name = "btnClearBackground";
            btnClearBackground.Size = new System.Drawing.Size(58, 23);
            btnClearBackground.TabIndex = 9;
            btnClearBackground.Text = "Limpar";
            btnClearBackground.UseVisualStyleBackColor = true;
            btnClearBackground.Click += BtnClearBackground_Click;
            // 
            // btnChangeBackground
            // 
            btnChangeBackground.Location = new System.Drawing.Point(289, 77);
            btnChangeBackground.Name = "btnChangeBackground";
            btnChangeBackground.Size = new System.Drawing.Size(36, 23);
            btnChangeBackground.TabIndex = 8;
            btnChangeBackground.Text = "...";
            btnChangeBackground.UseVisualStyleBackColor = true;
            btnChangeBackground.Click += BtnChangeBackground_Click;
            // 
            // chkDrawPath
            // 
            chkDrawPath.AutoSize = true;
            chkDrawPath.Checked = true;
            chkDrawPath.CheckState = System.Windows.Forms.CheckState.Checked;
            chkDrawPath.Location = new System.Drawing.Point(6, 174);
            chkDrawPath.Name = "chkDrawPath";
            chkDrawPath.Size = new System.Drawing.Size(170, 19);
            chkDrawPath.TabIndex = 7;
            chkDrawPath.Text = "Mostrar traçado das órbitas";
            chkDrawPath.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            btnApply.Location = new System.Drawing.Point(169, 217);
            btnApply.Name = "btnApply";
            btnApply.Size = new System.Drawing.Size(70, 30);
            btnApply.TabIndex = 44;
            btnApply.Text = "Aplicar";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += BtnApply_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new System.Drawing.Point(93, 217);
            btnOk.Name = "btnOk";
            btnOk.Size = new System.Drawing.Size(70, 30);
            btnOk.TabIndex = 45;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += BtnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(245, 217);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(70, 30);
            btnCancel.TabIndex = 46;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += BtnCancel_Click;
            // 
            // openBackgroundImageDialog
            // 
            openBackgroundImageDialog.InitialDirectory = "resources\\background";
            // 
            // FrmOptions
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(407, 255);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(btnApply);
            Controls.Add(groupBox4);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "FrmOptions";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Opções";
            Load += FrmOptions_Load;
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnClearBackground;
        private System.Windows.Forms.Button btnChangeBackground;
        private System.Windows.Forms.CheckBox chkDrawPath;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.OpenFileDialog openBackgroundImageDialog;
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