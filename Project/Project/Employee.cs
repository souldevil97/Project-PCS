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
using System.IO;

namespace Project
{
    public partial class Employee : Form
    {
        Function func = new Function();
        Form parent;
        OracleConnection connect;
        Boolean insert = true;
        //--Gambar--
        FileStream fs;
        String File_name_gambar = "";
        byte[] cover_buku;
        //--End--

        public void getPictureAndConvert()
        {
            getPictureFromFile();
            cover_buku = getDataImage();
        }

        //untuk mengubah gambar menjadi tipe data blob, jadi nanti tinggal insertin rawData ke database
        public byte[] getDataImage()
        {
            byte[] rawData = new byte[fs.Length];
            fs.Read(rawData, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return rawData;
        }

        //Untuk Mengambil gambar dari file
        public void getPictureFromFile()
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg;*.jpeg;*.gif;*.bmp)|*.jpg;*.jpeg;*.gif;*.bmp";
                File_name_gambar = open.FileName;

                if (open.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bit = new Bitmap(open.FileName);
                    Picture.Image = bit;
                    Picture.SizeMode = PictureBoxSizeMode.StretchImage;
                    fs = new FileStream(open.FileName, FileMode.OpenOrCreate, FileAccess.Read);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public Employee(Form lastform)
        {
            InitializeComponent();
            connect = Main_Menu.connect;
            parent = lastform;
        }

        //Insert data ke dgv
        void ShowData()
        {
            EmployeesData.Rows.Clear();
            DataTable dt = func.ShowEmployees(connect);
            foreach (DataRow item in dt.Rows)
            {
                EmployeesData.Rows.Add(item[0], item[1], item[2], item[3], item[4], item[5], item[6]);
            }
        }

        void ShowData(String ID)
        {
            EmployeesData.Rows.Clear();
            DataTable dt = func.ShowEmployees(connect);
            foreach (DataRow item in dt.Rows)
            {
                EmployeesData.Rows.Add(item[0], item[1], item[2], item[3], item[4], item[5], item[6]);
            }
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            ShowData();
            bInsert.Enabled = true;
            bUpdate.Enabled = false;
            bDelete.Enabled = false;
        }

        private void tPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bPicture_Click(object sender, EventArgs e)
        {
            getPictureAndConvert();
        }

        private void EmployeesData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            insert = false;
            dtBirthDate.Value = Convert.ToDateTime(EmployeesData.Rows[e.RowIndex].Cells[4].Value.ToString());
            tName.Text = EmployeesData.Rows[e.RowIndex].Cells[1].Value.ToString();
            tEmployeeID.Text = EmployeesData.Rows[e.RowIndex].Cells[0].Value.ToString();
            tAddress.Text = EmployeesData.Rows[e.RowIndex].Cells[2].Value.ToString();
            tPhoneNumber.Text = EmployeesData.Rows[e.RowIndex].Cells[3].Value.ToString();
            if(EmployeesData.Rows[e.RowIndex].Cells[5].Value.ToString() == "Male"){ rbMale.Checked = true; }
            else{ rbFemale.Checked = true; }
            if (EmployeesData.Rows[e.RowIndex].Cells[6].Value.ToString() == "Active") { cbActive.Checked = true; }
            else { cbActive.Checked = false; }
            Picture.Image = Image.FromStream(func.GetPicture(connect, EmployeesData.Rows[e.RowIndex].Cells[0].Value.ToString(),"PEGAWAI"));
            Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            bInsert.Enabled = false;
            bUpdate.Enabled = true;
            bDelete.Enabled = true;
        }

