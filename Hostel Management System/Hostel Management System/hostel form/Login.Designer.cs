namespace Hostel_Management_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chk_password = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(291, 207);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(164, 26);
            this.txt_Password.TabIndex = 43;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(183, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 19);
            this.label7.TabIndex = 50;
            this.label7.Text = "Password:";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_Clear.Image")));
            this.btn_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Clear.Location = new System.Drawing.Point(368, 253);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(114, 58);
            this.btn_Clear.TabIndex = 49;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Clear.UseVisualStyleBackColor = true;
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Image = ((System.Drawing.Image)(resources.GetObject("btn_Login.Image")));
            this.btn_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Login.Location = new System.Drawing.Point(247, 253);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(116, 58);
            this.btn_Login.TabIndex = 48;
            this.btn_Login.Text = "Login";
            this.btn_Login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(291, 146);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(164, 26);
            this.txt_UserName.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(183, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 47;
            this.label6.Text = "User Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(191, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "WellCome";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 317);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(633, 53);
            this.panel2.TabIndex = 39;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 109);
            this.panel1.TabIndex = 37;
            // 
            // chk_password
            // 
            this.chk_password.AutoSize = true;
            this.chk_password.Location = new System.Drawing.Point(477, 209);
            this.chk_password.Name = "chk_password";
            this.chk_password.Size = new System.Drawing.Size(148, 24);
            this.chk_password.TabIndex = 51;
            this.chk_password.Text = "Show Password";
            this.chk_password.UseVisualStyleBackColor = true;
            this.chk_password.CheckedChanged += new System.EventHandler(this.chk_password_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(411, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 19);
            this.label2.TabIndex = 51;
            this.label2.Text = "Hostel Management System";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 370);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chk_password);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(655, 426);
            this.MinimumSize = new System.Drawing.Size(655, 426);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chk_password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}