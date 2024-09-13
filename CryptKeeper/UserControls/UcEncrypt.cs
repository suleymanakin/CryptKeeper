using CryptKeeper.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptKeeper.UserControls
{
    public partial class UcEncrypt : UserControl
    {
        private string inputFile;
        private string inputFolder;
        private bool isChecked = false;
        public UcEncrypt()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (rbtnFileEncryption.Checked)
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    inputFile = openFileDialog.FileName; // Seçilen dosya
                    tbxPath.Text = openFileDialog.FileName;
                    isChecked = true;
                }
            }
            else if (rbtnFolderEncryption.Checked)
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK) // FolderBrowserDialog'ı göster
                {
                    inputFolder = folderBrowserDialog.SelectedPath; // Seçilen klasör yolu
                    tbxPath.Text = folderBrowserDialog.SelectedPath;
                    isChecked = true;
                }
            }
            else
            {
                MessageBox.Show("Bir seçim yapınız.");
            }
        }

        private void btnStartEncryption_Click(object sender, EventArgs e)
        {
            EncryptionHelper.CreateLogFilePath();
            if (isChecked)
            {
                lblStatus.Text = "Processing";
                DialogResult result = MessageBox.Show("Şifreleme işlemini onaylıyor musunuz?", "Onay", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    if (inputFile != null)
                    {
                        if (EncryptionHelper.EncryptFile(inputFile))
                        {
                            lblStatus.Text = "Success";
                            inputFile = null;
                        }
                        else
                        {
                            lblStatus.Text = "Failed";
                        }
                    }
                    else if (inputFolder != null)
                    {
                        //lblStatus.Text = "Processing";
                        if (inputFolder != null)
                        {
                            if (EncryptionHelper.EncryptFolder(inputFolder))
                            {
                                lblStatus.Text = "Success";
                                inputFolder = null;
                            }
                            else
                            {
                                lblStatus.Text = "Failed";
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bir seçim ypaın");
                    lblStatus.Text = "Failed";
                }
            }
            EncryptionHelper.FinalizeLog();
        }
    }
}
