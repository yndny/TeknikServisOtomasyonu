using System;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace TeknikServis
{
    public partial class DatabaseBilgileri : Form
    {
        public DatabaseBilgileri()
        {
            InitializeComponent();
        }

        private void lblKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtAnahtar.Text != "" && txtKullaniciAdi.Text != "" && txtSifre.Text != "" && txtSunucuAdi.Text != "" && txtVeritabaniAdi.Text != "")
            {
                XmlTextWriter yaz = new XmlTextWriter(Application.StartupPath + "\\Ayarlar.xml", UTF8Encoding.UTF8);
                yaz.Formatting = Formatting.Indented;
                try
                {
                    yaz.WriteStartDocument();
                    yaz.WriteStartElement("Ayarlar");
                    yaz.WriteStartElement("Sql");
                    yaz.WriteElementString("ID", "1");
                    yaz.WriteElementString("Server", txtSunucuAdi.Text);
                    yaz.WriteElementString("Database", txtVeritabaniAdi.Text);
                    yaz.WriteElementString("UserID", txtKullaniciAdi.Text);
                    yaz.WriteElementString("Password", Ayar.Sifrele(txtSifre.Text, txtAnahtar.Text));
                    yaz.WriteElementString("Anahtar", txtAnahtar.Text);
                    yaz.WriteEndElement();
                    yaz.WriteEndElement();
                    yaz.Close();

                    MessageBox.Show("Ayarlar dosyanız oluştu. Programı yeniden başladıktan sonra kullanıma hazır olacaktır.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata mesajı : " + ex.Message, "Hata Alındı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Tüm alanları doldurmanız gerekir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}