using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace TeknikServis
{
    public class Ayar
    {
        public static string conString = "";
        public static int KullaniciID = 1;
        public static string KullaniciAdi = "";
        public static int YetkiID = 1;
        public static string AnahtarKelime = "TeknikServisKey";

        public static string Sifrele(string sifrelenecekDeger, string anahtar)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(sifrelenecekDeger);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(anahtar));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return Convert.ToBase64String(results, 0, results.Length);
                }
            }
        }

        public static string SifreCoz(string cozulecekDeger, string anahtar)
        {
            byte[] data = Convert.FromBase64String(cozulecekDeger);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(anahtar));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return UTF8Encoding.UTF8.GetString(results);
                }
            }
        }

        public static bool XmlOkuVeBaglantiKur()
        {
            string dosyaDizini = Application.StartupPath + "\\Ayarlar.xml";
            if (!File.Exists(dosyaDizini))
            {
                conString = @"Data Source=.\SQLEXPRESS;Initial Catalog=TeknikServis;Integrated Security=True";
                return false;
            }

            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(dosyaDizini);

                string server = xmlDoc.SelectSingleNode("Ayarlar/Sql/Server")?.InnerText ?? ".";
                string database = xmlDoc.SelectSingleNode("Ayarlar/Sql/Database")?.InnerText ?? "TeknikServis";
                string userId = xmlDoc.SelectSingleNode("Ayarlar/Sql/UserID")?.InnerText ?? "";
                string passwordSifreli = xmlDoc.SelectSingleNode("Ayarlar/Sql/Password")?.InnerText ?? "";
                string anahtar = xmlDoc.SelectSingleNode("Ayarlar/Sql/Anahtar")?.InnerText ?? "TeknikServisKey";

                AnahtarKelime = anahtar;

                if (userId.ToLower() == "windows" || string.IsNullOrWhiteSpace(userId))
                {
                    conString = $"Data Source={server};Initial Catalog={database};Integrated Security=True";
                }
                else
                {
                    string cozulmusSifre = SifreCoz(passwordSifreli, anahtar);
                    conString = $"Data Source={server};Initial Catalog={database};User ID={userId};Password={cozulmusSifre}";
                }
                return true;
            }
            catch
            {
                conString = @"Data Source=.\SQLEXPRESS;Initial Catalog=TeknikServis;Integrated Security=True";
                return false;
            }
        }
    }
}