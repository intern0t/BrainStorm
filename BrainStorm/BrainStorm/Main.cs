using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BrainStorm
{
    public partial class Main : MetroForm
    {
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

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "BrainStorm Files (*.bsf)|*.bsf";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ofd.FileName.Length > 1)
                {
                    txtFilePath.Text = ofd.FileName;
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

            }
            catch { }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            try
            {

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
