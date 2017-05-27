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
    public partial class Member : Form
    {
        Function func = new Function();
        Form parent;
        OracleConnection connect;
        Boolean insert;
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
        public Member(Form lastform)
        {
            InitializeComponent();
            connect = Main_Menu.connect;
            parent = lastform;
        }

        void ShowData()
        {
            MembersData.Rows.Clear();
            DataTable dt = func.ShowMembers(connect);
            foreach (DataRow item in dt.Rows)
            {
                MembersData.Rows.Add(item[0], item[1], item[2], item[3], item[4], item[5], item[6], item[7], item[8]);
            }
        }

        private void Member_Load(object sender, EventArgs e)
        {
            ShowData();
            bInsert.Enabled = true;
            bUpdate.Enabled = false;
            bDelete.Enabled = false;
            cbMember.SelectedIndex = 0;
        }

        private void tPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
        private void MembersData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            insert = false;
            dtBirthDate.Value = Convert.ToDateTime(MembersData.Rows[e.RowIndex].Cells[4].Value.ToString());
            tName.Text = MembersData.Rows[e.RowIndex].Cells[1].Value.ToString();
            tMemberID.Text = MembersData.Rows[e.RowIndex].Cells[0].Value.ToString();
            tAddress.Text = MembersData.Rows[e.RowIndex].Cells[2].Value.ToString();
            tPhoneNumber.Text =  MembersData.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbMember.SelectedItem = MembersData.Rows[e.RowIndex].Cells[5].Value.ToString();
            Boolean status = false;
            if (MembersData.Rows[e.RowIndex].Cells[6].Value.ToString() == "Male") { rbMale.Checked = true; }
            else { rbFemale.Checked = true; }
            if (MembersData.Rows[e.RowIndex].Cells[8].Value.ToString() == "Active") { status = true; }
            cbActive.Checked = status;
            Picture.Image = Image.FromStream(func.GetPicture(connect, MembersData.Rows[e.RowIndex].Cells[0].Value.ToString(),"MEMBER"));
            Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            bInsert.Enabled = false;
            bUpdate.Enabled = true;
            bDelete.Enabled = true;
        }

        private void tName_TextChanged(object sender, EventArgs e)
        {
            if (insert)
            {
                if (tName.Text.Length >= 2)
                {
                    if (tName.Text.IndexOf(" ") == -1)
                    {
                        tMemberID.Text = func.CodeMember(connect, tName.Text);
                    }
                    else
                    {
                        if (tName.Text.Length > tName.Text.IndexOf(" ") + 1)
                        {
                            tMemberID.Text = func.CodeMember(connect, tName.Text);
                        }
                    }
                }
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
                String tanggal = dtBirthDate.Value.Day.ToString() + "-" + dtBirthDate.Value.Month.ToString() + "-" + dtBirthDate.Value.Year.ToString();
                try
                {
                    connect.Open();
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = connect;
                    cmd.CommandText = "INSERT INTO MEMBER(NAMA_MEMBER,FOTO_MEMBER,ALAMAT_MEMBER,TELP_MEMBER,TTL_MEMBER,JENIS_MEMBER,JK_MEMBER) VALUES (:NAMA,:PHOTO,:Alamat,:TELP,TO_DATE('" + tanggal + "','DD-MM-YYYY'),:JENIS,:JK)";
                    cmd.Parameters.Add(":NAMA", tName.Text);
                    cmd.Parameters.Add(":PHOTO", cover_buku);
                    cmd.Parameters.Add(":ALAMAT", tAddress.Text);
                    cmd.Parameters.Add(":TELP", tPhoneNumber.Text);
                    cmd.Parameters.Add(":JENIS", cbMember.SelectedItem);
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
                    tMemberID.Text = "";
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

        private void bPicture_Click(object sender, EventArgs e)
        {
            getPictureAndConvert();
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
                    cmd.CommandText = "UPDATE PEGAWAI SET NAMA_MEMBER = :NAMA, FOTO_MEMBER = :PHOTO, ALAMAT_MEMBER = :Alamat,TELP_MEMBER = :TELP,TTL_MEMBER = TO_DATE('" + tanggal + "','DD-MM-YYYY'),JK_MEMBER = :JK,JENIS_MEMBER = :JENIS WHERE ID_MEMBER = '" + tMemberID.Text + "'";
                    cmd.Parameters.Add(":NAMA", tName.Text);
                    cmd.Parameters.Add(":PHOTO", cover_buku);
                    cmd.Parameters.Add(":ALAMAT", tAddress.Text);
                    cmd.Parameters.Add(":TELP", tPhoneNumber.Text);
                    cmd.Parameters.Add(":JENIS", cbMember.SelectedItem);
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
                    tMemberID.Text = "";
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

        }
    }
}
