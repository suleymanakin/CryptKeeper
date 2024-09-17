using Newtonsoft.Json;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace CryptKeeper.Classes
{
    public class SecretKeyHelper
    {
        public byte[] Key { get; private set; }
        public byte[] IV { get; private set; }

        private readonly byte[] _fixedKey = Convert.FromBase64String("21YFQOLCQDeECkaACgNPiNtTKdPb1/IegJE6Vy3xc+c="); // Sabit key
        private readonly byte[] _fixedIV = Convert.FromBase64String("05Lj0RYb+4FUrNYgU+wTdQ=="); // Sabit IV

        public (byte[] key, byte[] iv) ReadSecretKey()
        {
            string filePath = @"..\..\UserFiles\SecretKey.json"; //SecretKey.json dosya yolu

            // Eğer dosya yoksa, yeni bir key ve IV üret ve şifreli JSON dosyası oluştur
            if (!File.Exists(filePath))
            {
                DialogResult result = MessageBox.Show("SecretKey dosyası bulunamadı. Yenisini oluşturmak istermisiniz?", "Uyarı", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    CreateSecretKeyFile(filePath);
                }
                else
                {
                    MessageBox.Show("Programı kullanmaya devam etmek için SecretKey dosyasına ihtiyacınız var.");
                    Environment.Exit(0);
                }

            }

            // Dosyayı deşifre edip key ve IV döndürülecek
            var (key, iv) = DecryptWithSecretKey(filePath);

            // Key ve IV değişkenlerine atama
            Key = key;
            IV = iv;

            return (key, iv);
        }

        // Yeni key ve IV üret ve şifreli JSON dosyası oluştur
        public void CreateSecretKeyFile(string filePath)
        {
            // Yeni key ve IV üret
            var secretKeyData = GenerateKeynIV();

            // JSON formatına dönüştür
            string json = JsonConvert.SerializeObject(secretKeyData, Formatting.Indented);

            // JSON'u sabit key ve IV ile şifrele
            byte[] encryptedData = EncryptWithFixedKey(Encoding.UTF8.GetBytes(json));

            // Şifrelenmiş JSON'u dosyaya yaz
            File.WriteAllBytes(filePath, encryptedData);
        }

        // Yeni key ve IV üret
        private SecretKeyData GenerateKeynIV()
        {
            using (var aes = Aes.Create())
            {
                aes.KeySize = 256;
                aes.GenerateKey();
                aes.GenerateIV();

                return new SecretKeyData
                {
                    Key = Convert.ToBase64String(aes.Key),
                    IV = Convert.ToBase64String(aes.IV)
                };
            }
        }

        // Sabit key ve IV ile JSON dosyasını şifrele
        private byte[] EncryptWithFixedKey(byte[] plainBytes)
        {
            using (var aes = Aes.Create())
            {
                aes.Key = _fixedKey;
                aes.IV = _fixedIV;

                var encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (var ms = new MemoryStream())
                {
                    using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        cs.Write(plainBytes, 0, plainBytes.Length);
                    }

                    return ms.ToArray();
                }
            }
        }

        // Sabit key ve IV ile JSON dosyasını deşifrele
        private (byte[] key, byte[] iv) DecryptWithSecretKey(string filePath)
        {
            byte[] encryptedData = File.ReadAllBytes(filePath);

            using (var aes = Aes.Create())
            {
                aes.Key = _fixedKey;
                aes.IV = _fixedIV;

                var decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (var ms = new MemoryStream(encryptedData))
                {
                    using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        using (var sr = new StreamReader(cs))
                        {
                            // Deşifre edilen JSON'u oku
                            string decryptedJson = sr.ReadToEnd();

                            // Key ve IV değerlerini içeren objeyi deserialize et
                            var secretKeyData = JsonConvert.DeserializeObject<SecretKeyData>(decryptedJson);

                            byte[] decryptedKey = Convert.FromBase64String(secretKeyData.Key);
                            byte[] decryptedIV = Convert.FromBase64String(secretKeyData.IV);

                            return (decryptedKey, decryptedIV); // JSON'dan okunan key ve IV döndürülüyor
                        }
                    }
                }
            }
        }

        // Program genelindeki şifreleme ve deşifreleme işlemleri için kullanılacak
        public byte[] EncryptWithSecretKey(byte[] dataToEncrypt)
        {
            using (var aes = Aes.Create())
            {
                aes.Key = Key; // JSON'dan okunan Key kullanılıyor
                aes.IV = IV;   // JSON'dan okunan IV kullanılıyor

                var encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (var ms = new MemoryStream())
                {
                    using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        cs.Write(dataToEncrypt, 0, dataToEncrypt.Length);
                    }

                    return ms.ToArray();
                }
            }
        }

        public byte[] DecryptWithSecretKey(byte[] dataToDecrypt)
        {
            using (var aes = Aes.Create())
            {
                aes.Key = Key; // JSON'dan okunan Key kullanılıyor
                aes.IV = IV;   // JSON'dan okunan IV kullanılıyor

                var decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (var ms = new MemoryStream(dataToDecrypt))
                {
                    using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        using (var msOutput = new MemoryStream())
                        {
                            cs.CopyTo(msOutput);
                            return msOutput.ToArray();
                        }
                    }
                }
            }
        }
    }

    public class SecretKeyData
    {
        public string Key { get; set; }
        public string IV { get; set; }
    }
}
