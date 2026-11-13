using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TeknikServis
{
    public partial class frmCihazKayit : Form
    {
        bool musteriVarMi = false;
        int mevcutMusteriID = 0;

        public frmCihazKayit()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Doldur()
        {
            using (SqlConnection con = new SqlConnection(Ayar.conString))
            {
                SqlDataAdapter daMarka = new SqlDataAdapter("SELECT * FROM Markalar WHERE Silindi=0", con);
                DataTable dtMarka = new DataTable();
                daMarka.Fill(dtMarka);
                cmbMarka.DisplayMember = "MarkaAdi";
                cmbMarka.ValueMember = "MarkaID";
                cmbMarka.DataSource = dtMarka;
                cmbMarka.SelectedIndex = -1;

                SqlDataAdapter daCihaz = new SqlDataAdapter("SELECT * FROM Cihazlar WHERE Silindi=0", con);
                DataTable dtCihaz = new DataTable();
                daCihaz.Fill(dtCihaz);
                cmbCihazTuru.DisplayMember = "CihazAdi";
                cmbCihazTuru.ValueMember = "CihazID";
                cmbCihazTuru.DataSource = dtCihaz;
                cmbCihazTuru.SelectedIndex = -1;

                SqlDataAdapter daIslem = new SqlDataAdapter("SELECT * FROM Islemler WHERE Silindi=0", con);
                DataTable dtIslem = new DataTable();
                daIslem.Fill(dtIslem);
                cmbDurum.DisplayMember = "IslemAdi";
                cmbDurum.ValueMember = "IslemID";
                cmbDurum.DataSource = dtIslem;
                cmbDurum.SelectedIndex = -1;
            }
        }

        private void Temizle()
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox || item is MaskedTextBox || item is RichTextBox || item is ComboBox)
                    item.Text = "";
            }
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox || item is MaskedTextBox || item is RichTextBox || item is ComboBox)
                    item.Text = "";
            }
            Doldur();
        }

        private void frmCihazKayit_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {
            if (txtTC.Text.Trim().Length == 11)
            {
                using (SqlConnection con = new SqlConnection(Ayar.conString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Musteriler WHERE TC=@p1", con);
                    cmd.Parameters.AddWithValue("@p1", txtTC.Text.Trim());
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        musteriVarMi = true;
                        mevcutMusteriID = Convert.ToInt32(dr["MusteriID"]);
                        txtAdSoyad.Text = dr["AdSoyad"].ToString();
                        txtAdres.Text = dr["Adres"].ToString();
                        txtMail.Text = dr["Mail"].ToString();
                        txtTelefon.Text = dr["Telefon"].ToString();
                    }
                    else
                    {
                        musteriVarMi = false;
                        mevcutMusteriID = 0;
                    }
                }
            }
            else
            {
                musteriVarMi = false;
                mevcutMusteriID = 0;
            }
        }

        private void btnCihazKaydet_Click(object sender, EventArgs e)
        {
            bool durum1 = true;
            bool durum2 = true;

            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox || item is MaskedTextBox || item is RichTextBox || item is ComboBox)
                {
                    if (string.IsNullOrWhiteSpace(item.Text))
                    {
                        durum1 = false;
                        break;
                    }
                }
            }

            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox || item is MaskedTextBox || item is RichTextBox || item is ComboBox)
                {
                    if (string.IsNullOrWhiteSpace(item.Text))
                    {
                        durum2 = false;
                        break;
                    }
                }
            }

            if (!durum1 || !durum2)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(Ayar.conString))
                {
                    con.Open();
                    int musteriId = mevcutMusteriID;

                    // 1. Müşteriyi Kaydet veya Güncelle
                    if (!musteriVarMi)
                    {
                        SqlCommand cmdMusteri = new SqlCommand("INSERT INTO Musteriler (TC, AdSoyad, Mail, Telefon, Adres, KayitTarihi, KaydedenPersonel) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7); SELECT SCOPE_IDENTITY();", con);
                        cmdMusteri.Parameters.AddWithValue("@p1", txtTC.Text.Trim());
                        cmdMusteri.Parameters.AddWithValue("@p2", txtAdSoyad.Text.Trim());
                        cmdMusteri.Parameters.AddWithValue("@p3", txtMail.Text.Trim());
                        cmdMusteri.Parameters.AddWithValue("@p4", txtTelefon.Text.Trim());
                        cmdMusteri.Parameters.AddWithValue("@p5", txtAdres.Text.Trim());
                        cmdMusteri.Parameters.AddWithValue("@p6", DateTime.Now);
                        cmdMusteri.Parameters.AddWithValue("@p7", Ayar.KullaniciID);
                        musteriId = Convert.ToInt32(cmdMusteri.ExecuteScalar());
                    }
                    else
                    {
                        SqlCommand cmdMusteri = new SqlCommand("UPDATE Musteriler SET AdSoyad=@p2, Mail=@p3, Telefon=@p4, Adres=@p5, KayitTarihi=@p6, KaydedenPersonel=@p7 WHERE TC=@p1", con);
                        cmdMusteri.Parameters.AddWithValue("@p1", txtTC.Text.Trim());
                        cmdMusteri.Parameters.AddWithValue("@p2", txtAdSoyad.Text.Trim());
                        cmdMusteri.Parameters.AddWithValue("@p3", txtMail.Text.Trim());
                        cmdMusteri.Parameters.AddWithValue("@p4", txtTelefon.Text.Trim());
                        cmdMusteri.Parameters.AddWithValue("@p5", txtAdres.Text.Trim());
                        cmdMusteri.Parameters.AddWithValue("@p6", DateTime.Now);
                        cmdMusteri.Parameters.AddWithValue("@p7", Ayar.KullaniciID);
                        cmdMusteri.ExecuteNonQuery();
                    }

                    // 2. Arıza Kayıt Tablosuna Ekle ve Kayıt ID'sini Al
                    SqlCommand cmdAriza = new SqlCommand("INSERT INTO ArizaKayit (MusteriID, CihazID, MarkaID, Model, Sikayet, TahminiArizaSebebi, KayitTarihi, Durumu) VALUES (@mId, @p1, @p2, @p3, @p4, @p5, @p6, @p7); SELECT SCOPE_IDENTITY();", con);
                    cmdAriza.Parameters.AddWithValue("@mId", musteriId);
                    cmdAriza.Parameters.AddWithValue("@p1", cmbCihazTuru.SelectedValue);
                    cmdAriza.Parameters.AddWithValue("@p2", cmbMarka.SelectedValue);
                    cmdAriza.Parameters.AddWithValue("@p3", txtModel.Text.Trim().ToUpper());
                    cmdAriza.Parameters.AddWithValue("@p4", txtSikayet.Text.Trim());
                    cmdAriza.Parameters.AddWithValue("@p5", txtArizaTahmin.Text.Trim());
                    cmdAriza.Parameters.AddWithValue("@p6", DateTime.Now);
                    cmdAriza.Parameters.AddWithValue("@p7", cmbDurum.SelectedValue);
                    int kayitId = Convert.ToInt32(cmdAriza.ExecuteScalar());

                    // 3. Arıza Detay Tablosuna Ekle
                    SqlCommand cmdDetay = new SqlCommand("INSERT INTO ArizaDetay (KayitID, IslemTarihi, YapilanIslem, YapanPersonel) VALUES (@p1, @p2, @p3, @p4)", con);
                    cmdDetay.Parameters.AddWithValue("@p1", kayitId);
                    cmdDetay.Parameters.AddWithValue("@p2", DateTime.Now);
                    cmdDetay.Parameters.AddWithValue("@p3", cmbDurum.Text);
                    cmdDetay.Parameters.AddWithValue("@p4", Ayar.KullaniciID);
                    cmdDetay.ExecuteNonQuery();
                }

                MessageBox.Show("Kayıt başarıyla gerçekleşti.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}