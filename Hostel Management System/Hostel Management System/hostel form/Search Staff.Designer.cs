namespace Hostel_Management_System.hostel_form
{
    partial class Search_Staff
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_searchstaff = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gd_searchstaff = new System.Windows.Forms.DataGridView();
            this.hostelDbDataSet4 = new Hostel_Management_System.HostelDbDataSet4();
            this.tblRegistrationNewStaffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_RegistrationNewStaffTableAdapter = new Hostel_Management_System.HostelDbDataSet4TableAdapters.tbl_RegistrationNewStaffTableAdapter();
            this.cNICDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfRegistrationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_searchstaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDbDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegistrationNewStaffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 612);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1289, 53);
            this.panel2.TabIndex = 41;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1289, 109);
            this.panel1.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(496, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Staff";
            // 
            // btn_searchstaff
            // 
            this.btn_searchstaff.Location = new System.Drawing.Point(726, 126);
            this.btn_searchstaff.Name = "btn_searchstaff";
            this.btn_searchstaff.Size = new System.Drawing.Size(93, 39);
            this.btn_searchstaff.TabIndex = 48;
            this.btn_searchstaff.Text = "Search";
            this.btn_searchstaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_searchstaff.UseVisualStyleBackColor = true;
            this.btn_searchstaff.Click += new System.EventHandler(this.btn_searchstaff_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(520, 133);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(158, 26);
            this.txt_name.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Name:";
            // 
            // gd_searchstaff
            // 
            this.gd_searchstaff.AutoGenerateColumns = false;
            this.gd_searchstaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_searchstaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNICDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.fatherNameDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.dateOfRegistrationDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.bloodGroupDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn});
            this.gd_searchstaff.DataSource = this.tblRegistrationNewStaffBindingSource;
            this.gd_searchstaff.Location = new System.Drawing.Point(12, 177);
            this.gd_searchstaff.Name = "gd_searchstaff";
            this.gd_searchstaff.RowHeadersWidth = 62;
            this.gd_searchstaff.RowTemplate.Height = 28;
            this.gd_searchstaff.Size = new System.Drawing.Size(1262, 415);
            this.gd_searchstaff.TabIndex = 49;
            // 
            // hostelDbDataSet4
            // 
            this.hostelDbDataSet4.DataSetName = "HostelDbDataSet4";
            this.hostelDbDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblRegistrationNewStaffBindingSource
            // 
            this.tblRegistrationNewStaffBindingSource.DataMember = "tbl_RegistrationNewStaff";
            this.tblRegistrationNewStaffBindingSource.DataSource = this.hostelDbDataSet4;
            // 
            // tbl_RegistrationNewStaffTableAdapter
            // 
            this.tbl_RegistrationNewStaffTableAdapter.ClearBeforeFill = true;
            // 
            // cNICDataGridViewTextBoxColumn
            // 
            this.cNICDataGridViewTextBoxColumn.DataPropertyName = "CNIC";
            this.cNICDataGridViewTextBoxColumn.HeaderText = "CNIC";
            this.cNICDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cNICDataGridViewTextBoxColumn.Name = "cNICDataGridViewTextBoxColumn";
            this.cNICDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // fatherNameDataGridViewTextBoxColumn
            // 
            this.fatherNameDataGridViewTextBoxColumn.DataPropertyName = "FatherName";
            this.fatherNameDataGridViewTextBoxColumn.HeaderText = "FatherName";
            this.fatherNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fatherNameDataGridViewTextBoxColumn.Name = "fatherNameDataGridViewTextBoxColumn";
            this.fatherNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "Mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "Mobile";
            this.mobileDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            this.mobileDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateOfRegistrationDataGridViewTextBoxColumn
            // 
            this.dateOfRegistrationDataGridViewTextBoxColumn.DataPropertyName = "DateOfRegistration";
            this.dateOfRegistrationDataGridViewTextBoxColumn.HeaderText = "DateOfRegistration";
            this.dateOfRegistrationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateOfRegistrationDataGridViewTextBoxColumn.Name = "dateOfRegistrationDataGridViewTextBoxColumn";
            this.dateOfRegistrationDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.Width = 150;
            // 
            // bloodGroupDataGridViewTextBoxColumn
            // 
            this.bloodGroupDataGridViewTextBoxColumn.DataPropertyName = "BloodGroup";
            this.bloodGroupDataGridViewTextBoxColumn.HeaderText = "BloodGroup";
            this.bloodGroupDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bloodGroupDataGridViewTextBoxColumn.Name = "bloodGroupDataGridViewTextBoxColumn";
            this.bloodGroupDataGridViewTextBoxColumn.Width = 150;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 150;
            // 
            // Search_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 665);
            this.Controls.Add(this.gd_searchstaff);
            this.Controls.Add(this.btn_searchstaff);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Search_Staff";
            this.Text = "Search_Staff";
            this.Load += new System.EventHandler(this.Search_Staff_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_searchstaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDbDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegistrationNewStaffBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_searchstaff;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gd_searchstaff;
        private HostelDbDataSet4 hostelDbDataSet4;
        private System.Windows.Forms.BindingSource tblRegistrationNewStaffBindingSource;
        private HostelDbDataSet4TableAdapters.tbl_RegistrationNewStaffTableAdapter tbl_RegistrationNewStaffTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNICDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfRegistrationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
    }
}