        private void bInsert_Click(object sender, EventArgs e)
        {
            if (tName.Text == "" || tAddress.Text == "" || tPhoneNumber.Text == "")
            {
                MessageBox.Show("Make sure all fields are filled!");
            }
            else
            {
                String tanggal = dtBirthDate.Value.Day.ToString() + "-" + dtBirthDate.Value.Month.ToString() + "-" + dtBirthDate.Value.Year.ToString();
                try
                {
                    connect.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = connect;
                    cmd.CommandText = "INSERT INTO PEGAWAI(NAMA_PEGAWAI,FOTO_PEGAWAI,ALAMAT_PEGAWAI,TELP_PEGAWAI,TTL_PEGAWAI,JK_PEGAWAI) VALUES (:NAMA,:PHOTO,:Alamat,:TELP,TO_DATE('" + tanggal + "','DD-MM-YYYY'),:JK)";
                    cmd.Parameters.Add(":NAMA", tName.Text);
                    cmd.Parameters.Add(":PHOTO", cover_buku);
                    cmd.Parameters.Add(":ALAMAT", tAddress.Text);
                    cmd.Parameters.Add(":TELP", tPhoneNumber.Text);
                    if (rbMale.Checked == true)
                    {
                        cmd.Parameters.Add(":JK", 'L');
                    }
                    else
                    {
                        cmd.Parameters.Add(":JK", 'P');
                    }
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    ShowData();
                    tEmployeeID.Text = "";
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
                insert = true;
                bInsert.Enabled = true;
                bUpdate.Enabled = false;
                bDelete.Enabled = false;
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
                String tanggal = dtBirthDate.Value.Day.ToString() + "-" + dtBirthDate.Value.Month.ToString() + "-" + dtBirthDate.Value.Year.ToString();
                try
                {
                    connect.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = connect;
                    cmd.CommandText = "UPDATE PEGAWAI SET NAMA_PEGAWAI = :NAMA, FOTO_PEGAWAI = :PHOTO, ALAMAT_PEGAWAI = :Alamat,TELP_PEGAWAI = :TELP,TTL_PEGAWAI = TO_DATE('" + tanggal + "','DD-MM-YYYY'),JK_PEGAWAI = :JK WHERE ID_PEGAWAI = '" + tEmployeeID.Text + "'";
                    cmd.Parameters.Add(":NAMA", tName.Text);
                    cmd.Parameters.Add(":PHOTO", cover_buku);
                    cmd.Parameters.Add(":ALAMAT", tAddress.Text);
                    cmd.Parameters.Add(":TELP", tPhoneNumber.Text);
                    if (rbMale.Checked == true)
                    {
                        cmd.Parameters.Add(":JK", 'L');
                    }
                    else
                    {
                        cmd.Parameters.Add(":JK", 'P');
                    }
                    cmd.ExecuteNonQuery();
                    connect.Close();
                    ShowData();
                    tEmployeeID.Text = "";
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
                insert = true;
                bInsert.Enabled = true;
                bUpdate.Enabled = false;
                bDelete.Enabled = false;
            }
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = connect;
                cmd.CommandText = "UPDATE PEGAWAI SET STATUS_AKTIF = '0' WHERE ID_PEGAWAI = '"+tEmployeeID.Text+"'";
                cmd.Parameters.Add(":NAMA", tName.Text);
                cmd.Parameters.Add(":PHOTO", cover_buku);
                cmd.Parameters.Add(":ALAMAT", tAddress.Text);
                cmd.Parameters.Add(":TELP", tPhoneNumber.Text);
                if (rbMale.Checked == true)
                {
                    cmd.Parameters.Add(":JK", 'L');
                }
                else
                {
                    cmd.Parameters.Add(":JK", 'P');
                }
                cmd.ExecuteNonQuery();
                connect.Close();
                ShowData();
                tEmployeeID.Text = "";
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
            insert = true;
            bInsert.Enabled = true;
            bUpdate.Enabled = false;
            bDelete.Enabled = false;
        }

        private void tName_TextChanged(object sender, EventArgs e)
        {
            if (insert)
            {
                if (tName.Text.Length >= 2)
                {
                    if (tName.Text.IndexOf(" ") == -1)
                    {
                        tEmployeeID.Text = func.CodeEmployee(connect, tName.Text);
                    }
                    else
                    {
                        if (tName.Text.Length > tName.Text.IndexOf(" ") + 1)
                        {
                            tEmployeeID.Text = func.CodeEmployee(connect, tName.Text);
                        }
                    }
                }
            }
        }
    }
}
