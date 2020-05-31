﻿namespace Project_Hospital
{
    partial class FramePatientLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FramePatientLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MaskTC = new System.Windows.Forms.MaskedTextBox();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.LnkSign = new System.Windows.Forms.LinkLabel();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(114, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Login Panel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Turkish Identity Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // MaskTC
            // 
            this.MaskTC.Location = new System.Drawing.Point(235, 119);
            this.MaskTC.Margin = new System.Windows.Forms.Padding(5);
            this.MaskTC.Mask = "00000000000";
            this.MaskTC.Name = "MaskTC";
            this.MaskTC.Size = new System.Drawing.Size(202, 31);
            this.MaskTC.TabIndex = 3;
            // 
            // TxtPass
            // 
            this.TxtPass.Location = new System.Drawing.Point(235, 198);
            this.TxtPass.Margin = new System.Windows.Forms.Padding(5);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(202, 31);
            this.TxtPass.TabIndex = 4;
            this.TxtPass.UseSystemPasswordChar = true;
            // 
            // LnkSign
            // 
            this.LnkSign.AutoSize = true;
            this.LnkSign.Location = new System.Drawing.Point(321, 286);
            this.LnkSign.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LnkSign.Name = "LnkSign";
            this.LnkSign.Size = new System.Drawing.Size(70, 23);
            this.LnkSign.TabIndex = 5;
            this.LnkSign.TabStop = true;
            this.LnkSign.Text = "Sign Up";
            this.LnkSign.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkSign_LinkClicked);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnLogin.Location = new System.Drawing.Point(164, 273);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(5);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(125, 48);
            this.BtnLogin.TabIndex = 6;
            this.BtnLogin.Text = "LOGIN";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // FramePatientLogin
            // 
            this.AcceptButton = this.BtnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(509, 326);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.LnkSign);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.MaskTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FramePatientLogin";
            this.Text = "Patient Login ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox MaskTC;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.LinkLabel LnkSign;
        private System.Windows.Forms.Button BtnLogin;
    }
}