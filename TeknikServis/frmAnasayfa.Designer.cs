namespace TeknikServis
{
    partial class frmAnasayfa
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.PnlUst = new System.Windows.Forms.Panel();
            this.lblKullaniciAdi = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PnlCihaz = new System.Windows.Forms.Panel();
            this.btnCihazIslemleriCihazKayit = new System.Windows.Forms.Button();
            this.PnlCari = new System.Windows.Forms.Panel();
            this.PnlPersonel = new System.Windows.Forms.Panel();
            this.btnPersonelDuzenle = new System.Windows.Forms.Button();
            this.btnPersonelEkle = new System.Windows.Forms.Button();
            this.PnlSistem = new System.Windows.Forms.Panel();
            this.btnYetkiIslemleri = new System.Windows.Forms.Button();
            this.btnYedekParcaIslemleri = new System.Windows.Forms.Button();
            this.btnYedekParcaKategorisi = new System.Windows.Forms.Button();
            this.btnCihazIslemleri = new System.Windows.Forms.Button();
            this.btnMarkaIslemleri = new System.Windows.Forms.Button();
            this.PnlMarkaIslemleri = new System.Windows.Forms.Panel();
            this.btnMarkaSil = new System.Windows.Forms.Button();
            this.btnYeniMarka = new System.Windows.Forms.Button();
            this.btnMarkaGuncelle = new System.Windows.Forms.Button();
            this.txtMarkaIslemleriMarkaAdi = new System.Windows.Forms.TextBox();
            this.lblMarkaAdi = new System.Windows.Forms.Label();
            this.lblMarkaIslemleriMarkaID = new System.Windows.Forms.Label();
            this.lblMarkaIDBaslik = new System.Windows.Forms.Label();
            this.lstMarkaIslemleriMarkalar = new System.Windows.Forms.ListBox();
            this.PnlSistemCihazIslemleri = new System.Windows.Forms.Panel();
            this.btnCihazSil = new System.Windows.Forms.Button();
            this.btnYeniCihaz = new System.Windows.Forms.Button();
            this.btnCihazGuncelle = new System.Windows.Forms.Button();
            this.txtCihazIslemleriCihazAdi = new System.Windows.Forms.TextBox();
            this.lblCihazAdiBaslik = new System.Windows.Forms.Label();
            this.lblCihazIslemleriCihazID = new System.Windows.Forms.Label();
            this.lblCihazIDBaslik = new System.Windows.Forms.Label();
            this.lstCihazIslemleriCihazlar = new System.Windows.Forms.ListBox();
            this.PnlYedekParcaKategori = new System.Windows.Forms.Panel();
            this.btnYedekParcaKategoriSil = new System.Windows.Forms.Button();
            this.btnYedekParcaYeniKategori = new System.Windows.Forms.Button();
            this.btnYedekParcaKategoriGuncelle = new System.Windows.Forms.Button();
            this.txtYedekParcaKategoriAdi = new System.Windows.Forms.TextBox();
            this.lblKatAdiBaslik = new System.Windows.Forms.Label();
            this.lblYedekParcaKategoriIslemleriID = new System.Windows.Forms.Label();
            this.lblKatIDBaslik = new System.Windows.Forms.Label();
            this.lstYedekParcaKategoriIslemleri = new System.Windows.Forms.ListBox();
            this.PnlYedekParcaIslemleri = new System.Windows.Forms.Panel();
            this.btnYedekParcaIslemleriSil = new System.Windows.Forms.Button();
            this.btnYedekParcaIslemleriYeni = new System.Windows.Forms.Button();
            this.btnYedekParcaIslemleriGuncelle = new System.Windows.Forms.Button();
            this.txtYedekParcaIslemleriEkOzellikler = new System.Windows.Forms.TextBox();
            this.lblYPOzellikBaslik = new System.Windows.Forms.Label();
            this.txtYedekParcaIslemleriStok = new System.Windows.Forms.TextBox();
            this.lblYPStokBaslik = new System.Windows.Forms.Label();
            this.txtYedekParcaIslemleriModel = new System.Windows.Forms.TextBox();
            this.lblYPModelBaslik = new System.Windows.Forms.Label();
            this.cmbYedekParcaIslemleriMarka = new System.Windows.Forms.ComboBox();
            this.lblYPMarkaBaslik = new System.Windows.Forms.Label();
            this.cmbYedekParcaIslemleriKategori = new System.Windows.Forms.ComboBox();
            this.lblYPKategoriBaslik = new System.Windows.Forms.Label();
            this.lblYedekParcaIslemleriYedekParcaID = new System.Windows.Forms.Label();
            this.lblYedekParcaIDBaslik = new System.Windows.Forms.Label();
            this.lblYedekParcaIslemleri = new System.Windows.Forms.Label();
            this.lstYedekParcaIslemleri = new System.Windows.Forms.ListBox();
            this.PnlYetkiIslemleri = new System.Windows.Forms.Panel();
            this.grpYetkiler = new System.Windows.Forms.GroupBox();
            this.btnYetkiKaydet = new System.Windows.Forms.Button();
            this.chcSistemAyarlari = new System.Windows.Forms.CheckBox();
            this.chcCariIslemler = new System.Windows.Forms.CheckBox();
            this.chcYedekParca = new System.Windows.Forms.CheckBox();
            this.chcKayitTamamlama = new System.Windows.Forms.CheckBox();
            this.chcKayitAcma = new System.Windows.Forms.CheckBox();
            this.chcPersonelSilme = new System.Windows.Forms.CheckBox();
            this.chcPersonelEkleme = new System.Windows.Forms.CheckBox();
            this.btnYetkiGrubuEkle = new System.Windows.Forms.Button();
            this.txtYetkiAdi = new System.Windows.Forms.TextBox();
            this.cmbYetkiler = new System.Windows.Forms.ComboBox();
            this.lblYetkiGrubuSec = new System.Windows.Forms.Label();
            this.PnlPersonelEkle = new System.Windows.Forms.Panel();
            this.btnPersonelEkleKaydet = new System.Windows.Forms.Button();
            this.txtPersonelEkleSifre = new System.Windows.Forms.TextBox();
            this.lblPESifre = new System.Windows.Forms.Label();
            this.txtPersonelEkleMaas = new System.Windows.Forms.TextBox();
            this.lblPEMaas = new System.Windows.Forms.Label();
            this.txtPersonelEkleAdres = new System.Windows.Forms.TextBox();
            this.lblPEAdres = new System.Windows.Forms.Label();
            this.cmbPersonelEkleYetki = new System.Windows.Forms.ComboBox();
            this.lblPEYetki = new System.Windows.Forms.Label();
            this.txtPersonelEkleGorev = new System.Windows.Forms.TextBox();
            this.lblPEGorev = new System.Windows.Forms.Label();
            this.txtPersonelEkleMail = new System.Windows.Forms.TextBox();
            this.lblPEMail = new System.Windows.Forms.Label();
            this.txtPersonelEkleTelefon = new System.Windows.Forms.MaskedTextBox();
            this.lblPETelefon = new System.Windows.Forms.Label();
            this.txtPersonelEkleAdSoyad = new System.Windows.Forms.TextBox();
            this.lblPEAdSoyad = new System.Windows.Forms.Label();
            this.txtPersonelEkleKullaniciAdi = new System.Windows.Forms.TextBox();
            this.lblPEKadi = new System.Windows.Forms.Label();
            this.txtPersonelEkleTC = new System.Windows.Forms.MaskedTextBox();
            this.lblPETC = new System.Windows.Forms.Label();
            this.PnlPersonelDuzenle = new System.Windows.Forms.Panel();
            this.btnPersonelDuzenleSil = new System.Windows.Forms.Button();
            this.btnPersonelDuzenleGuncelle = new System.Windows.Forms.Button();
            this.txtPersonelDuzenleSifre = new System.Windows.Forms.TextBox();
            this.lblPDSifre = new System.Windows.Forms.Label();
            this.txtPersonelDuzenleMaas = new System.Windows.Forms.TextBox();
            this.lblPDMaas = new System.Windows.Forms.Label();
            this.txtPersonelDuzenleAdres = new System.Windows.Forms.TextBox();
            this.lblPDAdres = new System.Windows.Forms.Label();
            this.cmbPersonelDuzenleYetki = new System.Windows.Forms.ComboBox();
            this.lblPDYetki = new System.Windows.Forms.Label();
            this.txtPersonelDuzenleGorev = new System.Windows.Forms.TextBox();
            this.lblPDGorev = new System.Windows.Forms.Label();
            this.txtPersonelDuzenleMail = new System.Windows.Forms.TextBox();
            this.lblPDMail = new System.Windows.Forms.Label();
            this.txtPersonelDuzenleTelefon = new System.Windows.Forms.MaskedTextBox();
            this.lblPDTelefon = new System.Windows.Forms.Label();
            this.txtPersonelDuzenleAdSoyad = new System.Windows.Forms.TextBox();
            this.lblPDAdSoyad = new System.Windows.Forms.Label();
            this.txtPersonelDuzenleKullaniciAdi = new System.Windows.Forms.TextBox();
            this.lblPDKadi = new System.Windows.Forms.Label();
            this.txtPersonelDuzenleTC = new System.Windows.Forms.MaskedTextBox();
            this.lblPDTC = new System.Windows.Forms.Label();
            this.txtPersonelDuzenlePersonelNo = new System.Windows.Forms.TextBox();
            this.lblPDPersonelNo = new System.Windows.Forms.Label();
            this.lstPersonelAdlari = new System.Windows.Forms.ListBox();
            this.PnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PnlCihaz.SuspendLayout();
            this.PnlPersonel.SuspendLayout();
            this.PnlSistem.SuspendLayout();
            this.PnlMarkaIslemleri.SuspendLayout();
            this.PnlSistemCihazIslemleri.SuspendLayout();
            this.PnlYedekParcaKategori.SuspendLayout();
            this.PnlYedekParcaIslemleri.SuspendLayout();
            this.PnlYetkiIslemleri.SuspendLayout();
            this.grpYetkiler.SuspendLayout();
            this.PnlPersonelEkle.SuspendLayout();
            this.PnlPersonelDuzenle.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlUst
            // 
            this.PnlUst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.PnlUst.Controls.Add(this.lblKullaniciAdi);
            this.PnlUst.Controls.Add(this.pictureBox1);
            this.PnlUst.Controls.Add(this.button5);
            this.PnlUst.Controls.Add(this.button4);
            this.PnlUst.Controls.Add(this.button3);
            this.PnlUst.Controls.Add(this.button2);
            this.PnlUst.Controls.Add(this.button1);
            this.PnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlUst.Location = new System.Drawing.Point(0, 0);
            this.PnlUst.Name = "PnlUst";
            this.PnlUst.Size = new System.Drawing.Size(1289, 87);
            this.PnlUst.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Tomato;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 87);
            this.button1.TabIndex = 0;
            this.button1.Text = "CİHAZ İŞLEMLERİ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Tomato;
            this.button2.Location = new System.Drawing.Point(210, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 87);
            this.button2.TabIndex = 1;
            this.button2.Text = "CARİ İŞLEMLERİ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.Tomato;
            this.button3.Location = new System.Drawing.Point(420, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(210, 87);
            this.button3.TabIndex = 2;
            this.button3.Text = "PERSONEL İŞLEMLERİ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.Tomato;
            this.button4.Location = new System.Drawing.Point(630, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(210, 87);
            this.button4.TabIndex = 3;
            this.button4.Text = "SİSTEM AYARLARI";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.Tomato;
            this.button5.Location = new System.Drawing.Point(840, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(210, 87);
            this.button5.TabIndex = 4;
            this.button5.Text = "ÇIKIŞ YAP";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1145, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.ActiveLinkColor = System.Drawing.Color.Tomato;
            this.lblKullaniciAdi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblKullaniciAdi.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblKullaniciAdi.LinkColor = System.Drawing.Color.Tomato;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(1065, 58);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(210, 23);
            this.lblKullaniciAdi.TabIndex = 6;
            this.lblKullaniciAdi.TabStop = true;
            this.lblKullaniciAdi.Text = "...";
            this.lblKullaniciAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlCihaz
            // 
            this.PnlCihaz.BackColor = System.Drawing.Color.DarkCyan;
            this.PnlCihaz.Controls.Add(this.btnCihazIslemleriCihazKayit);
            this.PnlCihaz.Location = new System.Drawing.Point(0, 87);
            this.PnlCihaz.Name = "PnlCihaz";
            this.PnlCihaz.Size = new System.Drawing.Size(1289, 81);
            this.PnlCihaz.TabIndex = 1;
            this.PnlCihaz.Visible = false;
            // 
            // btnCihazIslemleriCihazKayit
            // 
            this.btnCihazIslemleriCihazKayit.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCihazIslemleriCihazKayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCihazIslemleriCihazKayit.FlatAppearance.BorderSize = 0;
            this.btnCihazIslemleriCihazKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCihazIslemleriCihazKayit.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCihazIslemleriCihazKayit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCihazIslemleriCihazKayit.Location = new System.Drawing.Point(0, 0);
            this.btnCihazIslemleriCihazKayit.Name = "btnCihazIslemleriCihazKayit";
            this.btnCihazIslemleriCihazKayit.Size = new System.Drawing.Size(210, 81);
            this.btnCihazIslemleriCihazKayit.TabIndex = 0;
            this.btnCihazIslemleriCihazKayit.Text = "CİHAZ KAYDI YAP";
            this.btnCihazIslemleriCihazKayit.UseVisualStyleBackColor = false;
            this.btnCihazIslemleriCihazKayit.Click += new System.EventHandler(this.btnCihazIslemleriCihazKayit_Click);
            // 
            // PnlCari
            // 
            this.PnlCari.BackColor = System.Drawing.Color.DarkCyan;
            this.PnlCari.Location = new System.Drawing.Point(0, 87);
            this.PnlCari.Name = "PnlCari";
            this.PnlCari.Size = new System.Drawing.Size(1289, 81);
            this.PnlCari.TabIndex = 2;
            this.PnlCari.Visible = false;
            // 
            // PnlPersonel
            // 
            this.PnlPersonel.BackColor = System.Drawing.Color.DarkCyan;
            this.PnlPersonel.Controls.Add(this.btnPersonelDuzenle);
            this.PnlPersonel.Controls.Add(this.btnPersonelEkle);
            this.PnlPersonel.Location = new System.Drawing.Point(0, 87);
            this.PnlPersonel.Name = "PnlPersonel";
            this.PnlPersonel.Size = new System.Drawing.Size(1289, 81);
            this.PnlPersonel.TabIndex = 3;
            this.PnlPersonel.Visible = false;
            // 
            // btnPersonelEkle
            // 
            this.btnPersonelEkle.BackColor = System.Drawing.Color.DarkCyan;
            this.btnPersonelEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonelEkle.FlatAppearance.BorderSize = 0;
            this.btnPersonelEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonelEkle.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnPersonelEkle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPersonelEkle.Location = new System.Drawing.Point(0, 0);
            this.btnPersonelEkle.Name = "btnPersonelEkle";
            this.btnPersonelEkle.Size = new System.Drawing.Size(210, 81);
            this.btnPersonelEkle.TabIndex = 0;
            this.btnPersonelEkle.Text = "PERSONEL EKLE";
            this.btnPersonelEkle.UseVisualStyleBackColor = false;
            this.btnPersonelEkle.Click += new System.EventHandler(this.btnPersonelEkle_Click);
            // 
            // btnPersonelDuzenle
            // 
            this.btnPersonelDuzenle.BackColor = System.Drawing.Color.DarkCyan;
            this.btnPersonelDuzenle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonelDuzenle.FlatAppearance.BorderSize = 0;
            this.btnPersonelDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonelDuzenle.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnPersonelDuzenle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPersonelDuzenle.Location = new System.Drawing.Point(210, 0);
            this.btnPersonelDuzenle.Name = "btnPersonelDuzenle";
            this.btnPersonelDuzenle.Size = new System.Drawing.Size(210, 81);
            this.btnPersonelDuzenle.TabIndex = 1;
            this.btnPersonelDuzenle.Text = "PERSONEL DÜZENLE";
            this.btnPersonelDuzenle.UseVisualStyleBackColor = false;
            this.btnPersonelDuzenle.Click += new System.EventHandler(this.btnPersonelDuzenle_Click);
            // 
            // PnlSistem
            // 
            this.PnlSistem.BackColor = System.Drawing.Color.DarkCyan;
            this.PnlSistem.Controls.Add(this.btnYetkiIslemleri);
            this.PnlSistem.Controls.Add(this.btnYedekParcaIslemleri);
            this.PnlSistem.Controls.Add(this.btnYedekParcaKategorisi);
            this.PnlSistem.Controls.Add(this.btnCihazIslemleri);
            this.PnlSistem.Controls.Add(this.btnMarkaIslemleri);
            this.PnlSistem.Location = new System.Drawing.Point(0, 87);
            this.PnlSistem.Name = "PnlSistem";
            this.PnlSistem.Size = new System.Drawing.Size(1289, 81);
            this.PnlSistem.TabIndex = 4;
            this.PnlSistem.Visible = false;
            // 
            // btnMarkaIslemleri
            // 
            this.btnMarkaIslemleri.BackColor = System.Drawing.Color.DarkCyan;
            this.btnMarkaIslemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarkaIslemleri.FlatAppearance.BorderSize = 0;
            this.btnMarkaIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkaIslemleri.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnMarkaIslemleri.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMarkaIslemleri.Location = new System.Drawing.Point(0, 0);
            this.btnMarkaIslemleri.Name = "btnMarkaIslemleri";
            this.btnMarkaIslemleri.Size = new System.Drawing.Size(210, 81);
            this.btnMarkaIslemleri.TabIndex = 0;
            this.btnMarkaIslemleri.Text = "MARKA İŞLEMLERİ";
            this.btnMarkaIslemleri.UseVisualStyleBackColor = false;
            this.btnMarkaIslemleri.Click += new System.EventHandler(this.btnMarkaIslemleri_Click);
            // 
            // btnCihazIslemleri
            // 
            this.btnCihazIslemleri.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCihazIslemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCihazIslemleri.FlatAppearance.BorderSize = 0;
            this.btnCihazIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCihazIslemleri.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCihazIslemleri.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCihazIslemleri.Location = new System.Drawing.Point(210, 0);
            this.btnCihazIslemleri.Name = "btnCihazIslemleri";
            this.btnCihazIslemleri.Size = new System.Drawing.Size(210, 81);
            this.btnCihazIslemleri.TabIndex = 1;
            this.btnCihazIslemleri.Text = "CİHAZ İŞLEMLERİ";
            this.btnCihazIslemleri.UseVisualStyleBackColor = false;
            this.btnCihazIslemleri.Click += new System.EventHandler(this.btnCihazIslemleri_Click);
            // 
            // btnYedekParcaKategorisi
            // 
            this.btnYedekParcaKategorisi.BackColor = System.Drawing.Color.DarkCyan;
            this.btnYedekParcaKategorisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYedekParcaKategorisi.FlatAppearance.BorderSize = 0;
            this.btnYedekParcaKategorisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYedekParcaKategorisi.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnYedekParcaKategorisi.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnYedekParcaKategorisi.Location = new System.Drawing.Point(420, 0);
            this.btnYedekParcaKategorisi.Name = "btnYedekParcaKategorisi";
            this.btnYedekParcaKategorisi.Size = new System.Drawing.Size(210, 81);
            this.btnYedekParcaKategorisi.TabIndex = 2;
            this.btnYedekParcaKategorisi.Text = "YEDEK PARÇA\r\nKATEGORİSİ";
            this.btnYedekParcaKategorisi.UseVisualStyleBackColor = false;
            this.btnYedekParcaKategorisi.Click += new System.EventHandler(this.btnYedekParcaKategorisi_Click);
            // 
            // btnYedekParcaIslemleri
            // 
            this.btnYedekParcaIslemleri.BackColor = System.Drawing.Color.DarkCyan;
            this.btnYedekParcaIslemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYedekParcaIslemleri.FlatAppearance.BorderSize = 0;
            this.btnYedekParcaIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYedekParcaIslemleri.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnYedekParcaIslemleri.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnYedekParcaIslemleri.Location = new System.Drawing.Point(630, 0);
            this.btnYedekParcaIslemleri.Name = "btnYedekParcaIslemleri";
            this.btnYedekParcaIslemleri.Size = new System.Drawing.Size(210, 81);
            this.btnYedekParcaIslemleri.TabIndex = 3;
            this.btnYedekParcaIslemleri.Text = "YEDEK PARÇA\r\nİŞLEMLERİ";
            this.btnYedekParcaIslemleri.UseVisualStyleBackColor = false;
            this.btnYedekParcaIslemleri.Click += new System.EventHandler(this.btnYedekParcaIslemleri_Click);
            // 
            // btnYetkiIslemleri
            // 
            this.btnYetkiIslemleri.BackColor = System.Drawing.Color.DarkCyan;
            this.btnYetkiIslemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYetkiIslemleri.FlatAppearance.BorderSize = 0;
            this.btnYetkiIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYetkiIslemleri.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnYetkiIslemleri.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnYetkiIslemleri.Location = new System.Drawing.Point(840, 0);
            this.btnYetkiIslemleri.Name = "btnYetkiIslemleri";
            this.btnYetkiIslemleri.Size = new System.Drawing.Size(210, 81);
            this.btnYetkiIslemleri.TabIndex = 4;
            this.btnYetkiIslemleri.Text = "YETKİ İŞLEMLERİ";
            this.btnYetkiIslemleri.UseVisualStyleBackColor = false;
            this.btnYetkiIslemleri.Click += new System.EventHandler(this.btnYetkiIslemleri_Click);
            // 
            // PnlMarkaIslemleri
            // 
            this.PnlMarkaIslemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.PnlMarkaIslemleri.Controls.Add(this.btnMarkaSil);
            this.PnlMarkaIslemleri.Controls.Add(this.btnYeniMarka);
            this.PnlMarkaIslemleri.Controls.Add(this.btnMarkaGuncelle);
            this.PnlMarkaIslemleri.Controls.Add(this.txtMarkaIslemleriMarkaAdi);
            this.PnlMarkaIslemleri.Controls.Add(this.lblMarkaAdi);
            this.PnlMarkaIslemleri.Controls.Add(this.lblMarkaIslemleriMarkaID);
            this.PnlMarkaIslemleri.Controls.Add(this.lblMarkaIDBaslik);
            this.PnlMarkaIslemleri.Controls.Add(this.lstMarkaIslemleriMarkalar);
            this.PnlMarkaIslemleri.Location = new System.Drawing.Point(0, 168);
            this.PnlMarkaIslemleri.Name = "PnlMarkaIslemleri";
            this.PnlMarkaIslemleri.Size = new System.Drawing.Size(1289, 431);
            this.PnlMarkaIslemleri.TabIndex = 5;
            this.PnlMarkaIslemleri.Visible = false;
            // 
            // lstMarkaIslemleriMarkalar
            // 
            this.lstMarkaIslemleriMarkalar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.lstMarkaIslemleriMarkalar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstMarkaIslemleriMarkalar.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lstMarkaIslemleriMarkalar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lstMarkaIslemleriMarkalar.ItemHeight = 18;
            this.lstMarkaIslemleriMarkalar.Location = new System.Drawing.Point(35, 30);
            this.lstMarkaIslemleriMarkalar.Name = "lstMarkaIslemleriMarkalar";
            this.lstMarkaIslemleriMarkalar.Size = new System.Drawing.Size(280, 360);
            this.lstMarkaIslemleriMarkalar.TabIndex = 0;
            this.lstMarkaIslemleriMarkalar.DoubleClick += new System.EventHandler(this.lstMarkaIslemleriMarkalar_DoubleClick);
            // 
            // lblMarkaIDBaslik
            // 
            this.lblMarkaIDBaslik.AutoSize = true;
            this.lblMarkaIDBaslik.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblMarkaIDBaslik.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMarkaIDBaslik.Location = new System.Drawing.Point(350, 45);
            this.lblMarkaIDBaslik.Name = "lblMarkaIDBaslik";
            this.lblMarkaIDBaslik.Size = new System.Drawing.Size(80, 17);
            this.lblMarkaIDBaslik.TabIndex = 1;
            this.lblMarkaIDBaslik.Text = "Marka ID :";
            // 
            // lblMarkaIslemleriMarkaID
            // 
            this.lblMarkaIslemleriMarkaID.AutoSize = true;
            this.lblMarkaIslemleriMarkaID.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblMarkaIslemleriMarkaID.ForeColor = System.Drawing.Color.Tomato;
            this.lblMarkaIslemleriMarkaID.Location = new System.Drawing.Point(445, 45);
            this.lblMarkaIslemleriMarkaID.Name = "lblMarkaIslemleriMarkaID";
            this.lblMarkaIslemleriMarkaID.Size = new System.Drawing.Size(0, 17);
            this.lblMarkaIslemleriMarkaID.TabIndex = 2;
            // 
            // lblMarkaAdi
            // 
            this.lblMarkaAdi.AutoSize = true;
            this.lblMarkaAdi.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblMarkaAdi.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMarkaAdi.Location = new System.Drawing.Point(350, 90);
            this.lblMarkaAdi.Name = "lblMarkaAdi";
            this.lblMarkaAdi.Size = new System.Drawing.Size(86, 17);
            this.lblMarkaAdi.TabIndex = 3;
            this.lblMarkaAdi.Text = "Marka Adı :";
            // 
            // txtMarkaIslemleriMarkaAdi
            // 
            this.txtMarkaIslemleriMarkaAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.txtMarkaIslemleriMarkaAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMarkaIslemleriMarkaAdi.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtMarkaIslemleriMarkaAdi.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtMarkaIslemleriMarkaAdi.Location = new System.Drawing.Point(450, 87);
            this.txtMarkaIslemleriMarkaAdi.Multiline = true;
            this.txtMarkaIslemleriMarkaAdi.Name = "txtMarkaIslemleriMarkaAdi";
            this.txtMarkaIslemleriMarkaAdi.Size = new System.Drawing.Size(260, 26);
            this.txtMarkaIslemleriMarkaAdi.TabIndex = 4;
            // 
            // btnMarkaGuncelle
            // 
            this.btnMarkaGuncelle.BackColor = System.Drawing.Color.DarkCyan;
            this.btnMarkaGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarkaGuncelle.FlatAppearance.BorderSize = 0;
            this.btnMarkaGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkaGuncelle.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnMarkaGuncelle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMarkaGuncelle.Location = new System.Drawing.Point(450, 130);
            this.btnMarkaGuncelle.Name = "btnMarkaGuncelle";
            this.btnMarkaGuncelle.Size = new System.Drawing.Size(260, 35);
            this.btnMarkaGuncelle.TabIndex = 5;
            this.btnMarkaGuncelle.Text = "MARKA GÜNCELLE";
            this.btnMarkaGuncelle.UseVisualStyleBackColor = false;
            this.btnMarkaGuncelle.Click += new System.EventHandler(this.btnMarkaGuncelle_Click);
            // 
            // btnYeniMarka
            // 
            this.btnYeniMarka.BackColor = System.Drawing.Color.SeaGreen;
            this.btnYeniMarka.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYeniMarka.FlatAppearance.BorderSize = 0;
            this.btnYeniMarka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniMarka.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnYeniMarka.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnYeniMarka.Location = new System.Drawing.Point(450, 175);
            this.btnYeniMarka.Name = "btnYeniMarka";
            this.btnYeniMarka.Size = new System.Drawing.Size(260, 35);
            this.btnYeniMarka.TabIndex = 6;
            this.btnYeniMarka.Text = "YENİ MARKA";
            this.btnYeniMarka.UseVisualStyleBackColor = false;
            this.btnYeniMarka.Click += new System.EventHandler(this.btnYeniMarka_Click);
            // 
            // btnMarkaSil
            // 
            this.btnMarkaSil.BackColor = System.Drawing.Color.Firebrick;
            this.btnMarkaSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarkaSil.FlatAppearance.BorderSize = 0;
            this.btnMarkaSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkaSil.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnMarkaSil.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMarkaSil.Location = new System.Drawing.Point(450, 220);
            this.btnMarkaSil.Name = "btnMarkaSil";
            this.btnMarkaSil.Size = new System.Drawing.Size(260, 35);
            this.btnMarkaSil.TabIndex = 7;
            this.btnMarkaSil.Text = "MARKA SİL";
            this.btnMarkaSil.UseVisualStyleBackColor = false;
            this.btnMarkaSil.Click += new System.EventHandler(this.btnMarkaSil_Click);
            // 
            // PnlSistemCihazIslemleri
            // 
            this.PnlSistemCihazIslemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.PnlSistemCihazIslemleri.Controls.Add(this.btnCihazSil);
            this.PnlSistemCihazIslemleri.Controls.Add(this.btnYeniCihaz);
            this.PnlSistemCihazIslemleri.Controls.Add(this.btnCihazGuncelle);
            this.PnlSistemCihazIslemleri.Controls.Add(this.txtCihazIslemleriCihazAdi);
            this.PnlSistemCihazIslemleri.Controls.Add(this.lblCihazAdiBaslik);
            this.PnlSistemCihazIslemleri.Controls.Add(this.lblCihazIslemleriCihazID);
            this.PnlSistemCihazIslemleri.Controls.Add(this.lblCihazIDBaslik);
            this.PnlSistemCihazIslemleri.Controls.Add(this.lstCihazIslemleriCihazlar);
            this.PnlSistemCihazIslemleri.Location = new System.Drawing.Point(0, 168);
            this.PnlSistemCihazIslemleri.Name = "PnlSistemCihazIslemleri";
            this.PnlSistemCihazIslemleri.Size = new System.Drawing.Size(1289, 431);
            this.PnlSistemCihazIslemleri.TabIndex = 6;
            this.PnlSistemCihazIslemleri.Visible = false;
            // 
            // lstCihazIslemleriCihazlar
            // 
            this.lstCihazIslemleriCihazlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.lstCihazIslemleriCihazlar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstCihazIslemleriCihazlar.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lstCihazIslemleriCihazlar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lstCihazIslemleriCihazlar.ItemHeight = 18;
            this.lstCihazIslemleriCihazlar.Location = new System.Drawing.Point(35, 30);
            this.lstCihazIslemleriCihazlar.Name = "lstCihazIslemleriCihazlar";
            this.lstCihazIslemleriCihazlar.Size = new System.Drawing.Size(280, 360);
            this.lstCihazIslemleriCihazlar.TabIndex = 0;
            this.lstCihazIslemleriCihazlar.DoubleClick += new System.EventHandler(this.lstCihazIslemleriCihazlar_DoubleClick);
            // 
            // lblCihazIDBaslik
            // 
            this.lblCihazIDBaslik.AutoSize = true;
            this.lblCihazIDBaslik.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblCihazIDBaslik.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCihazIDBaslik.Location = new System.Drawing.Point(350, 45);
            this.lblCihazIDBaslik.Name = "lblCihazIDBaslik";
            this.lblCihazIDBaslik.Size = new System.Drawing.Size(76, 17);
            this.lblCihazIDBaslik.TabIndex = 1;
            this.lblCihazIDBaslik.Text = "Cihaz ID :";
            // 
            // lblCihazIslemleriCihazID
            // 
            this.lblCihazIslemleriCihazID.AutoSize = true;
            this.lblCihazIslemleriCihazID.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblCihazIslemleriCihazID.ForeColor = System.Drawing.Color.Tomato;
            this.lblCihazIslemleriCihazID.Location = new System.Drawing.Point(445, 45);
            this.lblCihazIslemleriCihazID.Name = "lblCihazIslemleriCihazID";
            this.lblCihazIslemleriCihazID.Size = new System.Drawing.Size(0, 17);
            this.lblCihazIslemleriCihazID.TabIndex = 2;
            // 
            // lblCihazAdiBaslik
            // 
            this.lblCihazAdiBaslik.AutoSize = true;
            this.lblCihazAdiBaslik.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblCihazAdiBaslik.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCihazAdiBaslik.Location = new System.Drawing.Point(350, 90);
            this.lblCihazAdiBaslik.Name = "lblCihazAdiBaslik";
            this.lblCihazAdiBaslik.Size = new System.Drawing.Size(82, 17);
            this.lblCihazAdiBaslik.TabIndex = 3;
            this.lblCihazAdiBaslik.Text = "Cihaz Adı :";
            // 
            // txtCihazIslemleriCihazAdi
            // 
            this.txtCihazIslemleriCihazAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.txtCihazIslemleriCihazAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCihazIslemleriCihazAdi.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtCihazIslemleriCihazAdi.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtCihazIslemleriCihazAdi.Location = new System.Drawing.Point(450, 87);
            this.txtCihazIslemleriCihazAdi.Multiline = true;
            this.txtCihazIslemleriCihazAdi.Name = "txtCihazIslemleriCihazAdi";
            this.txtCihazIslemleriCihazAdi.Size = new System.Drawing.Size(260, 26);
            this.txtCihazIslemleriCihazAdi.TabIndex = 4;
            // 
            // btnCihazGuncelle
            // 
            this.btnCihazGuncelle.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCihazGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCihazGuncelle.FlatAppearance.BorderSize = 0;
            this.btnCihazGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCihazGuncelle.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCihazGuncelle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCihazGuncelle.Location = new System.Drawing.Point(450, 130);
            this.btnCihazGuncelle.Name = "btnCihazGuncelle";
            this.btnCihazGuncelle.Size = new System.Drawing.Size(260, 35);
            this.btnCihazGuncelle.TabIndex = 5;
            this.btnCihazGuncelle.Text = "CİHAZ GÜNCELLE";
            this.btnCihazGuncelle.UseVisualStyleBackColor = false;
            this.btnCihazGuncelle.Click += new System.EventHandler(this.btnCihazGuncelle_Click);
            // 
            // btnYeniCihaz
            // 
            this.btnYeniCihaz.BackColor = System.Drawing.Color.SeaGreen;
            this.btnYeniCihaz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYeniCihaz.FlatAppearance.BorderSize = 0;
            this.btnYeniCihaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniCihaz.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnYeniCihaz.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnYeniCihaz.Location = new System.Drawing.Point(450, 175);
            this.btnYeniCihaz.Name = "btnYeniCihaz";
            this.btnYeniCihaz.Size = new System.Drawing.Size(260, 35);
            this.btnYeniCihaz.TabIndex = 6;
            this.btnYeniCihaz.Text = "YENİ CİHAZ";
            this.btnYeniCihaz.UseVisualStyleBackColor = false;
            this.btnYeniCihaz.Click += new System.EventHandler(this.btnYeniCihaz_Click);
            // 
            // btnCihazSil
            // 
            this.btnCihazSil.BackColor = System.Drawing.Color.Firebrick;
            this.btnCihazSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCihazSil.FlatAppearance.BorderSize = 0;
            this.btnCihazSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCihazSil.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCihazSil.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCihazSil.Location = new System.Drawing.Point(450, 220);
            this.btnCihazSil.Name = "btnCihazSil";
            this.btnCihazSil.Size = new System.Drawing.Size(260, 35);
            this.btnCihazSil.TabIndex = 7;
            this.btnCihazSil.Text = "CİHAZ SİL";
            this.btnCihazSil.UseVisualStyleBackColor = false;
            this.btnCihazSil.Click += new System.EventHandler(this.btnCihazSil_Click);
            // 
            // PnlYedekParcaKategori
            // 
            this.PnlYedekParcaKategori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.PnlYedekParcaKategori.Controls.Add(this.btnYedekParcaKategoriSil);
            this.PnlYedekParcaKategori.Controls.Add(this.btnYedekParcaYeniKategori);
            this.PnlYedekParcaKategori.Controls.Add(this.btnYedekParcaKategoriGuncelle);
            this.PnlYedekParcaKategori.Controls.Add(this.txtYedekParcaKategoriAdi);
            this.PnlYedekParcaKategori.Controls.Add(this.lblKatAdiBaslik);
            this.PnlYedekParcaKategori.Controls.Add(this.lblYedekParcaKategoriIslemleriID);
            this.PnlYedekParcaKategori.Controls.Add(this.lblKatIDBaslik);
            this.PnlYedekParcaKategori.Controls.Add(this.lstYedekParcaKategoriIslemleri);
            this.PnlYedekParcaKategori.Location = new System.Drawing.Point(0, 168);
            this.PnlYedekParcaKategori.Name = "PnlYedekParcaKategori";
            this.PnlYedekParcaKategori.Size = new System.Drawing.Size(1289, 431);
            this.PnlYedekParcaKategori.TabIndex = 7;
            this.PnlYedekParcaKategori.Visible = false;
            // 
            // lstYedekParcaKategoriIslemleri
            // 
            this.lstYedekParcaKategoriIslemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.lstYedekParcaKategoriIslemleri.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstYedekParcaKategoriIslemleri.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lstYedekParcaKategoriIslemleri.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lstYedekParcaKategoriIslemleri.ItemHeight = 18;
            this.lstYedekParcaKategoriIslemleri.Location = new System.Drawing.Point(35, 30);
            this.lstYedekParcaKategoriIslemleri.Name = "lstYedekParcaKategoriIslemleri";
            this.lstYedekParcaKategoriIslemleri.Size = new System.Drawing.Size(280, 360);
            this.lstYedekParcaKategoriIslemleri.TabIndex = 0;
            this.lstYedekParcaKategoriIslemleri.DoubleClick += new System.EventHandler(this.lstYedekParcaKategoriIslemleri_DoubleClick);
            // 
            // lblKatIDBaslik
            // 
            this.lblKatIDBaslik.AutoSize = true;
            this.lblKatIDBaslik.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblKatIDBaslik.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblKatIDBaslik.Location = new System.Drawing.Point(350, 45);
            this.lblKatIDBaslik.Name = "lblKatIDBaslik";
            this.lblKatIDBaslik.Size = new System.Drawing.Size(96, 17);
            this.lblKatIDBaslik.TabIndex = 1;
            this.lblKatIDBaslik.Text = "Kategori ID :";
            // 
            // lblYedekParcaKategoriIslemleriID
            // 
            this.lblYedekParcaKategoriIslemleriID.AutoSize = true;
            this.lblYedekParcaKategoriIslemleriID.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblYedekParcaKategoriIslemleriID.ForeColor = System.Drawing.Color.Tomato;
            this.lblYedekParcaKategoriIslemleriID.Location = new System.Drawing.Point(460, 45);
            this.lblYedekParcaKategoriIslemleriID.Name = "lblYedekParcaKategoriIslemleriID";
            this.lblYedekParcaKategoriIslemleriID.Size = new System.Drawing.Size(0, 17);
            this.lblYedekParcaKategoriIslemleriID.TabIndex = 2;
            // 
            // lblKatAdiBaslik
            // 
            this.lblKatAdiBaslik.AutoSize = true;
            this.lblKatAdiBaslik.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblKatAdiBaslik.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblKatAdiBaslik.Location = new System.Drawing.Point(350, 90);
            this.lblKatAdiBaslik.Name = "lblKatAdiBaslik";
            this.lblKatAdiBaslik.Size = new System.Drawing.Size(102, 17);
            this.lblKatAdiBaslik.TabIndex = 3;
            this.lblKatAdiBaslik.Text = "Kategori Adı :";
            // 
            // txtYedekParcaKategoriAdi
            // 
            this.txtYedekParcaKategoriAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.txtYedekParcaKategoriAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYedekParcaKategoriAdi.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtYedekParcaKategoriAdi.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtYedekParcaKategoriAdi.Location = new System.Drawing.Point(465, 87);
            this.txtYedekParcaKategoriAdi.Multiline = true;
            this.txtYedekParcaKategoriAdi.Name = "txtYedekParcaKategoriAdi";
            this.txtYedekParcaKategoriAdi.Size = new System.Drawing.Size(260, 26);
            this.txtYedekParcaKategoriAdi.TabIndex = 4;
            // 
            // btnYedekParcaKategoriGuncelle
            // 
            this.btnYedekParcaKategoriGuncelle.BackColor = System.Drawing.Color.DarkCyan;
            this.btnYedekParcaKategoriGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYedekParcaKategoriGuncelle.FlatAppearance.BorderSize = 0;
            this.btnYedekParcaKategoriGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYedekParcaKategoriGuncelle.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnYedekParcaKategoriGuncelle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnYedekParcaKategoriGuncelle.Location = new System.Drawing.Point(465, 130);
            this.btnYedekParcaKategoriGuncelle.Name = "btnYedekParcaKategoriGuncelle";
            this.btnYedekParcaKategoriGuncelle.Size = new System.Drawing.Size(260, 35);
            this.btnYedekParcaKategoriGuncelle.TabIndex = 5;
            this.btnYedekParcaKategoriGuncelle.Text = "KATEGORİ GÜNCELLE";
            this.btnYedekParcaKategoriGuncelle.UseVisualStyleBackColor = false;
            this.btnYedekParcaKategoriGuncelle.Click += new System.EventHandler(this.btnYedekParcaKategoriGuncelle_Click);
            // 
            // btnYedekParcaYeniKategori
            // 
            this.btnYedekParcaYeniKategori.BackColor = System.Drawing.Color.SeaGreen;
            this.btnYedekParcaYeniKategori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYedekParcaYeniKategori.FlatAppearance.BorderSize = 0;
            this.btnYedekParcaYeniKategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYedekParcaYeniKategori.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnYedekParcaYeniKategori.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnYedekParcaYeniKategori.Location = new System.Drawing.Point(465, 175);
            this.btnYedekParcaYeniKategori.Name = "btnYedekParcaYeniKategori";
            this.btnYedekParcaYeniKategori.Size = new System.Drawing.Size(260, 35);
            this.btnYedekParcaYeniKategori.TabIndex = 6;
            this.btnYedekParcaYeniKategori.Text = "YENİ KATEGORİ";
            this.btnYedekParcaYeniKategori.UseVisualStyleBackColor = false;
            this.btnYedekParcaYeniKategori.Click += new System.EventHandler(this.btnYedekParcaYeniKategori_Click);
            // 
            // btnYedekParcaKategoriSil
            // 
            this.btnYedekParcaKategoriSil.BackColor = System.Drawing.Color.Firebrick;
            this.btnYedekParcaKategoriSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYedekParcaKategoriSil.FlatAppearance.BorderSize = 0;
            this.btnYedekParcaKategoriSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYedekParcaKategoriSil.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnYedekParcaKategoriSil.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnYedekParcaKategoriSil.Location = new System.Drawing.Point(465, 220);
            this.btnYedekParcaKategoriSil.Name = "btnYedekParcaKategoriSil";
            this.btnYedekParcaKategoriSil.Size = new System.Drawing.Size(260, 35);
            this.btnYedekParcaKategoriSil.TabIndex = 7;
            this.btnYedekParcaKategoriSil.Text = "KATEGORİ SİL";
            this.btnYedekParcaKategoriSil.UseVisualStyleBackColor = false;
            this.btnYedekParcaKategoriSil.Click += new System.EventHandler(this.btnYedekParcaKategoriSil_Click);
            // 
            // PnlYedekParcaIslemleri
            // 
            this.PnlYedekParcaIslemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.PnlYedekParcaIslemleri.Controls.Add(this.btnYedekParcaIslemleriSil);
            this.PnlYedekParcaIslemleri.Controls.Add(this.btnYedekParcaIslemleriYeni);
            this.PnlYedekParcaIslemleri.Controls.Add(this.btnYedekParcaIslemleriGuncelle);
            this.PnlYedekParcaIslemleri.Controls.Add(this.txtYedekParcaIslemleriEkOzellikler);
            this.PnlYedekParcaIslemleri.Controls.Add(this.lblYPOzellikBaslik);
            this.PnlYedekParcaIslemleri.Controls.Add(this.txtYedekParcaIslemleriStok);
            this.PnlYedekParcaIslemleri.Controls.Add(this.lblYPStokBaslik);
            this.PnlYedekParcaIslemleri.Controls.Add(this.txtYedekParcaIslemleriModel);
            this.PnlYedekParcaIslemleri.Controls.Add(this.lblYPModelBaslik);
            this.PnlYedekParcaIslemleri.Controls.Add(this.cmbYedekParcaIslemleriMarka);
            this.PnlYedekParcaIslemleri.Controls.Add(this.lblYPMarkaBaslik);
            this.PnlYedekParcaIslemleri.Controls.Add(this.cmbYedekParcaIslemleriKategori);
            this.PnlYedekParcaIslemleri.Controls.Add(this.lblYPKategoriBaslik);
            this.PnlYedekParcaIslemleri.Controls.Add(this.lblYedekParcaIslemleriYedekParcaID);
            this.PnlYedekParcaIslemleri.Controls.Add(this.lblYedekParcaIDBaslik);
            this.PnlYedekParcaIslemleri.Controls.Add(this.lblYedekParcaIslemleri);
            this.PnlYedekParcaIslemleri.Controls.Add(this.lstYedekParcaIslemleri);
            this.PnlYedekParcaIslemleri.Location = new System.Drawing.Point(0, 168);
            this.PnlYedekParcaIslemleri.Name = "PnlYedekParcaIslemleri";
            this.PnlYedekParcaIslemleri.Size = new System.Drawing.Size(1289, 431);
            this.PnlYedekParcaIslemleri.TabIndex = 8;
            this.PnlYedekParcaIslemleri.Visible = false;
            // 
            // lblYedekParcaIslemleri
            // 
            this.lblYedekParcaIslemleri.BackColor = System.Drawing.Color.Tomato;
            this.lblYedekParcaIslemleri.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblYedekParcaIslemleri.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblYedekParcaIslemleri.Location = new System.Drawing.Point(35, 15);
            this.lblYedekParcaIslemleri.Name = "lblYedekParcaIslemleri";
            this.lblYedekParcaIslemleri.Size = new System.Drawing.Size(280, 28);
            this.lblYedekParcaIslemleri.TabIndex = 0;
            this.lblYedekParcaIslemleri.Text = "KATEGORİLER";
            this.lblYedekParcaIslemleri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstYedekParcaIslemleri
            // 
            this.lstYedekParcaIslemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.lstYedekParcaIslemleri.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstYedekParcaIslemleri.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lstYedekParcaIslemleri.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lstYedekParcaIslemleri.ItemHeight = 18;
            this.lstYedekParcaIslemleri.Location = new System.Drawing.Point(35, 45);
            this.lstYedekParcaIslemleri.Name = "lstYedekParcaIslemleri";
            this.lstYedekParcaIslemleri.Size = new System.Drawing.Size(280, 345);
            this.lstYedekParcaIslemleri.TabIndex = 1;
            this.lstYedekParcaIslemleri.DoubleClick += new System.EventHandler(this.lstYedekParcaIslemleri_DoubleClick);
            // 
            // lblYedekParcaIDBaslik
            // 
            this.lblYedekParcaIDBaslik.AutoSize = true;
            this.lblYedekParcaIDBaslik.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblYedekParcaIDBaslik.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblYedekParcaIDBaslik.Location = new System.Drawing.Point(350, 25);
            this.lblYedekParcaIDBaslik.Name = "lblYedekParcaIDBaslik";
            this.lblYedekParcaIDBaslik.Size = new System.Drawing.Size(121, 17);
            this.lblYedekParcaIDBaslik.TabIndex = 2;
            this.lblYedekParcaIDBaslik.Text = "Yedek Parça ID :";
            // 
            // lblYedekParcaIslemleriYedekParcaID
            // 
            this.lblYedekParcaIslemleriYedekParcaID.AutoSize = true;
            this.lblYedekParcaIslemleriYedekParcaID.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblYedekParcaIslemleriYedekParcaID.ForeColor = System.Drawing.Color.Tomato;
            this.lblYedekParcaIslemleriYedekParcaID.Location = new System.Drawing.Point(495, 25);
            this.lblYedekParcaIslemleriYedekParcaID.Name = "lblYedekParcaIslemleriYedekParcaID";
            this.lblYedekParcaIslemleriYedekParcaID.Size = new System.Drawing.Size(0, 17);
            this.lblYedekParcaIslemleriYedekParcaID.TabIndex = 3;
            // 
            // lblYPKategoriBaslik
            // 
            this.lblYPKategoriBaslik.AutoSize = true;
            this.lblYPKategoriBaslik.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblYPKategoriBaslik.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblYPKategoriBaslik.Location = new System.Drawing.Point(350, 62);
            this.lblYPKategoriBaslik.Name = "lblYPKategoriBaslik";
            this.lblYPKategoriBaslik.Size = new System.Drawing.Size(136, 17);
            this.lblYPKategoriBaslik.TabIndex = 4;
            this.lblYPKategoriBaslik.Text = "Yedek Parça Kat. :";
            // 
            // cmbYedekParcaIslemleriKategori
            // 
            this.cmbYedekParcaIslemleriKategori.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.cmbYedekParcaIslemleriKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYedekParcaIslemleriKategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbYedekParcaIslemleriKategori.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cmbYedekParcaIslemleriKategori.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmbYedekParcaIslemleriKategori.FormattingEnabled = true;
            this.cmbYedekParcaIslemleriKategori.Location = new System.Drawing.Point(495, 59);
            this.cmbYedekParcaIslemleriKategori.Name = "cmbYedekParcaIslemleriKategori";
            this.cmbYedekParcaIslemleriKategori.Size = new System.Drawing.Size(260, 24);
            this.cmbYedekParcaIslemleriKategori.TabIndex = 5;
            // 
            // lblYPMarkaBaslik
            // 
            this.lblYPMarkaBaslik.AutoSize = true;
            this.lblYPMarkaBaslik.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblYPMarkaBaslik.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblYPMarkaBaslik.Location = new System.Drawing.Point(350, 102);
            this.lblYPMarkaBaslik.Name = "lblYPMarkaBaslik";
            this.lblYPMarkaBaslik.Size = new System.Drawing.Size(141, 17);
            this.lblYPMarkaBaslik.TabIndex = 6;
            this.lblYPMarkaBaslik.Text = "Yedek Parça Marka:";
            // 
            // cmbYedekParcaIslemleriMarka
            // 
            this.cmbYedekParcaIslemleriMarka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.cmbYedekParcaIslemleriMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYedekParcaIslemleriMarka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbYedekParcaIslemleriMarka.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cmbYedekParcaIslemleriMarka.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmbYedekParcaIslemleriMarka.FormattingEnabled = true;
            this.cmbYedekParcaIslemleriMarka.Location = new System.Drawing.Point(495, 99);
            this.cmbYedekParcaIslemleriMarka.Name = "cmbYedekParcaIslemleriMarka";
            this.cmbYedekParcaIslemleriMarka.Size = new System.Drawing.Size(260, 24);
            this.cmbYedekParcaIslemleriMarka.TabIndex = 7;
            // 
            // lblYPModelBaslik
            // 
            this.lblYPModelBaslik.AutoSize = true;
            this.lblYPModelBaslik.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblYPModelBaslik.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblYPModelBaslik.Location = new System.Drawing.Point(350, 142);
            this.lblYPModelBaslik.Name = "lblYPModelBaslik";
            this.lblYPModelBaslik.Size = new System.Drawing.Size(141, 17);
            this.lblYPModelBaslik.TabIndex = 8;
            this.lblYPModelBaslik.Text = "Yedek Parça Model:";
            // 
            // txtYedekParcaIslemleriModel
            // 
            this.txtYedekParcaIslemleriModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.txtYedekParcaIslemleriModel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYedekParcaIslemleriModel.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtYedekParcaIslemleriModel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtYedekParcaIslemleriModel.Location = new System.Drawing.Point(495, 139);
            this.txtYedekParcaIslemleriModel.Multiline = true;
            this.txtYedekParcaIslemleriModel.Name = "txtYedekParcaIslemleriModel";
            this.txtYedekParcaIslemleriModel.Size = new System.Drawing.Size(260, 26);
            this.txtYedekParcaIslemleriModel.TabIndex = 9;
            // 
            // lblYPStokBaslik
            // 
            this.lblYPStokBaslik.AutoSize = true;
            this.lblYPStokBaslik.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblYPStokBaslik.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblYPStokBaslik.Location = new System.Drawing.Point(350, 182);
            this.lblYPStokBaslik.Name = "lblYPStokBaslik";
            this.lblYPStokBaslik.Size = new System.Drawing.Size(83, 17);
            this.lblYPStokBaslik.TabIndex = 10;
            this.lblYPStokBaslik.Text = "Stok Adet :";
            // 
            // txtYedekParcaIslemleriStok
            // 
            this.txtYedekParcaIslemleriStok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.txtYedekParcaIslemleriStok.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYedekParcaIslemleriStok.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtYedekParcaIslemleriStok.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtYedekParcaIslemleriStok.Location = new System.Drawing.Point(495, 179);
            this.txtYedekParcaIslemleriStok.Multiline = true;
            this.txtYedekParcaIslemleriStok.Name = "txtYedekParcaIslemleriStok";
            this.txtYedekParcaIslemleriStok.Size = new System.Drawing.Size(260, 26);
            this.txtYedekParcaIslemleriStok.TabIndex = 11;
            // 
            // lblYPOzellikBaslik
            // 
            this.lblYPOzellikBaslik.AutoSize = true;
            this.lblYPOzellikBaslik.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblYPOzellikBaslik.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblYPOzellikBaslik.Location = new System.Drawing.Point(350, 222);
            this.lblYPOzellikBaslik.Name = "lblYPOzellikBaslik";
            this.lblYPOzellikBaslik.Size = new System.Drawing.Size(104, 17);
            this.lblYPOzellikBaslik.TabIndex = 12;
            this.lblYPOzellikBaslik.Text = "Ek Özellikler :";
            // 
            // txtYedekParcaIslemleriEkOzellikler
            // 
            this.txtYedekParcaIslemleriEkOzellikler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.txtYedekParcaIslemleriEkOzellikler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYedekParcaIslemleriEkOzellikler.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtYedekParcaIslemleriEkOzellikler.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtYedekParcaIslemleriEkOzellikler.Location = new System.Drawing.Point(495, 222);
            this.txtYedekParcaIslemleriEkOzellikler.Multiline = true;
            this.txtYedekParcaIslemleriEkOzellikler.Name = "txtYedekParcaIslemleriEkOzellikler";
            this.txtYedekParcaIslemleriEkOzellikler.Size = new System.Drawing.Size(260, 168);
            this.txtYedekParcaIslemleriEkOzellikler.TabIndex = 13;
            // 
            // btnYedekParcaIslemleriGuncelle
            // 
            this.btnYedekParcaIslemleriGuncelle.BackColor = System.Drawing.Color.DarkCyan;
            this.btnYedekParcaIslemleriGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYedekParcaIslemleriGuncelle.FlatAppearance.BorderSize = 0;
            this.btnYedekParcaIslemleriGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYedekParcaIslemleriGuncelle.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnYedekParcaIslemleriGuncelle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnYedekParcaIslemleriGuncelle.Location = new System.Drawing.Point(780, 59);
            this.btnYedekParcaIslemleriGuncelle.Name = "btnYedekParcaIslemleriGuncelle";
            this.btnYedekParcaIslemleriGuncelle.Size = new System.Drawing.Size(240, 38);
            this.btnYedekParcaIslemleriGuncelle.TabIndex = 14;
            this.btnYedekParcaIslemleriGuncelle.Text = "YEDEK PARÇA GÜNCELLE";
            this.btnYedekParcaIslemleriGuncelle.UseVisualStyleBackColor = false;
            this.btnYedekParcaIslemleriGuncelle.Click += new System.EventHandler(this.btnYedekParcaIslemleriGuncelle_Click);
            // 
            // btnYedekParcaIslemleriYeni
            // 
            this.btnYedekParcaIslemleriYeni.BackColor = System.Drawing.Color.SeaGreen;
            this.btnYedekParcaIslemleriYeni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYedekParcaIslemleriYeni.FlatAppearance.BorderSize = 0;
            this.btnYedekParcaIslemleriYeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYedekParcaIslemleriYeni.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnYedekParcaIslemleriYeni.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnYedekParcaIslemleriYeni.Location = new System.Drawing.Point(780, 108);
            this.btnYedekParcaIslemleriYeni.Name = "btnYedekParcaIslemleriYeni";
            this.btnYedekParcaIslemleriYeni.Size = new System.Drawing.Size(240, 38);
            this.btnYedekParcaIslemleriYeni.TabIndex = 15;
            this.btnYedekParcaIslemleriYeni.Text = "YENİ YEDEK PARÇA";
            this.btnYedekParcaIslemleriYeni.UseVisualStyleBackColor = false;
            this.btnYedekParcaIslemleriYeni.Click += new System.EventHandler(this.btnYedekParcaIslemleriYeni_Click);
            // 
            // btnYedekParcaIslemleriSil
            // 
            this.btnYedekParcaIslemleriSil.BackColor = System.Drawing.Color.Firebrick;
            this.btnYedekParcaIslemleriSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYedekParcaIslemleriSil.FlatAppearance.BorderSize = 0;
            this.btnYedekParcaIslemleriSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYedekParcaIslemleriSil.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnYedekParcaIslemleriSil.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnYedekParcaIslemleriSil.Location = new System.Drawing.Point(780, 157);
            this.btnYedekParcaIslemleriSil.Name = "btnYedekParcaIslemleriSil";
            this.btnYedekParcaIslemleriSil.Size = new System.Drawing.Size(240, 38);
            this.btnYedekParcaIslemleriSil.TabIndex = 16;
            this.btnYedekParcaIslemleriSil.Text = "YEDEK PARÇA SİL";
            this.btnYedekParcaIslemleriSil.UseVisualStyleBackColor = false;
            this.btnYedekParcaIslemleriSil.Click += new System.EventHandler(this.btnYedekParcaIslemleriSil_Click);
            // 
            // PnlYetkiIslemleri
            // 
            this.PnlYetkiIslemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.PnlYetkiIslemleri.Controls.Add(this.grpYetkiler);
            this.PnlYetkiIslemleri.Controls.Add(this.btnYetkiGrubuEkle);
            this.PnlYetkiIslemleri.Controls.Add(this.txtYetkiAdi);
            this.PnlYetkiIslemleri.Controls.Add(this.cmbYetkiler);
            this.PnlYetkiIslemleri.Controls.Add(this.lblYetkiGrubuSec);
            this.PnlYetkiIslemleri.Location = new System.Drawing.Point(0, 168);
            this.PnlYetkiIslemleri.Name = "PnlYetkiIslemleri";
            this.PnlYetkiIslemleri.Size = new System.Drawing.Size(1289, 431);
            this.PnlYetkiIslemleri.TabIndex = 9;
            this.PnlYetkiIslemleri.Visible = false;
            // 
            // lblYetkiGrubuSec
            // 
            this.lblYetkiGrubuSec.AutoSize = true;
            this.lblYetkiGrubuSec.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblYetkiGrubuSec.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblYetkiGrubuSec.Location = new System.Drawing.Point(40, 35);
            this.lblYetkiGrubuSec.Name = "lblYetkiGrubuSec";
            this.lblYetkiGrubuSec.Size = new System.Drawing.Size(147, 17);
            this.lblYetkiGrubuSec.TabIndex = 0;
            this.lblYetkiGrubuSec.Text = "Yetki Grubunu Seçin";
            // 
            // cmbYetkiler
            // 
            this.cmbYetkiler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.cmbYetkiler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYetkiler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbYetkiler.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cmbYetkiler.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmbYetkiler.FormattingEnabled = true;
            this.cmbYetkiler.Location = new System.Drawing.Point(200, 32);
            this.cmbYetkiler.Name = "cmbYetkiler";
            this.cmbYetkiler.Size = new System.Drawing.Size(230, 24);
            this.cmbYetkiler.TabIndex = 1;
            this.cmbYetkiler.SelectionChangeCommitted += new System.EventHandler(this.cmbYetkiler_SelectionChangeCommitted);
            // 
            // txtYetkiAdi
            // 
            this.txtYetkiAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.txtYetkiAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYetkiAdi.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtYetkiAdi.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtYetkiAdi.Location = new System.Drawing.Point(200, 32);
            this.txtYetkiAdi.Multiline = true;
            this.txtYetkiAdi.Name = "txtYetkiAdi";
            this.txtYetkiAdi.Size = new System.Drawing.Size(230, 24);
            this.txtYetkiAdi.TabIndex = 2;
            this.txtYetkiAdi.Visible = false;
            // 
            // btnYetkiGrubuEkle
            // 
            this.btnYetkiGrubuEkle.BackColor = System.Drawing.Color.Firebrick;
            this.btnYetkiGrubuEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYetkiGrubuEkle.FlatAppearance.BorderSize = 0;
            this.btnYetkiGrubuEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYetkiGrubuEkle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnYetkiGrubuEkle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnYetkiGrubuEkle.Location = new System.Drawing.Point(445, 30);
            this.btnYetkiGrubuEkle.Name = "btnYetkiGrubuEkle";
            this.btnYetkiGrubuEkle.Size = new System.Drawing.Size(230, 28);
            this.btnYetkiGrubuEkle.TabIndex = 3;
            this.btnYetkiGrubuEkle.Text = "YENİ YETKİ GRUBU EKLE";
            this.btnYetkiGrubuEkle.UseVisualStyleBackColor = false;
            this.btnYetkiGrubuEkle.Click += new System.EventHandler(this.btnYetkiGrubuEkle_Click);
            // 
            // grpYetkiler
            // 
            this.grpYetkiler.Controls.Add(this.btnYetkiKaydet);
            this.grpYetkiler.Controls.Add(this.chcSistemAyarlari);
            this.grpYetkiler.Controls.Add(this.chcCariIslemler);
            this.grpYetkiler.Controls.Add(this.chcYedekParca);
            this.grpYetkiler.Controls.Add(this.chcKayitTamamlama);
            this.grpYetkiler.Controls.Add(this.chcKayitAcma);
            this.grpYetkiler.Controls.Add(this.chcPersonelSilme);
            this.grpYetkiler.Controls.Add(this.chcPersonelEkleme);
            this.grpYetkiler.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.grpYetkiler.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpYetkiler.Location = new System.Drawing.Point(40, 80);
            this.grpYetkiler.Name = "grpYetkiler";
            this.grpYetkiler.Size = new System.Drawing.Size(635, 290);
            this.grpYetkiler.TabIndex = 4;
            this.grpYetkiler.TabStop = false;
            this.grpYetkiler.Text = "Yetki İşlemleri";
            // 
            // chcPersonelEkleme
            // 
            this.chcPersonelEkleme.AutoSize = true;
            this.chcPersonelEkleme.Font = new System.Drawing.Font("Tahoma", 10F);
            this.chcPersonelEkleme.Location = new System.Drawing.Point(30, 40);
            this.chcPersonelEkleme.Name = "chcPersonelEkleme";
            this.chcPersonelEkleme.Size = new System.Drawing.Size(122, 21);
            this.chcPersonelEkleme.TabIndex = 0;
            this.chcPersonelEkleme.Text = "Personel Ekleme";
            this.chcPersonelEkleme.UseVisualStyleBackColor = true;
            // 
            // chcPersonelSilme
            // 
            this.chcPersonelSilme.AutoSize = true;
            this.chcPersonelSilme.Font = new System.Drawing.Font("Tahoma", 10F);
            this.chcPersonelSilme.Location = new System.Drawing.Point(30, 80);
            this.chcPersonelSilme.Name = "chcPersonelSilme";
            this.chcPersonelSilme.Size = new System.Drawing.Size(111, 21);
            this.chcPersonelSilme.TabIndex = 1;
            this.chcPersonelSilme.Text = "Personel Silme";
            this.chcPersonelSilme.UseVisualStyleBackColor = true;
            // 
            // chcKayitAcma
            // 
            this.chcKayitAcma.AutoSize = true;
            this.chcKayitAcma.Font = new System.Drawing.Font("Tahoma", 10F);
            this.chcKayitAcma.Location = new System.Drawing.Point(30, 120);
            this.chcKayitAcma.Name = "chcKayitAcma";
            this.chcKayitAcma.Size = new System.Drawing.Size(91, 21);
            this.chcKayitAcma.TabIndex = 2;
            this.chcKayitAcma.Text = "Kayıt Açma";
            this.chcKayitAcma.UseVisualStyleBackColor = true;
            // 
            // chcKayitTamamlama
            // 
            this.chcKayitTamamlama.AutoSize = true;
            this.chcKayitTamamlama.Font = new System.Drawing.Font("Tahoma", 10F);
            this.chcKayitTamamlama.Location = new System.Drawing.Point(30, 160);
            this.chcKayitTamamlama.Name = "chcKayitTamamlama";
            this.chcKayitTamamlama.Size = new System.Drawing.Size(126, 21);
            this.chcKayitTamamlama.TabIndex = 3;
            this.chcKayitTamamlama.Text = "Kayıt Tamamlama";
            this.chcKayitTamamlama.UseVisualStyleBackColor = true;
            // 
            // chcYedekParca
            // 
            this.chcYedekParca.AutoSize = true;
            this.chcYedekParca.Font = new System.Drawing.Font("Tahoma", 10F);
            this.chcYedekParca.Location = new System.Drawing.Point(250, 40);
            this.chcYedekParca.Name = "chcYedekParca";
            this.chcYedekParca.Size = new System.Drawing.Size(151, 21);
            this.chcYedekParca.TabIndex = 4;
            this.chcYedekParca.Text = "Yedek Parça İşlemleri";
            this.chcYedekParca.UseVisualStyleBackColor = true;
            // 
            // chcCariIslemler
            // 
            this.chcCariIslemler.AutoSize = true;
            this.chcCariIslemler.Font = new System.Drawing.Font("Tahoma", 10F);
            this.chcCariIslemler.Location = new System.Drawing.Point(250, 80);
            this.chcCariIslemler.Name = "chcCariIslemler";
            this.chcCariIslemler.Size = new System.Drawing.Size(102, 21);
            this.chcCariIslemler.TabIndex = 5;
            this.chcCariIslemler.Text = "Cari İşlemler";
            this.chcCariIslemler.UseVisualStyleBackColor = true;
            // 
            // chcSistemAyarlari
            // 
            this.chcSistemAyarlari.AutoSize = true;
            this.chcSistemAyarlari.Font = new System.Drawing.Font("Tahoma", 10F);
            this.chcSistemAyarlari.Location = new System.Drawing.Point(250, 120);
            this.chcSistemAyarlari.Name = "chcSistemAyarlari";
            this.chcSistemAyarlari.Size = new System.Drawing.Size(113, 21);
            this.chcSistemAyarlari.TabIndex = 6;
            this.chcSistemAyarlari.Text = "Sistem Ayarları";
            this.chcSistemAyarlari.UseVisualStyleBackColor = true;
            // 
            // btnYetkiKaydet
            // 
            this.btnYetkiKaydet.BackColor = System.Drawing.Color.SeaGreen;
            this.btnYetkiKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYetkiKaydet.FlatAppearance.BorderSize = 0;
            this.btnYetkiKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYetkiKaydet.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnYetkiKaydet.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnYetkiKaydet.Location = new System.Drawing.Point(250, 160);
            this.btnYetkiKaydet.Name = "btnYetkiKaydet";
            this.btnYetkiKaydet.Size = new System.Drawing.Size(220, 38);
            this.btnYetkiKaydet.TabIndex = 7;
            this.btnYetkiKaydet.Text = "YETKİYİ KAYDET";
            this.btnYetkiKaydet.UseVisualStyleBackColor = false;
            this.btnYetkiKaydet.Click += new System.EventHandler(this.btnYetkiKaydet_Click);
            // 
            // PnlPersonelEkle
            // 
            this.PnlPersonelEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.PnlPersonelEkle.Controls.Add(this.btnPersonelEkleKaydet);
            this.PnlPersonelEkle.Controls.Add(this.txtPersonelEkleSifre);
            this.PnlPersonelEkle.Controls.Add(this.lblPESifre);
            this.PnlPersonelEkle.Controls.Add(this.txtPersonelEkleMaas);
            this.PnlPersonelEkle.Controls.Add(this.lblPEMaas);
            this.PnlPersonelEkle.Controls.Add(this.txtPersonelEkleAdres);
            this.PnlPersonelEkle.Controls.Add(this.lblPEAdres);
            this.PnlPersonelEkle.Controls.Add(this.cmbPersonelEkleYetki);
            this.PnlPersonelEkle.Controls.Add(this.lblPEYetki);
            this.PnlPersonelEkle.Controls.Add(this.txtPersonelEkleGorev);
            this.PnlPersonelEkle.Controls.Add(this.lblPEGorev);
            this.PnlPersonelEkle.Controls.Add(this.txtPersonelEkleMail);
            this.PnlPersonelEkle.Controls.Add(this.lblPEMail);
            this.PnlPersonelEkle.Controls.Add(this.txtPersonelEkleTelefon);
            this.PnlPersonelEkle.Controls.Add(this.lblPETelefon);
            this.PnlPersonelEkle.Controls.Add(this.txtPersonelEkleAdSoyad);
            this.PnlPersonelEkle.Controls.Add(this.lblPEAdSoyad);
            this.PnlPersonelEkle.Controls.Add(this.txtPersonelEkleKullaniciAdi);
            this.PnlPersonelEkle.Controls.Add(this.lblPEKadi);
            this.PnlPersonelEkle.Controls.Add(this.txtPersonelEkleTC);
            this.PnlPersonelEkle.Controls.Add(this.lblPETC);
            this.PnlPersonelEkle.Location = new System.Drawing.Point(0, 168);
            this.PnlPersonelEkle.Name = "PnlPersonelEkle";
            this.PnlPersonelEkle.Size = new System.Drawing.Size(1289, 431);
            this.PnlPersonelEkle.TabIndex = 10;
            this.PnlPersonelEkle.Visible = false;
            // 
            // lblPETC
            // 
            this.lblPETC.AutoSize = true;
            this.lblPETC.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblPETC.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPETC.Location = new System.Drawing.Point(50, 40);
            this.lblPETC.Name = "lblPETC";
            this.lblPETC.Size = new System.Drawing.Size(113, 17);
            this.lblPETC.TabIndex = 0;
            this.lblPETC.Text = "TC Kimlik No :";
            // 
            // txtPersonelEkleTC
            // 
            this.txtPersonelEkleTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.txtPersonelEkleTC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPersonelEkleTC.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPersonelEkleTC.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPersonelEkleTC.Location = new System.Drawing.Point(175, 38);
            this.txtPersonelEkleTC.Mask = "00000000000";
            this.txtPersonelEkleTC.Name = "txtPersonelEkleTC";
            this.txtPersonelEkleTC.Size = new System.Drawing.Size(240, 20);
            this.txtPersonelEkleTC.TabIndex = 1;
            // 
            // lblPEKadi
            // 
            this.lblPEKadi.AutoSize = true;
            this.lblPEKadi.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblPEKadi.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPEKadi.Location = new System.Drawing.Point(55, 85);
            this.lblPEKadi.Name = "lblPEKadi";
            this.lblPEKadi.Size = new System.Drawing.Size(96, 17);
            this.lblPEKadi.TabIndex = 2;
            this.lblPEKadi.Text = "Kullanıcı Adı :";
            // 
            // txtPersonelEkleKullaniciAdi
            // 
            this.txtPersonelEkleKullaniciAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.txtPersonelEkleKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPersonelEkleKullaniciAdi.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPersonelEkleKullaniciAdi.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPersonelEkleKullaniciAdi.Location = new System.Drawing.Point(175, 82);
            this.txtPersonelEkleKullaniciAdi.Multiline = true;
            this.txtPersonelEkleKullaniciAdi.Name = "txtPersonelEkleKullaniciAdi";
            this.txtPersonelEkleKullaniciAdi.Size = new System.Drawing.Size(240, 24);
            this.txtPersonelEkleKullaniciAdi.TabIndex = 3;
            // 
            // lblPEAdSoyad
            // 
            this.lblPEAdSoyad.AutoSize = true;
            this.lblPEAdSoyad.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblPEAdSoyad.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPEAdSoyad.Location = new System.Drawing.Point(71, 130);
            this.lblPEAdSoyad.Name = "lblPEAdSoyad";
            this.lblPEAdSoyad.Size = new System.Drawing.Size(80, 17);
            this.lblPEAdSoyad.TabIndex = 4;
            this.lblPEAdSoyad.Text = "Adı Soyadı :";
            // 
            // txtPersonelEkleAdSoyad
            // 
            this.txtPersonelEkleAdSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.txtPersonelEkleAdSoyad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPersonelEkleAdSoyad.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPersonelEkleAdSoyad.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPersonelEkleAdSoyad.Location = new System.Drawing.Point(175, 127);
            this.txtPersonelEkleAdSoyad.Multiline = true;
            this.txtPersonelEkleAdSoyad.Name = "txtPersonelEkleAdSoyad";
            this.txtPersonelEkleAdSoyad.Size = new System.Drawing.Size(240, 24);
            this.txtPersonelEkleAdSoyad.TabIndex = 5;
            // 
            // lblPETelefon
            // 
            this.lblPETelefon.AutoSize = true;
            this.lblPETelefon.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblPETelefon.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPETelefon.Location = new System.Drawing.Point(85, 175);
            this.lblPETelefon.Name = "lblPETelefon";
            this.lblPETelefon.Size = new System.Drawing.Size(66, 17);
            this.lblPETelefon.TabIndex = 6;
            this.lblPETelefon.Text = "Telefon :";
            // 
            // txtPersonelEkleTelefon
            // 
            this.txtPersonelEkleTelefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.txtPersonelEkleTelefon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPersonelEkleTelefon.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPersonelEkleTelefon.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPersonelEkleTelefon.Location = new System.Drawing.Point(175, 173);
            this.txtPersonelEkleTelefon.Mask = "(999) 000-0000";
            this.txtPersonelEkleTelefon.Name = "txtPersonelEkleTelefon";
            this.txtPersonelEkleTelefon.Size = new System.Drawing.Size(240, 20);
            this.txtPersonelEkleTelefon.TabIndex = 7;
            // 
            // lblPEMail
            // 
            this.lblPEMail.AutoSize = true;
            this.lblPEMail.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblPEMail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPEMail.Location = new System.Drawing.Point(95, 220);
            this.lblPEMail.Name = "lblPEMail";
            this.lblPEMail.Size = new System.Drawing.Size(56, 17);
            this.lblPEMail.TabIndex = 8;
            this.lblPEMail.Text = "E-Mail :";
            // 
            // txtPersonelEkleMail
            // 
            this.txtPersonelEkleMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.txtPersonelEkleMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPersonelEkleMail.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPersonelEkleMail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPersonelEkleMail.Location = new System.Drawing.Point(175, 217);
            this.txtPersonelEkleMail.Multiline = true;
            this.txtPersonelEkleMail.Name = "txtPersonelEkleMail";
            this.txtPersonelEkleMail.Size = new System.Drawing.Size(240, 24);
            this.txtPersonelEkleMail.TabIndex = 9;
            // 
            // lblPEGorev
            // 
            this.lblPEGorev.AutoSize = true;
            this.lblPEGorev.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblPEGorev.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPEGorev.Location = new System.Drawing.Point(92, 265);
            this.lblPEGorev.Name = "lblPEGorev";
            this.lblPEGorev.Size = new System.Drawing.Size(59, 17);
            this.lblPEGorev.TabIndex = 10;
            this.lblPEGorev.Text = "Görevi :";
            // 
            // txtPersonelEkleGorev
            // 
            this.txtPersonelEkleGorev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.txtPersonelEkleGorev.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPersonelEkleGorev.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPersonelEkleGorev.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPersonelEkleGorev.Location = new System.Drawing.Point(175, 262);
            this.txtPersonelEkleGorev.Multiline = true;
            this.txtPersonelEkleGorev.Name = "txtPersonelEkleGorev";
            this.txtPersonelEkleGorev.Size = new System.Drawing.Size(240, 24);
            this.txtPersonelEkleGorev.TabIndex = 11;
            // 
            // lblPEYetki
            // 
            this.lblPEYetki.AutoSize = true;
            this.lblPEYetki.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblPEYetki.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPEYetki.Location = new System.Drawing.Point(480, 40);
            this.lblPEYetki.Name = "lblPEYetki";
            this.lblPEYetki.Size = new System.Drawing.Size(61, 17);
            this.lblPEYetki.TabIndex = 12;
            this.lblPEYetki.Text = "Yetkisi :";
            // 
            // cmbPersonelEkleYetki
            // 
            this.cmbPersonelEkleYetki.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.cmbPersonelEkleYetki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonelEkleYetki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPersonelEkleYetki.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cmbPersonelEkleYetki.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmbPersonelEkleYetki.FormattingEnabled = true;
            this.cmbPersonelEkleYetki.Location = new System.Drawing.Point(560, 37);
            this.cmbPersonelEkleYetki.Name = "cmbPersonelEkleYetki";
            this.cmbPersonelEkleYetki.Size = new System.Drawing.Size(240, 24);
            this.cmbPersonelEkleYetki.TabIndex = 13;
            // 
            // lblPEAdres
            // 
            this.lblPEAdres.AutoSize = true;
            this.lblPEAdres.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblPEAdres.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPEAdres.Location = new System.Drawing.Point(486, 85);
            this.lblPEAdres.Name = "lblPEAdres";
            this.lblPEAdres.Size = new System.Drawing.Size(55, 17);
            this.lblPEAdres.TabIndex = 14;
            this.lblPEAdres.Text = "Adresi :";
            // 
            // txtPersonelEkleAdres
            // 
            this.txtPersonelEkleAdres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.txtPersonelEkleAdres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPersonelEkleAdres.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtPersonelEkleAdres.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPersonelEkleAdres.Location = new System.Drawing.Point(560, 82);
            this.txtPersonelEkleAdres.MaxLength = 255;
            this.txtPersonelEkleAdres.Multiline = true;
            this.txtPersonelEkleAdres.Name = "txtPersonelEkleAdres";
            this.txtPersonelEkleAdres.Size = new System.Drawing.Size(240, 70);
            this.txtPersonelEkleAdres.TabIndex = 15;
            // 
            // lblPEMaas
            // 
            this.lblPEMaas.AutoSize = true;
            this.lblPEMaas.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblPEMaas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPEMaas.Location = new System.Drawing.Point(490, 175);
            this.lblPEMaas.Name = "lblPEMaas";
            this.lblPEMaas.Size = new System.Drawing.Size(51, 17);
            this.lblPEMaas.TabIndex = 16;
            this.lblPEMaas.Text = "Maaşı :";
            // 
            // txtPersonelEkleMaas
            // 
            this.txtPersonelEkleMaas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.txtPersonelEkleMaas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPersonelEkleMaas.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPersonelEkleMaas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPersonelEkleMaas.Location = new System.Drawing.Point(560, 172);
            this.txtPersonelEkleMaas.Multiline = true;
            this.txtPersonelEkleMaas.Name = "txtPersonelEkleMaas";
            this.txtPersonelEkleMaas.Size = new System.Drawing.Size(240, 24);
            this.txtPersonelEkleMaas.TabIndex = 17;
            // 
            // lblPESifre
            // 
            this.lblPESifre.AutoSize = true;
            this.lblPESifre.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblPESifre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPESifre.Location = new System.Drawing.Point(485, 220);
            this.lblPESifre.Name = "lblPESifre";
            this.lblPESifre.Size = new System.Drawing.Size(56, 17);
            this.lblPESifre.TabIndex = 18;
            this.lblPESifre.Text = "Şifresi :";
            // 
            // txtPersonelEkleSifre
            // 
            this.txtPersonelEkleSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.txtPersonelEkleSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPersonelEkleSifre.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPersonelEkleSifre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPersonelEkleSifre.Location = new System.Drawing.Point(560, 217);
            this.txtPersonelEkleSifre.Multiline = true;
            this.txtPersonelEkleSifre.Name = "txtPersonelEkleSifre";
            this.txtPersonelEkleSifre.PasswordChar = '*';
            this.txtPersonelEkleSifre.Size = new System.Drawing.Size(240, 24);
            this.txtPersonelEkleSifre.TabIndex = 19;
            // 
            // btnPersonelEkleKaydet
            // 
            this.btnPersonelEkleKaydet.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPersonelEkleKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonelEkleKaydet.FlatAppearance.BorderSize = 0;
            this.btnPersonelEkleKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonelEkleKaydet.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnPersonelEkleKaydet.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPersonelEkleKaydet.Location = new System.Drawing.Point(560, 260);
            this.btnPersonelEkleKaydet.Name = "btnPersonelEkleKaydet";
            this.btnPersonelEkleKaydet.Size = new System.Drawing.Size(240, 38);
            this.btnPersonelEkleKaydet.TabIndex = 20;
            this.btnPersonelEkleKaydet.Text = "PERSONELİ KAYDET";
            this.btnPersonelEkleKaydet.UseVisualStyleBackColor = false;
            this.btnPersonelEkleKaydet.Click += new System.EventHandler(this.btnPersonelEkleKaydet_Click);
            // 
            // PnlPersonelDuzenle
            // 
            this.PnlPersonelDuzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.PnlPersonelDuzenle.Controls.Add(this.btnPersonelDuzenleSil);
            this.PnlPersonelDuzenle.Controls.Add(this.btnPersonelDuzenleGuncelle);
            this.PnlPersonelDuzenle.Controls.Add(this.txtPersonelDuzenleSifre);
            this.PnlPersonelDuzenle.Controls.Add(this.lblPDSifre);
            this.PnlPersonelDuzenle.Controls.Add(this.txtPersonelDuzenleMaas);
            this.PnlPersonelDuzenle.Controls.Add(this.lblPDMaas);
            this.PnlPersonelDuzenle.Controls.Add(this.txtPersonelDuzenleAdres);
            this.PnlPersonelDuzenle.Controls.Add(this.lblPDAdres);
            this.PnlPersonelDuzenle.Controls.Add(this.cmbPersonelDuzenleYetki);
            this.PnlPersonelDuzenle.Controls.Add(this.lblPDYetki);
            this.PnlPersonelDuzenle.Controls.Add(this.txtPersonelDuzenleGorev);
            this.PnlPersonelDuzenle.Controls.Add(this.lblPDGorev);
            this.PnlPersonelDuzenle.Controls.Add(this.txtPersonelDuzenleMail);
            this.PnlPersonelDuzenle.Controls.Add(this.lblPDMail);
            this.PnlPersonelDuzenle.Controls.Add(this.txtPersonelDuzenleTelefon);
            this.PnlPersonelDuzenle.Controls.Add(this.lblPDTelefon);
            this.PnlPersonelDuzenle.Controls.Add(this.txtPersonelDuzenleAdSoyad);
            this.PnlPersonelDuzenle.Controls.Add(this.lblPDAdSoyad);
            this.PnlPersonelDuzenle.Controls.Add(this.txtPersonelDuzenleKullaniciAdi);
            this.PnlPersonelDuzenle.Controls.Add(this.lblPDKadi);
            this.PnlPersonelDuzenle.Controls.Add(this.txtPersonelDuzenleTC);
            this.PnlPersonelDuzenle.Controls.Add(this.lblPDTC);
            this.PnlPersonelDuzenle.Controls.Add(this.txtPersonelDuzenlePersonelNo);
            this.PnlPersonelDuzenle.Controls.Add(this.lblPDPersonelNo);
            this.PnlPersonelDuzenle.Controls.Add(this.lstPersonelAdlari);
            this.PnlPersonelDuzenle.Location = new System.Drawing.Point(0, 168);
            this.PnlPersonelDuzenle.Name = "PnlPersonelDuzenle";
            this.PnlPersonelDuzenle.Size = new System.Drawing.Size(1289, 431);
            this.PnlPersonelDuzenle.TabIndex = 11;
            this.PnlPersonelDuzenle.Visible = false;
            // 
            // lstPersonelAdlari
            // 
            this.lstPersonelAdlari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.lstPersonelAdlari.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstPersonelAdlari.Font = new System.Drawing.Font("Tahoma", 11F);
            this.lstPersonelAdlari.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lstPersonelAdlari.ItemHeight = 18;
            this.lstPersonelAdlari.Location = new System.Drawing.Point(35, 30);
            this.lstPersonelAdlari.Name = "lstPersonelAdlari";
            this.lstPersonelAdlari.Size = new System.Drawing.Size(260, 360);
            this.lstPersonelAdlari.TabIndex = 0;
            this.lstPersonelAdlari.DoubleClick += new System.EventHandler(this.lstPersonelAdlari_DoubleClick);
            // 
            // lblPDPersonelNo
            // 
            this.lblPDPersonelNo.AutoSize = true;
            this.lblPDPersonelNo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblPDPersonelNo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPDPersonelNo.Location = new System.Drawing.Point(335, 35);
            this.lblPDPersonelNo.Name = "lblPDPersonelNo";
            this.lblPDPersonelNo.Size = new System.Drawing.Size(96, 17);
            this.lblPDPersonelNo.TabIndex = 1;
            this.lblPDPersonelNo.Text = "Personel No :";
            // 
            // txtPersonelDuzenlePersonelNo
            // 
            this.txtPersonelDuzenlePersonelNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.txtPersonelDuzenlePersonelNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPersonelDuzenlePersonelNo.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPersonelDuzenlePersonelNo.ForeColor = System.Drawing.Color.Tomato;
            this.txtPersonelDuzenlePersonelNo.Location = new System.Drawing.Point(455, 32);
            this.txtPersonelDuzenlePersonelNo.Multiline = true;
            this.txtPersonelDuzenlePersonelNo.Name = "txtPersonelDuzenlePersonelNo";
            this.txtPersonelDuzenlePersonelNo.ReadOnly = true;
            this.txtPersonelDuzenlePersonelNo.Size = new System.Drawing.Size(240, 24);
            this.txtPersonelDuzenlePersonelNo.TabIndex = 2;
            // 
            // lblPDTC
            // 
            this.lblPDTC.AutoSize = true;
            this.lblPDTC.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblPDTC.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPDTC.Location = new System.Drawing.Point(325, 80);
            this.lblPDTC.Name = "lblPDTC";
            this.lblPDTC.Size = new System.Drawing.Size(106, 17);
            this.lblPDTC.TabIndex = 3;
            this.lblPDTC.Text = "TC Kimlik No :";
            // 
            // txtPersonelDuzenleTC
            // 
            this.txtPersonelDuzenleTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.txtPersonelDuzenleTC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPersonelDuzenleTC.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPersonelDuzenleTC.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPersonelDuzenleTC.Location = new System.Drawing.Point(455, 78);
            this.txtPersonelDuzenleTC.Mask = "00000000000";
            this.txtPersonelDuzenleTC.Name = "txtPersonelDuzenleTC";
            this.txtPersonelDuzenleTC.Size = new System.Drawing.Size(240, 20);
            this.txtPersonelDuzenleTC.TabIndex = 4;
            // 
            // lblPDKadi
            // 
            this.lblPDKadi.AutoSize = true;
            this.lblPDKadi.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblPDKadi.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPDKadi.Location = new System.Drawing.Point(335, 125);
            this.lblPDKadi.Name = "lblPDKadi";
            this.lblPDKadi.Size = new System.Drawing.Size(96, 17);
            this.lblPDKadi.TabIndex = 5;
            this.lblPDKadi.Text = "Kullanıcı Adı :";
            // 
            // txtPersonelDuzenleKullaniciAdi
            // 
            this.txtPersonelDuzenleKullaniciAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.txtPersonelDuzenleKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPersonelDuzenleKullaniciAdi.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPersonelDuzenleKullaniciAdi.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPersonelDuzenleKullaniciAdi.Location = new System.Drawing.Point(455, 122);
            this.txtPersonelDuzenleKullaniciAdi.Multiline = true;
            this.txtPersonelDuzenleKullaniciAdi.Name = "txtPersonelDuzenleKullaniciAdi";
            this.txtPersonelDuzenleKullaniciAdi.Size = new System.Drawing.Size(240, 24);
            this.txtPersonelDuzenleKullaniciAdi.TabIndex = 6;
            // 
            // lblPDAdSoyad
            // 
            this.lblPDAdSoyad.AutoSize = true;
            this.lblPDAdSoyad.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblPDAdSoyad.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPDAdSoyad.Location = new System.Drawing.Point(351, 170);
            this.lblPDAdSoyad.Name = "lblPDAdSoyad";
            this.lblPDAdSoyad.Size = new System.Drawing.Size(80, 17);
            this.lblPDAdSoyad.TabIndex = 7;
            this.lblPDAdSoyad.Text = "Adı Soyadı :";
            // 
            // txtPersonelDuzenleAdSoyad
            // 
            this.txtPersonelDuzenleAdSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.txtPersonelDuzenleAdSoyad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPersonelDuzenleAdSoyad.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPersonelDuzenleAdSoyad.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPersonelDuzenleAdSoyad.Location = new System.Drawing.Point(455, 167);
            this.txtPersonelDuzenleAdSoyad.Multiline = true;
            this.txtPersonelDuzenleAdSoyad.Name = "txtPersonelDuzenleAdSoyad";
            this.txtPersonelDuzenleAdSoyad.Size = new System.Drawing.Size(240, 24);
            this.txtPersonelDuzenleAdSoyad.TabIndex = 8;
            // 
            // lblPDTelefon
            // 
            this.lblPDTelefon.AutoSize = true;
            this.lblPDTelefon.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblPDTelefon.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPDTelefon.Location = new System.Drawing.Point(365, 215);
            this.lblPDTelefon.Name = "lblPDTelefon";
            this.lblPDTelefon.Size = new System.Drawing.Size(66, 17);
            this.lblPDTelefon.TabIndex = 9;
            this.lblPDTelefon.Text = "Telefon :";
            // 
            // txtPersonelDuzenleTelefon
            // 
            this.txtPersonelDuzenleTelefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.txtPersonelDuzenleTelefon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPersonelDuzenleTelefon.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPersonelDuzenleTelefon.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPersonelDuzenleTelefon.Location = new System.Drawing.Point(455, 213);
            this.txtPersonelDuzenleTelefon.Mask = "(999) 000-0000";
            this.txtPersonelDuzenleTelefon.Name = "txtPersonelDuzenleTelefon";
            this.txtPersonelDuzenleTelefon.Size = new System.Drawing.Size(240, 20);
            this.txtPersonelDuzenleTelefon.TabIndex = 10;
            // 
            // lblPDMail
            // 
            this.lblPDMail.AutoSize = true;
            this.lblPDMail.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblPDMail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPDMail.Location = new System.Drawing.Point(375, 260);
            this.lblPDMail.Name = "lblPDMail";
            this.lblPDMail.Size = new System.Drawing.Size(56, 17);
            this.lblPDMail.TabIndex = 11;
            this.lblPDMail.Text = "E-Mail :";
            // 
            // txtPersonelDuzenleMail
            // 
            this.txtPersonelDuzenleMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.txtPersonelDuzenleMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPersonelDuzenleMail.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPersonelDuzenleMail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPersonelDuzenleMail.Location = new System.Drawing.Point(455, 257);
            this.txtPersonelDuzenleMail.Multiline = true;
            this.txtPersonelDuzenleMail.Name = "txtPersonelDuzenleMail";
            this.txtPersonelDuzenleMail.Size = new System.Drawing.Size(240, 24);
            this.txtPersonelDuzenleMail.TabIndex = 12;
            // 
            // lblPDGorev
            // 
            this.lblPDGorev.AutoSize = true;
            this.lblPDGorev.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblPDGorev.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPDGorev.Location = new System.Drawing.Point(372, 305);
            this.lblPDGorev.Name = "lblPDGorev";
            this.lblPDGorev.Size = new System.Drawing.Size(59, 17);
            this.lblPDGorev.TabIndex = 13;
            this.lblPDGorev.Text = "Görevi :";
            // 
            // txtPersonelDuzenleGorev
            // 
            this.txtPersonelDuzenleGorev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.txtPersonelDuzenleGorev.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPersonelDuzenleGorev.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPersonelDuzenleGorev.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPersonelDuzenleGorev.Location = new System.Drawing.Point(455, 302);
            this.txtPersonelDuzenleGorev.Multiline = true;
            this.txtPersonelDuzenleGorev.Name = "txtPersonelDuzenleGorev";
            this.txtPersonelDuzenleGorev.Size = new System.Drawing.Size(240, 24);
            this.txtPersonelDuzenleGorev.TabIndex = 14;
            // 
            // lblPDYetki
            // 
            this.lblPDYetki.AutoSize = true;
            this.lblPDYetki.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblPDYetki.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPDYetki.Location = new System.Drawing.Point(740, 35);
            this.lblPDYetki.Name = "lblPDYetki";
            this.lblPDYetki.Size = new System.Drawing.Size(61, 17);
            this.lblPDYetki.TabIndex = 15;
            this.lblPDYetki.Text = "Yetkisi :";
            // 
            // cmbPersonelDuzenleYetki
            // 
            this.cmbPersonelDuzenleYetki.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.cmbPersonelDuzenleYetki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonelDuzenleYetki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPersonelDuzenleYetki.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cmbPersonelDuzenleYetki.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmbPersonelDuzenleYetki.FormattingEnabled = true;
            this.cmbPersonelDuzenleYetki.Location = new System.Drawing.Point(820, 32);
            this.cmbPersonelDuzenleYetki.Name = "cmbPersonelDuzenleYetki";
            this.cmbPersonelDuzenleYetki.Size = new System.Drawing.Size(240, 24);
            this.cmbPersonelDuzenleYetki.TabIndex = 16;
            // 
            // lblPDAdres
            // 
            this.lblPDAdres.AutoSize = true;
            this.lblPDAdres.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblPDAdres.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPDAdres.Location = new System.Drawing.Point(746, 80);
            this.lblPDAdres.Name = "lblPDAdres";
            this.lblPDAdres.Size = new System.Drawing.Size(55, 17);
            this.lblPDAdres.TabIndex = 17;
            this.lblPDAdres.Text = "Adresi :";
            // 
            // txtPersonelDuzenleAdres
            // 
            this.txtPersonelDuzenleAdres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.txtPersonelDuzenleAdres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPersonelDuzenleAdres.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtPersonelDuzenleAdres.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPersonelDuzenleAdres.Location = new System.Drawing.Point(820, 78);
            this.txtPersonelDuzenleAdres.MaxLength = 255;
            this.txtPersonelDuzenleAdres.Multiline = true;
            this.txtPersonelDuzenleAdres.Name = "txtPersonelDuzenleAdres";
            this.txtPersonelDuzenleAdres.Size = new System.Drawing.Size(240, 70);
            this.txtPersonelDuzenleAdres.TabIndex = 18;
            // 
            // lblPDMaas
            // 
            this.lblPDMaas.AutoSize = true;
            this.lblPDMaas.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblPDMaas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPDMaas.Location = new System.Drawing.Point(750, 170);
            this.lblPDMaas.Name = "lblPDMaas";
            this.lblPDMaas.Size = new System.Drawing.Size(51, 17);
            this.lblPDMaas.TabIndex = 19;
            this.lblPDMaas.Text = "Maaşı :";
            // 
            // txtPersonelDuzenleMaas
            // 
            this.txtPersonelDuzenleMaas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.txtPersonelDuzenleMaas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPersonelDuzenleMaas.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPersonelDuzenleMaas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPersonelDuzenleMaas.Location = new System.Drawing.Point(820, 167);
            this.txtPersonelDuzenleMaas.Multiline = true;
            this.txtPersonelDuzenleMaas.Name = "txtPersonelDuzenleMaas";
            this.txtPersonelDuzenleMaas.Size = new System.Drawing.Size(240, 24);
            this.txtPersonelDuzenleMaas.TabIndex = 20;
            // 
            // lblPDSifre
            // 
            this.lblPDSifre.AutoSize = true;
            this.lblPDSifre.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblPDSifre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPDSifre.Location = new System.Drawing.Point(745, 215);
            this.lblPDSifre.Name = "lblPDSifre";
            this.lblPDSifre.Size = new System.Drawing.Size(56, 17);
            this.lblPDSifre.TabIndex = 21;
            this.lblPDSifre.Text = "Şifresi :";
            // 
            // txtPersonelDuzenleSifre
            // 
            this.txtPersonelDuzenleSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.txtPersonelDuzenleSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPersonelDuzenleSifre.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtPersonelDuzenleSifre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtPersonelDuzenleSifre.Location = new System.Drawing.Point(820, 212);
            this.txtPersonelDuzenleSifre.Multiline = true;
            this.txtPersonelDuzenleSifre.Name = "txtPersonelDuzenleSifre";
            this.txtPersonelDuzenleSifre.PasswordChar = '*';
            this.txtPersonelDuzenleSifre.Size = new System.Drawing.Size(240, 24);
            this.txtPersonelDuzenleSifre.TabIndex = 22;
            // 
            // btnPersonelDuzenleGuncelle
            // 
            this.btnPersonelDuzenleGuncelle.BackColor = System.Drawing.Color.DarkCyan;
            this.btnPersonelDuzenleGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonelDuzenleGuncelle.FlatAppearance.BorderSize = 0;
            this.btnPersonelDuzenleGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonelDuzenleGuncelle.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnPersonelDuzenleGuncelle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPersonelDuzenleGuncelle.Location = new System.Drawing.Point(820, 255);
            this.btnPersonelDuzenleGuncelle.Name = "btnPersonelDuzenleGuncelle";
            this.btnPersonelDuzenleGuncelle.Size = new System.Drawing.Size(240, 38);
            this.btnPersonelDuzenleGuncelle.TabIndex = 23;
            this.btnPersonelDuzenleGuncelle.Text = "PERSONEL BİLGİLERİNİ GÜNCELLE";
            this.btnPersonelDuzenleGuncelle.UseVisualStyleBackColor = false;
            this.btnPersonelDuzenleGuncelle.Click += new System.EventHandler(this.btnPersonelDuzenleGuncelle_Click);
            // 
            // btnPersonelDuzenleSil
            // 
            this.btnPersonelDuzenleSil.BackColor = System.Drawing.Color.Firebrick;
            this.btnPersonelDuzenleSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonelDuzenleSil.FlatAppearance.BorderSize = 0;
            this.btnPersonelDuzenleSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonelDuzenleSil.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnPersonelDuzenleSil.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPersonelDuzenleSil.Location = new System.Drawing.Point(820, 305);
            this.btnPersonelDuzenleSil.Name = "btnPersonelDuzenleSil";
            this.btnPersonelDuzenleSil.Size = new System.Drawing.Size(240, 38);
            this.btnPersonelDuzenleSil.TabIndex = 24;
            this.btnPersonelDuzenleSil.Text = "PERSONEL KAYDINI SİL";
            this.btnPersonelDuzenleSil.UseVisualStyleBackColor = false;
            this.btnPersonelDuzenleSil.Click += new System.EventHandler(this.btnPersonelDuzenleSil_Click);
            // 
            // frmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1289, 599);
            this.Controls.Add(this.PnlPersonelDuzenle);
            this.Controls.Add(this.PnlPersonelEkle);
            this.Controls.Add(this.PnlYetkiIslemleri);
            this.Controls.Add(this.PnlYedekParcaIslemleri);
            this.Controls.Add(this.PnlYedekParcaKategori);
            this.Controls.Add(this.PnlSistemCihazIslemleri);
            this.Controls.Add(this.PnlMarkaIslemleri);
            this.Controls.Add(this.PnlSistem);
            this.Controls.Add(this.PnlPersonel);
            this.Controls.Add(this.PnlCari);
            this.Controls.Add(this.PnlCihaz);
            this.Controls.Add(this.PnlUst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAnasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teknik Servis Anasayfa";
            this.PnlUst.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PnlCihaz.ResumeLayout(false);
            this.PnlPersonel.ResumeLayout(false);
            this.PnlSistem.ResumeLayout(false);
            this.PnlMarkaIslemleri.ResumeLayout(false);
            this.PnlMarkaIslemleri.PerformLayout();
            this.PnlSistemCihazIslemleri.ResumeLayout(false);
            this.PnlSistemCihazIslemleri.PerformLayout();
            this.PnlYedekParcaKategori.ResumeLayout(false);
            this.PnlYedekParcaKategori.PerformLayout();
            this.PnlYedekParcaIslemleri.ResumeLayout(false);
            this.PnlYedekParcaIslemleri.PerformLayout();
            this.PnlYetkiIslemleri.ResumeLayout(false);
            this.PnlYetkiIslemleri.PerformLayout();
            this.grpYetkiler.ResumeLayout(false);
            this.grpYetkiler.PerformLayout();
            this.PnlPersonelEkle.ResumeLayout(false);
            this.PnlPersonelEkle.PerformLayout();
            this.PnlPersonelDuzenle.ResumeLayout(false);
            this.PnlPersonelDuzenle.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel PnlUst;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.LinkLabel lblKullaniciAdi;
        private System.Windows.Forms.Panel PnlCihaz;
        private System.Windows.Forms.Button btnCihazIslemleriCihazKayit;
        private System.Windows.Forms.Panel PnlCari;
        private System.Windows.Forms.Panel PnlPersonel;
        private System.Windows.Forms.Button btnPersonelDuzenle;
        private System.Windows.Forms.Button btnPersonelEkle;
        private System.Windows.Forms.Panel PnlSistem;
        private System.Windows.Forms.Button btnYetkiIslemleri;
        private System.Windows.Forms.Button btnYedekParcaIslemleri;
        private System.Windows.Forms.Button btnYedekParcaKategorisi;
        private System.Windows.Forms.Button btnCihazIslemleri;
        private System.Windows.Forms.Button btnMarkaIslemleri;
        private System.Windows.Forms.Panel PnlMarkaIslemleri;
        private System.Windows.Forms.Button btnMarkaSil;
        private System.Windows.Forms.Button btnYeniMarka;
        private System.Windows.Forms.Button btnMarkaGuncelle;
        private System.Windows.Forms.TextBox txtMarkaIslemleriMarkaAdi;
        private System.Windows.Forms.Label lblMarkaAdi;
        private System.Windows.Forms.Label lblMarkaIslemleriMarkaID;
        private System.Windows.Forms.Label lblMarkaIDBaslik;
        private System.Windows.Forms.ListBox lstMarkaIslemleriMarkalar;
        private System.Windows.Forms.Panel PnlSistemCihazIslemleri;
        private System.Windows.Forms.Button btnCihazSil;
        private System.Windows.Forms.Button btnYeniCihaz;
        private System.Windows.Forms.Button btnCihazGuncelle;
        private System.Windows.Forms.TextBox txtCihazIslemleriCihazAdi;
        private System.Windows.Forms.Label lblCihazAdiBaslik;
        private System.Windows.Forms.Label lblCihazIslemleriCihazID;
        private System.Windows.Forms.Label lblCihazIDBaslik;
        private System.Windows.Forms.ListBox lstCihazIslemleriCihazlar;
        private System.Windows.Forms.Panel PnlYedekParcaKategori;
        private System.Windows.Forms.Button btnYedekParcaKategoriSil;
        private System.Windows.Forms.Button btnYedekParcaYeniKategori;
        private System.Windows.Forms.Button btnYedekParcaKategoriGuncelle;
        private System.Windows.Forms.TextBox txtYedekParcaKategoriAdi;
        private System.Windows.Forms.Label lblKatAdiBaslik;
        private System.Windows.Forms.Label lblYedekParcaKategoriIslemleriID;
        private System.Windows.Forms.Label lblKatIDBaslik;
        private System.Windows.Forms.ListBox lstYedekParcaKategoriIslemleri;
        private System.Windows.Forms.Panel PnlYedekParcaIslemleri;
        private System.Windows.Forms.Button btnYedekParcaIslemleriSil;
        private System.Windows.Forms.Button btnYedekParcaIslemleriYeni;
        private System.Windows.Forms.Button btnYedekParcaIslemleriGuncelle;
        private System.Windows.Forms.TextBox txtYedekParcaIslemleriEkOzellikler;
        private System.Windows.Forms.Label lblYPOzellikBaslik;
        private System.Windows.Forms.TextBox txtYedekParcaIslemleriStok;
        private System.Windows.Forms.Label lblYPStokBaslik;
        private System.Windows.Forms.TextBox txtYedekParcaIslemleriModel;
        private System.Windows.Forms.Label lblYPModelBaslik;
        private System.Windows.Forms.ComboBox cmbYedekParcaIslemleriMarka;
        private System.Windows.Forms.Label lblYPMarkaBaslik;
        private System.Windows.Forms.ComboBox cmbYedekParcaIslemleriKategori;
        private System.Windows.Forms.Label lblYPKategoriBaslik;
        private System.Windows.Forms.Label lblYedekParcaIslemleriYedekParcaID;
        private System.Windows.Forms.Label lblYedekParcaIDBaslik;
        private System.Windows.Forms.Label lblYedekParcaIslemleri;
        private System.Windows.Forms.ListBox lstYedekParcaIslemleri;
        private System.Windows.Forms.Panel PnlYetkiIslemleri;
        private System.Windows.Forms.GroupBox grpYetkiler;
        private System.Windows.Forms.Button btnYetkiKaydet;
        private System.Windows.Forms.CheckBox chcSistemAyarlari;
        private System.Windows.Forms.CheckBox chcCariIslemler;
        private System.Windows.Forms.CheckBox chcYedekParca;
        private System.Windows.Forms.CheckBox chcKayitTamamlama;
        private System.Windows.Forms.CheckBox chcKayitAcma;
        private System.Windows.Forms.CheckBox chcPersonelSilme;
        private System.Windows.Forms.CheckBox chcPersonelEkleme;
        private System.Windows.Forms.Button btnYetkiGrubuEkle;
        private System.Windows.Forms.TextBox txtYetkiAdi;
        private System.Windows.Forms.ComboBox cmbYetkiler;
        private System.Windows.Forms.Label lblYetkiGrubuSec;
        private System.Windows.Forms.Panel PnlPersonelEkle;
        private System.Windows.Forms.Button btnPersonelEkleKaydet;
        private System.Windows.Forms.TextBox txtPersonelEkleSifre;
        private System.Windows.Forms.Label lblPESifre;
        private System.Windows.Forms.TextBox txtPersonelEkleMaas;
        private System.Windows.Forms.Label lblPEMaas;
        private System.Windows.Forms.TextBox txtPersonelEkleAdres;
        private System.Windows.Forms.Label lblPEAdres;
        private System.Windows.Forms.ComboBox cmbPersonelEkleYetki;
        private System.Windows.Forms.Label lblPEYetki;
        private System.Windows.Forms.TextBox txtPersonelEkleGorev;
        private System.Windows.Forms.Label lblPEGorev;
        private System.Windows.Forms.TextBox txtPersonelEkleMail;
        private System.Windows.Forms.Label lblPEMail;
        private System.Windows.Forms.MaskedTextBox txtPersonelEkleTelefon;
        private System.Windows.Forms.Label lblPETelefon;
        private System.Windows.Forms.TextBox txtPersonelEkleAdSoyad;
        private System.Windows.Forms.Label lblPEAdSoyad;
        private System.Windows.Forms.TextBox txtPersonelEkleKullaniciAdi;
        private System.Windows.Forms.Label lblPEKadi;
        private System.Windows.Forms.MaskedTextBox txtPersonelEkleTC;
        private System.Windows.Forms.Label lblPETC;
        private System.Windows.Forms.Panel PnlPersonelDuzenle;
        private System.Windows.Forms.Button btnPersonelDuzenleSil;
        private System.Windows.Forms.Button btnPersonelDuzenleGuncelle;
        private System.Windows.Forms.TextBox txtPersonelDuzenleSifre;
        private System.Windows.Forms.Label lblPDSifre;
        private System.Windows.Forms.TextBox txtPersonelDuzenleMaas;
        private System.Windows.Forms.Label lblPDMaas;
        private System.Windows.Forms.TextBox txtPersonelDuzenleAdres;
        private System.Windows.Forms.Label lblPDAdres;
        private System.Windows.Forms.ComboBox cmbPersonelDuzenleYetki;
        private System.Windows.Forms.Label lblPDYetki;
        private System.Windows.Forms.TextBox txtPersonelDuzenleGorev;
        private System.Windows.Forms.Label lblPDGorev;
        private System.Windows.Forms.TextBox txtPersonelDuzenleMail;
        private System.Windows.Forms.Label lblPDMail;
        private System.Windows.Forms.MaskedTextBox txtPersonelDuzenleTelefon;
        private System.Windows.Forms.Label lblPDTelefon;
        private System.Windows.Forms.TextBox txtPersonelDuzenleAdSoyad;
        private System.Windows.Forms.Label lblPDAdSoyad;
        private System.Windows.Forms.TextBox txtPersonelDuzenleKullaniciAdi;
        private System.Windows.Forms.Label lblPDKadi;
        private System.Windows.Forms.MaskedTextBox txtPersonelDuzenleTC;
        private System.Windows.Forms.Label lblPDTC;
        private System.Windows.Forms.TextBox txtPersonelDuzenlePersonelNo;
        private System.Windows.Forms.Label lblPDPersonelNo;
        private System.Windows.Forms.ListBox lstPersonelAdlari;
    }
}