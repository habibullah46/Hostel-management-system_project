namespace HMS2023
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search_Visitor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.grd_searchvisitor = new System.Windows.Forms.DataGridView();
            this.cNICDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitingToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitingToCNICDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblVisitorEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchVisitor = new HMS2023.SearchVisitor();
            this.tbl_VisitorEntryTableAdapter = new HMS2023.SearchVisitorTableAdapters.tbl_VisitorEntryTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_scnic = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_searchwith = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_sname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_searchvisitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVisitorEntryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchVisitor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1309, 100);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(546, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Visitor";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.SystemColors.Window;
            this.panel2.Location = new System.Drawing.Point(0, 610);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1309, 59);
            this.panel2.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(1072, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Hostel Management System";
            // 
            // grd_searchvisitor
            // 
            this.grd_searchvisitor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grd_searchvisitor.AutoGenerateColumns = false;
            this.grd_searchvisitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_searchvisitor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNICDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.visitTimeDataGridViewTextBoxColumn,
            this.relationDataGridViewTextBoxColumn,
            this.visitingToDataGridViewTextBoxColumn,
            this.visitingToCNICDataGridViewTextBoxColumn});
            this.grd_searchvisitor.DataSource = this.tblVisitorEntryBindingSource;
            this.grd_searchvisitor.Location = new System.Drawing.Point(22, 195);
            this.grd_searchvisitor.MaximumSize = new System.Drawing.Size(1275, 409);
            this.grd_searchvisitor.MinimumSize = new System.Drawing.Size(1275, 409);
            this.grd_searchvisitor.Name = "grd_searchvisitor";
            this.grd_searchvisitor.RowHeadersWidth = 62;
            this.grd_searchvisitor.RowTemplate.Height = 28;
            this.grd_searchvisitor.Size = new System.Drawing.Size(1275, 409);
            this.grd_searchvisitor.TabIndex = 6;
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
            // visitingToCNICDataGridViewTextBoxColumn
            // 
            this.visitingToCNICDataGridViewTextBoxColumn.DataPropertyName = "VisitingToCNIC";
            this.visitingToCNICDataGridViewTextBoxColumn.HeaderText = "VisitingToCNIC";
            this.visitingToCNICDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.visitingToCNICDataGridViewTextBoxColumn.Name = "visitingToCNICDataGridViewTextBoxColumn";
            this.visitingToCNICDataGridViewTextBoxColumn.Width = 150;
            // 
            // tblVisitorEntryBindingSource
            // 
            this.tblVisitorEntryBindingSource.DataMember = "tbl_VisitorEntry";
            this.tblVisitorEntryBindingSource.DataSource = this.searchVisitor;
            // 
            // searchVisitor
            // 
            this.searchVisitor.DataSetName = "SearchVisitor";
            this.searchVisitor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_VisitorEntryTableAdapter
            // 
            this.tbl_VisitorEntryTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(840, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 44);
            this.button1.TabIndex = 42;
            this.button1.Text = "Search";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txt_scnic
            // 
            this.txt_scnic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_scnic.Location = new System.Drawing.Point(637, 159);
            this.txt_scnic.Name = "txt_scnic";
            this.txt_scnic.Size = new System.Drawing.Size(160, 26);
            this.txt_scnic.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(562, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 40;
            this.label4.Text = "CNIC:";
            // 
            // cmb_searchwith
            // 
            this.cmb_searchwith.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmb_searchwith.FormattingEnabled = true;
            this.cmb_searchwith.Items.AddRange(new object[] {
            "Name",
            "CNIC"});
            this.cmb_searchwith.Location = new System.Drawing.Point(396, 134);
            this.cmb_searchwith.Name = "cmb_searchwith";
            this.cmb_searchwith.Size = new System.Drawing.Size(139, 28);
            this.cmb_searchwith.TabIndex = 39;
            this.cmb_searchwith.SelectedIndexChanged += new System.EventHandler(this.cmb_searchwith_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(280, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 38;
            this.label3.Text = "Search With:";
            // 
            // txt_sname
            // 
            this.txt_sname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_sname.Location = new System.Drawing.Point(637, 115);
            this.txt_sname.Name = "txt_sname";
            this.txt_sname.Size = new System.Drawing.Size(160, 26);
            this.txt_sname.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(562, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 36;
            this.label2.Text = "Name:";
            // 
            // Search_Visitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 669);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_scnic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_searchwith);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_sname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grd_searchvisitor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Search_Visitor";
            this.Text = "Search_Visitor";
            this.Load += new System.EventHandler(this.Search_Visitor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_searchvisitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVisitorEntryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchVisitor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView grd_searchvisitor;
        private SearchVisitor searchVisitor;
        private System.Windows.Forms.BindingSource tblVisitorEntryBindingSource;
        private SearchVisitorTableAdapters.tbl_VisitorEntryTableAdapter tbl_VisitorEntryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNICDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn relationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitingToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitingToCNICDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_scnic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_searchwith;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_sname;
        private System.Windows.Forms.Label label2;
    }
}