# 🌾 Agriculture Presentation (Tarım Kurumsal Web Sitesi)

Bu proje, ASP.NET Core MVC ve **N-Katmanlı Mimari (N-Tier Architecture)** prensipleri kullanılarak geliştirilmiş, tarım sektörüne yönelik dinamik bir kurumsal web sitesi ve yönetim paneli uygulamasıdır. 

Murat Yücedağ'ın "C# ile OOP Temelleri: Adım Adım Katmanlı Mimari" eğitimi referans alınarak, kodlama pratiği yapmak ve **Repository Pattern** ile nesne yönelimli programlama (OOP) kavramlarını gerçek bir projede deneyimlemek amacıyla geliştirilmiştir.

---

## 🎯 Projenin Amacı ve Öğrenim Çıktıları
Bu projenin temel odak noktası sadece çalışan bir web sitesi yapmak değil, arka plandaki **mimariyi** sağlam kurmaktır. Proje geliştirme sürecinde elde edilen ana kazanımlar:
* **Separation of Concerns (Sorumlulukların Ayrılığı):** Projeyi katmanlara bölerek sürdürülebilirliği artırmak.
* **Repository Design Pattern:** Veritabanı işlemlerini soyutlayarak (abstraction) tekrar eden kodların önüne geçmek.
* **Identity Kütüphanesi:** Güvenli kullanıcı girişi (Authentication) ve yetkilendirme (Authorization) mekanizmalarını kurmak.

---

## 🏛️ Mimari Yapı (N-Layer Architecture)
Proje, bağımlılıkları en aza indirmek ve modülerliği sağlamak için 4 ana katmandan oluşmaktadır:
1. **EntityLayer:** Veritabanı tablolarının sınıflara (class) dönüştürüldüğü, varlıkların tutulduğu katman.
2. **DataAccessLayer (DAL):** Entity Framework Core kullanılarak veritabanı CRUD operasyonlarının (Repository Pattern ile) yürütüldüğü katman.
3. **BusinessLayer (BLL):** Verilerin sunum katmanına gitmeden önce iş kurallarından (Business Rules) ve doğrulama (FluentValidation) süreçlerinden geçtiği güvenlik duvarı.
4. **PresentationLayer (UI):** Kullanıcının etkileşime girdiği, ASP.NET Core MVC yapısıyla oluşturulmuş arayüz (Controller & Views).

---

## 🛠️ Kullanılan Teknolojiler & Araçlar
* **Backend:** C# / .NET Core, ASP.NET Core MVC
* **Veritabanı & ORM:** Microsoft SQL Server, Entity Framework Core (Code First)
* **Güvenlik:** ASP.NET Core Identity (Login/Register, Rol Yönetimi)
* **Mimari Desenler:** Repository Pattern, Dependency Injection
* **Validasyon:** FluentValidation
* **Frontend:** HTML5, CSS3, Bootstrap, Chart.js (Grafik Raporlamaları)

---

## 👨‍💻 Admin Paneli Özellikleri
Proje, tüm içeriklerin dinamik olarak yönetilebildiği bir yönetici paneline sahiptir:
* **Dashboard:** Sistem istatistiklerinin ve Chart.js entegreli grafiklerin bulunduğu kontrol merkezi.
* **Modül Yönetimi:** Hizmetler, Takım Arkadaşları, Haberler ve Duyuruların (CRUD) işlemleri.
* **Mesajlaşma:** Ziyaretçilerden gelen mesajların listelenmesi ve yönetimi.
* **Yetkilendirme:** Sadece onaylı yöneticilerin paneline erişebilmesi.

---

## 📸 Ekran Görüntüleri


| Vitrin (Ana Sayfa) | Admin Dashboard |
| :---: | :---: |
| ![Ana Sayfa](https://github.com/user-attachments/assets/b407c069-eab5-4f52-bb47-c840a7d9517f) | ![Dashboard](https://github.com/user-attachments/assets/27265518-f0d9-4eee-b831-e1b5586289e4) |

| Hizmetler Yönetimi | Login / Giriş Ekranı |
| :---: | :---: |
| ![Hizmetler](https://github.com/user-attachments/assets/cb547d4a-ba10-4fe1-b3f6-496e3b133a70) | ![Login](https://github.com/user-attachments/assets/c8375feb-b919-4cac-af79-eb56311e03c6) |

---

## 🚧 Bilinen Eksikler ve Geliştirilecekler (To-Do)
Bir yazılım projesi asla tam anlamıyla bitmez. Bu eğitim projesinde temel atılmış olup, ilerleyen süreçlerde eklenecek/düzeltilecek teknik borçlar (Technical Debt) şunlardır:
- [ ] **Hata Yönetimi (Exception Handling):** Sistem genelinde global bir hata yakalama mekanizması kurulması.
- [ ] **Şifremi Unuttum Modülü:** Identity üzerinden e-posta entegrasyonu (SMTP) ile şifre sıfırlama özelliğinin aktif edilmesi.
- [ ] **Resim Yükleme (Image Upload):** Statik URL'ler yerine sisteme fiziksel/bulut dosya yükleme altyapısının kurulması.
- [ ] **Performans İyileştirmeleri:** Sık kullanılan veriler için Cache (Önbelleğe Alma) mekanizmalarının entegre edilmesi.

---

## ⚙️ Kurulum ve Çalıştırma
Projeyi kendi bilgisayarınızda çalıştırmak için:
1. Repoyu bilgisayarınıza klonlayın.
2. `DataAccessLayer` içerisindeki `Context` sınıfında bulunan veritabanı bağlantı yolunu (`ConnectionString`) kendi SQL Server'ınıza göre güncelleyin.
3. Package Manager Console (PMC) üzerinden `Update-Database` komutunu çalıştırarak tabloları oluşturun.
4. Projeyi Visual Studio üzerinden ayağa kaldırın.
5. Admin Hesabı: Kullanıcı Adı -> Bugra  Şifre-> Bugra123!
