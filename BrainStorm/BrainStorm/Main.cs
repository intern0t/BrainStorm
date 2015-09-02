using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BrainStorm
{
    public partial class Main : MetroForm
    {
        private static String _MD5CheckSum  = string.Empty;
        private static String MD5CheckSum   = string.Empty;

        public Main()
        {
            InitializeComponent();

            #region Form Design Phase

            this.Style = MetroFramework.MetroColorStyle.Red;
            panelButton.Enabled = false;

            #endregion
        }



        private void Main_Load(object sender, EventArgs e)
        {

        }

        #region Triggered Events

        public static string MD5Calculate(string filePath)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filePath))
                {
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", "").ToLower();
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "BrainStorm Files (*.bsf)|*.bsf";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ofd.FileName.Length > 1)
                {
                    txtFilePath.Text = ofd.FileName;
                    panelButton.Enabled = true;
                    _MD5CheckSum = MD5Calculate(txtFilePath.Text);
                }
                else
                {
                    txtFilePath.Text = "Invalid *.BSF file path!";
                }
            }
            else { }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string FileContents = File.ReadAllText(txtFilePath.Text);
                string Encrypted = new Encryption().EncryptText(FileContents, txtDecryptionPassword.Text);
                File.WriteAllText(txtFilePath.Text, Encrypted, Encoding.UTF8);
            }
            catch { }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string FileContents = File.ReadAllText(@txtFilePath.Text);
                string Decrypted = new Encryption().DecryptText(FileContents, txtDecryptionPassword.Text);

                File.WriteAllText(txtFilePath.Text, Decrypted);
            }
            catch { }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch { }
        }

        #endregion
    }
}
