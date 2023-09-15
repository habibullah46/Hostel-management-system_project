namespace Hostel_Management_System.hostel_form
{
    partial class Edit_Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Staff));
            this.button1 = new System.Windows.Forms.Button();
            this.txt_registrationdate = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_mobile = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmd_name = new System.Windows.Forms.ComboBox();
            this.tblRegistrationNewStaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hostelDbDataSet7 = new Hostel_Management_System.HostelDbDataSet7();
            this.txt_dateofbirht = new System.Windows.Forms.DateTimePicker();
            this.txt_fathername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Bloodgroup = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cnic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbl_RegistrationNewStaffTableAdapter = new Hostel_Management_System.HostelDbDataSet7TableAdapters.tbl_RegistrationNewStaffTableAdapter();
            this.btn_clear = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegistrationNewStaffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDbDataSet7)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(126, 503);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 50);
            this.button1.TabIndex = 38;
            this.button1.Text = "Update";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_registrationdate
            // 
            this.txt_registrationdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_registrationdate.Location = new System.Drawing.Point(170, 445);
            this.txt_registrationdate.Name = "txt_registrationdate";
            this.txt_registrationdate.Size = new System.Drawing.Size(180, 26);
            this.txt_registrationdate.TabIndex = 37;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(15, 445);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 19);
            this.label14.TabIndex = 40;
            this.label14.Text = "Registration Date:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.txt_address);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_mobile);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(401, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 261);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contact Information";
            // 
            // txt_address
            // 
            this.txt_address.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_address.Location = new System.Drawing.Point(113, 117);
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
            this.label8.Location = new System.Drawing.Point(5, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "Address:";
            // 
            // txt_mobile
            // 
            this.txt_mobile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_mobile.Location = new System.Drawing.Point(113, 53);
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.Size = new System.Drawing.Size(180, 26);
            this.txt_mobile.TabIndex = 7;
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
            this.groupBox1.Location = new System.Drawing.Point(34, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 306);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Data";
            // 
            // cmd_name
            // 
            this.cmd_name.DataSource = this.tblRegistrationNewStaffBindingSource;
            this.cmd_name.DisplayMember = "Name";
            this.cmd_name.FormattingEnabled = true;
            this.cmd_name.Location = new System.Drawing.Point(135, 43);
            this.cmd_name.Name = "cmd_name";
            this.cmd_name.Size = new System.Drawing.Size(181, 28);
            this.cmd_name.TabIndex = 1;
            this.cmd_name.SelectedIndexChanged += new System.EventHandler(this.cmd_name_SelectedIndexChanged);
            // 
            // tblRegistrationNewStaffBindingSource
            // 
            this.tblRegistrationNewStaffBindingSource.DataMember = "tbl_RegistrationNewStaff";
            this.tblRegistrationNewStaffBindingSource.DataSource = this.hostelDbDataSet7;
            // 
            // hostelDbDataSet7
            // 
            this.hostelDbDataSet7.DataSetName = "HostelDbDataSet7";
            this.hostelDbDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_dateofbirht
            // 
            this.txt_dateofbirht.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_dateofbirht.Location = new System.Drawing.Point(135, 157);
            this.txt_dateofbirht.Name = "txt_dateofbirht";
            this.txt_dateofbirht.Size = new System.Drawing.Size(180, 26);
            this.txt_dateofbirht.TabIndex = 3;
            // 
            // txt_fathername
            // 
            this.txt_fathername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_fathername.Location = new System.Drawing.Point(135, 261);
            this.txt_fathername.Name = "txt_fathername";
            this.txt_fathername.Size = new System.Drawing.Size(180, 26);
            this.txt_fathername.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Father Name:";
            // 
            // txt_Bloodgroup
            // 
            this.txt_Bloodgroup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Bloodgroup.Location = new System.Drawing.Point(135, 209);
            this.txt_Bloodgroup.Name = "txt_Bloodgroup";
            this.txt_Bloodgroup.Size = new System.Drawing.Size(180, 26);
            this.txt_Bloodgroup.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Blood Group:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date of Birth:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name:";
            // 
            // txt_cnic
            // 
            this.txt_cnic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_cnic.Location = new System.Drawing.Point(135, 105);
            this.txt_cnic.Name = "txt_cnic";
            this.txt_cnic.Size = new System.Drawing.Size(180, 26);
            this.txt_cnic.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "CNIC:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 109);
            this.panel1.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(278, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Staff";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 569);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(792, 53);
            this.panel2.TabIndex = 34;
            // 
            // tbl_RegistrationNewStaffTableAdapter
            // 
            this.tbl_RegistrationNewStaffTableAdapter.ClearBeforeFill = true;
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_clear.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_clear.Image")));
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_clear.Location = new System.Drawing.Point(241, 503);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(109, 50);
            this.btn_clear.TabIndex = 46;
            this.btn_clear.Text = "Delete";
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Edit_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 622);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_registrationdate);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Edit_Staff";
            this.Text = "Edit_Staff";
            this.Load += new System.EventHandler(this.Edit_Staff_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegistrationNewStaffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDbDataSet7)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker txt_registrationdate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_mobile;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmd_name;
        private System.Windows.Forms.DateTimePicker txt_dateofbirht;
        private System.Windows.Forms.TextBox txt_fathername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Bloodgroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cnic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private HostelDbDataSet7 hostelDbDataSet7;
        private System.Windows.Forms.BindingSource tblRegistrationNewStaffBindingSource;
        private HostelDbDataSet7TableAdapters.tbl_RegistrationNewStaffTableAdapter tbl_RegistrationNewStaffTableAdapter;
        private System.Windows.Forms.Button btn_clear;
    }
}