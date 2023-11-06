namespace HMS2023
{
    partial class Update_Staff
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_Staff));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_dateOFBirth = new System.Windows.Forms.DateTimePicker();
            this.txt_FatherName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_name = new System.Windows.Forms.ComboBox();
            this.tblStaffBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hMSDB2023DataSet10 = new HMS2023.HMSDB2023DataSet10();
            this.txt_BloodGroup = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_CNIC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_mobile = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_dateOFREG = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tblStaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_StaffTableAdapter = new HMS2023.updatestaffTableAdapters.tbl_StaffTableAdapter();
            this.tbl_StaffTableAdapter1 = new HMS2023.HMSDB2023DataSet10TableAdapters.tbl_StaffTableAdapter();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_udpate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStaffBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDB2023DataSet10)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStaffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1207, 100);
            this.panel1.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(400, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Register Staff";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_dateOFBirth
            // 
            this.txt_dateOFBirth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_dateOFBirth.Location = new System.Drawing.Point(144, 116);
            this.txt_dateOFBirth.Name = "txt_dateOFBirth";
            this.txt_dateOFBirth.Size = new System.Drawing.Size(174, 26);
            this.txt_dateOFBirth.TabIndex = 3;
            // 
            // txt_FatherName
            // 
            this.txt_FatherName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_FatherName.Location = new System.Drawing.Point(146, 195);
            this.txt_FatherName.Name = "txt_FatherName";
            this.txt_FatherName.Size = new System.Drawing.Size(172, 26);
            this.txt_FatherName.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Father Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.cmb_name);
            this.groupBox1.Controls.Add(this.txt_dateOFBirth);
            this.groupBox1.Controls.Add(this.txt_FatherName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_BloodGroup);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_CNIC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(376, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 243);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Staff Bio Data";
            // 
            // cmb_name
            // 
            this.cmb_name.DataSource = this.tblStaffBindingSource1;
            this.cmb_name.DisplayMember = "Name";
            this.cmb_name.FormattingEnabled = true;
            this.cmb_name.Location = new System.Drawing.Point(146, 32);
            this.cmb_name.Name = "cmb_name";
            this.cmb_name.Size = new System.Drawing.Size(172, 27);
            this.cmb_name.TabIndex = 13;
            this.cmb_name.SelectedIndexChanged += new System.EventHandler(this.cmb_name_SelectedIndexChanged_1);
            // 
            // tblStaffBindingSource1
            // 
            this.tblStaffBindingSource1.DataMember = "tbl_Staff";
            this.tblStaffBindingSource1.DataSource = this.hMSDB2023DataSet10;
            // 
            // hMSDB2023DataSet10
            // 
            this.hMSDB2023DataSet10.DataSetName = "HMSDB2023DataSet10";
            this.hMSDB2023DataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_BloodGroup
            // 
            this.txt_BloodGroup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_BloodGroup.Location = new System.Drawing.Point(146, 156);
            this.txt_BloodGroup.Name = "txt_BloodGroup";
            this.txt_BloodGroup.Size = new System.Drawing.Size(172, 26);
            this.txt_BloodGroup.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Blood Group:\r\n";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date Of Birth:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name:";
            // 
            // txt_CNIC
            // 
            this.txt_CNIC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_CNIC.Location = new System.Drawing.Point(146, 75);
            this.txt_CNIC.Name = "txt_CNIC";
            this.txt_CNIC.Size = new System.Drawing.Size(172, 26);
            this.txt_CNIC.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "CNIC:";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(933, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(210, 20);
            this.label14.TabIndex = 1;
            this.label14.Text = "Hostel Management System";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.label14);
            this.panel2.Location = new System.Drawing.Point(4, 592);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1207, 59);
            this.panel2.TabIndex = 30;
            // 
            // txt_address
            // 
            this.txt_address.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_address.Location = new System.Drawing.Point(201, 104);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(184, 126);
            this.txt_address.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(59, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 19);
            this.label12.TabIndex = 24;
            this.label12.Text = "Address:";
            // 
            // txt_mobile
            // 
            this.txt_mobile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_mobile.Location = new System.Drawing.Point(201, 56);
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.Size = new System.Drawing.Size(184, 26);
            this.txt_mobile.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(55, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 19);
            this.label11.TabIndex = 14;
            this.label11.Text = "Mobile:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 395);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // txt_dateOFREG
            // 
            this.txt_dateOFREG.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_dateOFREG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dateOFREG.Location = new System.Drawing.Point(551, 406);
            this.txt_dateOFREG.Name = "txt_dateOFREG";
            this.txt_dateOFREG.Size = new System.Drawing.Size(174, 26);
            this.txt_dateOFREG.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(369, 410);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(180, 20);
            this.label13.TabIndex = 34;
            this.label13.Text = "Date Of Registration:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.txt_address);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txt_mobile);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(753, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 267);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contact Information";
            // 
            // tbl_StaffTableAdapter
            // 
            this.tbl_StaffTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_StaffTableAdapter1
            // 
            this.tbl_StaffTableAdapter1.ClearBeforeFill = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Delete.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.Image")));
            this.btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Delete.Location = new System.Drawing.Point(581, 438);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(113, 50);
            this.btn_Delete.TabIndex = 49;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_udpate
            // 
            this.btn_udpate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_udpate.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_udpate.Image = ((System.Drawing.Image)(resources.GetObject("btn_udpate.Image")));
            this.btn_udpate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_udpate.Location = new System.Drawing.Point(409, 438);
            this.btn_udpate.Name = "btn_udpate";
            this.btn_udpate.Size = new System.Drawing.Size(104, 50);
            this.btn_udpate.TabIndex = 48;
            this.btn_udpate.Text = "Update";
            this.btn_udpate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_udpate.UseVisualStyleBackColor = true;
            this.btn_udpate.Click += new System.EventHandler(this.btn_udpate_Click);
            // 
            // Update_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 657);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_udpate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_dateOFREG);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox2);
            this.Name = "Update_Staff";
            this.Text = "Update_Staff";
            this.Load += new System.EventHandler(this.Update_Staff_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStaffBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDB2023DataSet10)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStaffBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txt_dateOFBirth;
        private System.Windows.Forms.TextBox txt_FatherName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_BloodGroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_CNIC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_mobile;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker txt_dateOFREG;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb_name;
        private System.Windows.Forms.BindingSource tblStaffBindingSource;
        private updatestaffTableAdapters.tbl_StaffTableAdapter tbl_StaffTableAdapter;
        private HMSDB2023DataSet10 hMSDB2023DataSet10;
        private System.Windows.Forms.BindingSource tblStaffBindingSource1;
        private HMSDB2023DataSet10TableAdapters.tbl_StaffTableAdapter tbl_StaffTableAdapter1;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_udpate;
    }
}