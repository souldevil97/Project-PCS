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
    public partial class Login : Form
    {
        Form parent;
        OracleConnection connect;
        MenuStrip parentmenu;
        ToolStripMenuItem mastermenu,employeemenu;
        public Login(Form lastform,MenuStrip menu,ToolStripMenuItem menumaster,ToolStripMenuItem menuemployee)
        {
            InitializeComponent();
            parent = lastform;
            parentmenu = menu;
            mastermenu = menumaster;
            employeemenu = menuemployee;
            connect = Main_Menu.connect;
        }

        private String Status(int Value)
        {
            connect.Open();
            String status = "";
            OracleCommand cmd = new OracleCommand();
            if (Value == 0)
            {
                cmd.CommandText = "SELECT ID_PEGAWAI,PASSWORD_PEGAWAI,STATUS_AKTIF FROM PEGAWAI";
            }
            else
            {
                cmd.CommandText = "SELECT ID_PEGAWAI,PASSWORD_MEMBER,STATUS_AKTIF FROM MEMBER";
            }
            cmd.Connection = connect;
            OracleDataAdapter da = new OracleDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (tUsername.Text == ds.Tables[0].Rows[i][0].ToString())
                {
                    if (tPassword.Text == ds.Tables[0].Rows[i][1].ToString())
                    {
                        if (ds.Tables[0].Rows[i][2].ToString() == "1")
                        {
                            if (Value == 0)
                            {
                                status = "Pegawai";
                            }
                            else
                            {
                                status = "Member";
                            }
                        }
                        else
                        {
                            status = "ID sudah tidak aktif";
                        }
                    }
                    else
                    {
                        status = "Username / Password salah";
                    }
                }
            }
            connect.Close();
            return status;
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            parent.Close();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            if (tUsername.Text == "" || tPassword.Text == "")
            {
                MessageBox.Show("Make sure all fields are filled!");
            }
            else
            {
                connect.ConnectionString = "DATA SOURCE=;USER ID = PROYEKPCS;PASSWORD = pcs";
                try
                {
                    String status = "";
                    String Mbox = "";
                    for (int i = 0; i < 2; i++)
                    {
                        if (Status(i) == "Member")
                        {
                            status = "Member";
                            break;
                        }
                        else if (Status(i) == "Pegawai")
                        {
                            status = "Employee";
                            break;
                        }
                        else
                        {
                            Mbox = Status(i);
                        }
                    }
                    if (status == "")
                    {
                        MessageBox.Show(Mbox);
                    }
                    else
                    {
                        Main_Menu.Code = tUsername.Text;
                        Main_Menu.connect = connect;
                        Main_Menu.Status = status;
                        MessageBox.Show("Welcome, " + tUsername.Text + "!");
                        if (status == "Member")
                        {
                            parentmenu.Enabled = true;
                            employeemenu.Enabled = false;
                            mastermenu.Enabled = false;
                        }
                        else if (status == "Pegawai" || tUsername.Text == "admin")
                        {
                            parentmenu.Enabled = true;
                        }
                        else if (status == "Pegawai")
                        {
                            employeemenu.Enabled = false;
                            parentmenu.Enabled = true;
                        }
                        this.Close();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Wrong Username or Password!");
                }
                connect.Close();
            }
        }
    }
}
