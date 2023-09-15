namespace Hostel_Management_System.hostel_form
{
    partial class Search_Visitor
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
            this.gd_seachstudent = new System.Windows.Forms.DataGridView();
            this.hostelDbDataSet3 = new Hostel_Management_System.HostelDbDataSet3();
            this.tblVisitorEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_VisitorEntryTableAdapter = new Hostel_Management_System.HostelDbDataSet3TableAdapters.tbl_VisitorEntryTableAdapter();
            this.cNICDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitingToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vsitingToCNICDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_seachstudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDbDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVisitorEntryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 638);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(972, 53);
            this.panel2.TabIndex = 41;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 109);
            this.panel1.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(322, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Visitor";
            // 
            // gd_seachstudent
            // 
            this.gd_seachstudent.AutoGenerateColumns = false;
            this.gd_seachstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gd_seachstudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNICDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.visitTimeDataGridViewTextBoxColumn,
            this.relationDataGridViewTextBoxColumn,
            this.visitingToDataGridViewTextBoxColumn,
            this.vsitingToCNICDataGridViewTextBoxColumn});
            this.gd_seachstudent.DataSource = this.tblVisitorEntryBindingSource;
            this.gd_seachstudent.Location = new System.Drawing.Point(12, 208);
            this.gd_seachstudent.Name = "gd_seachstudent";
            this.gd_seachstudent.RowHeadersWidth = 62;
            this.gd_seachstudent.RowTemplate.Height = 28;
            this.gd_seachstudent.Size = new System.Drawing.Size(948, 424);
            this.gd_seachstudent.TabIndex = 42;
            // 
            // hostelDbDataSet3
            // 
            this.hostelDbDataSet3.DataSetName = "HostelDbDataSet3";
            this.hostelDbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblVisitorEntryBindingSource
            // 
            this.tblVisitorEntryBindingSource.DataMember = "tbl_VisitorEntry";
            this.tblVisitorEntryBindingSource.DataSource = this.hostelDbDataSet3;
            // 
            // tbl_VisitorEntryTableAdapter
            // 
            this.tbl_VisitorEntryTableAdapter.ClearBeforeFill = true;
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
            // visitTimeDataGridViewTextBoxColumn
            // 
            this.visitTimeDataGridViewTextBoxColumn.DataPropertyName = "VisitTime";
            this.visitTimeDataGridViewTextBoxColumn.HeaderText = "VisitTime";
            this.visitTimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.visitTimeDataGridViewTextBoxColumn.Name = "visitTimeDataGridViewTextBoxColumn";
            this.visitTimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // relationDataGridViewTextBoxColumn
            // 
            this.relationDataGridViewTextBoxColumn.DataPropertyName = "Relation";
            this.relationDataGridViewTextBoxColumn.HeaderText = "Relation";
            this.relationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.relationDataGridViewTextBoxColumn.Name = "relationDataGridViewTextBoxColumn";
            this.relationDataGridViewTextBoxColumn.Width = 150;
            // 
            // visitingToDataGridViewTextBoxColumn
            // 
            this.visitingToDataGridViewTextBoxColumn.DataPropertyName = "VisitingTo";
            this.visitingToDataGridViewTextBoxColumn.HeaderText = "VisitingTo";
            this.visitingToDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.visitingToDataGridViewTextBoxColumn.Name = "visitingToDataGridViewTextBoxColumn";
            this.visitingToDataGridViewTextBoxColumn.Width = 150;
            // 
            // vsitingToCNICDataGridViewTextBoxColumn
            // 
            this.vsitingToCNICDataGridViewTextBoxColumn.DataPropertyName = "VsitingToCNIC";
            this.vsitingToCNICDataGridViewTextBoxColumn.HeaderText = "VsitingToCNIC";
            this.vsitingToCNICDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.vsitingToCNICDataGridViewTextBoxColumn.Name = "vsitingToCNICDataGridViewTextBoxColumn";
            this.vsitingToCNICDataGridViewTextBoxColumn.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Name:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(360, 144);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(158, 26);
            this.txt_name.TabIndex = 44;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(566, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 39);
            this.button1.TabIndex = 45;
            this.button1.Text = "Search";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Search_Visitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 691);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gd_seachstudent);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Search_Visitor";
            this.Text = "Search_Visitor";
            this.Load += new System.EventHandler(this.Search_Visitor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gd_seachstudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDbDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVisitorEntryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gd_seachstudent;
        private HostelDbDataSet3 hostelDbDataSet3;
        private System.Windows.Forms.BindingSource tblVisitorEntryBindingSource;
        private HostelDbDataSet3TableAdapters.tbl_VisitorEntryTableAdapter tbl_VisitorEntryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNICDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn relationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitingToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vsitingToCNICDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button button1;
    }
}