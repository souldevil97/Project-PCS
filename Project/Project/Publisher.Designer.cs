namespace Project
{
    partial class Publisher
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
            this.PublishersData = new System.Windows.Forms.DataGridView();
            this.Publisher_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher_City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher_PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bSearch = new System.Windows.Forms.Button();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.tSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tPhoneNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tAddress = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bDelete = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bInsert = new System.Windows.Forms.Button();
            this.tName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tPublisherID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PublishersData)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PublishersData
            // 
            this.PublishersData.AllowUserToAddRows = false;
            this.PublishersData.AllowUserToDeleteRows = false;
            this.PublishersData.AllowUserToResizeColumns = false;
            this.PublishersData.AllowUserToResizeRows = false;
            this.PublishersData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PublishersData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PublishersData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Publisher_ID,
            this.Publisher_Name,
            this.Publisher_Address,
            this.Publisher_City,
            this.Publisher_PhoneNumber});
            this.PublishersData.Location = new System.Drawing.Point(440, 170);
            this.PublishersData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PublishersData.Name = "PublishersData";
            this.PublishersData.ReadOnly = true;
            this.PublishersData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PublishersData.Size = new System.Drawing.Size(1077, 546);
            this.PublishersData.TabIndex = 11;
            this.PublishersData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PublishersData_CellClick);
            // 
            // Publisher_ID
            // 
            this.Publisher_ID.HeaderText = "Publisher ID";
            this.Publisher_ID.Name = "Publisher_ID";
            this.Publisher_ID.ReadOnly = true;
            // 
            // Publisher_Name
            // 
            this.Publisher_Name.HeaderText = "Name";
            this.Publisher_Name.Name = "Publisher_Name";
            this.Publisher_Name.ReadOnly = true;
            // 
            // Publisher_Address
            // 
            this.Publisher_Address.HeaderText = "Address";
            this.Publisher_Address.Name = "Publisher_Address";
            this.Publisher_Address.ReadOnly = true;
            // 
            // Publisher_City
            // 
            this.Publisher_City.HeaderText = "City";
            this.Publisher_City.Name = "Publisher_City";
            this.Publisher_City.ReadOnly = true;
            // 
            // Publisher_PhoneNumber
            // 
            this.Publisher_PhoneNumber.HeaderText = "Phone Number";
            this.Publisher_PhoneNumber.Name = "Publisher_PhoneNumber";
            this.Publisher_PhoneNumber.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bSearch);
            this.groupBox3.Controls.Add(this.cbSearch);
            this.groupBox3.Controls.Add(this.tSearch);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(440, 60);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(1077, 105);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search";
            // 
            // bSearch
            // 
            this.bSearch.Location = new System.Drawing.Point(952, 30);
            this.bSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(112, 65);
            this.bSearch.TabIndex = 15;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = true;
            // 
            // cbSearch
            // 
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Location = new System.Drawing.Point(669, 50);
            this.cbSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(272, 28);
            this.cbSearch.TabIndex = 13;
            // 
            // tSearch
            // 
            this.tSearch.Location = new System.Drawing.Point(9, 54);
            this.tSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tSearch.Name = "tSearch";
            this.tSearch.Size = new System.Drawing.Size(649, 26);
            this.tSearch.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbCity);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tPhoneNumber);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tAddress);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.bDelete);
            this.groupBox1.Controls.Add(this.bUpdate);
            this.groupBox1.Controls.Add(this.bInsert);
            this.groupBox1.Controls.Add(this.tName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tPublisherID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(412, 656);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // cbCity
            // 
            this.cbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Items.AddRange(new object[] {
            "Banda Aceh",
            "Langsa",
            "Lhokseumawe",
            "Meulaboh",
            "Sabang",
            "Subulussalam",
            "Denpasar",
            "Pangkalpinang",
            "Cilegon",
            "Serang",
            "Tangerang Selatan",
            "Tangerang",
            "Bengkulu",
            "Gorontalo",
            "Jakarta Barat",
            "Jakarta Pusat",
            "Jakarta Selatan",
            "Jakarta Timur",
            "Jakarta Utara",
            "Sungai Penuh",
            "Jambi",
            "Bandung",
            "Bekasi",
            "Bogor",
            "Cimahi",
            "Cirebon",
            "Depok",
            "Sukabumi",
            "Tasikmalaya",
            "Banjar",
            "Magelang",
            "Pekalongan",
            "Purwokerto",
            "Salatiga",
            "Semarang",
            "Surakarta",
            "Tegal",
            "Batu",
            "Blitar",
            "Kediri",
            "Madiun",
            "Malang",
            "Mojokerto",
            "Pasuruan",
            "Probolinggo",
            "Surabaya",
            "Pontianak",
            "Singkawang",
            "Banjarbaru",
            "Banjarmasin",
            "Palangkaraya",
            "Balikpapan",
            "Bontang",
            "Samarinda",
            "Tarakan",
            "Batam",
            "Tanjungpinang",
            "Bandar Lampung",
            "Metro",
            "Ternate",
            "Tidore Kepulauan",
            "Ambon",
            "Tual",
            "Bima",
            "Mataram",
            "Kupang",
            "Sorong",
            "Jayapura",
            "Dumai",
            "Pekanbaru",
            "Makassar",
            "Palopo",
            "Parepare",
            "Palu",
            "Bau-Bau",
            "Kendari",
            "Bitung",
            "Kotamobagu",
            "Manado",
            "Tomohon",
            "Bukittinggi",
            "Padang",
            "Padangpanjang",
            "Pariaman",
            "Payakumbuh",
            "Sawahlunto",
            "Solok",
            "Lubuklinggau",
            "Pagaralam",
            "Palembang",
            "Prabumulih",
            "Binjai",
            "Medan",
            "Padang Sidempuan",
            "Pematangsiantar",
            "Sibolga",
            "Tanjungbalai",
            "Tebingtinggi",
            "Yogyakarta"});
            this.cbCity.Location = new System.Drawing.Point(13, 349);
            this.cbCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(376, 28);
            this.cbCity.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 324);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "City";
            // 
            // tPhoneNumber
            // 
            this.tPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPhoneNumber.Location = new System.Drawing.Point(13, 407);
            this.tPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tPhoneNumber.Name = "tPhoneNumber";
            this.tPhoneNumber.Size = new System.Drawing.Size(376, 26);
            this.tPhoneNumber.TabIndex = 5;
            this.tPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tPhoneNumber_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 382);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Phone Number";
            // 
            // tAddress
            // 
            this.tAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tAddress.Location = new System.Drawing.Point(13, 166);
            this.tAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tAddress.Name = "tAddress";
            this.tAddress.Size = new System.Drawing.Size(376, 153);
            this.tAddress.TabIndex = 3;
            this.tAddress.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Address";
            // 
            // bDelete
            // 
            this.bDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDelete.Location = new System.Drawing.Point(271, 443);
            this.bDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(120, 57);
            this.bDelete.TabIndex = 12;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUpdate.Location = new System.Drawing.Point(142, 443);
            this.bUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(120, 57);
            this.bUpdate.TabIndex = 11;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // bInsert
            // 
            this.bInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInsert.Location = new System.Drawing.Point(13, 443);
            this.bInsert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bInsert.Name = "bInsert";
            this.bInsert.Size = new System.Drawing.Size(120, 57);
            this.bInsert.TabIndex = 10;
            this.bInsert.Text = "Insert";
            this.bInsert.UseVisualStyleBackColor = true;
            this.bInsert.Click += new System.EventHandler(this.bInsert_Click);
            // 
            // tName
            // 
            this.tName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tName.Location = new System.Drawing.Point(13, 110);
            this.tName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(376, 26);
            this.tName.TabIndex = 2;
            this.tName.TextChanged += new System.EventHandler(this.tName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Publisher Name";
            // 
            // tPublisherID
            // 
            this.tPublisherID.Enabled = false;
            this.tPublisherID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPublisherID.Location = new System.Drawing.Point(13, 49);
            this.tPublisherID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tPublisherID.Name = "tPublisherID";
            this.tPublisherID.Size = new System.Drawing.Size(376, 26);
            this.tPublisherID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Publisher ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Master Publisher";
            // 
            // Publisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1806, 744);
            this.Controls.Add(this.PublishersData);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Publisher";
            this.Text = "Publisher";
            this.Load += new System.EventHandler(this.Publisher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PublishersData)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PublishersData;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.TextBox tSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tPhoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox tAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bInsert;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tPublisherID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher_City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher_PhoneNumber;

    }
}