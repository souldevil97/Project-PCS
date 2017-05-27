using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace Project
{
    public partial class Main_Menu : Form
    {
        public static String Code;
        public static String Status;
        public static OracleConnection connect = new OracleConnection();
        
        public Main_Menu()
        {
            InitializeComponent();
        }
        private void Main_Menu_Load(object sender, EventArgs e)
        {
            menuStrip1.Enabled = false;
            Login form = new Login(this,menuStrip1,MasterMenuItem,EmployeeMenuItem);
            form.MdiParent = this;
            form.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connect.Close();
            menuStrip1.Enabled = false;
            Login form = new Login(this, menuStrip1, MasterMenuItem, EmployeeMenuItem);
            form.MdiParent = this;
            form.Show();
        }

        private void BooksMenuItem_Click(object sender, EventArgs e)
        {
            Books form = new Books(this);
            form.MdiParent = this;
            form.Show();
        }

        private void EmployeeMenuItem_Click(object sender, EventArgs e)
        {
            Employee form = new Employee(this);
            form.MdiParent = this;
            form.Show();
        }

        private void PublisherMenuItem_Click(object sender, EventArgs e)
        {
            Publisher form = new Publisher(this);
            form.MdiParent = this;
            form.Show();
        }

        private void MemberMenuItem_Click(object sender, EventArgs e)
        {
            Member form = new Member(this);
            form.MdiParent = this;
            form.Show();
        }

        private void AuthorMenuItem_Click(object sender, EventArgs e)
        {
            Author form = new Author(this);
            form.MdiParent = this;
            form.Show();
        }

        private void ChangePasswordMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword form = new ChangePassword();
            form.MdiParent = this;
            form.Show();
        }
    }
}
