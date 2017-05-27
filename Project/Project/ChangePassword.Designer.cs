namespace Project
{
    partial class ChangePassword
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
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Btn_ChangePass = new System.Windows.Forms.Button();
            this.tNewPassword = new System.Windows.Forms.TextBox();
            this.tOldPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tConfirmPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancel.Location = new System.Drawing.Point(237, 165);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(124, 33);
            this.Btn_Cancel.TabIndex = 5;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Btn_ChangePass
            // 
            this.Btn_ChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ChangePass.Location = new System.Drawing.Point(91, 165);
            this.Btn_ChangePass.Name = "Btn_ChangePass";
            this.Btn_ChangePass.Size = new System.Drawing.Size(124, 33);
            this.Btn_ChangePass.TabIndex = 4;
            this.Btn_ChangePass.Text = "Change";
            this.Btn_ChangePass.UseVisualStyleBackColor = true;
            this.Btn_ChangePass.Click += new System.EventHandler(this.Btn_ChangePass_Click);
            // 
            // tNewPassword
            // 
            this.tNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNewPassword.Location = new System.Drawing.Point(216, 95);
            this.tNewPassword.Name = "tNewPassword";
            this.tNewPassword.PasswordChar = '*';
            this.tNewPassword.Size = new System.Drawing.Size(173, 26);
            this.tNewPassword.TabIndex = 2;
            // 
            // tOldPassword
            // 
            this.tOldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tOldPassword.Location = new System.Drawing.Point(216, 63);
            this.tOldPassword.Name = "tOldPassword";
            this.tOldPassword.PasswordChar = '*';
            this.tOldPassword.Size = new System.Drawing.Size(173, 26);
            this.tOldPassword.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "New Password : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Old Password : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Confirm Password : ";
            // 
            // tConfirmPassword
            // 
            this.tConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tConfirmPassword.Location = new System.Drawing.Point(216, 127);
            this.tConfirmPassword.Name = "tConfirmPassword";
            this.tConfirmPassword.PasswordChar = '*';
            this.tConfirmPassword.Size = new System.Drawing.Size(173, 26);
            this.tConfirmPassword.TabIndex = 3;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 261);
            this.ControlBox = false;
            this.Controls.Add(this.tConfirmPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_ChangePass);
            this.Controls.Add(this.tNewPassword);
            this.Controls.Add(this.tOldPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.Button Btn_ChangePass;
        private System.Windows.Forms.TextBox tNewPassword;
        private System.Windows.Forms.TextBox tOldPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tConfirmPassword;
    }
}