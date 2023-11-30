namespace Library_Management_System
{
    partial class viewBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewBook));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridview = new System.Windows.Forms.DataGridView();
            this.libraryManagementSystemDataSet = new Library_Management_System.LibraryManagementSystemDataSet();
            this.addBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addBookTableAdapter = new Library_Management_System.LibraryManagementSystemDataSetTableAdapters.AddBookTableAdapter();
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookAuthourNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPublicationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPurchaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1138, 100);
            this.panel1.TabIndex = 0;
            // 
            // gridview
            // 
            this.gridview.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gridview.AutoGenerateColumns = false;
            this.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIDDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.bookAuthourNameDataGridViewTextBoxColumn,
            this.bookPublicationDataGridViewTextBoxColumn,
            this.bookPurchaseDateDataGridViewTextBoxColumn,
            this.bookPriceDataGridViewTextBoxColumn,
            this.bookQuantityDataGridViewTextBoxColumn});
            this.gridview.DataSource = this.addBookBindingSource;
            this.gridview.Location = new System.Drawing.Point(7, 188);
            this.gridview.Name = "gridview";
            this.gridview.RowHeadersWidth = 62;
            this.gridview.RowTemplate.Height = 28;
            this.gridview.Size = new System.Drawing.Size(1119, 375);
            this.gridview.TabIndex = 2;
            // 
            // libraryManagementSystemDataSet
            // 
            this.libraryManagementSystemDataSet.DataSetName = "LibraryManagementSystemDataSet";
            this.libraryManagementSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addBookBindingSource
            // 
            this.addBookBindingSource.DataMember = "AddBook";
            this.addBookBindingSource.DataSource = this.libraryManagementSystemDataSet;
            // 
            // addBookTableAdapter
            // 
            this.addBookTableAdapter.ClearBeforeFill = true;
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "BookID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "BookID";
            this.bookIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            this.bookIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "BookName";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "BookName";
            this.bookNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            this.bookNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // bookAuthourNameDataGridViewTextBoxColumn
            // 
            this.bookAuthourNameDataGridViewTextBoxColumn.DataPropertyName = "BookAuthourName";
            this.bookAuthourNameDataGridViewTextBoxColumn.HeaderText = "BookAuthourName";
            this.bookAuthourNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bookAuthourNameDataGridViewTextBoxColumn.Name = "bookAuthourNameDataGridViewTextBoxColumn";
            this.bookAuthourNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // bookPublicationDataGridViewTextBoxColumn
            // 
            this.bookPublicationDataGridViewTextBoxColumn.DataPropertyName = "BookPublication";
            this.bookPublicationDataGridViewTextBoxColumn.HeaderText = "BookPublication";
            this.bookPublicationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bookPublicationDataGridViewTextBoxColumn.Name = "bookPublicationDataGridViewTextBoxColumn";
            this.bookPublicationDataGridViewTextBoxColumn.Width = 150;
            // 
            // bookPurchaseDateDataGridViewTextBoxColumn
            // 
            this.bookPurchaseDateDataGridViewTextBoxColumn.DataPropertyName = "BookPurchaseDate";
            this.bookPurchaseDateDataGridViewTextBoxColumn.HeaderText = "BookPurchaseDate";
            this.bookPurchaseDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bookPurchaseDateDataGridViewTextBoxColumn.Name = "bookPurchaseDateDataGridViewTextBoxColumn";
            this.bookPurchaseDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // bookPriceDataGridViewTextBoxColumn
            // 
            this.bookPriceDataGridViewTextBoxColumn.DataPropertyName = "BookPrice";
            this.bookPriceDataGridViewTextBoxColumn.HeaderText = "BookPrice";
            this.bookPriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bookPriceDataGridViewTextBoxColumn.Name = "bookPriceDataGridViewTextBoxColumn";
            this.bookPriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // bookQuantityDataGridViewTextBoxColumn
            // 
            this.bookQuantityDataGridViewTextBoxColumn.DataPropertyName = "BookQuantity";
            this.bookQuantityDataGridViewTextBoxColumn.HeaderText = "BookQuantity";
            this.bookQuantityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bookQuantityDataGridViewTextBoxColumn.Name = "bookQuantityDataGridViewTextBoxColumn";
            this.bookQuantityDataGridViewTextBoxColumn.Width = 150;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(474, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(239, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "View";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(775, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 45);
            this.label2.TabIndex = 6;
            this.label2.Text = "Book";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(379, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "BookName";
            // 
            // txt_Name
            // 
            this.txt_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_Name.Location = new System.Drawing.Point(474, 133);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(187, 26);
            this.txt_Name.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(680, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // viewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1138, 575);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridview);
            this.Controls.Add(this.panel1);
            this.Name = "viewBook";
            this.Text = "viewBook";
            this.Load += new System.EventHandler(this.viewBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridview;
        private LibraryManagementSystemDataSet libraryManagementSystemDataSet;
        private System.Windows.Forms.BindingSource addBookBindingSource;
        private LibraryManagementSystemDataSetTableAdapters.AddBookTableAdapter addBookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookAuthourNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookPublicationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookPurchaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Button button1;
    }
}