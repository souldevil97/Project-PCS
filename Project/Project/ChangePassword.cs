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
    public partial class ChangePassword : Form
    {
        Function func = new Function();
        OracleConnection connect;
        public ChangePassword()
        {
            InitializeComponent();
            connect = Main_Menu.connect;
        }

        private void Btn_ChangePass_Click(object sender, EventArgs e)
        {
            if (tNewPassword.Text == tConfirmPassword.Text)
            {
                if (tOldPassword.Text == func.Password(connect, Main_Menu.Code,Main_Menu.Status))
                {
                    if (MessageBox.Show("Are You Sure?", "Change Password", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        try
                        {
                            connect.Open();
                            OracleCommand cmd = new OracleCommand();
                            if (Main_Menu.Status == "Employee")
                            {
                                cmd.CommandText = "UPDATE PEGAWAI SET PASSWORD_PEGAWAI = '" + tNewPassword.Text + "' WHERE ID_PEGAWAI = '" + Main_Menu.Code + "'";
                            }
                            else if (Main_Menu.Status == "Member")
                            {
                                cmd.CommandText = "UPDATE MEMBER SET PASSWORD_MEMBER = '" + tNewPassword.Text + "' WHERE ID_MEMBER = '" + Main_Menu.Code + "'";
                            }
                            cmd.Connection = connect;
                            cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        connect.Close();
                        this.Close();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Test");
                }
            }
            else
            {
                MessageBox.Show("");
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
