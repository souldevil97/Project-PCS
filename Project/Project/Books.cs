using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Oracle.DataAccess.Client;

namespace Project
{
    public partial class Books : Form
    {
        Function func = new Function();
        Form parent;
        OracleConnection connect;
        DataSet ds = new DataSet();
        OracleDataAdapter da;
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

        public Books(Form lastform)
        {
            InitializeComponent();
            parent = lastform;
            cbAuthor.Items.Clear();
            cbCategory.Items.Clear();
            cbPublisher.Items.Clear();
            this.connect = Main_Menu.connect;
            //Insert Publisher
            da = func.InsertPublisher(connect);
            da.Fill(ds, "Publisher");
            cbPublisher.DataSource = ds.Tables["Publisher"];
            cbPublisher.DisplayMember = "NAMA_PENERBIT";
            cbPublisher.ValueMember = "ID_PENERBIT";
            //End Insert Publisher
            //Insert Category
            da = func.InsertCategories(connect);
            da.Fill(ds, "Categories");
            cbCategory.DataSource = ds.Tables["Categories"];
            cbCategory.DisplayMember = "NAMA_KATEGORI";
            cbCategory.ValueMember = "ID_KATEGORI";
            //End Insert Category
            //Insert Author
            da = func.InsertAuthor(connect);
            da.Fill(ds, "Pengarang");
            cbAuthor.DataSource = ds.Tables["Pengarang"];
            cbAuthor.DisplayMember = "NAMA_PENGARANG";
            cbAuthor.ValueMember = "ID_PENGARANG";
            cbAuthor.SelectedIndex = 0;
            cbPublisher.SelectedIndex = 0;
            cbCategory.SelectedIndex = 0;
        }

        void ShowData()
        {
            BooksData.Rows.Clear();
            DataTable dt = func.ShowBooks(connect);
            foreach (DataRow item in dt.Rows)
            {
                BooksData.Rows.Add(item[0], item[1], item[2]);
            }
        }

        void ShowData(String ID)
        {
            BooksData.Rows.Clear();
            DataTable dt = func.ShowBooks(connect, ID, cbSearch.SelectedIndex);
            foreach (DataRow item in dt.Rows)
            {
                BooksData.Rows.Add(item[0], item[1], item[2]);
            }
        }

        private void Books_Load(object sender, EventArgs e)
        {
            ShowData();
            bInsert.Enabled = true;
            bUpdate.Enabled = false;
            bDelete.Enabled = false;
        }

        private void BooksData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbAuthor.Items.Clear();
            tTitle.Text = BooksData.Rows[e.RowIndex].Cells[1].Value.ToString();
            tBookID.Text = BooksData.Rows[e.RowIndex].Cells[0].Value.ToString();
            /*
            DataTable dt = func.ShowAuthor(connect,tBooksID.Text);
            foreach (DataRow item in dt.Rows)
            {
                lbAuthor.Items.Add(item[0]);
            }
             */
            cbPublisher.SelectedValue = func.GetPublisher(connect,tBookID.Text);
            cbCategory.SelectedValue = func.GetCategory(connect,tBookID.Text);
            Picture.Image = Image.FromStream(func.GetPicture(connect,tBookID.Text,"BUKU"));
            Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            cbCanBorrowed.Checked = func.GetCanBorrowed(connect, tBookID.Text);
            cbBooked.Checked = func.GetBooked(connect, tBookID.Text);
            cbBorrowed.Checked = func.GetBorrowed(connect, tBookID.Text);
            insert = false;
            bInsert.Enabled = false;
            bUpdate.Enabled = true;
            bDelete.Enabled = true;
        }

        private void bPicture_Click(object sender, EventArgs e)
        {
            getPictureAndConvert();
        }

        private void bInsert_Click(object sender, EventArgs e)
        {
            if (tTitle.Text == "")
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
                    cmd.CommandText = "INSERT INTO BUKU(ID_PENERBIT,JUDUL_BUKU,COVER_BUKU,TAHUN_TERBIT,ID_KATEGORI,BAWA_PULANG) VALUES (:PENERBIT,:JUDUL,:COVER,TO_DATE('" + dateTimePicker1.Value.Year.ToString() + "','YYYY'),:KATEGORI,:BAWAPULANG)";
                    cmd.Parameters.Add(":PENERBIT", cbPublisher.SelectedValue.ToString());
                    cmd.Parameters.Add(":JUDUL", tTitle.Text);
                    cmd.Parameters.Add(":COVER", cover_buku);
                    cmd.Parameters.Add(":KATEGORI", cbCategory.SelectedValue.ToString());
                    if (cbCanBorrowed.Checked == true)
                    {
                        cmd.Parameters.Add(":BAWA_PULANG", '1');
                    }
                    else
                    {
                        cmd.Parameters.Add(":BAWA_PULANG", '0');
                    }
                    cmd.ExecuteNonQuery();
                    ShowData();
                    MessageBox.Show("Data Inserted!");
                    tTitle.Text = "";
                    lbAuthor.Items.Clear();
                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.ToString());
                }
                connect.Close();
                ShowData();
                insert = true;
                bInsert.Enabled = true;
                bUpdate.Enabled = false;
                bDelete.Enabled = false;
            }
        }

        private void bAddAuthor_Click(object sender, EventArgs e)
        {
            Boolean add = true;
            MessageBox.Show(cbAuthor.Text);
            for (int i = 0; i < lbAuthor.Items.Count; i++)
            {
                if (lbAuthor.Items[i].ToString() == cbAuthor.Text)
                {
                    add = false;
                }
            }
            if (add)
            {
                lbAuthor.Items.Add(cbAuthor.Text);
            }
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            if (tTitle.Text == "")
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
                    cmd.CommandText = "UPDATE BUKU SET ID_PENERBIT = :PENERBIT, JUDUL_BUKU = :JUDUL,COVER_BUKU = :COVER ,TAHUN_TERBIT = TO_DATE('" + dateTimePicker1.Value.Year.ToString() + "','YYYY'),ID_KATEGORI = :KATEGORI, BAWA_PULANG = :BAWA_PULANG WHERE ID_BUKU ='" + tBookID.Text + "'";
                    cmd.Parameters.Add(":PENERBIT", cbPublisher.SelectedValue.ToString());
                    cmd.Parameters.Add(":JUDUL", tTitle.Text);
                    cmd.Parameters.Add(":COVER", cover_buku);
                    cmd.Parameters.Add(":KATEGORI", cbCategory.SelectedValue.ToString());
                    if (cbCanBorrowed.Checked == true)
                    {
                        cmd.Parameters.Add(":BAWA_PULANG", '1');
                    }
                    else
                    {
                        cmd.Parameters.Add(":BAWA_PULANG", '0');
                    }
                    cmd.ExecuteNonQuery();
                    ShowData();
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
                cmd.CommandText = "UPDATE BUKU STATUS_BUKU = '0' WHERE ID_BUKU ='" + tBookID.Text + "'";
                cmd.ExecuteNonQuery();
                ShowData();
                MessageBox.Show("Data Deleted!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            connect.Close();
            ShowData();
            insert = true;
            bInsert.Enabled = true;
            bUpdate.Enabled = false;
            bDelete.Enabled = false;
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            ShowData(tSearch.Text);
        }

        private void tTitle_TextChanged(object sender, EventArgs e)
        {
            if (insert)
            {
                tBookID.Text = func.CodeBook(connect);
            }
        }
    }
}