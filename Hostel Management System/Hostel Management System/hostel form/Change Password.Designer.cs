namespace Hostel_Management_System.hostel_form
{
    partial class Change_Password
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ct_addNewUser = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_confirmPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmd_UserName = new System.Windows.Forms.ComboBox();
            this.tblloginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hostelDbDataSet5 = new Hostel_Management_System.HostelDbDataSet5();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbl_loginTableAdapter = new Hostel_Management_System.HostelDbDataSet5TableAdapters.tbl_loginTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.ct_addNewUser.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblloginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDbDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 109);
            this.panel1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(100, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change Password";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 486);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(559, 53);
            this.panel2.TabIndex = 20;
            // 
            // ct_addNewUser
            // 
            this.ct_addNewUser.Controls.Add(this.tabPage1);
            this.ct_addNewUser.Controls.Add(this.tabPage2);
            this.ct_addNewUser.Location = new System.Drawing.Point(12, 115);
            this.ct_addNewUser.Name = "ct_addNewUser";
            this.ct_addNewUser.SelectedIndex = 0;
            this.ct_addNewUser.Size = new System.Drawing.Size(528, 363);
            this.ct_addNewUser.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.RoyalBlue;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txt_confirmPassword);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txt_Password);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txt_UserName);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(520, 330);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add New User";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Confirm Passord:";
            // 
            // txt_confirmPassword
            // 
            this.txt_confirmPassword.Location = new System.Drawing.Point(237, 200);
            this.txt_confirmPassword.Name = "txt_confirmPassword";
            this.txt_confirmPassword.Size = new System.Drawing.Size(159, 26);
            this.txt_confirmPassword.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(237, 128);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(159, 26);
            this.txt_Password.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name:";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(237, 60);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(159, 26);
            this.txt_UserName.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage2.Controls.Add(this.cmd_UserName);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(520, 330);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Change Password";
            // 
            // cmd_UserName
            // 
            this.cmd_UserName.DataSource = this.tblloginBindingSource;
            this.cmd_UserName.DisplayMember = "UserName";
            this.cmd_UserName.FormattingEnabled = true;
            this.cmd_UserName.Location = new System.Drawing.Point(265, 64);
            this.cmd_UserName.Name = "cmd_UserName";
            this.cmd_UserName.Size = new System.Drawing.Size(159, 28);
            this.cmd_UserName.TabIndex = 13;
            this.cmd_UserName.SelectedIndexChanged += new System.EventHandler(this.cmd_UserName_SelectedIndexChanged);
            // 
            // tblloginBindingSource
            // 
            this.tblloginBindingSource.DataMember = "tbl_login";
            this.tblloginBindingSource.DataSource = this.hostelDbDataSet5;
            // 
            // hostelDbDataSet5
            // 
            this.hostelDbDataSet5.DataSetName = "HostelDbDataSet5";
            this.hostelDbDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(263, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 52);
            this.button2.TabIndex = 12;
            this.button2.Text = "ChangePassword";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(128, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Confirm Passord:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(265, 209);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 26);
            this.textBox1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(128, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Password:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(265, 139);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 26);
            this.textBox2.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(128, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "User Name:";
            // 
            // tbl_loginTableAdapter
            // 
            this.tbl_loginTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Change_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(559, 539);
            this.Controls.Add(this.ct_addNewUser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Change_Password";
            this.Text = "Change_Password";
            this.Load += new System.EventHandler(this.Change_Password_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ct_addNewUser.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblloginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDbDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl ct_addNewUser;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_confirmPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cmd_UserName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private HostelDbDataSet5 hostelDbDataSet5;
        private System.Windows.Forms.BindingSource tblloginBindingSource;
        private HostelDbDataSet5TableAdapters.tbl_loginTableAdapter tbl_loginTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}