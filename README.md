# 🏛️ GSB Etkinlik Otomasyon Projesi

<div align="center">

![C#](https://img.shields.io/badge/C%23-.NET%20Framework-239120?style=for-the-badge&logo=csharp&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-WinForms-0078D6?style=for-the-badge&logo=windows&logoColor=white)
![Entity Framework](https://img.shields.io/badge/Entity%20Framework-Code%20First-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL%20Server-LocalDB-CC2927?style=for-the-badge&logo=microsoftsqlserver&logoColor=white)

> **Gençlik ve Spor Bakanlığı (GSB) bünyesindeki yurt öğrencilerinin etkinliklere kayıt süreçlerini dijitalleştiren, Windows Forms tabanlı masaüstü otomasyon uygulaması.**

</div>

---

## 📋 İçindekiler

- [Proje Hakkında](#-proje-hakkında)
- [Özellikler](#-özellikler)
- [Sistem Mimarisi](#-sistem-mimarisi)
- [Veri Modeli](#-veri-modeli)
- [Ekranlar & Akış](#-ekranlar--akış)
- [Klasör Yapısı](#-klasör-yapısı)
- [Kurulum](#-kurulum)
- [Teknolojiler](#-teknolojiler)
- [Geliştirici](#-geliştirici)

---

## 🎯 Proje Hakkında

Bu proje; GSB yurtlarında kalan öğrencilerin etkinliklere (spor, kültür, sanat vb.) kayıt yaptırmasını, memurların bu kayıtları yönetmesini ve sürecin tamamen dijital ortamda yürütülmesini sağlamak amacıyla geliştirilmiştir.

Manuel kâğıt tabanlı işlemlerin yerini alan bu sistem sayesinde:

- ✅ Öğrenci kayıt/güncelleme/silme işlemleri anında yapılabilir
- ✅ Etkinliklere öğrenci atamaları tek ekrandan yönetilir
- ✅ Dashboard ile anlık istatistikler takip edilebilir
- ✅ Tüm işlemler log kayıtlarıyla izlenebilir

---

## ✨ Özellikler

| 🔑 Özellik | 📄 Açıklama |
|---|---|
| 🔐 **Güvenli Giriş** | TC Kimlik No tabanlı otomatik şifre oluşturma sistemi |
| 👨‍🎓 **Öğrenci Yönetimi** | Ekle / Güncelle / Sil / Listele / Arama |
| 🗓️ **Etkinlik Yönetimi** | Kontenjan, saat, yer bilgisiyle etkinlik takibi |
| 📋 **Kayıt Yönetimi** | Öğrenci–Etkinlik eşleştirme ve kayıt silme |
| 📊 **Dashboard** | En aktif öğrenci & en popüler etkinlik istatistikleri |
| 📝 **Log Kayıtları** | Tüm sistem hareketlerinin otomatik loglanması |
| 🔍 **Anlık Arama** | İsim/soyisim bazlı gerçek zamanlı filtreleme |

---

## 🏗️ Sistem Mimarisi

```
┌─────────────────────────────────────────────────────────────┐
│                     SUNUM KATMANI (UI)                      │
│                                                             │
│  ┌──────────┐  ┌──────────┐  ┌──────────┐  ┌──────────┐   │
│  │LoginForm │→ │AnaSayfa  │→ │Form_     │  │Form_     │   │
│  │          │  │Form      │  │Kayitlar  │  │Dashboard │   │
│  └──────────┘  └──────────┘  └──────────┘  └──────────┘   │
│                                      ↕              ↕       │
│                              ┌──────────────────────────┐   │
│                              │   Form_LogKayitlari      │   │
│                              └──────────────────────────┘   │
├─────────────────────────────────────────────────────────────┤
│                   İŞ MANTĞI KATMANI                         │
│                                                             │
│         ┌─────────────────┐    ┌──────────────┐            │
│         │  OgrenciService │    │   Helper.cs  │            │
│         └─────────────────┘    └──────────────┘            │
├─────────────────────────────────────────────────────────────┤
│                   VERİ ERİŞİM KATMANI                       │
│                                                             │
│         ┌──────────────────────────────────┐               │
│         │   OgrenciDbContext (EF Code First)│               │
│         └──────────────────────────────────┘               │
├─────────────────────────────────────────────────────────────┤
│                      VERİTABANI                             │
│                                                             │
│         ┌──────────────────────────────────┐               │
│         │     SQL Server LocalDB           │               │
│         └──────────────────────────────────┘               │
└─────────────────────────────────────────────────────────────┘
```

---

## 🗄️ Veri Modeli

```
┌──────────────────┐       ┌──────────────────┐
│    Ogrenci       │       │     Memur        │
├──────────────────┤       ├──────────────────┤
│ 🔑 Ogrenci_Id   │       │ 🔑 Memur_Id      │
│ Ogrenci_TC_No   │       │ Memur_Ad_Soyad   │
│ Ogrenci_Ad      │       │ Memur_Kullanici  │
│ Ogrenci_Soyad   │       │ Memur_Sifre      │
│ Ogrenci_Blok    │       └────────┬─────────┘
│ Ogrenci_Kat     │                │ 1
│ Ogrenci_Sifre   │                │
└────────┬─────────┘                │
         │ 1                        │ N
         │                 ┌────────▼─────────┐
         │                 │     Etkinlik     │
         │                 ├──────────────────┤
         │                 │ 🔑 Etkinlik_Id   │
         │                 │ Etkinlik_Adi     │
         │                 │ Etkinlik_Saati   │
         │ N               │ Etkinlik_Yeri    │
         │                 │ Kontenjan        │
    ┌────▼─────────────────▼──┐
    │        Kayitlar         │
    ├─────────────────────────┤
    │ 🔑 Kayit_Id             │
    │ 🔗 Ogrenci_Id (FK)      │
    │ 🔗 Etkinlik_Id (FK)     │
    │ Kayit_Tarihi            │
    └─────────────────────────┘
         │ 1
         │
    ┌────▼──────────┐
    │     Log       │
    ├───────────────┤
    │ 🔑 Log_Id     │
    │ Log_Mesaj     │
    │ Log_Tarihi    │
    └───────────────┘
```

---

## 🖥️ Ekranlar & Akış

### Uygulama Akış Diyagramı

```
          ┌─────────────────┐
          │   Uygulama      │
          │   Başlar        │
          └────────┬────────┘
                   │
                   ▼
          ┌─────────────────┐
          │  🔐 Login Form  │
          │  (TC + Şifre)   │
          └────────┬────────┘
                   │
          ┌────────▼────────┐
          │  Doğrulama OK?  │
          └────────┬────────┘
              ✅   │  ❌
               ────┤────────→ Hata Mesajı
               ▼
    ┌───────────────────────┐
    │   🏠 Ana Sayfa Form   │
    │   (Öğrenci Yönetimi)  │
    └──────┬──────┬──────┬──┘
           │      │      │
           ▼      ▼      ▼
    ┌──────────┐ ┌──────────┐ ┌────────────┐
    │📋Kayıtlar│ │📊Dashboard│ │📝LogKayıt. │
    │  Formu   │ │  Formu   │ │   Formu    │
    └──────────┘ └──────────┘ └────────────┘
```

### 📌 Form Açıklamaları

#### 🔐 Login Form
Memur kullanıcılarının sisteme güvenli giriş yapmasını sağlar. Yanlış bilgi girilmesi halinde uyarı verilir.

#### 🏠 Ana Sayfa Form (AnaSayfaForm)
Öğrenci CRUD işlemlerinin merkezi ekranıdır:
- 🔍 İsim/soyisim bazlı anlık arama
- ➕ Yeni öğrenci ekleme (TC'nin son 4 hanesi otomatik şifre)
- ✏️ Seçili öğrenciyi güncelleme
- 🗑️ Onay kutusuyla öğrenci silme
- 📋 Tüm öğrencileri listeleme
- 📊 Dashboard'a geçiş

#### 📋 Form_Kayitlar
Etkinlik kayıt yönetimi ekranı:
- Dropdown'dan öğrenci ve etkinlik seçimi
- Kayıt ekleme / silme
- En çok etkinliğe katılan öğrenci istatistiği
- En popüler etkinlik istatistiği

#### 📊 Form_Dashboard
Anlık raporlama ve istatistik ekranı.

#### 📝 Form_LogKayitlari
Sistemde gerçekleştirilen tüm işlemlerin zaman damgalı kayıtlarını görüntüler.

---

## 📁 Klasör Yapısı

```
GSB_Etkinlik_Otomasyon_Projesi/
│
├── 📂 Migrations/              → EF Code First veritabanı göç dosyaları
├── 📂 Properties/              → Proje özellikleri (AssemblyInfo vb.)
├── 📂 Resources/               → İkon, resim ve kaynak dosyaları
├── 📂 bin/Debug/               → Derleme çıktı dosyaları
├── 📂 obj/                     → Ara derleme nesneleri
│
├── 🖼️ LoginForm.cs             → Giriş ekranı
├── 🖼️ AnaSayfaForm.cs          → Ana ekran – öğrenci yönetimi
├── 🖼️ Form_Kayitlar.cs         → Etkinlik kayıt yönetimi
├── 🖼️ Form_Dashboard.cs        → İstatistik & raporlama
├── 🖼️ Form_LogKayitlari.cs     → Log kayıtları ekranı
│
├── 🧩 Ogrenci.cs               → Öğrenci entity modeli
├── 🧩 Etkinlik.cs              → Etkinlik entity modeli
├── 🧩 Kayitlar.cs              → Kayıt entity modeli
├── 🧩 Memur.cs                 → Memur entity modeli
├── 🧩 Log.cs                   → Log entity modeli
│
├── ⚙️ OgrenciDbContext.cs      → EF DbContext – veritabanı bağlamı
├── ⚙️ OgrenciService.cs        → Öğrenci CRUD iş mantığı servisi
├── ⚙️ Helper.cs                → Yardımcı fonksiyonlar
│
├── ⚙️ App.config               → Bağlantı dizesi ve uygulama ayarları
├── 🚀 Program.cs               → Uygulama giriş noktası
└── 📐 ClassDiagram1.cd         → Sınıf diyagramı
```

---

## 🚀 Kurulum

### Gereksinimler

- 🖥️ **İşletim Sistemi:** Windows 10 / 11
- 🛠️ **IDE:** Visual Studio 2019 veya üzeri
- 🟣 **.NET Framework:** 4.7.2 veya üzeri
- 🗄️ **Veritabanı:** SQL Server LocalDB (Visual Studio ile birlikte gelir)

### Adımlar

```bash
# 1. Repoyu klonlayın
git clone https://github.com/alimekokcuoglu/GSB_Etkinlik_Otomasyon_Projesi.git

# 2. Çözümü Visual Studio'da açın
# Otomasyon_Projesi.csproj dosyasına çift tıklayın

# 3. NuGet paketlerini geri yükleyin
# Tools > NuGet Package Manager > Restore NuGet Packages

# 4. Veritabanını oluşturun (Package Manager Console)
Enable-Migrations
Update-Database

# 5. Projeyi derleyin ve çalıştırın (F5)
```

> ⚠️ **Not:** `App.config` içindeki bağlantı dizesinin SQL Server instance adınızla eşleştiğinden emin olun.

---

## 🛠️ Teknolojiler

| Teknoloji | Kullanım Amacı |
|---|---|
| ![C#](https://img.shields.io/badge/-C%23-239120?logo=csharp&logoColor=white) | Ana programlama dili |
| ![.NET](https://img.shields.io/badge/-.NET%20Framework-512BD4?logo=dotnet&logoColor=white) | Uygulama çerçevesi |
| ![WinForms](https://img.shields.io/badge/-Windows%20Forms-0078D6?logo=windows&logoColor=white) | Masaüstü UI katmanı |
| ![EF](https://img.shields.io/badge/-Entity%20Framework-512BD4?logo=dotnet&logoColor=white) | ORM – veritabanı erişimi |
| ![SQL Server](https://img.shields.io/badge/-SQL%20Server%20LocalDB-CC2927?logo=microsoftsqlserver&logoColor=white) | İlişkisel veritabanı |
| ![LINQ](https://img.shields.io/badge/-LINQ-239120?logo=csharp&logoColor=white) | Veri sorgulama |

---



<div align="center">

**Alime KÖKCÜOĞLU**

[![GitHub](https://img.shields.io/badge/GitHub-alimekokcuoglu-181717?style=for-the-badge&logo=github)](https://github.com/alimekokcuoglu)

</div>

---

<div align="center">

⭐ Bu proje Nesnesel Tasarım ve Programlama dersi final sınavı için geliştirilmiştir.Beğendiyseniz yıldız vermeyi unutmayın!

C# · Windows Forms · MSSQL · ADO.NET · .NET Framework 4.7.2

</div>
