namespace Hostel_Management_System
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
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_Assign = new System.Windows.Forms.Button();
            this.cmd_RoomNO = new System.Windows.Forms.ComboBox();
            this.tblroomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hostelDbDataSet1 = new Hostel_Management_System.HostelDbDataSet1();
            this.cmd_studentCnic = new System.Windows.Forms.ComboBox();
            this.tblstudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hostelDbDataSet = new Hostel_Management_System.HostelDbDataSet();
            this.txt_StudentNmae = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataSet1 = new Hostel_Management_System.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_studentTableAdapter = new Hostel_Management_System.HostelDbDataSetTableAdapters.tbl_studentTableAdapter();
            this.txt_AvailableSeats = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbl_roomTableAdapter = new Hostel_Management_System.HostelDbDataSet1TableAdapters.tbl_roomTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tblroomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDbDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_clear.Image")));
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_clear.Location = new System.Drawing.Point(253, 396);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(102, 50);
            this.btn_clear.TabIndex = 33;
            this.btn_clear.Text = "Clear";
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // btn_Assign
            // 
            this.btn_Assign.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Assign.Image = ((System.Drawing.Image)(resources.GetObject("btn_Assign.Image")));
            this.btn_Assign.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Assign.Location = new System.Drawing.Point(132, 396);
            this.btn_Assign.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Assign.Name = "btn_Assign";
            this.btn_Assign.Size = new System.Drawing.Size(104, 50);
            this.btn_Assign.TabIndex = 5;
            this.btn_Assign.Text = "Assign";
            this.btn_Assign.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Assign.UseVisualStyleBackColor = true;
            this.btn_Assign.Click += new System.EventHandler(this.btn_Assign_Click);
            // 
            // cmd_RoomNO
            // 
            this.cmd_RoomNO.DataSource = this.tblroomBindingSource;
            this.cmd_RoomNO.DisplayMember = "RoomNumber";
            this.cmd_RoomNO.FormattingEnabled = true;
            this.cmd_RoomNO.Location = new System.Drawing.Point(203, 272);
            this.cmd_RoomNO.Name = "cmd_RoomNO";
            this.cmd_RoomNO.Size = new System.Drawing.Size(164, 28);
            this.cmd_RoomNO.TabIndex = 3;
            this.cmd_RoomNO.SelectedIndexChanged += new System.EventHandler(this.cmd_RoomNO_SelectedIndexChanged);
            // 
            // tblroomBindingSource
            // 
            this.tblroomBindingSource.DataMember = "tbl_room";
            this.tblroomBindingSource.DataSource = this.hostelDbDataSet1;
            // 
            // hostelDbDataSet1
            // 
            this.hostelDbDataSet1.DataSetName = "HostelDbDataSet1";
            this.hostelDbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmd_studentCnic
            // 
            this.cmd_studentCnic.DataSource = this.tblstudentBindingSource;
            this.cmd_studentCnic.DisplayMember = "CNIC";
            this.cmd_studentCnic.FormattingEnabled = true;
            this.cmd_studentCnic.Location = new System.Drawing.Point(203, 136);
            this.cmd_studentCnic.Name = "cmd_studentCnic";
            this.cmd_studentCnic.Size = new System.Drawing.Size(164, 28);
            this.cmd_studentCnic.TabIndex = 1;
            this.cmd_studentCnic.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tblstudentBindingSource
            // 
            this.tblstudentBindingSource.DataMember = "tbl_student";
            this.tblstudentBindingSource.DataSource = this.hostelDbDataSet;
            // 
            // hostelDbDataSet
            // 
            this.hostelDbDataSet.DataSetName = "HostelDbDataSet";
            this.hostelDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_StudentNmae
            // 
            this.txt_StudentNmae.Location = new System.Drawing.Point(203, 205);
            this.txt_StudentNmae.Name = "txt_StudentNmae";
            this.txt_StudentNmae.ReadOnly = true;
            this.txt_StudentNmae.Size = new System.Drawing.Size(164, 26);
            this.txt_StudentNmae.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(70, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 19);
            this.label6.TabIndex = 31;
            this.label6.Text = "Student Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 30;
            this.label5.Text = "Room No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(96, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assign Room";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "Student CNIC:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 503);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 53);
            this.panel2.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 109);
            this.panel1.TabIndex = 21;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // tbl_studentTableAdapter
            // 
            this.tbl_studentTableAdapter.ClearBeforeFill = true;
            // 
            // txt_AvailableSeats
            // 
            this.txt_AvailableSeats.Location = new System.Drawing.Point(203, 346);
            this.txt_AvailableSeats.Name = "txt_AvailableSeats";
            this.txt_AvailableSeats.ReadOnly = true;
            this.txt_AvailableSeats.Size = new System.Drawing.Size(164, 26);
            this.txt_AvailableSeats.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 35;
            this.label2.Text = "Available Seats:";
            // 
            // tbl_roomTableAdapter
            // 
            this.tbl_roomTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Assign_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(438, 556);
            this.Controls.Add(this.txt_AvailableSeats);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_Assign);
            this.Controls.Add(this.cmd_RoomNO);
            this.Controls.Add(this.cmd_studentCnic);
            this.Controls.Add(this.txt_StudentNmae);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(460, 612);
            this.MinimumSize = new System.Drawing.Size(460, 612);
            this.Name = "Assign_Room";
            this.Text = "Assign_Room";
            this.Load += new System.EventHandler(this.Assign_Room_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblroomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblstudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDbDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_Assign;
        private System.Windows.Forms.ComboBox cmd_RoomNO;
        private System.Windows.Forms.ComboBox cmd_studentCnic;
        private System.Windows.Forms.TextBox txt_StudentNmae;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private HostelDbDataSet hostelDbDataSet;
        private System.Windows.Forms.BindingSource tblstudentBindingSource;
        private HostelDbDataSetTableAdapters.tbl_studentTableAdapter tbl_studentTableAdapter;
        private System.Windows.Forms.TextBox txt_AvailableSeats;
        private System.Windows.Forms.Label label2;
        private HostelDbDataSet1 hostelDbDataSet1;
        private System.Windows.Forms.BindingSource tblroomBindingSource;
        private HostelDbDataSet1TableAdapters.tbl_roomTableAdapter tbl_roomTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}