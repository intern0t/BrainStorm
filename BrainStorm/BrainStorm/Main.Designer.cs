namespace BrainStorm
{
    partial class Main
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
            this.lnkOwner = new MetroFramework.Controls.MetroLink();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtFilePath = new MetroFramework.Controls.MetroTextBox();
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.txtDecryptionPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btnEncrypt = new MetroFramework.Controls.MetroButton();
            this.btnDecrypt = new MetroFramework.Controls.MetroButton();
            this.btnBackup = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lnkOwner
            // 
            this.lnkOwner.Location = new System.Drawing.Point(324, 173);
            this.lnkOwner.Name = "lnkOwner";
            this.lnkOwner.Size = new System.Drawing.Size(158, 23);
            this.lnkOwner.TabIndex = 0;
            this.lnkOwner.Text = "Copyright © 2015, intern0t";
            this.lnkOwner.UseSelectable = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.Controls.Add(this.txtDecryptionPassword);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.btnBrowse);
            this.metroPanel1.Controls.Add(this.txtFilePath);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 65);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(459, 105);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 6);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(118, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Browse Secure File";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Lines = new string[0];
            this.txtFilePath.Location = new System.Drawing.Point(148, 5);
            this.txtFilePath.MaxLength = 32767;
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.PasswordChar = '\0';
            this.txtFilePath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFilePath.SelectedText = "";
            this.txtFilePath.Size = new System.Drawing.Size(277, 23);
            this.txtFilePath.TabIndex = 3;
            this.txtFilePath.UseSelectable = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(431, 5);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(25, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "..";
            this.btnBrowse.UseSelectable = true;
            // 
            // txtDecryptionPassword
            // 
            this.txtDecryptionPassword.Lines = new string[0];
            this.txtDecryptionPassword.Location = new System.Drawing.Point(148, 34);
            this.txtDecryptionPassword.MaxLength = 32767;
            this.txtDecryptionPassword.Name = "txtDecryptionPassword";
            this.txtDecryptionPassword.PasswordChar = '\0';
            this.txtDecryptionPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDecryptionPassword.SelectedText = "";
            this.txtDecryptionPassword.Size = new System.Drawing.Size(308, 23);
            this.txtDecryptionPassword.TabIndex = 6;
            this.txtDecryptionPassword.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(11, 35);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(131, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Decryption Password";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.btnBackup);
            this.metroPanel2.Controls.Add(this.btnDecrypt);
            this.metroPanel2.Controls.Add(this.btnEncrypt);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(3, 63);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(453, 39);
            this.metroPanel2.TabIndex = 7;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(145, 7);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(100, 23);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseSelectable = true;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(251, 7);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(91, 23);
            this.btnDecrypt.TabIndex = 3;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseSelectable = true;
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(348, 7);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(102, 23);
            this.btnBackup.TabIndex = 4;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseSelectable = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 209);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.lnkOwner);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Resizable = false;
            this.Text = "BrainStorm";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink lnkOwner;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private MetroFramework.Controls.MetroTextBox txtFilePath;
        private MetroFramework.Controls.MetroTextBox txtDecryptionPassword;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton btnBackup;
        private MetroFramework.Controls.MetroButton btnDecrypt;
        private MetroFramework.Controls.MetroButton btnEncrypt;
    }
}

