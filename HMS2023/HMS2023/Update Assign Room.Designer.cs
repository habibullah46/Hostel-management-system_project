namespace HMS2023
{
    partial class Update_Assign_Room
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_Assign_Room));
            this.tbl_RoomTableAdapter = new HMS2023.HMSDB2023DataSet3TableAdapters.tbl_RoomTableAdapter();
            this.hMSDB2023DataSet3 = new HMS2023.HMSDB2023DataSet3();
            this.tblRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmb_RoomNo = new System.Windows.Forms.ComboBox();
            this.hMSDB2023DataSet2 = new HMS2023.HMSDB2023DataSet2();
            this.tblstudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmb_StudentName = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.tbl_studentTableAdapter = new HMS2023.HMSDB2023DataSet2TableAdapters.tbl_studentTableAdapter();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_StudentCnic = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.updateAssignRoomdataset = new HMS2023.UpdateAssignRoomdataset();
            this.tblAssignRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_AssignRoomTableAdapter = new HMS2023.UpdateAssignRoomdatasetTableAdapters.tbl_AssignRoomTableAdapter();
            this.txt_AvialbleSeat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.hMSDB2023DataSet8 = new HMS2023.HMSDB2023DataSet8();
            this.tblRoomBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_RoomTableAdapter1 = new HMS2023.HMSDB2023DataSet8TableAdapters.tbl_RoomTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDB2023DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDB2023DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateAssignRoomdataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAssignRoomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDB2023DataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoomBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_RoomTableAdapter
            // 
            this.tbl_RoomTableAdapter.ClearBeforeFill = true;
            // 
            // hMSDB2023DataSet3
            // 
            this.hMSDB2023DataSet3.DataSetName = "HMSDB2023DataSet3";
            this.hMSDB2023DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblRoomBindingSource
            // 
            this.tblRoomBindingSource.DataMember = "tbl_Room";
            this.tblRoomBindingSource.DataSource = this.hMSDB2023DataSet3;
            // 
            // cmb_RoomNo
            // 
            this.cmb_RoomNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmb_RoomNo.DataSource = this.tblRoomBindingSource1;
            this.cmb_RoomNo.DisplayMember = "RoomNumber";
            this.cmb_RoomNo.FormattingEnabled = true;
            this.cmb_RoomNo.Location = new System.Drawing.Point(413, 268);
            this.cmb_RoomNo.Name = "cmb_RoomNo";
            this.cmb_RoomNo.Size = new System.Drawing.Size(160, 28);
            this.cmb_RoomNo.TabIndex = 24;
            this.cmb_RoomNo.SelectedIndexChanged += new System.EventHandler(this.cmb_RoomNo_SelectedIndexChanged);
            // 
            // hMSDB2023DataSet2
            // 
            this.hMSDB2023DataSet2.DataSetName = "HMSDB2023DataSet2";
            this.hMSDB2023DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblstudentBindingSource
            // 
            this.tblstudentBindingSource.DataMember = "tbl_student";
            this.tblstudentBindingSource.DataSource = this.hMSDB2023DataSet2;
            // 
            // cmb_StudentName
            // 
            this.cmb_StudentName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmb_StudentName.DataSource = this.tblAssignRoomBindingSource;
            this.cmb_StudentName.DisplayMember = "StudentName";
            this.cmb_StudentName.FormattingEnabled = true;
            this.cmb_StudentName.Location = new System.Drawing.Point(413, 176);
            this.cmb_StudentName.Name = "cmb_StudentName";
            this.cmb_StudentName.Size = new System.Drawing.Size(160, 28);
            this.cmb_StudentName.TabIndex = 22;
            this.cmb_StudentName.SelectedIndexChanged += new System.EventHandler(this.cmb_StudentName_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.Location = new System.Drawing.Point(332, 352);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(104, 50);
            this.btn_save.TabIndex = 27;
            this.btn_save.Text = "Update";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tbl_studentTableAdapter
            // 
            this.tbl_studentTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Clear.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_Clear.Image")));
            this.btn_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Clear.Location = new System.Drawing.Point(460, 352);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(113, 50);
            this.btn_Clear.TabIndex = 30;
            this.btn_Clear.Text = "Delete";
            this.btn_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(289, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "Roon No:";
            // 
            // txt_StudentCnic
            // 
            this.txt_StudentCnic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_StudentCnic.Location = new System.Drawing.Point(413, 223);
            this.txt_StudentCnic.Name = "txt_StudentCnic";
            this.txt_StudentCnic.ReadOnly = true;
            this.txt_StudentCnic.Size = new System.Drawing.Size(160, 26);
            this.txt_StudentCnic.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(289, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "Student Name:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(289, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "Student CNIC:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(223, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Room";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 105);
            this.panel1.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Right;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(458, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Hostel Management System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 439);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(668, 59);
            this.panel2.TabIndex = 28;
            // 
            // updateAssignRoomdataset
            // 
            this.updateAssignRoomdataset.DataSetName = "UpdateAssignRoomdataset";
            this.updateAssignRoomdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblAssignRoomBindingSource
            // 
            this.tblAssignRoomBindingSource.DataMember = "tbl_AssignRoom";
            this.tblAssignRoomBindingSource.DataSource = this.updateAssignRoomdataset;
            // 
            // tbl_AssignRoomTableAdapter
            // 
            this.tbl_AssignRoomTableAdapter.ClearBeforeFill = true;
            // 
            // txt_AvialbleSeat
            // 
            this.txt_AvialbleSeat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_AvialbleSeat.Location = new System.Drawing.Point(413, 309);
            this.txt_AvialbleSeat.Name = "txt_AvialbleSeat";
            this.txt_AvialbleSeat.ReadOnly = true;
            this.txt_AvialbleSeat.Size = new System.Drawing.Size(160, 26);
            this.txt_AvialbleSeat.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(286, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 19);
            this.label5.TabIndex = 36;
            this.label5.Text = "Available Seats:";
            // 
            // hMSDB2023DataSet8
            // 
            this.hMSDB2023DataSet8.DataSetName = "HMSDB2023DataSet8";
            this.hMSDB2023DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblRoomBindingSource1
            // 
            this.tblRoomBindingSource1.DataMember = "tbl_Room";
            this.tblRoomBindingSource1.DataSource = this.hMSDB2023DataSet8;
            // 
            // tbl_RoomTableAdapter1
            // 
            this.tbl_RoomTableAdapter1.ClearBeforeFill = true;
            // 
            // Update_Assign_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 498);
            this.Controls.Add(this.txt_AvialbleSeat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_RoomNo);
            this.Controls.Add(this.cmb_StudentName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_StudentCnic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximumSize = new System.Drawing.Size(690, 554);
            this.MinimumSize = new System.Drawing.Size(690, 554);
            this.Name = "Update_Assign_Room";
            this.Text = "Update_Assign_Room";
            this.Load += new System.EventHandler(this.Update_Assign_Room_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hMSDB2023DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDB2023DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateAssignRoomdataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAssignRoomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDB2023DataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoomBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HMSDB2023DataSet3TableAdapters.tbl_RoomTableAdapter tbl_RoomTableAdapter;
        private HMSDB2023DataSet3 hMSDB2023DataSet3;
        private System.Windows.Forms.BindingSource tblRoomBindingSource;
        private System.Windows.Forms.ComboBox cmb_RoomNo;
        private HMSDB2023DataSet2 hMSDB2023DataSet2;
        private System.Windows.Forms.BindingSource tblstudentBindingSource;
        private System.Windows.Forms.ComboBox cmb_StudentName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_save;
        private HMSDB2023DataSet2TableAdapters.tbl_studentTableAdapter tbl_studentTableAdapter;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_StudentCnic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private UpdateAssignRoomdataset updateAssignRoomdataset;
        private System.Windows.Forms.BindingSource tblAssignRoomBindingSource;
        private UpdateAssignRoomdatasetTableAdapters.tbl_AssignRoomTableAdapter tbl_AssignRoomTableAdapter;
        private System.Windows.Forms.TextBox txt_AvialbleSeat;
        private System.Windows.Forms.Label label5;
        private HMSDB2023DataSet8 hMSDB2023DataSet8;
        private System.Windows.Forms.BindingSource tblRoomBindingSource1;
        private HMSDB2023DataSet8TableAdapters.tbl_RoomTableAdapter tbl_RoomTableAdapter1;
    }
}