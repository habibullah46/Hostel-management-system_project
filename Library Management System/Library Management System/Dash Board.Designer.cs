namespace Library_Management_System
{
    partial class Dash_Board
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dash_Board));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completeBookDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_txt = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Red;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.studentToolStripMenuItem,
            this.issueBookToolStripMenuItem,
            this.returnToolStripMenuItem,
            this.completeBookDetailsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1430, 110);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewBooksToolStripMenuItem,
            this.viewBookToolStripMenuItem});
            this.booksToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("booksToolStripMenuItem.Image")));
            this.booksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(126, 106);
            this.booksToolStripMenuItem.Text = "Books";
            // 
            // addNewBooksToolStripMenuItem
            // 
            this.addNewBooksToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.addNewBooksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewBooksToolStripMenuItem.Image")));
            this.addNewBooksToolStripMenuItem.Name = "addNewBooksToolStripMenuItem";
            this.addNewBooksToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.addNewBooksToolStripMenuItem.Text = "Add New Books";
            // 
            // viewBookToolStripMenuItem
            // 
            this.viewBookToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.viewBookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewBookToolStripMenuItem.Image")));
            this.viewBookToolStripMenuItem.Name = "viewBookToolStripMenuItem";
            this.viewBookToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.viewBookToolStripMenuItem.Text = "View Book";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewStudentToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.studentToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("studentToolStripMenuItem.Image")));
            this.studentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(196, 106);
            this.studentToolStripMenuItem.Text = "Student ";
            // 
            // addNewStudentToolStripMenuItem
            // 
            this.addNewStudentToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.addNewStudentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewStudentToolStripMenuItem.Image")));
            this.addNewStudentToolStripMenuItem.Name = "addNewStudentToolStripMenuItem";
            this.addNewStudentToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.addNewStudentToolStripMenuItem.Text = "Add New Student";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.viewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewToolStripMenuItem.Image")));
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // issueBookToolStripMenuItem
            // 
            this.issueBookToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueBookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("issueBookToolStripMenuItem.Image")));
            this.issueBookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.issueBookToolStripMenuItem.Name = "issueBookToolStripMenuItem";
            this.issueBookToolStripMenuItem.Size = new System.Drawing.Size(182, 106);
            this.issueBookToolStripMenuItem.Text = "Issue Book";
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("returnToolStripMenuItem.Image")));
            this.returnToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(135, 106);
            this.returnToolStripMenuItem.Text = "Return";
            // 
            // completeBookDetailsToolStripMenuItem
            // 
            this.completeBookDetailsToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completeBookDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("completeBookDetailsToolStripMenuItem.Image")));
            this.completeBookDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.completeBookDetailsToolStripMenuItem.Name = "completeBookDetailsToolStripMenuItem";
            this.completeBookDetailsToolStripMenuItem.Size = new System.Drawing.Size(270, 106);
            this.completeBookDetailsToolStripMenuItem.Text = "Complete Book Details";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(111, 106);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lbl_txt
            // 
            this.lbl_txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_txt.AutoSize = true;
            this.lbl_txt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_txt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_txt.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_txt.Location = new System.Drawing.Point(345, 236);
            this.lbl_txt.Name = "lbl_txt";
            this.lbl_txt.Size = new System.Drawing.Size(685, 53);
            this.lbl_txt.TabIndex = 2;
            this.lbl_txt.Text = "Well Come To Imran Khan library ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(347, 292);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(683, 344);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Dash_Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1430, 673);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_txt);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dash_Board";
            this.Text = "Dash_Board";
            this.Load += new System.EventHandler(this.Dash_Board_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem completeBookDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lbl_txt;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}