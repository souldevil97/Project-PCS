using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.IO;

namespace Project
{
    class Function
    {
        OracleCommand cmd;
        OracleDataAdapter da;
       
        //View table buku
        public DataTable ShowBooks(OracleConnection connect)
        {
            connect.Open();
            cmd = new OracleCommand();
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT B.ID_BUKU, SUBSTR(B.JUDUL_BUKU,0,20), P.NAMA_PENERBIT FROM BUKU B,PENERBIT P WHERE B.ID_PENERBIT = P.ID_PENERBIT AND STATUS_BUKU = '1'";
            cmd.Connection = connect;
            OracleDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            dr.Close();
            connect.Close();
            return dt;
        }

        //search view table buku
        public DataTable ShowBooks(OracleConnection connect, String ID,int Value)
        {
            connect.Open();
            cmd = new OracleCommand();
            DataTable dt = new DataTable();
            if (Value == 0) { cmd.CommandText = "SELECT B.ID_BUKU, SUBSTR(B.JUDUL_BUKU,0,20), P.NAMA_PENERBIT FROM BUKU B,PENERBIT P WHERE B.ID_PENERBIT = P.ID_PENERBIT AND STATUS_BUKU = '1' AND JUDUL_BUKU LIKE '%" + ID + "%'"; }
            cmd.Connection = connect;
            OracleDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            dr.Close();
            connect.Close();
            return dt;
        }

        //View table pegawai
        public DataTable ShowEmployees(OracleConnection connect)
        {
            connect.Open();
            cmd = new OracleCommand();
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT ID_PEGAWAI, NAMA_PEGAWAI, ALAMAT_PEGAWAI, TELP_PEGAWAI, TO_CHAR(TTL_PEGAWAI,'DD-MM-YYYY'), CASE JK_PEGAWAI WHEN 'L' THEN 'Male' WHEN 'P' THEN 'FEMALE' END, CASE STATUS_AKTIF WHEN '1' THEN 'Active' WHEN '0' THEN 'Not Active' END FROM PEGAWAI WHERE ID_PEGAWAI != 'admin'";
            cmd.Connection = connect;
            OracleDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            dr.Close();
            connect.Close();
            return dt;
        }

        //Search view table pegawai
        public DataTable ShowEmployees(OracleConnection connect, String ID, int Value)
        {
            connect.Open();
            cmd = new OracleCommand();
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT ID_PEGAWAI, NAMA_PEGAWAI, ALAMAT_PEGAWAI, TELP_PEGAWAI, TO_CHAR(TTL_PEGAWAI,'DD-MM-YYYY'), CASE JK_PEGAWAI WHEN 'L' THEN 'Male' WHEN 'P' THEN 'FEMALE' END, CASE STATUS_AKTIF WHEN '1' THEN 'Active' WHEN '0' THEN 'Not Active' END FROM PEGAWAI WHERE ID_PEGAWAI NOTLIKE 'admin'";
            cmd.Connection = connect;
            OracleDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            dr.Close();
            connect.Close();
            return dt;
        }

        //View table member
        public DataTable ShowMembers(OracleConnection connect)
        {
            connect.Open();
            cmd = new OracleCommand();
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT ID_MEMBER, NAMA_MEMBER, ALAMAT_MEMBER, TELP_MEMBER, TO_CHAR(TTL_MEMBER,'DD-MM-YYYY'),JENIS_MEMBER, CASE JK_MEMBER WHEN 'L' THEN 'Male' WHEN 'P' THEN 'Female' END,TO_CHAR(TGL_EXP,'DD-MM-YYYY'), CASE STATUS_AKTIF WHEN '1' THEN 'Active' WHEN '0' THEN 'Not Active' END FROM MEMBER";
            cmd.Connection = connect;
            OracleDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            dr.Close();
            connect.Close();
            return dt;
        }

        public DataTable ShowMembers(OracleConnection connect,String ID,int Value)
        {
            connect.Open();
            cmd = new OracleCommand();
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT ID_MEMBER, NAMA_MEMBER, ALAMAT_MEMBER, TELP_MEMBER, TO_CHAR(TTL_MEMBER,'DD-MM-YYYY'),JENIS_MEMBER, CASE JK_MEMBER WHEN 'L' THEN 'Male' WHEN 'P' THEN 'Female' END,TO_CHAR(TGL_EXP,'DD-MM-YYYY'), CASE STATUS_AKTIF WHEN '1' THEN 'Active' WHEN '0' THEN 'Not Active' END FROM MEMBER WHERE ID_MEMBER ='" + ID + "'";
            cmd.Connection = connect;
            OracleDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            dr.Close();
            connect.Close();
            return dt;
        }

