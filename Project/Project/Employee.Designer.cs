namespace Project
{
    partial class Employee
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.dtBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cbActive = new System.Windows.Forms.CheckBox();
            this.tPhoneNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tAddress = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bPicture = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bInsert = new System.Windows.Forms.Button();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.tName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tEmployeeID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeesData = new System.Windows.Forms.DataGridView();
            this.Employee_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee_DateBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee_Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bSearch = new System.Windows.Forms.Button();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.tSearch = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesData)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Master Employee";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dtBirthDate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbActive);
            this.groupBox1.Controls.Add(this.tPhoneNumber);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tAddress);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.bPicture);
            this.groupBox1.Controls.Add(this.bDelete);
            this.groupBox1.Controls.Add(this.bUpdate);
            this.groupBox1.Controls.Add(this.bInsert);
            this.groupBox1.Controls.Add(this.Picture);
            this.groupBox1.Controls.Add(this.tName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tEmployeeID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 408);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbFemale);
            this.groupBox2.Controls.Add(this.rbMale);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(218, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(158, 80);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gender";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(7, 49);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(80, 24);
            this.rbFemale.TabIndex = 8;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(7, 23);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(61, 24);
            this.rbMale.TabIndex = 7;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // dtBirthDate
            // 
            this.dtBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBirthDate.Location = new System.Drawing.Point(10, 318);
            this.dtBirthDate.Name = "dtBirthDate";
            this.dtBirthDate.Size = new System.Drawing.Size(202, 26);
            this.dtBirthDate.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Birth Date";
            // 
            // cbActive
            // 
            this.cbActive.AutoSize = true;
            this.cbActive.Checked = true;
            this.cbActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbActive.Location = new System.Drawing.Point(218, 248);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(71, 24);
            this.cbActive.TabIndex = 6;
            this.cbActive.Text = "Active";
            this.cbActive.UseVisualStyleBackColor = true;
            // 
            // tPhoneNumber
            // 
            this.tPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPhoneNumber.Location = new System.Drawing.Point(10, 266);
            this.tPhoneNumber.Name = "tPhoneNumber";
            this.tPhoneNumber.Size = new System.Drawing.Size(202, 26);
            this.tPhoneNumber.TabIndex = 4;
            this.tPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tPhoneNumber_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Phone Number";
            // 
            // tAddress
            // 
            this.tAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tAddress.Location = new System.Drawing.Point(10, 144);
            this.tAddress.Name = "tAddress";
            this.tAddress.Size = new System.Drawing.Size(202, 96);
            this.tAddress.TabIndex = 3;
            this.tAddress.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Address";
            // 
            // bPicture
            // 
            this.bPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPicture.Location = new System.Drawing.Point(218, 207);
            this.bPicture.Name = "bPicture";
            this.bPicture.Size = new System.Drawing.Size(158, 35);
            this.bPicture.TabIndex = 7;
            this.bPicture.Text = "Insert Picture";
            this.bPicture.UseVisualStyleBackColor = true;
            this.bPicture.Click += new System.EventHandler(this.bPicture_Click);
            // 
            // bDelete
            // 
            this.bDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDelete.Location = new System.Drawing.Point(262, 362);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(120, 35);
            this.bDelete.TabIndex = 11;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUpdate.Location = new System.Drawing.Point(136, 362);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(120, 35);
            this.bUpdate.TabIndex = 10;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // bInsert
            // 
            this.bInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInsert.Location = new System.Drawing.Point(10, 362);
            this.bInsert.Name = "bInsert";
            this.bInsert.Size = new System.Drawing.Size(120, 35);
            this.bInsert.TabIndex = 9;
            this.bInsert.Text = "Insert";
            this.bInsert.UseVisualStyleBackColor = true;
            this.bInsert.Click += new System.EventHandler(this.bInsert_Click);
            // 
            // Picture
            // 
            this.Picture.Location = new System.Drawing.Point(218, 16);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(158, 185);
            this.Picture.TabIndex = 13;
            this.Picture.TabStop = false;
            // 
            // tName
            // 
            this.tName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tName.Location = new System.Drawing.Point(10, 91);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(202, 26);
            this.tName.TabIndex = 2;
            this.tName.TextChanged += new System.EventHandler(this.tName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // tEmployeeID
            // 
            this.tEmployeeID.Enabled = false;
            this.tEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tEmployeeID.Location = new System.Drawing.Point(10, 39);
            this.tEmployeeID.Name = "tEmployeeID";
            this.tEmployeeID.Size = new System.Drawing.Size(202, 26);
            this.tEmployeeID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            // 
            // EmployeesData
            // 
            this.EmployeesData.AllowUserToAddRows = false;
            this.EmployeesData.AllowUserToDeleteRows = false;
            this.EmployeesData.AllowUserToResizeColumns = false;
            this.EmployeesData.AllowUserToResizeRows = false;
            this.EmployeesData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeesData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Employee_ID,
            this.Employee_Name,
            this.Employee_Address,
            this.Employee_Number,
            this.Employee_DateBirth,
            this.Employee_Gender,
            this.Employee_Status});
            this.EmployeesData.Location = new System.Drawing.Point(409, 108);
            this.EmployeesData.Name = "EmployeesData";
            this.EmployeesData.ReadOnly = true;
            this.EmployeesData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeesData.Size = new System.Drawing.Size(712, 337);
            this.EmployeesData.TabIndex = 4;
            this.EmployeesData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeesData_CellClick);
            // 
            // Employee_ID
            // 
            this.Employee_ID.HeaderText = "Employee ID";
            this.Employee_ID.Name = "Employee_ID";
            this.Employee_ID.ReadOnly = true;
            // 
            // Employee_Name
            // 
            this.Employee_Name.HeaderText = "Name";
            this.Employee_Name.Name = "Employee_Name";
            this.Employee_Name.ReadOnly = true;
            // 
            // Employee_Address
            // 
            this.Employee_Address.HeaderText = "Address";
            this.Employee_Address.Name = "Employee_Address";
            this.Employee_Address.ReadOnly = true;
            // 
            // Employee_Number
            // 
            this.Employee_Number.HeaderText = "Phone Number";
            this.Employee_Number.Name = "Employee_Number";
            this.Employee_Number.ReadOnly = true;
            // 
            // Employee_DateBirth
            // 
            this.Employee_DateBirth.HeaderText = "Birth Date";
            this.Employee_DateBirth.Name = "Employee_DateBirth";
            this.Employee_DateBirth.ReadOnly = true;
            // 
            // Employee_Gender
            // 
            this.Employee_Gender.HeaderText = "Gender";
            this.Employee_Gender.Name = "Employee_Gender";
            this.Employee_Gender.ReadOnly = true;
            // 
            // Employee_Status
            // 
            this.Employee_Status.HeaderText = "Status";
            this.Employee_Status.Name = "Employee_Status";
            this.Employee_Status.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bSearch);
            this.groupBox3.Controls.Add(this.cbSearch);
            this.groupBox3.Controls.Add(this.tSearch);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(409, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(712, 65);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search";
            // 
            // bSearch
            // 
            this.bSearch.Location = new System.Drawing.Point(634, 19);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(75, 40);
            this.bSearch.TabIndex = 14;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = true;
            // 
            // cbSearch
            // 
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Location = new System.Drawing.Point(446, 31);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(183, 28);
            this.cbSearch.TabIndex = 13;
            // 
            // tSearch
            // 
            this.tSearch.Location = new System.Drawing.Point(6, 33);
            this.tSearch.Name = "tSearch";
            this.tSearch.Size = new System.Drawing.Size(434, 26);
            this.tSearch.TabIndex = 12;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 632);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.EmployeesData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesData)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bPicture;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bInsert;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tEmployeeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtBirthDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbActive;
        private System.Windows.Forms.TextBox tPhoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox tAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.DataGridView EmployeesData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee_DateBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee_Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee_Status;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.TextBox tSearch;
        private System.Windows.Forms.Button bSearch;
    }
}