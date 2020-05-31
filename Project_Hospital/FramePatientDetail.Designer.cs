namespace Project_Hospital
{
    partial class FramePatientDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FramePatientDetail));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblNameSurname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblTC = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtAppId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LnkEditInfo = new System.Windows.Forms.LinkLabel();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.RchComp = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbDoc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbDept = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnHomepage = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblNameSurname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LblTC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            // 
            // LblNameSurname
            // 
            this.LblNameSurname.AutoSize = true;
            this.LblNameSurname.Location = new System.Drawing.Point(206, 86);
            this.LblNameSurname.Name = "LblNameSurname";
            this.LblNameSurname.Size = new System.Drawing.Size(56, 23);
            this.LblNameSurname.TabIndex = 10;
            this.LblNameSurname.Text = "NULL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "NAME SURNAME";
            // 
            // LblTC
            // 
            this.LblTC.AutoSize = true;
            this.LblTC.Location = new System.Drawing.Point(175, 47);
            this.LblTC.Name = "LblTC";
            this.LblTC.Size = new System.Drawing.Size(120, 23);
            this.LblTC.TabIndex = 8;
            this.LblTC.Text = "00000000000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "TC NO";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtAppId);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.LnkEditInfo);
            this.groupBox2.Controls.Add(this.BtnSave);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.RchComp);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.CmbDoc);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.CmbDept);
            this.groupBox2.Location = new System.Drawing.Point(12, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 370);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recourse";
            // 
            // TxtAppId
            // 
            this.TxtAppId.Enabled = false;
            this.TxtAppId.Location = new System.Drawing.Point(171, 45);
            this.TxtAppId.Name = "TxtAppId";
            this.TxtAppId.Size = new System.Drawing.Size(191, 31);
            this.TxtAppId.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "APPOINTMENT ID";
            // 
            // LnkEditInfo
            // 
            this.LnkEditInfo.AutoSize = true;
            this.LnkEditInfo.Location = new System.Drawing.Point(6, 339);
            this.LnkEditInfo.Name = "LnkEditInfo";
            this.LnkEditInfo.Size = new System.Drawing.Size(176, 23);
            this.LnkEditInfo.TabIndex = 16;
            this.LnkEditInfo.TabStop = true;
            this.LnkEditInfo.Text = "Edit Your Information";
            this.LnkEditInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkEditInfo_LinkClicked);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(128, 309);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(234, 31);
            this.BtnSave.TabIndex = 14;
            this.BtnSave.Text = "Save Appointment";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSaveAppointment_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "COMPLAINT";
            // 
            // RchComp
            // 
            this.RchComp.Location = new System.Drawing.Point(128, 194);
            this.RchComp.Name = "RchComp";
            this.RchComp.Size = new System.Drawing.Size(234, 109);
            this.RchComp.TabIndex = 13;
            this.RchComp.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "DOCTORS";
            // 
            // CmbDoc
            // 
            this.CmbDoc.FormattingEnabled = true;
            this.CmbDoc.Location = new System.Drawing.Point(128, 147);
            this.CmbDoc.Name = "CmbDoc";
            this.CmbDoc.Size = new System.Drawing.Size(234, 31);
            this.CmbDoc.TabIndex = 13;
            this.CmbDoc.SelectedIndexChanged += new System.EventHandler(this.CmbDoc_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "DEPARMENT";
            // 
            // CmbDept
            // 
            this.CmbDept.FormattingEnabled = true;
            this.CmbDept.Location = new System.Drawing.Point(128, 92);
            this.CmbDept.Name = "CmbDept";
            this.CmbDept.Size = new System.Drawing.Size(234, 31);
            this.CmbDept.TabIndex = 11;
            this.CmbDept.SelectedIndexChanged += new System.EventHandler(this.CmbDept_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(389, 277);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(464, 250);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Active Appointments";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 27);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(458, 220);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(386, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(464, 259);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Past Appointment";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(458, 229);
            this.dataGridView1.TabIndex = 0;
            // 
            // BtnHomepage
            // 
            this.BtnHomepage.Location = new System.Drawing.Point(12, 533);
            this.BtnHomepage.Name = "BtnHomepage";
            this.BtnHomepage.Size = new System.Drawing.Size(119, 40);
            this.BtnHomepage.TabIndex = 19;
            this.BtnHomepage.Text = "Homepage";
            this.BtnHomepage.UseVisualStyleBackColor = true;
            this.BtnHomepage.Click += new System.EventHandler(this.BtnHomepage_Click);
            // 
            // FramePatientDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(863, 579);
            this.Controls.Add(this.BtnHomepage);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FramePatientDetail";
            this.Text = "PatientDetail";
            this.Load += new System.EventHandler(this.FramePatientDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblNameSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox RchComp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbDoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbDept;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.LinkLabel LnkEditInfo;
        private System.Windows.Forms.TextBox TxtAppId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnHomepage;
    }
}