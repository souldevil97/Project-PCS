namespace Project
{
    partial class Books
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbBooked = new System.Windows.Forms.CheckBox();
            this.cbBorrowed = new System.Windows.Forms.CheckBox();
            this.cbCanBorrowed = new System.Windows.Forms.CheckBox();
            this.bAddAuthor = new System.Windows.Forms.Button();
            this.cbAuthor = new System.Windows.Forms.ComboBox();
            this.lbAuthor = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bPicture = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bInsert = new System.Windows.Forms.Button();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbPublisher = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBookID = new System.Windows.Forms.TextBox();
            this.BooksData = new System.Windows.Forms.DataGridView();
            this.Book_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bSearch = new System.Windows.Forms.Button();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.tSearch = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksData)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Master Book";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbBooked);
            this.groupBox1.Controls.Add(this.cbBorrowed);
            this.groupBox1.Controls.Add(this.cbCanBorrowed);
            this.groupBox1.Controls.Add(this.bAddAuthor);
            this.groupBox1.Controls.Add(this.cbAuthor);
            this.groupBox1.Controls.Add(this.lbAuthor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.bPicture);
            this.groupBox1.Controls.Add(this.bDelete);
            this.groupBox1.Controls.Add(this.bUpdate);
            this.groupBox1.Controls.Add(this.bInsert);
            this.groupBox1.Controls.Add(this.Picture);
            this.groupBox1.Controls.Add(this.cbCategory);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbPublisher);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tTitle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tBookID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 441);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // cbBooked
            // 
            this.cbBooked.AutoSize = true;
            this.cbBooked.Enabled = false;
            this.cbBooked.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBooked.Location = new System.Drawing.Point(158, 327);
            this.cbBooked.Name = "cbBooked";
            this.cbBooked.Size = new System.Drawing.Size(83, 24);
            this.cbBooked.TabIndex = 20;
            this.cbBooked.Text = "Booked";
            this.cbBooked.UseVisualStyleBackColor = true;
            // 
            // cbBorrowed
            // 
            this.cbBorrowed.AutoSize = true;
            this.cbBorrowed.Enabled = false;
            this.cbBorrowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBorrowed.Location = new System.Drawing.Point(158, 305);
            this.cbBorrowed.Name = "cbBorrowed";
            this.cbBorrowed.Size = new System.Drawing.Size(96, 24);
            this.cbBorrowed.TabIndex = 19;
            this.cbBorrowed.Text = "Borrowed";
            this.cbBorrowed.UseVisualStyleBackColor = true;
            // 
            // cbCanBorrowed
            // 
            this.cbCanBorrowed.AutoSize = true;
            this.cbCanBorrowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCanBorrowed.Location = new System.Drawing.Point(158, 281);
            this.cbCanBorrowed.Name = "cbCanBorrowed";
            this.cbCanBorrowed.Size = new System.Drawing.Size(129, 24);
            this.cbCanBorrowed.TabIndex = 18;
            this.cbCanBorrowed.Text = "Can Borrowed";
            this.cbCanBorrowed.UseVisualStyleBackColor = true;
            // 
            // bAddAuthor
            // 
            this.bAddAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAddAuthor.Location = new System.Drawing.Point(158, 247);
            this.bAddAuthor.Name = "bAddAuthor";
            this.bAddAuthor.Size = new System.Drawing.Size(100, 28);
            this.bAddAuthor.TabIndex = 17;
            this.bAddAuthor.Text = "Add Author";
            this.bAddAuthor.UseVisualStyleBackColor = true;
            this.bAddAuthor.Click += new System.EventHandler(this.bAddAuthor_Click);
            // 
            // cbAuthor
            // 
            this.cbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAuthor.FormattingEnabled = true;
            this.cbAuthor.Location = new System.Drawing.Point(10, 248);
            this.cbAuthor.Name = "cbAuthor";
            this.cbAuthor.Size = new System.Drawing.Size(134, 28);
            this.cbAuthor.TabIndex = 14;
            // 
            // lbAuthor
            // 
            this.lbAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAuthor.FormattingEnabled = true;
            this.lbAuthor.ItemHeight = 20;
            this.lbAuthor.Location = new System.Drawing.Point(10, 197);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(134, 44);
            this.lbAuthor.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Authors";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(10, 301);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker1.Size = new System.Drawing.Size(134, 26);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // bPicture
            // 
            this.bPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPicture.Location = new System.Drawing.Point(158, 207);
            this.bPicture.Name = "bPicture";
            this.bPicture.Size = new System.Drawing.Size(158, 35);
            this.bPicture.TabIndex = 7;
            this.bPicture.Text = "Insert Picture";
            this.bPicture.UseVisualStyleBackColor = true;
            this.bPicture.Click += new System.EventHandler(this.bPicture_Click);
            // 
            // bDelete
            // 
            this.bDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDelete.Location = new System.Drawing.Point(218, 388);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(98, 35);
            this.bDelete.TabIndex = 10;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUpdate.Location = new System.Drawing.Point(114, 388);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(98, 35);
            this.bUpdate.TabIndex = 9;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // bInsert
            // 
            this.bInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInsert.Location = new System.Drawing.Point(10, 388);
            this.bInsert.Name = "bInsert";
            this.bInsert.Size = new System.Drawing.Size(98, 35);
            this.bInsert.TabIndex = 8;
            this.bInsert.Text = "Insert";
            this.bInsert.UseVisualStyleBackColor = true;
            this.bInsert.Click += new System.EventHandler(this.bInsert_Click);
            // 
            // Picture
            // 
            this.Picture.Location = new System.Drawing.Point(158, 16);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(158, 185);
            this.Picture.TabIndex = 13;
            this.Picture.TabStop = false;
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(10, 354);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(134, 28);
            this.cbCategory.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Year Publication";
            // 
            // cbPublisher
            // 
            this.cbPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPublisher.FormattingEnabled = true;
            this.cbPublisher.Location = new System.Drawing.Point(10, 143);
            this.cbPublisher.Name = "cbPublisher";
            this.cbPublisher.Size = new System.Drawing.Size(134, 28);
            this.cbPublisher.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Publisher";
            // 
            // tTitle
            // 
            this.tTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tTitle.Location = new System.Drawing.Point(10, 91);
            this.tTitle.Name = "tTitle";
            this.tTitle.Size = new System.Drawing.Size(134, 26);
            this.tTitle.TabIndex = 2;
            this.tTitle.TextChanged += new System.EventHandler(this.tTitle_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Title";
            // 
            // tBookID
            // 
            this.tBookID.Enabled = false;
            this.tBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBookID.Location = new System.Drawing.Point(10, 39);
            this.tBookID.Name = "tBookID";
            this.tBookID.Size = new System.Drawing.Size(134, 26);
            this.tBookID.TabIndex = 1;
            // 
            // BooksData
            // 
            this.BooksData.AllowUserToAddRows = false;
            this.BooksData.AllowUserToDeleteRows = false;
            this.BooksData.AllowUserToResizeColumns = false;
            this.BooksData.AllowUserToResizeRows = false;
            this.BooksData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BooksData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Book_ID,
            this.Title,
            this.Publisher});
            this.BooksData.Location = new System.Drawing.Point(340, 108);
            this.BooksData.Name = "BooksData";
            this.BooksData.ReadOnly = true;
            this.BooksData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BooksData.Size = new System.Drawing.Size(712, 370);
            this.BooksData.TabIndex = 3;
            this.BooksData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BooksData_CellClick);
            // 
            // Book_ID
            // 
            this.Book_ID.HeaderText = "Book ID";
            this.Book_ID.Name = "Book_ID";
            this.Book_ID.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Publisher
            // 
            this.Publisher.HeaderText = "Publisher";
            this.Publisher.Name = "Publisher";
            this.Publisher.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bSearch);
            this.groupBox3.Controls.Add(this.cbSearch);
            this.groupBox3.Controls.Add(this.tSearch);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(340, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(712, 65);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search";
            // 
            // bSearch
            // 
            this.bSearch.Location = new System.Drawing.Point(634, 19);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(75, 40);
            this.bSearch.TabIndex = 14;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // cbSearch
            // 
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Location = new System.Drawing.Point(446, 31);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(183, 28);
            this.cbSearch.TabIndex = 13;
            // 
            // tSearch
            // 
            this.tSearch.Location = new System.Drawing.Point(6, 33);
            this.tSearch.Name = "tSearch";
            this.tSearch.Size = new System.Drawing.Size(434, 26);
            this.tSearch.TabIndex = 12;
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 515);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.BooksData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Name = "Books";
            this.Text = "Books";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Books_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksData)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bInsert;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbPublisher;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBookID;
        private System.Windows.Forms.Button bPicture;
        private System.Windows.Forms.DataGridView BooksData;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button bAddAuthor;
        private System.Windows.Forms.ComboBox cbAuthor;
        private System.Windows.Forms.ListBox lbAuthor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbBooked;
        private System.Windows.Forms.CheckBox cbBorrowed;
        private System.Windows.Forms.CheckBox cbCanBorrowed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.TextBox tSearch;
    }
}