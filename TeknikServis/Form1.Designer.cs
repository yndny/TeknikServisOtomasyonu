namespace TeknikServis
{
    partial class Form1
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
            this.lblKullanici = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.lblKapat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.lblBaslik.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.Tomato;
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(350, 55);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "TEKNİK SERVİS GİRİŞ";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.lblKullanici.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblKullanici.Location = new System.Drawing.Point(35, 80);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(96, 16);
            this.lblKullanici.TabIndex = 1;
            this.lblKullanici.Text = "Kullanıcı Adı :";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.txtKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtKullaniciAdi.ForeColor = System.Drawing.Color.White;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(38, 102);
            this.txtKullaniciAdi.Multiline = true;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(274, 28);
            this.txtKullaniciAdi.TabIndex = 2;
            this.txtKullaniciAdi.Text = "admin";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Verdana", 9.5F);
            this.lblSifre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSifre.Location = new System.Drawing.Point(35, 145);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(49, 16);
            this.lblSifre.TabIndex = 3;
            this.lblSifre.Text = "Şifre :";
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSifre.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtSifre.ForeColor = System.Drawing.Color.White;
            this.txtSifre.Location = new System.Drawing.Point(38, 167);
            this.txtSifre.Multiline = true;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(274, 28);
            this.txtSifre.TabIndex = 4;
            this.txtSifre.Text = "1234";
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.Tomato;
            this.btnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiris.FlatAppearance.BorderSize = 0;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnGiris.ForeColor = System.Drawing.Color.White;
            this.btnGiris.Location = new System.Drawing.Point(38, 215);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(274, 38);
            this.btnGiris.TabIndex = 5;
            this.btnGiris.Text = "SİSTEME GİRİŞ YAP";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // lblKapat
            // 
            this.lblKapat.AutoSize = true;
            this.lblKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblKapat.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lblKapat.ForeColor = System.Drawing.Color.Tomato;
            this.lblKapat.Location = new System.Drawing.Point(108, 270);
            this.lblKapat.Name = "lblKapat";
            this.lblKapat.Size = new System.Drawing.Size(135, 14);
            this.lblKapat.TabIndex = 6;
            this.lblKapat.Text = "PROGRAMI KAPAT";
            this.lblKapat.Click += new System.EventHandler(this.lblKapat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(350, 305);
            this.Controls.Add(this.lblKapat);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Girişi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label lblKapat;
    }
}