        //View table penerbit
        public DataTable ShowPublishers(OracleConnection connect)
        {
            connect.Open();
            cmd = new OracleCommand();
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT ID_PENERBIT, NAMA_PENERBIT, ALAMAT_PENERBIT, KOTA_PENERBIT, TELP_PENERBIT FROM PENERBIT";
            cmd.Connection = connect;
            OracleDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            dr.Close();
            connect.Close();
            return dt;
        }

        //View table pengarang
        public DataTable ShowAuthors(OracleConnection connect)
        {
            connect.Open();
            cmd = new OracleCommand();
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT ID_PENGARANG, NAMA_PENGARANG FROM PENGARANG";
            cmd.Connection = connect;
            OracleDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            dr.Close();
            connect.Close();
            return dt;
        }

        //input cbpenerbit
        public OracleDataAdapter InsertPublisher(OracleConnection connect)
        {
            connect.Open();
            da = new OracleDataAdapter("SELECT * FROM PENERBIT", connect);
            connect.Close();
            return da;
        }

        //input cbkategori
        public OracleDataAdapter InsertCategories(OracleConnection connect)
        {
            connect.Open();
            da = new OracleDataAdapter("SELECT * FROM KATEGORI", connect);
            connect.Close();
            return da;
        }

        //input cbpegnarang
        public OracleDataAdapter InsertAuthor(OracleConnection connect)
        {
            connect.Open();
            da = new OracleDataAdapter("SELECT * FROM PENGARANG", connect);
            connect.Close();
            return da;
        }

        //ambil id penerbit
        public String GetPublisher(OracleConnection connect, String ID)
        {
            connect.Open();
            cmd = new OracleCommand();
            cmd.CommandText = "SELECT ID_PENERBIT FROM BUKU WHERE ID_BUKU = '" + ID + "'";
            cmd.Connection = connect;
            String hasil = cmd.ExecuteScalar().ToString();
            connect.Close();
            return hasil;
        }

        public Boolean GetBooked(OracleConnection connect, String ID)
        {
            connect.Open();
            Boolean hasil = false ;
            cmd = new OracleCommand();
            cmd.CommandText = "SELECT DIBOOKING FROM BUKU WHERE ID_BUKU = '" + ID + "'";
            cmd.Connection = connect;
            if (cmd.ExecuteScalar().ToString() == "1")
            {
                hasil = true;
            }
            connect.Close();
            return hasil;
        }

        public Boolean GetBorrowed(OracleConnection connect, String ID)
        {
            connect.Open();
            Boolean hasil = false;
            cmd = new OracleCommand();
            cmd.CommandText = "SELECT DIPINJAM FROM BUKU WHERE ID_BUKU = '" + ID + "'";
            cmd.Connection = connect;
            if (cmd.ExecuteScalar().ToString() == "1")
            {
                hasil = true;
            }
            connect.Close();
            return hasil;
        }

        public Boolean GetCanBorrowed(OracleConnection connect, String ID)
        {
            connect.Open();
            Boolean hasil = false;
            cmd = new OracleCommand();
            cmd.CommandText = "SELECT BAWA_PULANG FROM BUKU WHERE ID_BUKU = '" + ID + "'";
            cmd.Connection = connect;
            if (cmd.ExecuteScalar().ToString() == "1")
            {
                hasil = true;
            }
            connect.Close();
            return hasil;
        }
        
        //ambil id kategori
        public String GetCategory(OracleConnection connect, String ID)
        {
            connect.Open();
            cmd = new OracleCommand();
            cmd.CommandText = "SELECT ID_KATEGORI FROM BUKU WHERE ID_BUKU = '" + ID + "'";
            cmd.Connection = connect;
            String hasil = cmd.ExecuteScalar().ToString();
            connect.Close();
            return hasil;
        }

        //ambil nama pengarang masuk ke listbox
        public DataTable ShowAuthor(OracleConnection connect, String ID)
        {
            connect.Open();
            cmd = new OracleCommand();
            DataTable dt = new DataTable();
            cmd.CommandText = "SELECT P.NAMA_PENGARANG FROM BUKU_PENGARANG BP, PENGARANG P WHERE P.ID_PENGARANG = BP.ID_PENGARANG AND P.ID_BUKU = '" + ID + "'";
            cmd.Connection = connect;
            OracleDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            dr.Close();
            connect.Close();
            return dt;
        }

        //cek password dalam database
        public String Password(OracleConnection connect, String ID, String Status)
        {
            String hasil = "";
            try
            {
                connect.Open();
                cmd = new OracleCommand();
                if (Status == "Member")
                {
                    cmd.CommandText = "SELECT PASSWORD_MEMBER FROM MEMBER WHERE ID_MEMBER = '" + ID + "'";
                }
                else if (Status == "Employee")
                {
                    cmd.CommandText = "SELECT PASSWORD_PEGAWAI FROM PEGAWAI WHERE ID_PEGAWAI = '" + ID + "'";
                }
                cmd.Connection = connect;
                hasil = cmd.ExecuteScalar().ToString();
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Wrong Username or Password!");
            }
            connect.Close();
            return hasil;
        }

