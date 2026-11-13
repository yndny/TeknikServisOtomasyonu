USE master;
GO

IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'TeknikServis')
BEGIN
    CREATE DATABASE [TeknikServis];
END
GO

USE [TeknikServis];
GO

IF OBJECT_ID('dbo.Yetkilendirme', 'U') IS NULL
CREATE TABLE dbo.Yetkilendirme (
    YetkiID INT IDENTITY(1,1) PRIMARY KEY,
    YetkiAdi NVARCHAR(50),
    PersonelEkle BIT DEFAULT 0,
    PersonelSil BIT DEFAULT 0,
    KayitAcma BIT DEFAULT 0,
    KayitTamamlama BIT DEFAULT 0,
    YedekParcaIslemleri BIT DEFAULT 0,
    CariIslemleri BIT DEFAULT 0,
    SistemAyarlari BIT DEFAULT 0
);

IF OBJECT_ID('dbo.Personel', 'U') IS NULL
CREATE TABLE dbo.Personel (
    PersonelID INT IDENTITY(1,1) PRIMARY KEY,
    TC NCHAR(11),
    KullaniciAdi NVARCHAR(MAX),
    AdSoyad NVARCHAR(MAX),
    Telefon NVARCHAR(15),
    Mail NVARCHAR(MAX),
    Adres NVARCHAR(MAX),
    Gorevi NVARCHAR(MAX),
    Yetkisi INT FOREIGN KEY REFERENCES dbo.Yetkilendirme(YetkiID),
    CalismaDurumu NVARCHAR(MAX),
    Maas NVARCHAR(MAX),
    Password NVARCHAR(MAX),
    Silindi BIT DEFAULT 0 NOT NULL
);

IF OBJECT_ID('dbo.Cihazlar', 'U') IS NULL
CREATE TABLE dbo.Cihazlar (
    CihazID INT IDENTITY(1,1) PRIMARY KEY,
    CihazAdi NVARCHAR(MAX),
    Silindi BIT DEFAULT 0 NOT NULL
);

IF OBJECT_ID('dbo.Markalar', 'U') IS NULL
CREATE TABLE dbo.Markalar (
    MarkaID INT IDENTITY(1,1) PRIMARY KEY,
    MarkaAdi NVARCHAR(MAX),
    Silindi BIT DEFAULT 0 NOT NULL
);

IF OBJECT_ID('dbo.YedekParcaUstKategori', 'U') IS NULL
CREATE TABLE dbo.YedekParcaUstKategori (
    KategoriID INT IDENTITY(1,1) PRIMARY KEY,
    KategoriAdi NVARCHAR(MAX),
    Silindi BIT DEFAULT 0 NOT NULL
);

IF OBJECT_ID('dbo.YedekParca', 'U') IS NULL
CREATE TABLE dbo.YedekParca (
    YedekParcaID INT IDENTITY(1,1) PRIMARY KEY,
    KategoriID INT FOREIGN KEY REFERENCES dbo.YedekParcaUstKategori(KategoriID),
    Marka INT FOREIGN KEY REFERENCES dbo.Markalar(MarkaID),
    Model NVARCHAR(MAX),
    Stok INT,
    Ozellikler NVARCHAR(MAX),
    EkleyenPersonel INT FOREIGN KEY REFERENCES dbo.Personel(PersonelID)
);

IF OBJECT_ID('dbo.Musteriler', 'U') IS NULL
CREATE TABLE dbo.Musteriler (
    MusteriID INT IDENTITY(1,1) PRIMARY KEY,
    TC NCHAR(11),
    AdSoyad NVARCHAR(MAX),
    Mail NVARCHAR(MAX),
    Telefon NVARCHAR(MAX),
    Adres NVARCHAR(MAX),
    KayitTarihi DATE,
    KaydedenPersonel INT FOREIGN KEY REFERENCES dbo.Personel(PersonelID)
);

IF OBJECT_ID('dbo.Islemler', 'U') IS NULL
CREATE TABLE dbo.Islemler (
    IslemID INT IDENTITY(1,1) PRIMARY KEY,
    IslemAdi NVARCHAR(MAX),
    Silindi BIT DEFAULT 0 NOT NULL
);

IF OBJECT_ID('dbo.ArizaKayit', 'U') IS NULL
CREATE TABLE dbo.ArizaKayit (
    KayitID INT IDENTITY(1,1) PRIMARY KEY,
    MusteriID INT FOREIGN KEY REFERENCES dbo.Musteriler(MusteriID),
    CihazID INT FOREIGN KEY REFERENCES dbo.Cihazlar(CihazID),
    MarkaID INT FOREIGN KEY REFERENCES dbo.Markalar(MarkaID),
    Model NVARCHAR(MAX),
    Sikayet NVARCHAR(MAX),
    TahminiArizaSebebi NVARCHAR(MAX),
    KayitTarihi DATE,
    Durumu INT FOREIGN KEY REFERENCES dbo.Islemler(IslemID)
);

