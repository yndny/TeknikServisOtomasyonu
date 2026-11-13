# 🛠️ C# Teknik Servis Otomasyonu

C# Windows Forms (.NET Framework) ve MS SQL Server kullanılarak geliştirilmiş Teknik Servis ve Arıza Takip Otomasyonu.

## 🚀 Kurulum ve Çalıştırma (Hızlı Başlangıç)

### 1. Veritabanı Kurulumu
1. **SQL Server Management Studio (SSMS)** uygulamasını açın.
2. Ana dizinde yer alan **eritabani_kurulum.sql** dosyasını SSMS içerisine sürükleyin (veya New Query ekranına yapıştırın) ve **Execute (F5)** tuşuna basın.
3. Bu işlem TeknikServis veritabanını, ilişkili tabloları ve varsayılan yönetici hesabını otomatik olarak oluşturacaktır.

### 2. İlk Çalıştırma ve Bağlantı Ayarı
1. TeknikServis.sln dosyasını Visual Studio ile açıp projeyi başlatın (**Start / F5**).
2. İlk açılışta **Ayarlar.xml** dosyası henüz oluşmadığı için **Veritabanı Kayıt** ekranı açılacaktır:
   * **Sunucu Adı:** Yerel varsayılan SQL Server için . (nokta), SQL Express kurulumu için .\SQLEXPRESS yazınız.
   * **Veritabanı Adı:** TeknikServis (Hazır gelir)
   * **Kullanıcı Adı:** Windows *(Şifresiz Windows Authentication ile doğrudan bağlanmak için Windows bırakınız).*
3. **VERİLERİ KAYDET** butonuna bastığınızda bağlantı bilgileri **MD5 + TripleDES** ile şifrelenerek Ayarlar.xml dosyasına kaydedilir ve uygulama yeniden başlar.

---

## 🔑 Varsayılan Giriş Bilgileri

| Alan | Değer |
| :--- | :--- |
| **Kullanıcı Adı** | dmin |
| **Şifre** | 1234 |
