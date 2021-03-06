﻿namespace BrainStorm
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
            this.panelMain = new MetroFramework.Controls.MetroPanel();
            this.panelButton = new MetroFramework.Controls.MetroPanel();
            this.btnBackup = new MetroFramework.Controls.MetroButton();
            this.btnDecrypt = new MetroFramework.Controls.MetroButton();
            this.btnEncrypt = new MetroFramework.Controls.MetroButton();
            this.txtDecryptionPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.txtFilePath = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panelMain.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // lnkOwner
            // 
            this.lnkOwner.Location = new System.Drawing.Point(311, 165);
            this.lnkOwner.Name = "lnkOwner";
            this.lnkOwner.Size = new System.Drawing.Size(171, 23);
            this.lnkOwner.TabIndex = 0;
            this.lnkOwner.Text = "Copyright © 2015, Scarecrow";
            this.lnkOwner.UseSelectable = true;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelButton);
            this.panelMain.Controls.Add(this.txtDecryptionPassword);
            this.panelMain.Controls.Add(this.metroLabel2);
            this.panelMain.Controls.Add(this.btnBrowse);
            this.panelMain.Controls.Add(this.txtFilePath);
            this.panelMain.Controls.Add(this.metroLabel1);
            this.panelMain.HorizontalScrollbarBarColor = true;
            this.panelMain.HorizontalScrollbarHighlightOnWheel = false;
            this.panelMain.HorizontalScrollbarSize = 10;
            this.panelMain.Location = new System.Drawing.Point(23, 65);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(459, 96);
            this.panelMain.TabIndex = 1;
            this.panelMain.VerticalScrollbarBarColor = true;
            this.panelMain.VerticalScrollbarHighlightOnWheel = false;
            this.panelMain.VerticalScrollbarSize = 10;
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.btnBackup);
            this.panelButton.Controls.Add(this.btnDecrypt);
            this.panelButton.Controls.Add(this.btnEncrypt);
            this.panelButton.HorizontalScrollbarBarColor = true;
            this.panelButton.HorizontalScrollbarHighlightOnWheel = false;
            this.panelButton.HorizontalScrollbarSize = 10;
            this.panelButton.Location = new System.Drawing.Point(3, 63);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(453, 30);
            this.panelButton.TabIndex = 7;
            this.panelButton.VerticalScrollbarBarColor = true;
            this.panelButton.VerticalScrollbarHighlightOnWheel = false;
            this.panelButton.VerticalScrollbarSize = 10;
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(348, 3);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(102, 23);
            this.btnBackup.TabIndex = 4;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseSelectable = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(251, 3);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(91, 23);
            this.btnDecrypt.TabIndex = 3;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseSelectable = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(145, 3);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(100, 23);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseSelectable = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
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
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(431, 5);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(25, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "..";
            this.btnBrowse.UseSelectable = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
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
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(24, 6);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(118, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Browse Secure File";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 197);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.lnkOwner);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Resizable = false;
            this.Text = "BrainStorm";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink lnkOwner;
        private MetroFramework.Controls.MetroPanel panelMain;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private MetroFramework.Controls.MetroTextBox txtFilePath;
        private MetroFramework.Controls.MetroTextBox txtDecryptionPassword;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroPanel panelButton;
        private MetroFramework.Controls.MetroButton btnBackup;
        private MetroFramework.Controls.MetroButton btnDecrypt;
        private MetroFramework.Controls.MetroButton btnEncrypt;
    }
}

