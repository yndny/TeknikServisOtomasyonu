using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace TeknikServis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string dosyaDizini = Application.StartupPath + "\\Ayarlar.xml";
            if (File.Exists(dosyaDizini) == true)
            {
                Ayar.XmlOkuVeBaglantiKur();
            }
            else
            {
                DatabaseBilgileri db = new DatabaseBilgileri();
                db.Show();
            }
        }

        private void lblKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "" || txtSifre.Text == "")
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre alanlarını doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string girilenSifre = txtSifre.Text.Trim();
                string sifreliParola = Ayar.Sifrele(girilenSifre, Ayar.AnahtarKelime);

                using (SqlConnection baglanti = new SqlConnection(Ayar.conString))
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("SELECT * FROM Personel WHERE KullaniciAdi=@kadi AND (Password=@sifreDuz OR Password=@sifreKripto) AND Silindi=0", baglanti);
                    komut.Parameters.AddWithValue("@kadi", txtKullaniciAdi.Text.Trim());
                    komut.Parameters.AddWithValue("@sifreDuz", girilenSifre);
                    komut.Parameters.AddWithValue("@sifreKripto", sifreliParola);

                    SqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read())
                    {
                        Ayar.KullaniciID = Convert.ToInt32(dr["PersonelID"]);
                        Ayar.KullaniciAdi = dr["KullaniciAdi"].ToString();
                        Ayar.YetkiID = dr["Yetkisi"] != DBNull.Value ? Convert.ToInt32(dr["Yetkisi"]) : 1;

                        frmAnasayfa ans = new frmAnasayfa();
                        ans.lblKullaniciAdi.Text = dr["KullaniciAdi"].ToString();
                        this.Hide();
                        ans.Show();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantı hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}