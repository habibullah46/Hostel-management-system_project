namespace HMS2023
{
    partial class Assign_Room
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Assign_Room));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_StudentName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_AvialbleSeat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmb_StudentCNIC = new System.Windows.Forms.ComboBox();
            this.tblstudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hMSDB2023DataSet2 = new HMS2023.HMSDB2023DataSet2();
            this.cmb_RoomNo = new System.Windows.Forms.ComboBox();
            this.tblRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hMSDB2023DataSet3 = new HMS2023.HMSDB2023DataSet3();
            this.tbl_studentTableAdapter = new HMS2023.HMSDB2023DataSet2TableAdapters.tbl_studentTableAdapter();
            this.tbl_RoomTableAdapter = new HMS2023.HMSDB2023DataSet3TableAdapters.tbl_RoomTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.hMSDB2023DataSet14 = new HMS2023.HMSDB2023DataSet14();
            this.tblAssignRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_AssignRoomTableAdapter = new HMS2023.HMSDB2023DataSet14TableAdapters.tbl_AssignRoomTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentCNICDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDB2023DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDB2023DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDB2023DataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAssignRoomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 465);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1490, 59);
            this.panel2.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Right;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(1280, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Hostel Management System";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1490, 105);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(550, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assign Room";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Student CNIC:";
            // 
            // txt_StudentName
            // 
            this.txt_StudentName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_StudentName.Location = new System.Drawing.Point(398, 216);
            this.txt_StudentName.Name = "txt_StudentName";
            this.txt_StudentName.ReadOnly = true;
            this.txt_StudentName.Size = new System.Drawing.Size(160, 26);
            this.txt_StudentName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(274, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Student Name:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(274, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Roon No:";
            // 
            // txt_AvialbleSeat
            // 
            this.txt_AvialbleSeat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_AvialbleSeat.Location = new System.Drawing.Point(398, 308);
            this.txt_AvialbleSeat.Name = "txt_AvialbleSeat";
            this.txt_AvialbleSeat.ReadOnly = true;
            this.txt_AvialbleSeat.Size = new System.Drawing.Size(160, 26);
            this.txt_AvialbleSeat.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(275, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Available Seats:";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Clear.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_Clear.Image")));
            this.btn_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Clear.Location = new System.Drawing.Point(452, 359);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(113, 50);
            this.btn_Clear.TabIndex = 6;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.Location = new System.Drawing.Point(324, 359);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(104, 50);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 164);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // cmb_StudentCNIC
            // 
            this.cmb_StudentCNIC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmb_StudentCNIC.DataSource = this.tblstudentBindingSource;
            this.cmb_StudentCNIC.DisplayMember = "CNIC";
            this.cmb_StudentCNIC.FormattingEnabled = true;
            this.cmb_StudentCNIC.Location = new System.Drawing.Point(398, 164);
            this.cmb_StudentCNIC.Name = "cmb_StudentCNIC";
            this.cmb_StudentCNIC.Size = new System.Drawing.Size(160, 28);
            this.cmb_StudentCNIC.TabIndex = 1;
            this.cmb_StudentCNIC.SelectedIndexChanged += new System.EventHandler(this.cmb_StudentCNIC_SelectedIndexChanged);
            // 
            // tblstudentBindingSource
            // 
            this.tblstudentBindingSource.DataMember = "tbl_student";
            this.tblstudentBindingSource.DataSource = this.hMSDB2023DataSet2;
            // 
            // hMSDB2023DataSet2
            // 
            this.hMSDB2023DataSet2.DataSetName = "HMSDB2023DataSet2";
            this.hMSDB2023DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmb_RoomNo
            // 
            this.cmb_RoomNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmb_RoomNo.DataSource = this.tblRoomBindingSource;
            this.cmb_RoomNo.DisplayMember = "RoomNumber";
            this.cmb_RoomNo.FormattingEnabled = true;
            this.cmb_RoomNo.Location = new System.Drawing.Point(398, 256);
            this.cmb_RoomNo.Name = "cmb_RoomNo";
            this.cmb_RoomNo.Size = new System.Drawing.Size(160, 28);
            this.cmb_RoomNo.TabIndex = 3;
            this.cmb_RoomNo.SelectedIndexChanged += new System.EventHandler(this.cmb_RoomNo_SelectedIndexChanged);
            // 
            // tblRoomBindingSource
            // 
            this.tblRoomBindingSource.DataMember = "tbl_Room";
            this.tblRoomBindingSource.DataSource = this.hMSDB2023DataSet3;
            // 
            // hMSDB2023DataSet3
            // 
            this.hMSDB2023DataSet3.DataSetName = "HMSDB2023DataSet3";
            this.hMSDB2023DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_studentTableAdapter
            // 
            this.tbl_studentTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_RoomTableAdapter
            // 
            this.tbl_RoomTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.studentCNICDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.roomNumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblAssignRoomBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(571, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(914, 245);
            this.dataGridView1.TabIndex = 22;
            // 
            // hMSDB2023DataSet14
            // 
            this.hMSDB2023DataSet14.DataSetName = "HMSDB2023DataSet14";
            this.hMSDB2023DataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblAssignRoomBindingSource
            // 
            this.tblAssignRoomBindingSource.DataMember = "tbl_AssignRoom";
            this.tblAssignRoomBindingSource.DataSource = this.hMSDB2023DataSet14;
            // 
            // tbl_AssignRoomTableAdapter
            // 
            this.tbl_AssignRoomTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // studentCNICDataGridViewTextBoxColumn
            // 
            this.studentCNICDataGridViewTextBoxColumn.DataPropertyName = "StudentCNIC";
            this.studentCNICDataGridViewTextBoxColumn.HeaderText = "StudentCNIC";
            this.studentCNICDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studentCNICDataGridViewTextBoxColumn.Name = "studentCNICDataGridViewTextBoxColumn";
            this.studentCNICDataGridViewTextBoxColumn.Width = 150;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            this.studentNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // roomNumberDataGridViewTextBoxColumn
            // 
            this.roomNumberDataGridViewTextBoxColumn.DataPropertyName = "RoomNumber";
            this.roomNumberDataGridViewTextBoxColumn.HeaderText = "RoomNumber";
            this.roomNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.roomNumberDataGridViewTextBoxColumn.Name = "roomNumberDataGridViewTextBoxColumn";
            this.roomNumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // Assign_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1490, 524);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmb_RoomNo);
            this.Controls.Add(this.cmb_StudentCNIC);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.txt_AvialbleSeat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_StudentName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Assign_Room";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assign_Room";
            this.Load += new System.EventHandler(this.Assign_Room_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDB2023DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDB2023DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDB2023DataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAssignRoomBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_StudentName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_AvialbleSeat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmb_StudentCNIC;
        private System.Windows.Forms.ComboBox cmb_RoomNo;
        private System.Windows.Forms.Label label6;
        private HMSDB2023DataSet2 hMSDB2023DataSet2;
        private System.Windows.Forms.BindingSource tblstudentBindingSource;
        private HMSDB2023DataSet2TableAdapters.tbl_studentTableAdapter tbl_studentTableAdapter;
        private HMSDB2023DataSet3 hMSDB2023DataSet3;
        private System.Windows.Forms.BindingSource tblRoomBindingSource;
        private HMSDB2023DataSet3TableAdapters.tbl_RoomTableAdapter tbl_RoomTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private HMSDB2023DataSet14 hMSDB2023DataSet14;
        private System.Windows.Forms.BindingSource tblAssignRoomBindingSource;
        private HMSDB2023DataSet14TableAdapters.tbl_AssignRoomTableAdapter tbl_AssignRoomTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentCNICDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
    }
}