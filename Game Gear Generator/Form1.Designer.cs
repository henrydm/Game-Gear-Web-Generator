namespace Game_Gear_Generator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textEmulador = new System.Windows.Forms.TextBox();
            this.radioNTSC = new System.Windows.Forms.RadioButton();
            this.radioPAL = new System.Windows.Forms.RadioButton();
            this.checkBoxLightGun = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxResX = new System.Windows.Forms.TextBox();
            this.textBoxResY = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 269);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form_DragDrop);
            this.pictureBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form_DragEnter);
            // 
            // textEmulador
            // 
            this.textEmulador.Location = new System.Drawing.Point(10, 20);
            this.textEmulador.Name = "textEmulador";
            this.textEmulador.Size = new System.Drawing.Size(129, 20);
            this.textEmulador.TabIndex = 1;
            this.textEmulador.Text = "JavaGear.jar";
            // 
            // radioNTSC
            // 
            this.radioNTSC.AutoSize = true;
            this.radioNTSC.Checked = true;
            this.radioNTSC.Location = new System.Drawing.Point(6, 22);
            this.radioNTSC.Name = "radioNTSC";
            this.radioNTSC.Size = new System.Drawing.Size(54, 17);
            this.radioNTSC.TabIndex = 3;
            this.radioNTSC.TabStop = true;
            this.radioNTSC.Text = "NTSC";
            this.radioNTSC.UseVisualStyleBackColor = true;
            // 
            // radioPAL
            // 
            this.radioPAL.AutoSize = true;
            this.radioPAL.Location = new System.Drawing.Point(66, 23);
            this.radioPAL.Name = "radioPAL";
            this.radioPAL.Size = new System.Drawing.Size(45, 17);
            this.radioPAL.TabIndex = 4;
            this.radioPAL.Text = "PAL";
            this.radioPAL.UseVisualStyleBackColor = true;
            // 
            // checkBoxLightGun
            // 
            this.checkBoxLightGun.AutoSize = true;
            this.checkBoxLightGun.Checked = true;
            this.checkBoxLightGun.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLightGun.Location = new System.Drawing.Point(26, 358);
            this.checkBoxLightGun.Name = "checkBoxLightGun";
            this.checkBoxLightGun.Size = new System.Drawing.Size(69, 17);
            this.checkBoxLightGun.TabIndex = 5;
            this.checkBoxLightGun.Text = "LightGun";
            this.checkBoxLightGun.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxResX);
            this.groupBox1.Controls.Add(this.textBoxResY);
            this.groupBox1.Controls.Add(this.radioNTSC);
            this.groupBox1.Controls.Add(this.radioPAL);
            this.groupBox1.Location = new System.Drawing.Point(217, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 117);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Format de Video";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Resolució:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "X";
            // 
            // textBoxResX
            // 
            this.textBoxResX.Location = new System.Drawing.Point(8, 80);
            this.textBoxResX.Name = "textBoxResX";
            this.textBoxResX.Size = new System.Drawing.Size(40, 20);
            this.textBoxResX.TabIndex = 6;
            this.textBoxResX.Text = "480";
            this.textBoxResX.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxResY
            // 
            this.textBoxResY.Location = new System.Drawing.Point(73, 80);
            this.textBoxResY.Name = "textBoxResY";
            this.textBoxResY.Size = new System.Drawing.Size(41, 20);
            this.textBoxResY.TabIndex = 5;
            this.textBoxResY.Text = "432";
            this.textBoxResY.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textEmulador);
            this.groupBox2.Location = new System.Drawing.Point(12, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(146, 51);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Emulador";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 404);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBoxLightGun);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Sega Game Gear";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textEmulador;
        private System.Windows.Forms.RadioButton radioNTSC;
        private System.Windows.Forms.RadioButton radioPAL;
        private System.Windows.Forms.CheckBox checkBoxLightGun;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxResX;
        private System.Windows.Forms.TextBox textBoxResY;
    }
}

