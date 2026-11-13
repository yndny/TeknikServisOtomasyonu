using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TeknikServis
{
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }

        private void PanelleriKapat()
        {
            // Sistem Ayarları
            PnlMarkaIslemleri.Visible = false;
            PnlSistemCihazIslemleri.Visible = false;
            PnlYedekParcaKategori.Visible = false;
            PnlYedekParcaIslemleri.Visible = false;
            PnlYetkiIslemleri.Visible = false;

            // Personel İşlemleri
            PnlPersonelEkle.Visible = false;
            PnlPersonelDuzenle.Visible = false;
        }

        // ==================== ÜST MENÜ BUTONLARI ====================
        private void button1_Click(object sender, EventArgs e)
        {
            PanelleriKapat();
            if (PnlCihaz.Visible == false)
            {
                button1.BackColor = Color.DarkCyan;
                button2.BackColor = Color.FromArgb(30, 30, 40);
                button3.BackColor = Color.FromArgb(30, 30, 40);
                button4.BackColor = Color.FromArgb(30, 30, 40);
                button5.BackColor = Color.FromArgb(30, 30, 40);

                PnlCihaz.Visible = true;
                PnlPersonel.Visible = false;
                PnlSistem.Visible = false;
                PnlCari.Visible = false;
            }
            else
            {
                PnlCihaz.Visible = false;
                button1.BackColor = Color.FromArgb(30, 30, 40);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PanelleriKapat();
            if (PnlCari.Visible == false)
            {
                button2.BackColor = Color.DarkCyan;
                button1.BackColor = Color.FromArgb(30, 30, 40);
                button3.BackColor = Color.FromArgb(30, 30, 40);
                button4.BackColor = Color.FromArgb(30, 30, 40);
                button5.BackColor = Color.FromArgb(30, 30, 40);

                PnlCari.Visible = true;
                PnlPersonel.Visible = false;
                PnlSistem.Visible = false;
                PnlCihaz.Visible = false;
            }
            else
            {
                PnlCari.Visible = false;
                button2.BackColor = Color.FromArgb(30, 30, 40);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PanelleriKapat();
            if (PnlPersonel.Visible == false)
            {
                button3.BackColor = Color.DarkCyan;
                button1.BackColor = Color.FromArgb(30, 30, 40);
                button2.BackColor = Color.FromArgb(30, 30, 40);
                button4.BackColor = Color.FromArgb(30, 30, 40);
                button5.BackColor = Color.FromArgb(30, 30, 40);

                PnlPersonel.Visible = true;
                PnlCari.Visible = false;
                PnlSistem.Visible = false;
                PnlCihaz.Visible = false;
            }
            else
            {
                PnlPersonel.Visible = false;
                button3.BackColor = Color.FromArgb(30, 30, 40);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PanelleriKapat();
            if (PnlSistem.Visible == false)
            {
                button4.BackColor = Color.DarkCyan;
                button1.BackColor = Color.FromArgb(30, 30, 40);
                button2.BackColor = Color.FromArgb(30, 30, 40);
                button3.BackColor = Color.FromArgb(30, 30, 40);
                button5.BackColor = Color.FromArgb(30, 30, 40);

                PnlSistem.Visible = true;
                PnlPersonel.Visible = false;
                PnlCari.Visible = false;
                PnlCihaz.Visible = false;
            }
            else
            {
                PnlSistem.Visible = false;
                button4.BackColor = Color.FromArgb(30, 30, 40);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Close();
            login.Show();
        }

        // ==================== VERİ DOLDURMA FONKSİYONLARI ====================
        private void MarkaDoldur()
        {
            using (SqlConnection con = new SqlConnection(Ayar.conString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Markalar WHERE Silindi=0", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                lstMarkaIslemleriMarkalar.DisplayMember = "MarkaAdi";
                lstMarkaIslemleriMarkalar.ValueMember = "MarkaID";
                lstMarkaIslemleriMarkalar.DataSource = dt;

                DataTable dtCombo = dt.Copy();
                cmbYedekParcaIslemleriMarka.DisplayMember = "MarkaAdi";
                cmbYedekParcaIslemleriMarka.ValueMember = "MarkaID";
                cmbYedekParcaIslemleriMarka.DataSource = dtCombo;
                cmbYedekParcaIslemleriMarka.SelectedIndex = -1;
            }
        }

        private void CihazDoldur()
        {
            using (SqlConnection con = new SqlConnection(Ayar.conString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Cihazlar WHERE Silindi=0", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                lstCihazIslemleriCihazlar.DisplayMember = "CihazAdi";
                lstCihazIslemleriCihazlar.ValueMember = "CihazID";
                lstCihazIslemleriCihazlar.DataSource = dt;
            }
        }

        private void KategoriDoldur()
        {
            using (SqlConnection con = new SqlConnection(Ayar.conString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM YedekParcaUstKategori WHERE Silindi=0", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                lstYedekParcaKategoriIslemleri.DisplayMember = "KategoriAdi";
                lstYedekParcaKategoriIslemleri.ValueMember = "KategoriID";
                lstYedekParcaKategoriIslemleri.DataSource = dt;

                DataTable dtList = dt.Copy();
                lstYedekParcaIslemleri.DataSource = null;
                lstYedekParcaIslemleri.DisplayMember = "KategoriAdi";
                lstYedekParcaIslemleri.ValueMember = "KategoriID";
                lstYedekParcaIslemleri.DataSource = dtList;

                DataTable dtCombo = dt.Copy();
                cmbYedekParcaIslemleriKategori.DisplayMember = "KategoriAdi";
                cmbYedekParcaIslemleriKategori.ValueMember = "KategoriID";
                cmbYedekParcaIslemleriKategori.DataSource = dtCombo;
                cmbYedekParcaIslemleriKategori.SelectedIndex = -1;

                lblYedekParcaIslemleri.Text = "KATEGORİLER";
                lblYedekParcaIslemleri.BackColor = Color.Tomato;
            }
        }

        private void YetkiDoldur()
        {
            using (SqlConnection con = new SqlConnection(Ayar.conString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Yetkilendirme", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbYetkiler.DisplayMember = "YetkiAdi";
                cmbYetkiler.ValueMember = "YetkiID";
                cmbYetkiler.DataSource = dt;
                cmbYetkiler.SelectedIndex = -1;

                DataTable dtPE = dt.Copy();
                cmbPersonelEkleYetki.DisplayMember = "YetkiAdi";
                cmbPersonelEkleYetki.ValueMember = "YetkiID";
                cmbPersonelEkleYetki.DataSource = dtPE;
                cmbPersonelEkleYetki.SelectedIndex = -1;

                DataTable dtPD = dt.Copy();
                cmbPersonelDuzenleYetki.DisplayMember = "YetkiAdi";
                cmbPersonelDuzenleYetki.ValueMember = "YetkiID";
                cmbPersonelDuzenleYetki.DataSource = dtPD;
                cmbPersonelDuzenleYetki.SelectedIndex = -1;
            }

            chcCariIslemler.Checked = false;
            chcKayitAcma.Checked = false;
            chcKayitTamamlama.Checked = false;
            chcPersonelEkleme.Checked = false;
            chcPersonelSilme.Checked = false;
            chcSistemAyarlari.Checked = false;
            chcYedekParca.Checked = false;

            cmbYetkiler.Visible = true;
            txtYetkiAdi.Visible = false;
            txtYetkiAdi.Text = "";
            btnYetkiGrubuEkle.Visible = true;
        }

        private void PersonelDoldur()
        {
            using (SqlConnection con = new SqlConnection(Ayar.conString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Personel WHERE Silindi=0", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                lstPersonelAdlari.DataSource = null;
                lstPersonelAdlari.DisplayMember = "AdSoyad";
                lstPersonelAdlari.ValueMember = "PersonelID";
                lstPersonelAdlari.DataSource = dt;
            }
        }

        // ==================== 1. MARKA İŞLEMLERİ ====================
        private void btnMarkaIslemleri_Click(object sender, EventArgs e)
        {
            PanelleriKapat();
            PnlMarkaIslemleri.Visible = true;

            btnMarkaGuncelle.Enabled = false;
            btnMarkaSil.Enabled = false;
            btnYeniMarka.Enabled = true;
            txtMarkaIslemleriMarkaAdi.Text = "";
            lblMarkaIslemleriMarkaID.Text = "";

            MarkaDoldur();
        }

        private void lstMarkaIslemleriMarkalar_DoubleClick(object sender, EventArgs e)
        {
            if (lstMarkaIslemleriMarkalar.SelectedValue == null) return;

            btnMarkaGuncelle.Enabled = true;
            btnMarkaSil.Enabled = true;
            btnYeniMarka.Enabled = false;

            txtMarkaIslemleriMarkaAdi.Text = lstMarkaIslemleriMarkalar.Text;
            lblMarkaIslemleriMarkaID.Text = lstMarkaIslemleriMarkalar.SelectedValue.ToString();
        }

        private void btnYeniMarka_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMarkaIslemleriMarkaAdi.Text))
            {
                MessageBox.Show("Lütfen Marka Adı alanını doldurunuz.", "Boş Alan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(Ayar.conString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Markalar (MarkaAdi, Silindi) VALUES (@p1, 0)", con);
                    cmd.Parameters.AddWithValue("@p1", txtMarkaIslemleriMarkaAdi.Text.Trim().ToUpper());
                    cmd.ExecuteNonQuery();
                }
                MarkaDoldur();
                txtMarkaIslemleriMarkaAdi.Text = "";
                lblMarkaIslemleriMarkaID.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Sistemsel Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMarkaGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMarkaIslemleriMarkaAdi.Text) || string.IsNullOrWhiteSpace(lblMarkaIslemleriMarkaID.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Boş Alan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(Ayar.conString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Markalar SET MarkaAdi=@p1 WHERE MarkaID=@p2", con);
                    cmd.Parameters.AddWithValue("@p1", txtMarkaIslemleriMarkaAdi.Text.Trim().ToUpper());
                    cmd.Parameters.AddWithValue("@p2", lblMarkaIslemleriMarkaID.Text);
                    cmd.ExecuteNonQuery();
                }
                MarkaDoldur();
                txtMarkaIslemleriMarkaAdi.Text = "";
                lblMarkaIslemleriMarkaID.Text = "";
                btnMarkaGuncelle.Enabled = false;
                btnMarkaSil.Enabled = false;
                btnYeniMarka.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Sistemsel Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMarkaSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblMarkaIslemleriMarkaID.Text)) return;

            using (SqlConnection con = new SqlConnection(Ayar.conString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Markalar SET Silindi=1 WHERE MarkaID=@p1", con);
                cmd.Parameters.AddWithValue("@p1", lblMarkaIslemleriMarkaID.Text);
                cmd.ExecuteNonQuery();
            }

            txtMarkaIslemleriMarkaAdi.Text = "";
            lblMarkaIslemleriMarkaID.Text = "";
            MarkaDoldur();
            btnMarkaGuncelle.Enabled = false;
            btnMarkaSil.Enabled = false;
            btnYeniMarka.Enabled = true;
        }

        // ==================== 2. CİHAZ İŞLEMLERİ ====================
        private void btnCihazIslemleri_Click(object sender, EventArgs e)
        {
            PanelleriKapat();
            PnlSistemCihazIslemleri.Visible = true;

            btnCihazGuncelle.Enabled = false;
            btnCihazSil.Enabled = false;
            btnYeniCihaz.Enabled = true;
            txtCihazIslemleriCihazAdi.Text = "";
            lblCihazIslemleriCihazID.Text = "";

            CihazDoldur();
        }

        private void lstCihazIslemleriCihazlar_DoubleClick(object sender, EventArgs e)
        {
            if (lstCihazIslemleriCihazlar.SelectedValue == null) return;

            btnCihazGuncelle.Enabled = true;
            btnCihazSil.Enabled = true;
            btnYeniCihaz.Enabled = false;

            txtCihazIslemleriCihazAdi.Text = lstCihazIslemleriCihazlar.Text;
            lblCihazIslemleriCihazID.Text = lstCihazIslemleriCihazlar.SelectedValue.ToString();
        }

        private void btnYeniCihaz_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCihazIslemleriCihazAdi.Text))
            {
                MessageBox.Show("Lütfen Cihaz Adı alanını doldurunuz.", "Boş Alan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(Ayar.conString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Cihazlar (CihazAdi, Silindi) VALUES (@p1, 0)", con);
                cmd.Parameters.AddWithValue("@p1", txtCihazIslemleriCihazAdi.Text.Trim().ToUpper());
                cmd.ExecuteNonQuery();
            }

            CihazDoldur();
            txtCihazIslemleriCihazAdi.Text = "";
            lblCihazIslemleriCihazID.Text = "";
        }

        private void btnCihazGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCihazIslemleriCihazAdi.Text) || string.IsNullOrWhiteSpace(lblCihazIslemleriCihazID.Text))
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.", "Boş Alan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(Ayar.conString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Cihazlar SET CihazAdi=@p1 WHERE CihazID=@p2", con);
                cmd.Parameters.AddWithValue("@p1", txtCihazIslemleriCihazAdi.Text.Trim().ToUpper());
                cmd.Parameters.AddWithValue("@p2", lblCihazIslemleriCihazID.Text);
                cmd.ExecuteNonQuery();
            }

            CihazDoldur();
            txtCihazIslemleriCihazAdi.Text = "";
            lblCihazIslemleriCihazID.Text = "";
            btnCihazGuncelle.Enabled = false;
            btnCihazSil.Enabled = false;
            btnYeniCihaz.Enabled = true;
        }

        private void btnCihazSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblCihazIslemleriCihazID.Text)) return;

            using (SqlConnection con = new SqlConnection(Ayar.conString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Cihazlar SET Silindi=1 WHERE CihazID=@p1", con);
                cmd.Parameters.AddWithValue("@p1", lblCihazIslemleriCihazID.Text);
                cmd.ExecuteNonQuery();
            }

            CihazDoldur();
            txtCihazIslemleriCihazAdi.Text = "";
            lblCihazIslemleriCihazID.Text = "";
            btnCihazGuncelle.Enabled = false;
            btnCihazSil.Enabled = false;
            btnYeniCihaz.Enabled = true;
        }

        // ==================== 3. YEDEK PARÇA KATEGORİ İŞLEMLERİ ====================
        private void btnYedekParcaKategorisi_Click(object sender, EventArgs e)
        {
            PanelleriKapat();
            PnlYedekParcaKategori.Visible = true;

            btnYedekParcaKategoriGuncelle.Enabled = false;
            btnYedekParcaKategoriSil.Enabled = false;
            btnYedekParcaYeniKategori.Enabled = true;
            txtYedekParcaKategoriAdi.Text = "";
            lblYedekParcaKategoriIslemleriID.Text = "";

            KategoriDoldur();
        }

        private void lstYedekParcaKategoriIslemleri_DoubleClick(object sender, EventArgs e)
        {
            if (lstYedekParcaKategoriIslemleri.SelectedValue == null) return;

            btnYedekParcaKategoriGuncelle.Enabled = true;
            btnYedekParcaKategoriSil.Enabled = true;
            btnYedekParcaYeniKategori.Enabled = false;

            txtYedekParcaKategoriAdi.Text = lstYedekParcaKategoriIslemleri.Text;
            lblYedekParcaKategoriIslemleriID.Text = lstYedekParcaKategoriIslemleri.SelectedValue.ToString();
        }

        private void btnYedekParcaYeniKategori_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtYedekParcaKategoriAdi.Text))
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.", "Boş Alan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(Ayar.conString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO YedekParcaUstKategori (KategoriAdi, Silindi) VALUES (@p1, 0)", con);
                cmd.Parameters.AddWithValue("@p1", txtYedekParcaKategoriAdi.Text.Trim().ToUpper());
                cmd.ExecuteNonQuery();
            }

            KategoriDoldur();
            txtYedekParcaKategoriAdi.Text = "";
            lblYedekParcaKategoriIslemleriID.Text = "";
        }

        private void btnYedekParcaKategoriGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtYedekParcaKategoriAdi.Text) || string.IsNullOrWhiteSpace(lblYedekParcaKategoriIslemleriID.Text))
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız.", "Boş Alan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(Ayar.conString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE YedekParcaUstKategori SET KategoriAdi=@p1 WHERE KategoriID=@p2", con);
                cmd.Parameters.AddWithValue("@p1", txtYedekParcaKategoriAdi.Text.Trim().ToUpper());
                cmd.Parameters.AddWithValue("@p2", lblYedekParcaKategoriIslemleriID.Text);
                cmd.ExecuteNonQuery();
            }

            KategoriDoldur();
            txtYedekParcaKategoriAdi.Text = "";
            lblYedekParcaKategoriIslemleriID.Text = "";
            btnYedekParcaKategoriGuncelle.Enabled = false;
            btnYedekParcaKategoriSil.Enabled = false;
            btnYedekParcaYeniKategori.Enabled = true;
        }

        private void btnYedekParcaKategoriSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblYedekParcaKategoriIslemleriID.Text)) return;

            using (SqlConnection con = new SqlConnection(Ayar.conString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE YedekParcaUstKategori SET Silindi=1 WHERE KategoriID=@p1", con);
                cmd.Parameters.AddWithValue("@p1", lblYedekParcaKategoriIslemleriID.Text);
                cmd.ExecuteNonQuery();
            }

            KategoriDoldur();
            txtYedekParcaKategoriAdi.Text = "";
            lblYedekParcaKategoriIslemleriID.Text = "";
            btnYedekParcaKategoriGuncelle.Enabled = false;
            btnYedekParcaKategoriSil.Enabled = false;
            btnYedekParcaYeniKategori.Enabled = true;
        }

        // ==================== 4. YEDEK PARÇA İŞLEMLERİ ====================
        private void YedekParcaAlanlariSifirla()
        {
            KategoriDoldur();
            MarkaDoldur();

            lblYedekParcaIslemleriYedekParcaID.Text = "";
            txtYedekParcaIslemleriModel.Text = "";
            txtYedekParcaIslemleriStok.Text = "";
            txtYedekParcaIslemleriEkOzellikler.Text = "";

            btnYedekParcaIslemleriGuncelle.Enabled = false;
            btnYedekParcaIslemleriSil.Enabled = false;
            btnYedekParcaIslemleriYeni.Enabled = true;
        }

        private void btnYedekParcaIslemleri_Click(object sender, EventArgs e)
        {
            PanelleriKapat();
            PnlYedekParcaIslemleri.Visible = true;
            YedekParcaAlanlariSifirla();
        }

        private void lstYedekParcaIslemleri_DoubleClick(object sender, EventArgs e)
        {
            if (lstYedekParcaIslemleri.SelectedValue == null) return;

            if (lblYedekParcaIslemleri.Text == "KATEGORİLER")
            {
                int secilenKatId = int.Parse(lstYedekParcaIslemleri.SelectedValue.ToString());
                cmbYedekParcaIslemleriKategori.SelectedValue = secilenKatId;

                using (SqlConnection con = new SqlConnection(Ayar.conString))
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM YedekParca WHERE KategoriID=" + secilenKatId, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    lstYedekParcaIslemleri.DataSource = null;
                    lstYedekParcaIslemleri.DisplayMember = "Model";
                    lstYedekParcaIslemleri.ValueMember = "YedekParcaID";
                    lstYedekParcaIslemleri.DataSource = dt;

                    lblYedekParcaIslemleri.Text = "MODELLER";
                    lblYedekParcaIslemleri.BackColor = Color.Firebrick;
                }
            }
            else if (lblYedekParcaIslemleri.Text == "MODELLER")
            {
                int secilenParcaId = int.Parse(lstYedekParcaIslemleri.SelectedValue.ToString());
                lblYedekParcaIslemleriYedekParcaID.Text = secilenParcaId.ToString();

                using (SqlConnection con = new SqlConnection(Ayar.conString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM YedekParca WHERE YedekParcaID=@p1", con);
                    cmd.Parameters.AddWithValue("@p1", secilenParcaId);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        cmbYedekParcaIslemleriKategori.SelectedValue = dr["KategoriID"];
                        cmbYedekParcaIslemleriMarka.SelectedValue = dr["Marka"];
                        txtYedekParcaIslemleriModel.Text = dr["Model"].ToString();
                        txtYedekParcaIslemleriStok.Text = dr["Stok"].ToString();
                        txtYedekParcaIslemleriEkOzellikler.Text = dr["Ozellikler"].ToString();

                        btnYedekParcaIslemleriGuncelle.Enabled = true;
                        btnYedekParcaIslemleriSil.Enabled = true;
                        btnYedekParcaIslemleriYeni.Enabled = false;
                    }
                }
            }
        }

        private void btnYedekParcaIslemleriYeni_Click(object sender, EventArgs e)
        {
            if (txtYedekParcaIslemleriModel.Text != "" && txtYedekParcaIslemleriStok.Text != "" && txtYedekParcaIslemleriEkOzellikler.Text != "" && cmbYedekParcaIslemleriKategori.Text != "" && cmbYedekParcaIslemleriMarka.Text != "")
            {
                using (SqlConnection con = new SqlConnection(Ayar.conString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO YedekParca (KategoriID, Marka, Model, Stok, Ozellikler, EkleyenPersonel) VALUES (@p1, @p2, @p3, @p4, @p5, @p6)", con);
                    cmd.Parameters.AddWithValue("@p1", cmbYedekParcaIslemleriKategori.SelectedValue);
                    cmd.Parameters.AddWithValue("@p2", cmbYedekParcaIslemleriMarka.SelectedValue);
                    cmd.Parameters.AddWithValue("@p3", txtYedekParcaIslemleriModel.Text.Trim().ToUpper());
                    cmd.Parameters.AddWithValue("@p4", int.Parse(txtYedekParcaIslemleriStok.Text.Trim()));
                    cmd.Parameters.AddWithValue("@p5", txtYedekParcaIslemleriEkOzellikler.Text.Trim());
                    cmd.Parameters.AddWithValue("@p6", Ayar.KullaniciID);
                    cmd.ExecuteNonQuery();
                }
                YedekParcaAlanlariSifirla();
            }
            else
            {
                MessageBox.Show("Boş alan bırakmayınız!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnYedekParcaIslemleriGuncelle_Click(object sender, EventArgs e)
        {
            if (txtYedekParcaIslemleriModel.Text != "" && txtYedekParcaIslemleriStok.Text != "" && txtYedekParcaIslemleriEkOzellikler.Text != "" && cmbYedekParcaIslemleriKategori.Text != "" && cmbYedekParcaIslemleriMarka.Text != "" && lblYedekParcaIslemleriYedekParcaID.Text != "")
            {
                using (SqlConnection con = new SqlConnection(Ayar.conString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE YedekParca SET KategoriID=@p1, Marka=@p2, Model=@p3, Stok=@p4, Ozellikler=@p5 WHERE YedekParcaID=@p6", con);
                    cmd.Parameters.AddWithValue("@p1", cmbYedekParcaIslemleriKategori.SelectedValue);
                    cmd.Parameters.AddWithValue("@p2", cmbYedekParcaIslemleriMarka.SelectedValue);
                    cmd.Parameters.AddWithValue("@p3", txtYedekParcaIslemleriModel.Text.Trim().ToUpper());
                    cmd.Parameters.AddWithValue("@p4", int.Parse(txtYedekParcaIslemleriStok.Text.Trim()));
                    cmd.Parameters.AddWithValue("@p5", txtYedekParcaIslemleriEkOzellikler.Text.Trim());
                    cmd.Parameters.AddWithValue("@p6", lblYedekParcaIslemleriYedekParcaID.Text);
                    cmd.ExecuteNonQuery();
                }
                YedekParcaAlanlariSifirla();
            }
            else
            {
                MessageBox.Show("Boş alan bırakmayınız!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnYedekParcaIslemleriSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lblYedekParcaIslemleriYedekParcaID.Text)) return;

            using (SqlConnection con = new SqlConnection(Ayar.conString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM YedekParca WHERE YedekParcaID=@p1", con);
                cmd.Parameters.AddWithValue("@p1", lblYedekParcaIslemleriYedekParcaID.Text);
                cmd.ExecuteNonQuery();
            }
            YedekParcaAlanlariSifirla();
        }

        // ==================== 5. YETKİ İŞLEMLERİ ====================
        private void btnYetkiIslemleri_Click(object sender, EventArgs e)
        {
            PanelleriKapat();
            PnlYetkiIslemleri.Visible = true;
            YetkiDoldur();
        }

        private void cmbYetkiler_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbYetkiler.SelectedValue == null) return;

            using (SqlConnection con = new SqlConnection(Ayar.conString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Yetkilendirme WHERE YetkiID=@p1", con);
                cmd.Parameters.AddWithValue("@p1", cmbYetkiler.SelectedValue);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    chcPersonelEkleme.Checked = dr[2].ToString() == "True" || dr[2].ToString() == "1";
                    chcPersonelSilme.Checked = dr[3].ToString() == "True" || dr[3].ToString() == "1";
                    chcKayitAcma.Checked = dr[4].ToString() == "True" || dr[4].ToString() == "1";
                    chcKayitTamamlama.Checked = dr[5].ToString() == "True" || dr[5].ToString() == "1";
                    chcYedekParca.Checked = dr[6].ToString() == "True" || dr[6].ToString() == "1";
                    chcCariIslemler.Checked = dr[7].ToString() == "True" || dr[7].ToString() == "1";
                    chcSistemAyarlari.Checked = dr[8].ToString() == "True" || dr[8].ToString() == "1";
                }
            }
        }

        private void btnYetkiGrubuEkle_Click(object sender, EventArgs e)
        {
            YetkiDoldur();
            txtYetkiAdi.Visible = true;
            cmbYetkiler.Visible = false;
            btnYetkiGrubuEkle.Visible = false;
        }

        private void btnYetkiKaydet_Click(object sender, EventArgs e)
        {
            if (cmbYetkiler.SelectedValue == null && string.IsNullOrWhiteSpace(txtYetkiAdi.Text))
            {
                MessageBox.Show("Boş alanları doldurun ya da bir seçim yapın!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int pEkle = chcPersonelEkleme.Checked ? 1 : 0;
            int pSil = chcPersonelSilme.Checked ? 1 : 0;
            int kAc = chcKayitAcma.Checked ? 1 : 0;
            int kTamamla = chcKayitTamamlama.Checked ? 1 : 0;
            int yParca = chcYedekParca.Checked ? 1 : 0;
            int cIslem = chcCariIslemler.Checked ? 1 : 0;
            int sAyar = chcSistemAyarlari.Checked ? 1 : 0;

            int id = cmbYetkiler.SelectedValue == null ? 0 : int.Parse(cmbYetkiler.SelectedValue.ToString());

            using (SqlConnection con = new SqlConnection(Ayar.conString))
            {
                con.Open();
                if (id > 0 && cmbYetkiler.Visible)
                {
                    SqlCommand updateCmd = new SqlCommand("UPDATE Yetkilendirme SET PersonelEkle=@p1, PersonelSil=@p2, KayitAcma=@p3, KayitTamamlama=@p4, YedekParcaIslemleri=@p5, CariIslemleri=@p6, SistemAyarlari=@p7 WHERE YetkiID=@id", con);
                    updateCmd.Parameters.AddWithValue("@p1", pEkle);
                    updateCmd.Parameters.AddWithValue("@p2", pSil);
                    updateCmd.Parameters.AddWithValue("@p3", kAc);
                    updateCmd.Parameters.AddWithValue("@p4", kTamamla);
                    updateCmd.Parameters.AddWithValue("@p5", yParca);
                    updateCmd.Parameters.AddWithValue("@p6", cIslem);
                    updateCmd.Parameters.AddWithValue("@p7", sAyar);
                    updateCmd.Parameters.AddWithValue("@id", id);
                    updateCmd.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand insertCmd = new SqlCommand("INSERT INTO Yetkilendirme (YetkiAdi, PersonelEkle, PersonelSil, KayitAcma, KayitTamamlama, YedekParcaIslemleri, CariIslemleri, SistemAyarlari) VALUES (@ad, @p1, @p2, @p3, @p4, @p5, @p6, @p7)", con);
                    insertCmd.Parameters.AddWithValue("@ad", txtYetkiAdi.Text.Trim());
                    insertCmd.Parameters.AddWithValue("@p1", pEkle);
                    insertCmd.Parameters.AddWithValue("@p2", pSil);
                    insertCmd.Parameters.AddWithValue("@p3", kAc);
                    insertCmd.Parameters.AddWithValue("@p4", kTamamla);
                    insertCmd.Parameters.AddWithValue("@p5", yParca);
                    insertCmd.Parameters.AddWithValue("@p6", cIslem);
                    insertCmd.Parameters.AddWithValue("@p7", sAyar);
                    insertCmd.ExecuteNonQuery();
                }
            }

            YetkiDoldur();
        }

        // ==================== 6. PERSONEL EKLEME İŞLEMLERİ (#11. Video) ====================
        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            PanelleriKapat();
            YetkiDoldur();
            PnlPersonelEkle.Visible = true;
        }

        private void btnPersonelEkleKaydet_Click(object sender, EventArgs e)
        {
            if (txtPersonelEkleAdSoyad.Text != "" && txtPersonelEkleAdres.Text != "" && txtPersonelEkleMail.Text != "" && txtPersonelEkleGorev.Text != "" && txtPersonelEkleKullaniciAdi.Text != "" && txtPersonelEkleMaas.Text != "" && txtPersonelEkleSifre.Text != "" && txtPersonelEkleTC.Text != "" && txtPersonelEkleTelefon.Text != "" && cmbPersonelEkleYetki.Text != "")
            {
                if (txtPersonelEkleTC.Text.Trim().Length < 11)
                {
                    MessageBox.Show("TC Kimlik numarası 11 karakterden farklı olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection con = new SqlConnection(Ayar.conString))
                {
                    con.Open();
                    SqlCommand kontrol = new SqlCommand("SELECT TC, KullaniciAdi FROM Personel WHERE (TC=@p1 OR KullaniciAdi=@p2) AND Silindi=0", con);
                    kontrol.Parameters.AddWithValue("@p1", txtPersonelEkleTC.Text.Trim());
                    kontrol.Parameters.AddWithValue("@p2", txtPersonelEkleKullaniciAdi.Text.Trim());
                    SqlDataReader dr = kontrol.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Kullanıcı adı veya TC sistemde kayıtlı! Lütfen farklı bir kullanıcı kaydı yapınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    dr.Close();

                    SqlCommand cmd = new SqlCommand("INSERT INTO Personel (TC, KullaniciAdi, AdSoyad, Telefon, Mail, Adres, Gorevi, Yetkisi, Maas, Password, Silindi) VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, 0)", con);
                    cmd.Parameters.AddWithValue("@p1", txtPersonelEkleTC.Text.Trim());
                    cmd.Parameters.AddWithValue("@p2", txtPersonelEkleKullaniciAdi.Text.Trim());
                    cmd.Parameters.AddWithValue("@p3", txtPersonelEkleAdSoyad.Text.Trim());
                    cmd.Parameters.AddWithValue("@p4", txtPersonelEkleTelefon.Text.Trim());
                    cmd.Parameters.AddWithValue("@p5", txtPersonelEkleMail.Text.Trim());
                    cmd.Parameters.AddWithValue("@p6", txtPersonelEkleAdres.Text.Trim());
                    cmd.Parameters.AddWithValue("@p7", txtPersonelEkleGorev.Text.Trim().ToUpper());
                    cmd.Parameters.AddWithValue("@p8", cmbPersonelEkleYetki.SelectedValue);
                    cmd.Parameters.AddWithValue("@p9", txtPersonelEkleMaas.Text.Trim());
                    cmd.Parameters.AddWithValue("@p10", Ayar.Sifrele(txtPersonelEkleSifre.Text.Trim(), Ayar.AnahtarKelime));
                    cmd.ExecuteNonQuery();
                }

                YetkiDoldur();
                foreach (Control item in PnlPersonelEkle.Controls)
                {
                    if (item is TextBox || item is MaskedTextBox || item is RichTextBox)
                        item.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ==================== 7. PERSONEL DÜZENLEME İŞLEMLERİ (#12. Video) ====================
        private void PersonelDuzenleAlanlariTemizle()
        {
            foreach (Control item in PnlPersonelDuzenle.Controls)
            {
                if (item is TextBox || item is MaskedTextBox || item is RichTextBox)
                    item.Text = "";
            }
            btnPersonelDuzenleGuncelle.Enabled = false;
            btnPersonelDuzenleSil.Enabled = false;
        }

        private void btnPersonelDuzenle_Click(object sender, EventArgs e)
        {
            PanelleriKapat();
            YetkiDoldur();
            PersonelDoldur();
            PersonelDuzenleAlanlariTemizle();
            PnlPersonelDuzenle.Visible = true;
        }

        private void lstPersonelAdlari_DoubleClick(object sender, EventArgs e)
        {
            if (lstPersonelAdlari.SelectedValue == null) return;

            using (SqlConnection con = new SqlConnection(Ayar.conString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Personel WHERE PersonelID=@p1", con);
                cmd.Parameters.AddWithValue("@p1", lstPersonelAdlari.SelectedValue);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtPersonelDuzenlePersonelNo.Text = dr["PersonelID"].ToString();
                    txtPersonelDuzenleTC.Text = dr["TC"].ToString().Trim();
                    txtPersonelDuzenleKullaniciAdi.Text = dr["KullaniciAdi"].ToString();
                    txtPersonelDuzenleAdSoyad.Text = dr["AdSoyad"].ToString();
                    txtPersonelDuzenleTelefon.Text = dr["Telefon"].ToString();
                    txtPersonelDuzenleMail.Text = dr["Mail"].ToString();
                    txtPersonelDuzenleAdres.Text = dr["Adres"].ToString();
                    txtPersonelDuzenleGorev.Text = dr["Gorevi"].ToString();
                    cmbPersonelDuzenleYetki.SelectedValue = dr["Yetkisi"];
                    txtPersonelDuzenleMaas.Text = dr["Maas"] != DBNull.Value ? dr["Maas"].ToString() : "";

                    string dbSifre = dr["Password"].ToString();
                    try
                    {
                        txtPersonelDuzenleSifre.Text = Ayar.SifreCoz(dbSifre, Ayar.AnahtarKelime);
                    }
                    catch
                    {
                        txtPersonelDuzenleSifre.Text = dbSifre;
                    }

                    btnPersonelDuzenleGuncelle.Enabled = true;
                    btnPersonelDuzenleSil.Enabled = true;
                }
            }
        }

        private void btnPersonelDuzenleGuncelle_Click(object sender, EventArgs e)
        {
            if (txtPersonelDuzenlePersonelNo.Text != "" && txtPersonelDuzenleAdSoyad.Text != "" && txtPersonelDuzenleAdres.Text != "" && txtPersonelDuzenleMail.Text != "" && txtPersonelDuzenleGorev.Text != "" && txtPersonelDuzenleKullaniciAdi.Text != "" && txtPersonelDuzenleMaas.Text != "" && txtPersonelDuzenleSifre.Text != "" && txtPersonelDuzenleTC.Text != "" && txtPersonelDuzenleTelefon.Text != "" && cmbPersonelDuzenleYetki.Text != "")
            {
                if (txtPersonelDuzenleTC.Text.Trim().Length < 11)
                {
                    MessageBox.Show("TC Kimlik numarası 11 karakterden farklı olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection con = new SqlConnection(Ayar.conString))
                {
                    con.Open();
                    SqlCommand kontrol = new SqlCommand("SELECT TC, KullaniciAdi FROM Personel WHERE (TC=@p1 OR KullaniciAdi=@p2) AND PersonelID != @p3 AND Silindi=0", con);
                    kontrol.Parameters.AddWithValue("@p1", txtPersonelDuzenleTC.Text.Trim());
                    kontrol.Parameters.AddWithValue("@p2", txtPersonelDuzenleKullaniciAdi.Text.Trim());
                    kontrol.Parameters.AddWithValue("@p3", txtPersonelDuzenlePersonelNo.Text.Trim());
                    SqlDataReader dr = kontrol.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Bu TC veya Kullanıcı Adı başka bir personelde kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    dr.Close();

                    SqlCommand cmd = new SqlCommand("UPDATE Personel SET TC=@p1, KullaniciAdi=@p2, AdSoyad=@p3, Telefon=@p4, Mail=@p5, Adres=@p6, Gorevi=@p7, Yetkisi=@p8, Maas=@p9, Password=@p10 WHERE PersonelID=@id", con);
                    cmd.Parameters.AddWithValue("@p1", txtPersonelDuzenleTC.Text.Trim());
                    cmd.Parameters.AddWithValue("@p2", txtPersonelDuzenleKullaniciAdi.Text.Trim());
                    cmd.Parameters.AddWithValue("@p3", txtPersonelDuzenleAdSoyad.Text.Trim());
                    cmd.Parameters.AddWithValue("@p4", txtPersonelDuzenleTelefon.Text.Trim());
                    cmd.Parameters.AddWithValue("@p5", txtPersonelDuzenleMail.Text.Trim());
                    cmd.Parameters.AddWithValue("@p6", txtPersonelDuzenleAdres.Text.Trim());
                    cmd.Parameters.AddWithValue("@p7", txtPersonelDuzenleGorev.Text.Trim().ToUpper());
                    cmd.Parameters.AddWithValue("@p8", cmbPersonelDuzenleYetki.SelectedValue);
                    cmd.Parameters.AddWithValue("@p9", txtPersonelDuzenleMaas.Text.Trim());
                    cmd.Parameters.AddWithValue("@p10", Ayar.Sifrele(txtPersonelDuzenleSifre.Text.Trim(), Ayar.AnahtarKelime));
                    cmd.Parameters.AddWithValue("@id", txtPersonelDuzenlePersonelNo.Text.Trim());
                    cmd.ExecuteNonQuery();
                }

                PersonelDoldur();
                YetkiDoldur();
                PersonelDuzenleAlanlariTemizle();
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPersonelDuzenleSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPersonelDuzenlePersonelNo.Text)) return;

            using (SqlConnection con = new SqlConnection(Ayar.conString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Personel SET Silindi=1 WHERE PersonelID=@p1", con);
                cmd.Parameters.AddWithValue("@p1", txtPersonelDuzenlePersonelNo.Text.Trim());
                cmd.ExecuteNonQuery();
            }

            PersonelDoldur();
            YetkiDoldur();
            PersonelDuzenleAlanlariTemizle();
        }

        // ==================== 8. CİHAZ ARIZA KAYIT FORMU AÇILIŞI (#13. Video) ====================
        private void btnCihazIslemleriCihazKayit_Click(object sender, EventArgs e)
        {
            frmCihazKayit ck = new frmCihazKayit();
            ck.Show();
        }
    }
}