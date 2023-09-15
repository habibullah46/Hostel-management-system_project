namespace Hostel_Management_System.hostel_form
{
    partial class SearchingStudent
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cnic = new System.Windows.Forms.TextBox();
            this.dg_searchstudent = new System.Windows.Forms.DataGridView();
            this.cNICDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instituteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfRegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guardianNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guardianNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblstudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hostelDbDataSet2 = new Hostel_Management_System.HostelDbDataSet2();
            this.tbl_studentTableAdapter = new Hostel_Management_System.HostelDbDataSet2TableAdapters.tbl_studentTableAdapter();
            this.btn_search = new System.Windows.Forms.Button();
            this.cmd_searchwith = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_searchstudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDbDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 627);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1430, 53);
            this.panel2.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1430, 109);
            this.panel1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(509, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Searching Student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "CNIC:";
            // 
            // txt_cnic
            // 
            this.txt_cnic.Location = new System.Drawing.Point(436, 130);
            this.txt_cnic.Name = "txt_cnic";
            this.txt_cnic.Size = new System.Drawing.Size(171, 26);
            this.txt_cnic.TabIndex = 2;
            // 
            // dg_searchstudent
            // 
            this.dg_searchstudent.AutoGenerateColumns = false;
            this.dg_searchstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_searchstudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNICDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.fatherNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.mobileDataGridViewTextBoxColumn,
            this.instituteDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn,
            this.dateOfRegDataGridViewTextBoxColumn,
            this.doBDataGridViewTextBoxColumn,
            this.bloodGroupDataGridViewTextBoxColumn,
            this.guardianNumberDataGridViewTextBoxColumn,
            this.guardianNameDataGridViewTextBoxColumn});
            this.dg_searchstudent.DataSource = this.tblstudentBindingSource;
            this.dg_searchstudent.Location = new System.Drawing.Point(12, 200);
            this.dg_searchstudent.Name = "dg_searchstudent";
            this.dg_searchstudent.RowHeadersWidth = 62;
            this.dg_searchstudent.RowTemplate.Height = 28;
            this.dg_searchstudent.Size = new System.Drawing.Size(1406, 412);
            this.dg_searchstudent.TabIndex = 28;
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
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 150;
            // 
            // mobileDataGridViewTextBoxColumn
            // 
            this.mobileDataGridViewTextBoxColumn.DataPropertyName = "Mobile";
            this.mobileDataGridViewTextBoxColumn.HeaderText = "Mobile";
            this.mobileDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mobileDataGridViewTextBoxColumn.Name = "mobileDataGridViewTextBoxColumn";
            this.mobileDataGridViewTextBoxColumn.Width = 150;
            // 
            // instituteDataGridViewTextBoxColumn
            // 
            this.instituteDataGridViewTextBoxColumn.DataPropertyName = "Institute";
            this.instituteDataGridViewTextBoxColumn.HeaderText = "Institute";
            this.instituteDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.instituteDataGridViewTextBoxColumn.Name = "instituteDataGridViewTextBoxColumn";
            this.instituteDataGridViewTextBoxColumn.Width = 150;
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "Class";
            this.classDataGridViewTextBoxColumn.HeaderText = "Class";
            this.classDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            this.classDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateOfRegDataGridViewTextBoxColumn
            // 
            this.dateOfRegDataGridViewTextBoxColumn.DataPropertyName = "DateOfReg";
            this.dateOfRegDataGridViewTextBoxColumn.HeaderText = "DateOfReg";
            this.dateOfRegDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateOfRegDataGridViewTextBoxColumn.Name = "dateOfRegDataGridViewTextBoxColumn";
            this.dateOfRegDataGridViewTextBoxColumn.Width = 150;
            // 
            // doBDataGridViewTextBoxColumn
            // 
            this.doBDataGridViewTextBoxColumn.DataPropertyName = "DoB";
            this.doBDataGridViewTextBoxColumn.HeaderText = "DoB";
            this.doBDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.doBDataGridViewTextBoxColumn.Name = "doBDataGridViewTextBoxColumn";
            this.doBDataGridViewTextBoxColumn.Width = 150;
            // 
            // bloodGroupDataGridViewTextBoxColumn
            // 
            this.bloodGroupDataGridViewTextBoxColumn.DataPropertyName = "BloodGroup";
            this.bloodGroupDataGridViewTextBoxColumn.HeaderText = "BloodGroup";
            this.bloodGroupDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bloodGroupDataGridViewTextBoxColumn.Name = "bloodGroupDataGridViewTextBoxColumn";
            this.bloodGroupDataGridViewTextBoxColumn.Width = 150;
            // 
            // guardianNumberDataGridViewTextBoxColumn
            // 
            this.guardianNumberDataGridViewTextBoxColumn.DataPropertyName = "GuardianNumber";
            this.guardianNumberDataGridViewTextBoxColumn.HeaderText = "GuardianNumber";
            this.guardianNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.guardianNumberDataGridViewTextBoxColumn.Name = "guardianNumberDataGridViewTextBoxColumn";
            this.guardianNumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // guardianNameDataGridViewTextBoxColumn
            // 
            this.guardianNameDataGridViewTextBoxColumn.DataPropertyName = "GuardianName";
            this.guardianNameDataGridViewTextBoxColumn.HeaderText = "GuardianName";
            this.guardianNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.guardianNameDataGridViewTextBoxColumn.Name = "guardianNameDataGridViewTextBoxColumn";
            this.guardianNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // tblstudentBindingSource
            // 
            this.tblstudentBindingSource.DataMember = "tbl_student";
            this.tblstudentBindingSource.DataSource = this.hostelDbDataSet2;
            // 
            // hostelDbDataSet2
            // 
            this.hostelDbDataSet2.DataSetName = "HostelDbDataSet2";
            this.hostelDbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_studentTableAdapter
            // 
            this.tbl_studentTableAdapter.ClearBeforeFill = true;
            // 
            // btn_search
            // 
            this.btn_search.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
            this.btn_search.Location = new System.Drawing.Point(955, 124);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(86, 39);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "Search";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click_1);
            // 
            // cmd_searchwith
            // 
            this.cmd_searchwith.FormattingEnabled = true;
            this.cmd_searchwith.Items.AddRange(new object[] {
            "CNIC",
            "Name"});
            this.cmd_searchwith.Location = new System.Drawing.Point(209, 130);
            this.cmd_searchwith.Name = "cmd_searchwith";
            this.cmd_searchwith.Size = new System.Drawing.Size(121, 28);
            this.cmd_searchwith.TabIndex = 1;
            this.cmd_searchwith.SelectedIndexChanged += new System.EventHandler(this.cmd_searchwith_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Search With:";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(726, 132);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(171, 26);
            this.txt_Name.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(648, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Name:";
            // 
            // SearchingStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 680);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmd_searchwith);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dg_searchstudent);
            this.Controls.Add(this.txt_cnic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SearchingStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchingStudent";
            this.Load += new System.EventHandler(this.SearchingStudent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_searchstudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDbDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cnic;
        private System.Windows.Forms.DataGridView dg_searchstudent;
        private HostelDbDataSet2 hostelDbDataSet2;
        private System.Windows.Forms.BindingSource tblstudentBindingSource;
        private HostelDbDataSet2TableAdapters.tbl_studentTableAdapter tbl_studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNICDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn instituteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfRegDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guardianNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guardianNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox cmd_searchwith;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label4;
    }
}