IF OBJECT_ID('dbo.ArizaDetay', 'U') IS NULL
CREATE TABLE dbo.ArizaDetay (
    DetayID INT IDENTITY(1,1) PRIMARY KEY,
    KayitID INT FOREIGN KEY REFERENCES dbo.ArizaKayit(KayitID),
    IslemTarihi DATE,
    YapilanIslem NVARCHAR(MAX),
    YapanPersonel INT FOREIGN KEY REFERENCES dbo.Personel(PersonelID)
);

IF OBJECT_ID('dbo.Cari', 'U') IS NULL
CREATE TABLE dbo.Cari (
    CariID INT IDENTITY(1,1) PRIMARY KEY,
    MusteriID INT FOREIGN KEY REFERENCES dbo.Musteriler(MusteriID),
    Tutar DECIMAL(18,2) DEFAULT 0,
    KayitTarihi DATE,
    Aktiflik BIT DEFAULT 1
);

IF OBJECT_ID('dbo.CariDetay', 'U') IS NULL
CREATE TABLE dbo.CariDetay (
    CariDetayID INT IDENTITY(1,1) PRIMARY KEY,
    CariID INT FOREIGN KEY REFERENCES dbo.Cari(CariID),
    IslemTarihi DATE,
    IslemTutari DECIMAL(18,2),
    KalanBakiye DECIMAL(18,2),
    Detay NVARCHAR(MAX),
    YapanPersonel INT FOREIGN KEY REFERENCES dbo.Personel(PersonelID)
);

IF OBJECT_ID('dbo.Sistem', 'U') IS NULL
CREATE TABLE dbo.Sistem (
    SistemID INT IDENTITY(1,1) PRIMARY KEY,
    SirketAdi NVARCHAR(MAX),
    VergiNo NVARCHAR(MAX),
    Telefon NVARCHAR(MAX),
    Adres NVARCHAR(MAX),
    Mail NVARCHAR(MAX),
    MailSifre NVARCHAR(MAX),
    MailHost NVARCHAR(MAX),
    MailPort INT,
    MaksimumCari DECIMAL(18,2) DEFAULT 5000
);
GO

IF NOT EXISTS (SELECT * FROM dbo.Yetkilendirme)
BEGIN
    INSERT INTO dbo.Yetkilendirme (YetkiAdi, PersonelEkle, PersonelSil, KayitAcma, KayitTamamlama, YedekParcaIslemleri, CariIslemleri, SistemAyarlari)
    VALUES (N'Admin', 1, 1, 1, 1, 1, 1, 1),
           (N'Personel', 0, 0, 1, 1, 1, 0, 0);
END

IF NOT EXISTS (SELECT * FROM dbo.Personel WHERE KullaniciAdi = N'admin')
BEGIN
    INSERT INTO dbo.Personel (TC, KullaniciAdi, AdSoyad, Telefon, Mail, Adres, Gorevi, Yetkisi, CalismaDurumu, Maas, Password, Silindi)
    VALUES (N'11111111111', N'admin', N'Sistem Yöneticisi', N'(555) 000-0000', N'admin@teknikservis.com', N'Merkez', N'YÖNETİCİ', 1, N'Aktif', N'15000', N'1234', 0);
END

IF NOT EXISTS (SELECT * FROM dbo.Markalar)
    INSERT INTO dbo.Markalar (MarkaAdi, Silindi) VALUES (N'SAMSUNG', 0), (N'APPLE', 0), (N'ASUS', 0), (N'ARÇELİK', 0);

IF NOT EXISTS (SELECT * FROM dbo.Cihazlar)
    INSERT INTO dbo.Cihazlar (CihazAdi, Silindi) VALUES (N'CEP TELEFONU', 0), (N'LAPTOP / BİLGİSAYAR', 0), (N'TABLET', 0);

IF NOT EXISTS (SELECT * FROM dbo.YedekParcaUstKategori)
    INSERT INTO dbo.YedekParcaUstKategori (KategoriAdi, Silindi) VALUES (N'EKRAN', 0), (N'BATARYA', 0), (N'ANAKART', 0), (N'MENTEŞE', 0);

IF NOT EXISTS (SELECT * FROM dbo.Islemler)
    INSERT INTO dbo.Islemler (IslemAdi, Silindi) VALUES (N'KAYIT OLUŞTURULDU', 0), (N'CİHAZ İNCELENİYOR', 0), (N'ONARIM TAMAMLANDI', 0), (N'TESLİM EDİLDİ', 0);

IF NOT EXISTS (SELECT * FROM dbo.Sistem)
    INSERT INTO dbo.Sistem (SirketAdi, VergiNo, Telefon, Adres, Mail, MailSifre, MailHost, MailPort, MaksimumCari)
    VALUES (N'Teknik Servis A.Ş.', N'1234567890', N'02120000000', N'Türkiye', N'info@teknikservis.com', N'1234', N'smtp.gmail.com', 587, 5000);
GO
