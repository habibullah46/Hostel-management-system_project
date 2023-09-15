namespace Hostel_Management_System.hostel_form
{
    partial class Edit_Register_Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Register_Student));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_dateofbirht = new System.Windows.Forms.DateTimePicker();
            this.txt_fathername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_guardannumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_GuardianName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_class = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_educationalInstitute = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_mobile = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Bloodgroup = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cnic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.txt_registrationdate = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmd_name = new System.Windows.Forms.ComboBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.hostelDbDataSet8 = new Hostel_Management_System.HostelDbDataSet8();
            this.tblstudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_studentTableAdapter = new Hostel_Management_System.HostelDbDataSet8TableAdapters.tbl_studentTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDbDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstudentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(203, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(501, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Register Student";
            // 
            // txt_dateofbirht
            // 
            this.txt_dateofbirht.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_dateofbirht.Location = new System.Drawing.Point(135, 154);
            this.txt_dateofbirht.Name = "txt_dateofbirht";
            this.txt_dateofbirht.Size = new System.Drawing.Size(180, 26);
            this.txt_dateofbirht.TabIndex = 3;
            // 
            // txt_fathername
            // 
            this.txt_fathername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_fathername.Location = new System.Drawing.Point(135, 260);
            this.txt_fathername.Name = "txt_fathername";
            this.txt_fathername.Size = new System.Drawing.Size(180, 26);
            this.txt_fathername.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date of Birth:";
            // 
            // txt_address
            // 
            this.txt_address.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_address.Location = new System.Drawing.Point(180, 328);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(180, 114);
            this.txt_address.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "Address:";
            // 
            // txt_guardannumber
            // 
            this.txt_guardannumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_guardannumber.Location = new System.Drawing.Point(180, 273);
            this.txt_guardannumber.Name = "txt_guardannumber";
            this.txt_guardannumber.Size = new System.Drawing.Size(180, 26);
            this.txt_guardannumber.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 19);
            this.label9.TabIndex = 11;
            this.label9.Text = "Guardian Number:";
            // 
            // txt_GuardianName
            // 
            this.txt_GuardianName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_GuardianName.Location = new System.Drawing.Point(180, 218);
            this.txt_GuardianName.Name = "txt_GuardianName";
            this.txt_GuardianName.Size = new System.Drawing.Size(180, 26);
            this.txt_GuardianName.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 19);
            this.label10.TabIndex = 9;
            this.label10.Text = "Guardian Name:";
            // 
            // txt_class
            // 
            this.txt_class.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_class.Location = new System.Drawing.Point(180, 163);
            this.txt_class.Name = "txt_class";
            this.txt_class.Size = new System.Drawing.Size(180, 26);
            this.txt_class.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 19);
            this.label11.TabIndex = 7;
            this.label11.Text = "Class:";
            // 
            // txt_educationalInstitute
            // 
            this.txt_educationalInstitute.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_educationalInstitute.Location = new System.Drawing.Point(180, 108);
            this.txt_educationalInstitute.Name = "txt_educationalInstitute";
            this.txt_educationalInstitute.Size = new System.Drawing.Size(180, 26);
            this.txt_educationalInstitute.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 19);
            this.label12.TabIndex = 5;
            this.label12.Text = "Educational Institute:";
            // 
            // txt_mobile
            // 
            this.txt_mobile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_mobile.Location = new System.Drawing.Point(180, 53);
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.Size = new System.Drawing.Size(180, 26);
            this.txt_mobile.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Father Name:";
            // 
            // txt_Bloodgroup
            // 
            this.txt_Bloodgroup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Bloodgroup.Location = new System.Drawing.Point(135, 207);
            this.txt_Bloodgroup.Name = "txt_Bloodgroup";
            this.txt_Bloodgroup.Size = new System.Drawing.Size(180, 26);
            this.txt_Bloodgroup.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 600);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(888, 53);
            this.panel2.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.cmd_name);
            this.groupBox1.Controls.Add(this.txt_dateofbirht);
            this.groupBox1.Controls.Add(this.txt_fathername);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_Bloodgroup);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_cnic);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(39, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 306);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Data";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Blood Group:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name:";
            // 
            // txt_cnic
            // 
            this.txt_cnic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_cnic.Location = new System.Drawing.Point(135, 101);
            this.txt_cnic.Name = "txt_cnic";
            this.txt_cnic.Size = new System.Drawing.Size(180, 26);
            this.txt_cnic.TabIndex = 1;
            this.txt_cnic.Tag = "";
            this.txt_cnic.WordWrap = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "CNIC:";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(5, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 19);
            this.label13.TabIndex = 3;
            this.label13.Text = "Mobile:";
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Update.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Image = ((System.Drawing.Image)(resources.GetObject("btn_Update.Image")));
            this.btn_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Update.Location = new System.Drawing.Point(118, 499);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(108, 50);
            this.btn_Update.TabIndex = 30;
            this.btn_Update.Text = "Update";
            this.btn_Update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // txt_registrationdate
            // 
            this.txt_registrationdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_registrationdate.Location = new System.Drawing.Point(175, 441);
            this.txt_registrationdate.Name = "txt_registrationdate";
            this.txt_registrationdate.Size = new System.Drawing.Size(180, 26);
            this.txt_registrationdate.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(20, 441);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 19);
            this.label14.TabIndex = 32;
            this.label14.Text = "Registration Date:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.txt_address);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_guardannumber);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_GuardianName);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_class);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txt_educationalInstitute);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txt_mobile);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(440, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 448);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contact Information";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 109);
            this.panel1.TabIndex = 25;
            // 
            // cmd_name
            // 
            this.cmd_name.DataSource = this.tblstudentBindingSource;
            this.cmd_name.DisplayMember = "Name";
            this.cmd_name.FormattingEnabled = true;
            this.cmd_name.Location = new System.Drawing.Point(135, 46);
            this.cmd_name.Name = "cmd_name";
            this.cmd_name.Size = new System.Drawing.Size(180, 28);
            this.cmd_name.TabIndex = 12;
            this.cmd_name.SelectedIndexChanged += new System.EventHandler(this.cmd_name_SelectedIndexChanged);
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_clear.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_clear.Image")));
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_clear.Location = new System.Drawing.Point(246, 499);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(109, 50);
            this.btn_clear.TabIndex = 47;
            this.btn_clear.Text = "Delete";
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // hostelDbDataSet8
            // 
            this.hostelDbDataSet8.DataSetName = "HostelDbDataSet8";
            this.hostelDbDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblstudentBindingSource
            // 
            this.tblstudentBindingSource.DataMember = "tbl_student";
            this.tblstudentBindingSource.DataSource = this.hostelDbDataSet8;
            // 
            // tbl_studentTableAdapter
            // 
            this.tbl_studentTableAdapter.ClearBeforeFill = true;
            // 
            // Edit_Register_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 653);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.txt_registrationdate);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Name = "Edit_Register_Student";
            this.Text = "Edit_Register_Student";
            this.Load += new System.EventHandler(this.Edit_Register_Student_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDbDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstudentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txt_dateofbirht;
        private System.Windows.Forms.TextBox txt_fathername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_guardannumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_GuardianName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_class;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_educationalInstitute;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_mobile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Bloodgroup;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmd_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cnic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.DateTimePicker txt_registrationdate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_clear;
        private HostelDbDataSet8 hostelDbDataSet8;
        private System.Windows.Forms.BindingSource tblstudentBindingSource;
        private HostelDbDataSet8TableAdapters.tbl_studentTableAdapter tbl_studentTableAdapter;
    }
}