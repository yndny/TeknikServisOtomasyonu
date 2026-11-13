namespace TeknikServis
{
    partial class DatabaseBilgileri
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
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblUyari = new System.Windows.Forms.Label();
            this.lblSunucu = new System.Windows.Forms.Label();
            this.txtSunucuAdi = new System.Windows.Forms.TextBox();
            this.txtVeritabaniAdi = new System.Windows.Forms.TextBox();
            this.lblVeritabani = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtAnahtar = new System.Windows.Forms.TextBox();
            this.lblAnahtar = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lblKapat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.BackColor = System.Drawing.Color.DarkRed;
            this.lblBaslik.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(360, 50);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "   VERİTABANI KAYIT";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUyari
            // 
            this.lblUyari.Font = new System.Drawing.Font("Verdana", 8.5F, System.Drawing.FontStyle.Regular);
            this.lblUyari.ForeColor = System.Drawing.Color.DimGray;
            this.lblUyari.Location = new System.Drawing.Point(25, 65);
            this.lblUyari.Name = "lblUyari";
            this.lblUyari.Size = new System.Drawing.Size(310, 35);
            this.lblUyari.TabIndex = 1;
            this.lblUyari.Text = "* Lütfen veritabanı kullanıcı bilgilerini eksiksiz ve doğru giriniz. (Şifresiz giriş için Kullanıcıya Windows yazın)";
            // 
            // lblSunucu
            // 
            this.lblSunucu.AutoSize = true;
            this.lblSunucu.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular);
            this.lblSunucu.ForeColor = System.Drawing.Color.DimGray;
            this.lblSunucu.Location = new System.Drawing.Point(25, 110);
            this.lblSunucu.Name = "lblSunucu";
            this.lblSunucu.Size = new System.Drawing.Size(85, 14);
            this.lblSunucu.TabIndex = 2;
            this.lblSunucu.Text = "Sunucu Adı :";
            // 
            // txtSunucuAdi
            // 
            this.txtSunucuAdi.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSunucuAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSunucuAdi.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtSunucuAdi.Location = new System.Drawing.Point(28, 128);
            this.txtSunucuAdi.Multiline = true;
            this.txtSunucuAdi.Name = "txtSunucuAdi";
            this.txtSunucuAdi.Size = new System.Drawing.Size(304, 26);
            this.txtSunucuAdi.TabIndex = 3;
            this.txtSunucuAdi.Text = ".";
            // 
            // lblVeritabani
            // 
            this.lblVeritabani.AutoSize = true;
            this.lblVeritabani.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular);
            this.lblVeritabani.ForeColor = System.Drawing.Color.DimGray;
            this.lblVeritabani.Location = new System.Drawing.Point(25, 165);
            this.lblVeritabani.Name = "lblVeritabani";
            this.lblVeritabani.Size = new System.Drawing.Size(102, 14);
            this.lblVeritabani.TabIndex = 4;
            this.lblVeritabani.Text = "Veritabanı Adı :";
            // 
            // txtVeritabaniAdi
            // 
            this.txtVeritabaniAdi.BackColor = System.Drawing.Color.Gainsboro;
            this.txtVeritabaniAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVeritabaniAdi.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtVeritabaniAdi.Location = new System.Drawing.Point(28, 183);
            this.txtVeritabaniAdi.Multiline = true;
            this.txtVeritabaniAdi.Name = "txtVeritabaniAdi";
            this.txtVeritabaniAdi.Size = new System.Drawing.Size(304, 26);
            this.txtVeritabaniAdi.TabIndex = 5;
            this.txtVeritabaniAdi.Text = "TeknikServis";
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular);
            this.lblKullanici.ForeColor = System.Drawing.Color.DimGray;
            this.lblKullanici.Location = new System.Drawing.Point(25, 220);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(91, 14);
            this.lblKullanici.TabIndex = 6;
            this.lblKullanici.Text = "Kullanıcı Adı :";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.Color.Gainsboro;
            this.txtKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtKullaniciAdi.Location = new System.Drawing.Point(28, 238);
            this.txtKullaniciAdi.Multiline = true;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(304, 26);
            this.txtKullaniciAdi.TabIndex = 7;
            this.txtKullaniciAdi.Text = "Windows";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular);
            this.lblSifre.ForeColor = System.Drawing.Color.DimGray;
            this.lblSifre.Location = new System.Drawing.Point(25, 275);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(46, 14);
            this.lblSifre.TabIndex = 8;
            this.lblSifre.Text = "Şifre :";
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSifre.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtSifre.Location = new System.Drawing.Point(28, 293);
            this.txtSifre.Multiline = true;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(304, 26);
            this.txtSifre.TabIndex = 9;
            this.txtSifre.Text = "1234";
            // 
            // lblAnahtar
            // 
            this.lblAnahtar.AutoSize = true;
            this.lblAnahtar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular);
            this.lblAnahtar.ForeColor = System.Drawing.Color.DimGray;
            this.lblAnahtar.Location = new System.Drawing.Point(25, 330);
            this.lblAnahtar.Name = "lblAnahtar";
            this.lblAnahtar.Size = new System.Drawing.Size(110, 14);
            this.lblAnahtar.TabIndex = 10;
            this.lblAnahtar.Text = "Anahtar Kelime :";
            // 
            // txtAnahtar
            // 
            this.txtAnahtar.BackColor = System.Drawing.Color.Gainsboro;
            this.txtAnahtar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAnahtar.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtAnahtar.Location = new System.Drawing.Point(28, 348);
            this.txtAnahtar.Multiline = true;
            this.txtAnahtar.Name = "txtAnahtar";
            this.txtAnahtar.PasswordChar = '*';
            this.txtAnahtar.Size = new System.Drawing.Size(304, 26);
            this.txtAnahtar.TabIndex = 11;
            this.txtAnahtar.Text = "TeknikServisKey";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Firebrick;
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnKaydet.Location = new System.Drawing.Point(28, 390);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(304, 38);
            this.btnKaydet.TabIndex = 12;
            this.btnKaydet.Text = "VERİLERİ KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblKapat
            // 
            this.lblKapat.AutoSize = true;
            this.lblKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblKapat.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lblKapat.ForeColor = System.Drawing.Color.Firebrick;
            this.lblKapat.Location = new System.Drawing.Point(110, 440);
            this.lblKapat.Name = "lblKapat";
            this.lblKapat.Size = new System.Drawing.Size(142, 14);
            this.lblKapat.TabIndex = 13;
            this.lblKapat.Text = "PROGRAMI KAPAT";
            this.lblKapat.Click += new System.EventHandler(this.lblKapat_Click);
            // 
            // DatabaseBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(360, 475);
            this.Controls.Add(this.lblKapat);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtAnahtar);
            this.Controls.Add(this.lblAnahtar);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.txtVeritabaniAdi);
            this.Controls.Add(this.lblVeritabani);
            this.Controls.Add(this.txtSunucuAdi);
            this.Controls.Add(this.lblSunucu);
            this.Controls.Add(this.lblUyari);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DatabaseBilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatabaseBilgileri";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblUyari;
        private System.Windows.Forms.Label lblSunucu;
        private System.Windows.Forms.TextBox txtSunucuAdi;
        private System.Windows.Forms.TextBox txtVeritabaniAdi;
        private System.Windows.Forms.Label lblVeritabani;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtAnahtar;
        private System.Windows.Forms.Label lblAnahtar;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lblKapat;
    }
}