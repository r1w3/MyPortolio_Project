# Portfolio Project

Kişisel portfolyo websitesi ve içerik yönetim paneli. ASP.NET Core MVC ile geliştirildi; ziyaretçilerin gördüğü public site ile içeriğin tamamının yönetildiği bir admin panelden oluşuyor.

## Özellikler

**Public Site**
- Dinamik banner ve hakkımda bölümü
- Proje vitrini (teknoloji etiketleriyle)
- Deneyim, eğitim ve yetenek listesi
- Sunulan hizmetler
- İletişim formu

**Admin Panel**
- Proje yönetimi (CRUD)
- Deneyim & eğitim geçmişi yönetimi
- Yetenek yönetimi (aktif/pasif kontrolü)
- Hizmet yönetimi
- Teknoloji (tech stack) yönetimi
- Banner ve iletişim bilgileri yönetimi
- Gelen mesaj kutusu (okundu/okunmadı filtreleme)
- İstatistiklerin göründüğü dashboard
- Profil ve şifre güncelleme

## Kullanılan Teknolojiler

- **Backend:** ASP.NET Core MVC
- **ORM:** Entity Framework Core (Code First)
- **Veritabanı:** Microsoft SQL Server
- **Kimlik Doğrulama:** Cookie tabanlı (Claims)
- **Frontend:** Bootstrap 5, Bootstrap Icons
- **Bildirimler:** SweetAlert2

## Kurulum

1. Repoyu klonla:
   ```bash
   git clone https://github.com/r1w3/MyPortolio_Project.git
   ```

2. `appsettings.json` içindeki connection string'i kendi SQL Server bağlantına göre düzenle.

3. Migration'ları uygula:
   ```bash
   dotnet ef database update
   ```

4. Projeyi çalıştır:
   ```bash
   dotnet run
   ```

## Notlar

Proje aktif olarak geliştirilmeye devam ediyor. Katkı ve geri bildirimlere açığım.
