namespace TeknikServis
{
    partial class frmCihazKayit
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
            this.pnlUst = new System.Windows.Forms.Panel();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.lblDurum = new System.Windows.Forms.Label();
            this.txtArizaTahmin = new System.Windows.Forms.TextBox();
            this.lblTahmin = new System.Windows.Forms.Label();
            this.txtSikayet = new System.Windows.Forms.TextBox();
            this.lblSikayet = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.lblMarka = new System.Windows.Forms.Label();
            this.cmbCihazTuru = new System.Windows.Forms.ComboBox();
            this.lblCihazTuru = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCihazKaydet = new System.Windows.Forms.Button();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.lblTC = new System.Windows.Forms.Label();
            this.pnlUst.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.Color.DarkCyan;
            this.pnlUst.Controls.Add(this.lblBaslik);
            this.pnlUst.Controls.Add(this.btnKapat);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(790, 40);
            this.pnlUst.TabIndex = 0;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBaslik.Location = new System.Drawing.Point(15, 10);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(218, 18);
            this.lblBaslik.TabIndex = 1;
            this.lblBaslik.Text = "YENİ ARIZA / CİHAZ KAYDI";
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Firebrick;
            this.btnKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(745, 0);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(45, 40);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "X";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbDurum);
            this.groupBox1.Controls.Add(this.lblDurum);
            this.groupBox1.Controls.Add(this.txtArizaTahmin);
            this.groupBox1.Controls.Add(this.lblTahmin);
            this.groupBox1.Controls.Add(this.txtSikayet);
            this.groupBox1.Controls.Add(this.lblSikayet);
            this.groupBox1.Controls.Add(this.txtModel);
            this.groupBox1.Controls.Add(this.lblModel);
            this.groupBox1.Controls.Add(this.cmbMarka);
            this.groupBox1.Controls.Add(this.lblMarka);
            this.groupBox1.Controls.Add(this.cmbCihazTuru);
            this.groupBox1.Controls.Add(this.lblCihazTuru);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(15, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 395);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cihaz İşlemleri";
            // 
            // lblCihazTuru
            // 
            this.lblCihazTuru.AutoSize = true;
            this.lblCihazTuru.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.lblCihazTuru.Location = new System.Drawing.Point(20, 38);
            this.lblCihazTuru.Name = "lblCihazTuru";
            this.lblCihazTuru.Size = new System.Drawing.Size(73, 16);
            this.lblCihazTuru.TabIndex = 0;
            this.lblCihazTuru.Text = "Cihaz Türü :";
            // 
            // cmbCihazTuru
            // 
            this.cmbCihazTuru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.cmbCihazTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCihazTuru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCihazTuru.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.cmbCihazTuru.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmbCihazTuru.Location = new System.Drawing.Point(125, 35);
            this.cmbCihazTuru.Name = "cmbCihazTuru";
            this.cmbCihazTuru.Size = new System.Drawing.Size(220, 24);
            this.cmbCihazTuru.TabIndex = 1;
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.lblMarka.Location = new System.Drawing.Point(45, 78);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(48, 16);
            this.lblMarka.TabIndex = 2;
            this.lblMarka.Text = "Marka :";
            // 
            // cmbMarka
            // 
            this.cmbMarka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.cmbMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMarka.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.cmbMarka.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmbMarka.Location = new System.Drawing.Point(125, 75);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(220, 24);
            this.cmbMarka.TabIndex = 3;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.lblModel.Location = new System.Drawing.Point(47, 118);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(46, 16);
            this.lblModel.TabIndex = 4;
            this.lblModel.Text = "Model :";
            // 
            // txtModel
            // 
            this.txtModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.txtModel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtModel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtModel.Location = new System.Drawing.Point(125, 115);
            this.txtModel.Multiline = true;
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(220, 24);
            this.txtModel.TabIndex = 5;
            // 
            // lblSikayet
            // 
            this.lblSikayet.AutoSize = true;
            this.lblSikayet.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.lblSikayet.Location = new System.Drawing.Point(38, 158);
            this.lblSikayet.Name = "lblSikayet";
            this.lblSikayet.Size = new System.Drawing.Size(55, 16);
            this.lblSikayet.TabIndex = 6;
            this.lblSikayet.Text = "Şikayet :";
            // 
            // txtSikayet
            // 
            this.txtSikayet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.txtSikayet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSikayet.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txtSikayet.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtSikayet.Location = new System.Drawing.Point(125, 155);
            this.txtSikayet.MaxLength = 255;
            this.txtSikayet.Multiline = true;
            this.txtSikayet.Name = "txtSikayet";
            this.txtSikayet.Size = new System.Drawing.Size(220, 75);
            this.txtSikayet.TabIndex = 7;
            // 
            // lblTahmin
            // 
            this.lblTahmin.AutoSize = true;
            this.lblTahmin.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblTahmin.Location = new System.Drawing.Point(12, 245);
            this.lblTahmin.Name = "lblTahmin";
            this.lblTahmin.Size = new System.Drawing.Size(92, 30);
            this.lblTahmin.TabIndex = 8;
            this.lblTahmin.Text = "Tahmini Arıza :\r\n(Personel)";
            // 
            // txtArizaTahmin
            // 
            this.txtArizaTahmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.txtArizaTahmin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtArizaTahmin.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txtArizaTahmin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtArizaTahmin.Location = new System.Drawing.Point(125, 245);
            this.txtArizaTahmin.MaxLength = 255;
            this.txtArizaTahmin.Multiline = true;
            this.txtArizaTahmin.Name = "txtArizaTahmin";
            this.txtArizaTahmin.Size = new System.Drawing.Size(220, 75);
            this.txtArizaTahmin.TabIndex = 9;
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.lblDurum.Location = new System.Drawing.Point(36, 340);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(57, 16);
            this.lblDurum.TabIndex = 10;
            this.lblDurum.Text = "Durumu :";
            // 
            // cmbDurum
            // 
            this.cmbDurum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.cmbDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDurum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDurum.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.cmbDurum.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmbDurum.Location = new System.Drawing.Point(125, 337);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(220, 24);
            this.cmbDurum.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCihazKaydet);
            this.groupBox2.Controls.Add(this.txtAdres);
            this.groupBox2.Controls.Add(this.lblAdres);
            this.groupBox2.Controls.Add(this.txtTelefon);
            this.groupBox2.Controls.Add(this.lblTelefon);
            this.groupBox2.Controls.Add(this.txtMail);
            this.groupBox2.Controls.Add(this.lblMail);
            this.groupBox2.Controls.Add(this.txtAdSoyad);
            this.groupBox2.Controls.Add(this.lblAdSoyad);
            this.groupBox2.Controls.Add(this.txtTC);
            this.groupBox2.Controls.Add(this.lblTC);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Location = new System.Drawing.Point(400, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 395);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri Bilgileri";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.lblTC.Location = new System.Drawing.Point(34, 38);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(74, 16);
            this.lblTC.TabIndex = 0;
            this.lblTC.Text = "Müşteri TC :";
            // 
            // txtTC
            // 
            this.txtTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.txtTC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTC.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtTC.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtTC.Location = new System.Drawing.Point(125, 35);
            this.txtTC.MaxLength = 11;
            this.txtTC.Multiline = true;
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(225, 24);
            this.txtTC.TabIndex = 1;
            this.txtTC.TextChanged += new System.EventHandler(this.txtTC_TextChanged);
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.lblAdSoyad.Location = new System.Drawing.Point(38, 78);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(70, 16);
            this.lblAdSoyad.TabIndex = 2;
            this.lblAdSoyad.Text = "Adı Soyadı :";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.txtAdSoyad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdSoyad.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtAdSoyad.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtAdSoyad.Location = new System.Drawing.Point(125, 75);
            this.txtAdSoyad.Multiline = true;
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(225, 24);
            this.txtAdSoyad.TabIndex = 3;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.lblMail.Location = new System.Drawing.Point(72, 118);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(36, 16);
            this.lblMail.TabIndex = 4;
            this.lblMail.Text = "Mail :";
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMail.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtMail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtMail.Location = new System.Drawing.Point(125, 115);
            this.txtMail.Multiline = true;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(225, 24);
            this.txtMail.TabIndex = 5;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.lblTelefon.Location = new System.Drawing.Point(52, 158);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(56, 16);
            this.lblTelefon.TabIndex = 6;
            this.lblTelefon.Text = "Telefon :";
            // 
            // txtTelefon
            // 
            this.txtTelefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.txtTelefon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefon.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtTelefon.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtTelefon.Location = new System.Drawing.Point(125, 155);
            this.txtTelefon.Mask = "(999) 000-0000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(225, 22);
            this.txtTelefon.TabIndex = 7;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.lblAdres.Location = new System.Drawing.Point(62, 198);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(46, 16);
            this.lblAdres.TabIndex = 8;
            this.lblAdres.Text = "Adres :";
            // 
            // txtAdres
            // 
            this.txtAdres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.txtAdres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdres.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txtAdres.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtAdres.Location = new System.Drawing.Point(125, 195);
            this.txtAdres.MaxLength = 255;
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(225, 125);
            this.txtAdres.TabIndex = 9;
            // 
            // btnCihazKaydet
            // 
            this.btnCihazKaydet.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCihazKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCihazKaydet.FlatAppearance.BorderSize = 0;
            this.btnCihazKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCihazKaydet.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnCihazKaydet.ForeColor = System.Drawing.Color.White;
            this.btnCihazKaydet.Location = new System.Drawing.Point(125, 333);
            this.btnCihazKaydet.Name = "btnCihazKaydet";
            this.btnCihazKaydet.Size = new System.Drawing.Size(225, 38);
            this.btnCihazKaydet.TabIndex = 10;
            this.btnCihazKaydet.Text = "CİHAZ GİRİŞİNİ KAYDET";
            this.btnCihazKaydet.UseVisualStyleBackColor = false;
            this.btnCihazKaydet.Click += new System.EventHandler(this.btnCihazKaydet_Click);
            // 
            // frmCihazKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(790, 465);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlUst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCihazKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cihaz Kayıt İşlemleri";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmCihazKayit_Load);
            this.pnlUst.ResumeLayout(false);
            this.pnlUst.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.TextBox txtArizaTahmin;
        private System.Windows.Forms.Label lblTahmin;
        private System.Windows.Forms.TextBox txtSikayet;
        private System.Windows.Forms.Label lblSikayet;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.ComboBox cmbCihazTuru;
        private System.Windows.Forms.Label lblCihazTuru;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCihazKaydet;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label lblTC;
    }
}