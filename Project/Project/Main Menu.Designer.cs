namespace Project
{
    partial class Main_Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SystemMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangePasswordMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MasterMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PublisherMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AuthorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BooksMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmployeeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MemberMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransactionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportMenuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SystemMenuItem,
            this.MasterMenuItem,
            this.TransactionMenuItem,
            this.ReportMenuitem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1043, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SystemMenuItem
            // 
            this.SystemMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangePasswordMenuItem,
            this.ExitMenuItem});
            this.SystemMenuItem.Name = "SystemMenuItem";
            this.SystemMenuItem.Size = new System.Drawing.Size(57, 20);
            this.SystemMenuItem.Text = "System";
            // 
            // ChangePasswordMenuItem
            // 
            this.ChangePasswordMenuItem.Name = "ChangePasswordMenuItem";
            this.ChangePasswordMenuItem.Size = new System.Drawing.Size(168, 22);
            this.ChangePasswordMenuItem.Text = "Change Password";
            this.ChangePasswordMenuItem.Click += new System.EventHandler(this.ChangePasswordMenuItem_Click);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(168, 22);
            this.ExitMenuItem.Text = "Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MasterMenuItem
            // 
            this.MasterMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PublisherMenuItem,
            this.AuthorMenuItem,
            this.BooksMenuItem,
            this.EmployeeMenuItem,
            this.MemberMenuItem});
            this.MasterMenuItem.Name = "MasterMenuItem";
            this.MasterMenuItem.Size = new System.Drawing.Size(55, 20);
            this.MasterMenuItem.Text = "Master";
            // 
            // PublisherMenuItem
            // 
            this.PublisherMenuItem.Name = "PublisherMenuItem";
            this.PublisherMenuItem.Size = new System.Drawing.Size(152, 22);
            this.PublisherMenuItem.Text = "Publisher";
            this.PublisherMenuItem.Click += new System.EventHandler(this.PublisherMenuItem_Click);
            // 
            // AuthorMenuItem
            // 
            this.AuthorMenuItem.Name = "AuthorMenuItem";
            this.AuthorMenuItem.Size = new System.Drawing.Size(152, 22);
            this.AuthorMenuItem.Text = "Author";
            this.AuthorMenuItem.Click += new System.EventHandler(this.AuthorMenuItem_Click);
            // 
            // BooksMenuItem
            // 
            this.BooksMenuItem.Name = "BooksMenuItem";
            this.BooksMenuItem.Size = new System.Drawing.Size(152, 22);
            this.BooksMenuItem.Text = "Books";
            this.BooksMenuItem.Click += new System.EventHandler(this.BooksMenuItem_Click);
            // 
            // EmployeeMenuItem
            // 
            this.EmployeeMenuItem.Name = "EmployeeMenuItem";
            this.EmployeeMenuItem.Size = new System.Drawing.Size(152, 22);
            this.EmployeeMenuItem.Text = "Employee";
            this.EmployeeMenuItem.Click += new System.EventHandler(this.EmployeeMenuItem_Click);
            // 
            // MemberMenuItem
            // 
            this.MemberMenuItem.Name = "MemberMenuItem";
            this.MemberMenuItem.Size = new System.Drawing.Size(152, 22);
            this.MemberMenuItem.Text = "Member";
            this.MemberMenuItem.Click += new System.EventHandler(this.MemberMenuItem_Click);
            // 
            // TransactionMenuItem
            // 
            this.TransactionMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookingToolStripMenuItem});
            this.TransactionMenuItem.Name = "TransactionMenuItem";
            this.TransactionMenuItem.Size = new System.Drawing.Size(80, 20);
            this.TransactionMenuItem.Text = "Transaction";
            // 
            // bookingToolStripMenuItem
            // 
            this.bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            this.bookingToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.bookingToolStripMenuItem.Text = "Booking";
            // 
            // ReportMenuitem
            // 
            this.ReportMenuitem.Name = "ReportMenuitem";
            this.ReportMenuitem.Size = new System.Drawing.Size(54, 20);
            this.ReportMenuitem.Text = "Report";
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 459);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Menu";
            this.Text = "Main Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SystemMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangePasswordMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MasterMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TransactionMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PublisherMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AuthorMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BooksMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EmployeeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MemberMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReportMenuitem;
    }
}