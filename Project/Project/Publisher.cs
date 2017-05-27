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
    public partial class Publisher : Form
    {
        Function func = new Function();
        Form parent;
        OracleConnection connect;
        Boolean insert = true;
        public Publisher(Form lastform)
        {
            InitializeComponent();
            parent = lastform;
            connect = Main_Menu.connect;
        }

        void ShowData()
        {
            PublishersData.Rows.Clear();
            DataTable dt = func.ShowPublishers(connect);
            foreach (DataRow item in dt.Rows)
            {
                PublishersData.Rows.Add(item[0], item[1], item[2], item[3], item[4]);
            }
        }

        private void Publisher_Load(object sender, EventArgs e)
        {
            ShowData();
            bInsert.Enabled = true;
            bUpdate.Enabled = false;
            bDelete.Enabled = false;
        }

        private void PublishersData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            insert = false;
            tName.Text = PublishersData.Rows[e.RowIndex].Cells[1].Value.ToString();
            tPublisherID.Text = PublishersData.Rows[e.RowIndex].Cells[0].Value.ToString();
            tAddress.Text = PublishersData.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbCity.SelectedItem = PublishersData.Rows[e.RowIndex].Cells[3].Value.ToString();
            tPhoneNumber.Text = PublishersData.Rows[e.RowIndex].Cells[4].Value.ToString();
            bInsert.Enabled = false;
            bUpdate.Enabled = true;
            bDelete.Enabled = true;
        }

        private void tPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bInsert_Click(object sender, EventArgs e)
        {
            if (tName.Text == "" || tAddress.Text == "" || tPhoneNumber.Text == "")
            {
                MessageBox.Show("Make sure all fields are filled!");
            }
            else
            {
                try
                {
                    connect.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = connect;
                    cmd.CommandText = "INSERT INTO PENERBIT(NAMA_PENERBIT,ALAMAT_PENERBIT,KOTA_PENERBIT,TELP_PENERBIT) VALUES (:NAMA,:ALAMAT,:JKOTA,:TELP)";
                    cmd.Parameters.Add(":NAMA", tName.Text);
                    cmd.Parameters.Add(":ALAMAT", tAddress.Text);
                    cmd.Parameters.Add(":KOTA", cbCity.SelectedItem);
                    cmd.Parameters.Add(":TELP", tPhoneNumber.Text);
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    ShowData();
                    tPublisherID.Text = "";
                    tName.Text = "";
                    tAddress.Text = "";
                    tPhoneNumber.Text = "";
                    MessageBox.Show("Data Inserted!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                connect.Close();
                insert = false;
                bInsert.Enabled = true;
                bUpdate.Enabled = false;
                bDelete.Enabled = false;
            }
        }

        private void tName_TextChanged(object sender, EventArgs e)
        {
            if (insert)
            {
                tPublisherID.Text = func.CodePublisher(connect);
            }
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            if (tName.Text == "" || tAddress.Text == "" || tPhoneNumber.Text == "")
            {
                MessageBox.Show("Make sure all fields are filled!");
            }
            else
            {
                try
                {
                    connect.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = connect;
                    cmd.CommandText = "UPDATE PENERBIT SET NAMA_PENERBIT = :NAMA, ALAMAT_PENERBIT = :ALAMAT, KOTA_PENERBIT = :KOTA, TELP_PENERBIT = :TELP WHERE ID_PENERBIT = '" + tPublisherID.Text + "'";
                    cmd.Parameters.Add(":NAMA", tName.Text);
                    cmd.Parameters.Add(":ALAMAT", tAddress.Text);
                    cmd.Parameters.Add(":KOTA", cbCity.SelectedItem);
                    cmd.Parameters.Add(":TELP", tPhoneNumber.Text);
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    ShowData();
                    tPublisherID.Text = "";
                    tName.Text = "";
                    tAddress.Text = "";
                    tPhoneNumber.Text = "";
                    MessageBox.Show("Data Updated!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                connect.Close();
                insert = false;
                bInsert.Enabled = true;
                bUpdate.Enabled = false;
                bDelete.Enabled = false;
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            
        }
    }
}