        //convert ganbar dari blob
        public MemoryStream GetPicture(OracleConnection connect, String ID, String value)
        {
            connect.Open();
            if (value == "BUKU")
            {
                da = new OracleDataAdapter("SELECT * FROM BUKU WHERE ID_BUKU = '" + ID + "'",connect);
            }
            else if (value == "PEGAWAI")
            {
                da = new OracleDataAdapter("SELECT * FROM PEGAWAI WHERE ID_PEGAWAI = '" + ID + "'",connect);
            }
            else if (value == "MEMBER")
            {
                da = new OracleDataAdapter("SELECT * FROM MEMBER WHERE ID_MEMBER = '" + ID + "'",connect);
            }
            DataSet dataset = new DataSet();
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            //Fill the data adapter
            da.Fill(dataset);
            //Get the first row of the table
            DataRow row = dataset.Tables[0].Rows[0];
            //Read data in a stream
            byte[] rawData = new byte[0];
            if (value == "BUKU")
            {
                rawData = (byte[])row["COVER_BUKU"];
            }
            else if (value == "PEGAWAI")
            {
                rawData = (byte[])row["FOTO_PEGAWAI"];
            }
            else if (value == "MEMBER")
            {
                rawData = (byte[])row["FOTO_MEMBER"];
            }
            int len = new int();
            len = rawData.GetUpperBound(0);
            //Open rawData with pictureBox
            MemoryStream stmBLOBData = new MemoryStream(rawData);
            connect.Close();
            return stmBLOBData;
        }
        //generate kode pegawai
        public String CodeEmployee(OracleConnection connect,String Code)
        {
            connect.Open();
            cmd = new OracleCommand();
            cmd.Connection = connect;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GENERATEKODEPEGAWAI";

            OracleParameter pRetVal = new OracleParameter();
            pRetVal.ParameterName = "return";
            pRetVal.OracleDbType = OracleDbType.Varchar2;
            pRetVal.Size = 6;
            pRetVal.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(pRetVal);

            OracleParameter pNama = new OracleParameter();
            pNama.ParameterName = "NAMA"; 
            pNama.OracleDbType = OracleDbType.Varchar2;
            pNama.Direction = ParameterDirection.Input;
            pNama.Value = Code;
            cmd.Parameters.Add(pNama);

            cmd.ExecuteNonQuery();
            String hasil = pRetVal.Value.ToString();
            connect.Close();
            return hasil;
        }

        //generate kode member
        public String CodeMember(OracleConnection connect, String Code)
        {
            connect.Open();
            cmd = new OracleCommand();
            cmd.Connection = connect;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GENERATEKODEMEMBER";

            OracleParameter pRetVal = new OracleParameter();
            pRetVal.ParameterName = "return";
            pRetVal.OracleDbType = OracleDbType.Varchar2;
            pRetVal.Size = 6;
            pRetVal.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(pRetVal);

            OracleParameter pNama = new OracleParameter();
            pNama.ParameterName = "NAMA";
            pNama.OracleDbType = OracleDbType.Varchar2;
            pNama.Direction = ParameterDirection.Input;
            pNama.Value = Code;
            cmd.Parameters.Add(pNama);

            cmd.ExecuteNonQuery();
            String hasil = pRetVal.Value.ToString();
            connect.Close();
            return hasil;
        }

        public String CodePublisher(OracleConnection connect)
        {
            connect.Open();
            cmd = new OracleCommand();
            cmd.Connection = connect;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GENERATEKODEPENERBIT";

            OracleParameter pRetVal = new OracleParameter();
            pRetVal.ParameterName = "return";
            pRetVal.OracleDbType = OracleDbType.Varchar2;
            pRetVal.Size = 7;
            pRetVal.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(pRetVal);

            cmd.ExecuteNonQuery();
            String hasil = pRetVal.Value.ToString();
            connect.Close();
            return hasil;
        }

        public String CodeBook(OracleConnection connect)
        {
            connect.Open();
            cmd = new OracleCommand();
            cmd.Connection = connect;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GENERATEKODEBUKU";

            OracleParameter pRetVal = new OracleParameter();
            pRetVal.ParameterName = "return";
            pRetVal.OracleDbType = OracleDbType.Varchar2;
            pRetVal.Size = 5;
            pRetVal.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(pRetVal);

            cmd.ExecuteNonQuery();
            String hasil = pRetVal.Value.ToString();
            connect.Close();
            return hasil;
        }
    }
}
