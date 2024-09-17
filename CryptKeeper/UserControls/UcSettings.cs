using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptKeeper.Classes;
using Newtonsoft.Json;
using System.IO;

namespace CryptKeeper.UserControls
{
    public partial class UcSettings : UserControl
    {
        public UcSettings()
        {
            InitializeComponent();
        }
        SecretKeyHelper secretKeyHelper = new SecretKeyHelper();


        private void UcSettings_Load(object sender, EventArgs e)
        {
            secretKeyHelper.ReadSecretKey();
            byte[] keyBytes = secretKeyHelper.Key;
            byte[] IVBytes = secretKeyHelper.IV;
            if (keyBytes.Length == 32 && IVBytes.Length == 16)
            {
                lblKey.Text = "✔";
                lblIV.Text = "✔";
            }
        }

        private void btnNewSecreKey_Click(object sender, EventArgs e)
        {
            string filePath = @"..\..\UserFiles\SecretKey.json"; //SecretKey.json dosya yolu
            DialogResult result = MessageBox.Show("Yeni SecretKey dosyası oluşturulacak bu işlem geri alınamaz. Devam etmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // SecretKey Dosyasını arar eğer varsa siler
                    if (File.Exists(filePath))
                    {
                        File.Delete(filePath);
                    }

                    // Yeni SecretKey dosyası oluştur
                    secretKeyHelper.CreateSecretKeyFile(filePath);
                    MessageBox.Show("Yeni SecretKey dosyası başarılı şekilde oluşturuldu.");
                    Application.Restart();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
    }
}
