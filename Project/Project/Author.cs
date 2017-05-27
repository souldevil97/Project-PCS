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
    public partial class Author : Form
    {
        Function func = new Function();
        OracleConnection connect;
        Form parent;
        public Author(Form lastform)
        {
            InitializeComponent();
            connect = Main_Menu.connect;
            parent = lastform;
        }

        void ShowData()
        {
            AuthorsData.Rows.Clear();
            DataTable dt = func.ShowAuthors(connect);
            foreach (DataRow item in dt.Rows)
            {
                AuthorsData.Rows.Add(item[0], item[1]);
            }
        }

        private void Author_Load(object sender, EventArgs e)
        {
            ShowData();
        }
    }
}
