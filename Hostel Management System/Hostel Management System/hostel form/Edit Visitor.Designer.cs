namespace Hostel_Management_System.hostel_form
{
    partial class Edit_Visitor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Visitor));
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_Sname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_SCNIC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_VisitRelation = new System.Windows.Forms.TextBox();
            this.cmd_Visittime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CNIC = new System.Windows.Forms.TextBox();
            this.cmd_name = new System.Windows.Forms.ComboBox();
            this.hostelDbDataSet6 = new Hostel_Management_System.HostelDbDataSet6();
            this.tblVisitorEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_VisitorEntryTableAdapter = new Hostel_Management_System.HostelDbDataSet6TableAdapters.tbl_VisitorEntryTableAdapter();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDbDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVisitorEntryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.Location = new System.Drawing.Point(141, 383);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(105, 50);
            this.btn_save.TabIndex = 44;
            this.btn_save.Text = "Update";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_Sname
            // 
            this.txt_Sname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Sname.Location = new System.Drawing.Point(110, 103);
            this.txt_Sname.Name = "txt_Sname";
            this.txt_Sname.Size = new System.Drawing.Size(180, 26);
            this.txt_Sname.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 19);
            this.label7.TabIndex = 35;
            this.label7.Text = "Name:";
            // 
            // txt_SCNIC
            // 
            this.txt_SCNIC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_SCNIC.Location = new System.Drawing.Point(110, 50);
            this.txt_SCNIC.Name = "txt_SCNIC";
            this.txt_SCNIC.Size = new System.Drawing.Size(180, 26);
            this.txt_SCNIC.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 33;
            this.label6.Text = "CNIC:";
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_clear.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_clear.Image")));
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_clear.Location = new System.Drawing.Point(272, 383);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(102, 50);
            this.btn_clear.TabIndex = 45;
            this.btn_clear.Text = "Delete";
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.txt_Sname);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_SCNIC);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(448, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 172);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Details To Whome Visiting";
            // 
            // txt_VisitRelation
            // 
            this.txt_VisitRelation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_VisitRelation.Location = new System.Drawing.Point(185, 320);
            this.txt_VisitRelation.Name = "txt_VisitRelation";
            this.txt_VisitRelation.Size = new System.Drawing.Size(200, 26);
            this.txt_VisitRelation.TabIndex = 43;
            // 
            // cmd_Visittime
            // 
            this.cmd_Visittime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmd_Visittime.Location = new System.Drawing.Point(185, 261);
            this.cmd_Visittime.Name = "cmd_Visittime";
            this.cmd_Visittime.Size = new System.Drawing.Size(200, 26);
            this.cmd_Visittime.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 19);
            this.label5.TabIndex = 51;
            this.label5.Text = "Visitor Relation:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 19);
            this.label4.TabIndex = 50;
            this.label4.Text = "Time of Visit:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 49;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 48;
            this.label2.Text = "CNIC:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 451);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(849, 53);
            this.panel2.TabIndex = 47;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 109);
            this.panel1.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(207, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Visitor Entry";
            // 
            // txt_CNIC
            // 
            this.txt_CNIC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_CNIC.Location = new System.Drawing.Point(185, 202);
            this.txt_CNIC.Name = "txt_CNIC";
            this.txt_CNIC.Size = new System.Drawing.Size(200, 26);
            this.txt_CNIC.TabIndex = 40;
            // 
            // cmd_name
            // 
            this.cmd_name.DataSource = this.tblVisitorEntryBindingSource;
            this.cmd_name.DisplayMember = "Name";
            this.cmd_name.FormattingEnabled = true;
            this.cmd_name.Location = new System.Drawing.Point(185, 141);
            this.cmd_name.Name = "cmd_name";
            this.cmd_name.Size = new System.Drawing.Size(200, 28);
            this.cmd_name.TabIndex = 53;
            this.cmd_name.SelectedIndexChanged += new System.EventHandler(this.cmd_name_SelectedIndexChanged);
            // 
            // hostelDbDataSet6
            // 
            this.hostelDbDataSet6.DataSetName = "HostelDbDataSet6";
            this.hostelDbDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblVisitorEntryBindingSource
            // 
            this.tblVisitorEntryBindingSource.DataMember = "tbl_VisitorEntry";
            this.tblVisitorEntryBindingSource.DataSource = this.hostelDbDataSet6;
            // 
            // tbl_VisitorEntryTableAdapter
            // 
            this.tbl_VisitorEntryTableAdapter.ClearBeforeFill = true;
            // 
            // Edit_Visitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 504);
            this.Controls.Add(this.cmd_name);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_VisitRelation);
            this.Controls.Add(this.cmd_Visittime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_CNIC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Edit_Visitor";
            this.Text = "Edit_Visitor";
            this.Load += new System.EventHandler(this.Edit_Visitor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDbDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVisitorEntryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_Sname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_SCNIC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_VisitRelation;
        private System.Windows.Forms.DateTimePicker cmd_Visittime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_CNIC;
        private System.Windows.Forms.ComboBox cmd_name;
        private HostelDbDataSet6 hostelDbDataSet6;
        private System.Windows.Forms.BindingSource tblVisitorEntryBindingSource;
        private HostelDbDataSet6TableAdapters.tbl_VisitorEntryTableAdapter tbl_VisitorEntryTableAdapter;
    }
}