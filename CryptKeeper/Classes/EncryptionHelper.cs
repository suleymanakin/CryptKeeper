using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace CryptKeeper.Classes
{
    public class EncryptionHelper
    {
        private static byte[] Key;
        private static byte[] IV;

        private static int successfulOperations = 0;
        private static int failedOperations = 0;

        private static Stopwatch stopwatch = new Stopwatch();
        private static string logFilePath;

        public static string CreateLogFilePath()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            logFilePath = Path.Combine(desktopPath, $"log_crypt_{timestamp}.txt");
            return logFilePath;
        }

        private static void LogOperation(string message)
        {
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine(message);
            }
        }

        public static void FinalizeLog()
        {
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine();
                writer.WriteLine("Toplam başarılı işlem: " + successfulOperations);
                writer.WriteLine("Toplam başarısız işlem: " + failedOperations);
                writer.WriteLine("Toplam geçen süre: " + stopwatch.Elapsed.TotalSeconds + " saniye");
            }
            successfulOperations = 0;
            failedOperations = 0;
        }

        public static void InitializeSecretKey()
        {
            var secretKeyHelper = new SecretKeyHelper();
            var (key, iv) = secretKeyHelper.ReadSecretKey();
            Key = key;
            IV = iv;
        }

        public static bool EncryptFile(string inputFilePath)
        {
            stopwatch.Start();

            try
            {
                if (!File.Exists(inputFilePath))
                {
                    MessageBox.Show("Dosya bulunamadı: " + inputFilePath);
                    failedOperations++;
                    LogOperation($"Başarısız: {inputFilePath} (Dosya bulunamadı)");
                    return false;
                }

                using (Aes aes = Aes.Create())
                {
                    aes.Key = Key;
                    aes.IV = IV;
                    aes.Mode = CipherMode.CBC;
                    aes.Padding = PaddingMode.PKCS7;

                    string encryptedFilePath = inputFilePath + ".enc";

                    using (FileStream fsInput = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
                    using (FileStream fsEncrypted = new FileStream(encryptedFilePath, FileMode.Create, FileAccess.Write))
                    using (ICryptoTransform encryptor = aes.CreateEncryptor())
                    using (CryptoStream cryptoStream = new CryptoStream(fsEncrypted, encryptor, CryptoStreamMode.Write))
                    {
                        byte[] buffer = new byte[1024];
                        int bytesRead;
                        while ((bytesRead = fsInput.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            cryptoStream.Write(buffer, 0, bytesRead);
                        }
                    }

                    File.Delete(inputFilePath);
                    File.Move(encryptedFilePath, inputFilePath);
                }

                successfulOperations++;
                LogOperation($"Başarılı: {inputFilePath}");
                return true;
            }
            catch (Exception ex)
            {
                failedOperations++;
                LogOperation($"Başarısız: {inputFilePath} (Hata: {ex.Message})");
                MessageBox.Show("Şifreleme işlemi sırasında hata oluştu: " + ex.Message);
                return false;
            }
            finally
            {
                stopwatch.Stop();
            }
        }

        public static bool DecryptFile(string inputFilePath)
        {
            stopwatch.Start();

            try
            {
                if (!File.Exists(inputFilePath))
                {
                    MessageBox.Show("Dosya bulunamadı: " + inputFilePath);
                    failedOperations++;
                    LogOperation($"Başarısız: {inputFilePath} (Dosya bulunamadı)");
                    return false;
                }

                using (Aes aes = Aes.Create())
                {
                    aes.Key = Key;
                    aes.IV = IV;
                    aes.Mode = CipherMode.CBC;
                    aes.Padding = PaddingMode.PKCS7;

                    string decryptedFilePath = inputFilePath + ".dec";

                    using (FileStream fsEncrypted = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
                    using (FileStream fsDecrypted = new FileStream(decryptedFilePath, FileMode.Create, FileAccess.Write))
                    using (ICryptoTransform decryptor = aes.CreateDecryptor())
                    using (CryptoStream cryptoStream = new CryptoStream(fsDecrypted, decryptor, CryptoStreamMode.Write))
                    {
                        byte[] buffer = new byte[1024];
                        int bytesRead;
                        while ((bytesRead = fsEncrypted.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            cryptoStream.Write(buffer, 0, bytesRead);
                        }
                    }

                    File.Delete(inputFilePath);
                    File.Move(decryptedFilePath, inputFilePath);
                }

                successfulOperations++;
                LogOperation($"Başarılı: {inputFilePath}");
                return true;
            }
            catch (Exception ex)
            {
                failedOperations++;
                LogOperation($"Başarısız: {inputFilePath} (Hata: {ex.Message})");
                MessageBox.Show("Deşifreleme hatası: " + ex.Message);
                return false;
            }
            finally
            {
                stopwatch.Stop();
            }
        }

        public static bool EncryptFolder(string folderPath)
        {
            stopwatch.Start();

            try
            {
                if (!Directory.Exists(folderPath))
                {
                    MessageBox.Show("Klasör bulunamadı: " + folderPath);
                    failedOperations++;
                    LogOperation($"Başarısız: {folderPath} (Klasör bulunamadı)");
                    return false;
                }

                foreach (string file in Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories))
                {
                    bool success = EncryptFile(file);
                    if (!success)
                    {
                        failedOperations++;
                        LogOperation($"Başarısız: {file}");
                        return false;
                    }
                }

                successfulOperations++;
                LogOperation($"Başarılı: {folderPath}");
                MessageBox.Show("Klasördeki tüm dosyalar başarıyla şifrelendi.");
                return true;
            }
            catch (Exception ex)
            {
                failedOperations++;
                LogOperation($"Başarısız: {folderPath} (Hata: {ex.Message})");
                MessageBox.Show("Klasör şifreleme hatası: " + ex.Message);
                return false;
            }
            finally
            {
                stopwatch.Stop();
            }
        }

        public static bool DecryptFolder(string folderPath)
        {
            stopwatch.Start();

            try
            {
                if (!Directory.Exists(folderPath))
                {
                    MessageBox.Show("Klasör bulunamadı: " + folderPath);
                    failedOperations++;
                    LogOperation($"Başarısız: {folderPath} (Klasör bulunamadı)");
                    return false;
                }

                foreach (string file in Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories))
                {
                    bool success = DecryptFile(file);
                    if (!success)
                    {
                        failedOperations++;
                        LogOperation($"Başarısız: {file}");
                        return false;
                    }
                }

                successfulOperations++;
                LogOperation($"Başarılı: {folderPath}");
                MessageBox.Show("Klasördeki tüm dosyaların şifresi başarıyla çözüldü.");
                return true;
            }
            catch (Exception ex)
            {
                failedOperations++;
                LogOperation($"Başarısız: {folderPath} (Hata: {ex.Message})");
                MessageBox.Show("Klasör deşifreleme hatası: " + ex.Message);
                return false;
            }
            finally
            {
                stopwatch.Stop();
            }
        }
    }
}
