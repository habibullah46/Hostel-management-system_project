namespace HMS2023
{
    partial class Update_Room
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_Room));
            this.txt_Availableseats = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_AttachBAth = new System.Windows.Forms.ComboBox();
            this.txt_Rentseat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_flour = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.cmb_roomnumber = new System.Windows.Forms.ComboBox();
            this.udpateRoom = new HMS2023.UdpateRoom();
            this.tblRoomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_RoomTableAdapter = new HMS2023.UdpateRoomTableAdapters.tbl_RoomTableAdapter();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udpateRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Availableseats
            // 
            this.txt_Availableseats.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Availableseats.Location = new System.Drawing.Point(441, 364);
            this.txt_Availableseats.Name = "txt_Availableseats";
            this.txt_Availableseats.Size = new System.Drawing.Size(236, 26);
            this.txt_Availableseats.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(317, 367);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 19);
            this.label8.TabIndex = 55;
            this.label8.Text = "Available Seat:";
            // 
            // cmb_AttachBAth
            // 
            this.cmb_AttachBAth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmb_AttachBAth.FormattingEnabled = true;
            this.cmb_AttachBAth.Items.AddRange(new object[] {
            "Yes ",
            "No"});
            this.cmb_AttachBAth.Location = new System.Drawing.Point(441, 263);
            this.cmb_AttachBAth.Name = "cmb_AttachBAth";
            this.cmb_AttachBAth.Size = new System.Drawing.Size(236, 28);
            this.cmb_AttachBAth.TabIndex = 42;
            // 
            // txt_Rentseat
            // 
            this.txt_Rentseat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Rentseat.Location = new System.Drawing.Point(441, 316);
            this.txt_Rentseat.Name = "txt_Rentseat";
            this.txt_Rentseat.Size = new System.Drawing.Size(236, 26);
            this.txt_Rentseat.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(317, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 19);
            this.label7.TabIndex = 53;
            this.label7.Text = "Per Seat Rent:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 471);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(810, 59);
            this.panel2.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Right;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(600, 0);
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
            this.panel1.Size = new System.Drawing.Size(810, 105);
            this.panel1.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(370, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmb_type
            // 
            this.cmb_type.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmb_type.Location = new System.Drawing.Point(441, 212);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(236, 28);
            this.cmb_type.TabIndex = 41;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 289);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(318, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 38);
            this.label5.TabIndex = 51;
            this.label5.Text = "Attach Bath:\r\n\r\n";
            // 
            // txt_flour
            // 
            this.txt_flour.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_flour.Location = new System.Drawing.Point(441, 172);
            this.txt_flour.Name = "txt_flour";
            this.txt_flour.Size = new System.Drawing.Size(236, 26);
            this.txt_flour.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(317, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 49;
            this.label3.Text = "Flour:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 48;
            this.label2.Text = "Number:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(317, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 50;
            this.label4.Text = "Type:";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Clear.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_Clear.Image")));
            this.btn_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Clear.Location = new System.Drawing.Point(589, 415);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(113, 50);
            this.btn_Clear.TabIndex = 57;
            this.btn_Clear.Text = "Delete";
            this.btn_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_update
            // 
            this.btn_update.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_update.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.Image")));
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_update.Location = new System.Drawing.Point(406, 415);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(104, 50);
            this.btn_update.TabIndex = 56;
            this.btn_update.Text = "Update";
            this.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // cmb_roomnumber
            // 
            this.cmb_roomnumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmb_roomnumber.DataSource = this.tblRoomBindingSource;
            this.cmb_roomnumber.DisplayMember = "RoomNumber";
            this.cmb_roomnumber.FormattingEnabled = true;
            this.cmb_roomnumber.Location = new System.Drawing.Point(441, 120);
            this.cmb_roomnumber.Name = "cmb_roomnumber";
            this.cmb_roomnumber.Size = new System.Drawing.Size(236, 28);
            this.cmb_roomnumber.TabIndex = 58;
            this.cmb_roomnumber.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // udpateRoom
            // 
            this.udpateRoom.DataSetName = "UdpateRoom";
            this.udpateRoom.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblRoomBindingSource
            // 
            this.tblRoomBindingSource.DataMember = "tbl_Room";
            this.tblRoomBindingSource.DataSource = this.udpateRoom;
            // 
            // tbl_RoomTableAdapter
            // 
            this.tbl_RoomTableAdapter.ClearBeforeFill = true;
            // 
            // Update_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 530);
            this.Controls.Add(this.cmb_roomnumber);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txt_Availableseats);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmb_AttachBAth);
            this.Controls.Add(this.txt_Rentseat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmb_type);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_flour);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Name = "Update_Room";
            this.Text = "Update_Room";
            this.Load += new System.EventHandler(this.Update_Room_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udpateRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoomBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Availableseats;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_AttachBAth;
        private System.Windows.Forms.TextBox txt_Rentseat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_flour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.ComboBox cmb_roomnumber;
        private UdpateRoom udpateRoom;
        private System.Windows.Forms.BindingSource tblRoomBindingSource;
        private UdpateRoomTableAdapters.tbl_RoomTableAdapter tbl_RoomTableAdapter;
    }
}