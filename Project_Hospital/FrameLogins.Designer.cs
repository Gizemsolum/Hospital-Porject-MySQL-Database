namespace Project_Hospital
{
    partial class FrameLogins
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrameLogins));
            this.BtnPatientLogin = new System.Windows.Forms.Button();
            this.BtnDoctorLogin = new System.Windows.Forms.Button();
            this.BtnSecretaryLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnPatientLogin
            // 
            this.BtnPatientLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPatientLogin.BackgroundImage")));
            this.BtnPatientLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPatientLogin.Location = new System.Drawing.Point(65, 128);
            this.BtnPatientLogin.Name = "BtnPatientLogin";
            this.BtnPatientLogin.Size = new System.Drawing.Size(112, 83);
            this.BtnPatientLogin.TabIndex = 0;
            this.BtnPatientLogin.UseVisualStyleBackColor = true;
            this.BtnPatientLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnDoctorLogin
            // 
            this.BtnDoctorLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDoctorLogin.BackgroundImage")));
            this.BtnDoctorLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDoctorLogin.Location = new System.Drawing.Point(203, 128);
            this.BtnDoctorLogin.Name = "BtnDoctorLogin";
            this.BtnDoctorLogin.Size = new System.Drawing.Size(112, 83);
            this.BtnDoctorLogin.TabIndex = 1;
            this.BtnDoctorLogin.UseVisualStyleBackColor = true;
            this.BtnDoctorLogin.Click += new System.EventHandler(this.BtnDoctorLogin_Click);
            // 
            // BtnSecretaryLogin
            // 
            this.BtnSecretaryLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSecretaryLogin.BackgroundImage")));
            this.BtnSecretaryLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSecretaryLogin.Location = new System.Drawing.Point(335, 128);
            this.BtnSecretaryLogin.Name = "BtnSecretaryLogin";
            this.BtnSecretaryLogin.Size = new System.Drawing.Size(112, 83);
            this.BtnSecretaryLogin.TabIndex = 2;
            this.BtnSecretaryLogin.UseVisualStyleBackColor = true;
            this.BtnSecretaryLogin.Click += new System.EventHandler(this.BtnSecretaryLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Patient";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doctor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Secretary";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(267, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 97);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(57, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 43);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sea Green";
            // 
            // FrameLogins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(527, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSecretaryLogin);
            this.Controls.Add(this.BtnDoctorLogin);
            this.Controls.Add(this.BtnPatientLogin);
            this.Font = new System.Drawing.Font("Georgia", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrameLogins";
            this.Text = "Entrance to Sea Green Hospital";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPatientLogin;
        private System.Windows.Forms.Button BtnDoctorLogin;
        private System.Windows.Forms.Button BtnSecretaryLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

