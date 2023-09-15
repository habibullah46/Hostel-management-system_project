namespace Hostel_Management_System
{
    partial class Room
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Room));
            this.label7 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.cmd_washroom = new System.Windows.Forms.ComboBox();
            this.cmd_type = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_seatRent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmd_florr = new System.Windows.Forms.ComboBox();
            this.txt_AvailableSeats = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 19);
            this.label7.TabIndex = 34;
            this.label7.Text = "Per Seat Rent:";
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_clear.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_clear.Image")));
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_clear.Location = new System.Drawing.Point(238, 436);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(102, 50);
            this.btn_clear.TabIndex = 7;
            this.btn_clear.Text = "Clear";
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // cmd_washroom
            // 
            this.cmd_washroom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmd_washroom.FormattingEnabled = true;
            this.cmd_washroom.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmd_washroom.Location = new System.Drawing.Point(176, 260);
            this.cmd_washroom.Name = "cmd_washroom";
            this.cmd_washroom.Size = new System.Drawing.Size(164, 28);
            this.cmd_washroom.TabIndex = 4;
            // 
            // cmd_type
            // 
            this.cmd_type.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmd_type.FormattingEnabled = true;
            this.cmd_type.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmd_type.Location = new System.Drawing.Point(176, 200);
            this.cmd_type.Name = "cmd_type";
            this.cmd_type.Size = new System.Drawing.Size(164, 28);
            this.cmd_type.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 19);
            this.label5.TabIndex = 30;
            this.label5.Text = "Attach Washroom:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "Floor:";
            // 
            // txt_seatRent
            // 
            this.txt_seatRent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_seatRent.Location = new System.Drawing.Point(176, 320);
            this.txt_seatRent.Name = "txt_seatRent";
            this.txt_seatRent.Size = new System.Drawing.Size(164, 26);
            this.txt_seatRent.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Available Seats:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(138, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room\r\n";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "Type:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 508);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(378, 53);
            this.panel2.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 109);
            this.panel1.TabIndex = 21;
            // 
            // cmd_florr
            // 
            this.cmd_florr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmd_florr.FormattingEnabled = true;
            this.cmd_florr.Items.AddRange(new object[] {
            "1st",
            "2nd ",
            "3rd",
            "4th",
            "sth"});
            this.cmd_florr.Location = new System.Drawing.Point(176, 140);
            this.cmd_florr.Name = "cmd_florr";
            this.cmd_florr.Size = new System.Drawing.Size(164, 28);
            this.cmd_florr.TabIndex = 2;
            // 
            // txt_AvailableSeats
            // 
            this.txt_AvailableSeats.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_AvailableSeats.Location = new System.Drawing.Point(176, 378);
            this.txt_AvailableSeats.Name = "txt_AvailableSeats";
            this.txt_AvailableSeats.Size = new System.Drawing.Size(164, 26);
            this.txt_AvailableSeats.TabIndex = 5;
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.Location = new System.Drawing.Point(122, 436);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(95, 50);
            this.btn_save.TabIndex = 35;
            this.btn_save.Text = "Save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(378, 561);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_AvailableSeats);
            this.Controls.Add(this.cmd_florr);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.cmd_washroom);
            this.Controls.Add(this.cmd_type);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_seatRent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Room";
            this.Text = "Room";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ComboBox cmd_washroom;
        private System.Windows.Forms.ComboBox cmd_type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_seatRent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmd_florr;
        private System.Windows.Forms.TextBox txt_AvailableSeats;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}