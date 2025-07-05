# Araba Kiralama Yönetim Sistemi

Bu proje, araba kiralama işlemlerini yönetmek için geliştirilmiş bir Windows Forms uygulamasıdır. Uygulama C# dilinde yazılmış olup, SQL Server veritabanı kullanmaktadır.

## 📋 Proje Hakkında

Araba Kiralama Yönetim Sistemi, kiralık araçların bilgilerini kaydetmek, güncellemek, silmek ve görüntülemek için tasarlanmış bir masaüstü uygulamasıdır. Sistem araç bilgilerini veritabanında saklar ve kullanıcı dostu bir arayüz sunar.

## ✨ Özellikler

- **Araç Ekleme**: Yeni araçları sisteme kaydetme
- **Araç Güncelleme**: Mevcut araç bilgilerini düzenleme
- **Araç Silme**: Sistemden araç kayıtlarını kaldırma
- **Araç Listeleme**: Tüm araçları tablo halinde görüntüleme
- **Veri Doğrulama**: Girilen verilerin kontrol edilmesi

## 🚗 Araç Bilgileri

Sistem aşağıdaki araç bilgilerini yönetir:

- **Plaka**: Araç plaka numarası
- **Model**: Araç markası ve modeli
- **Üretim Yılı**: Aracın üretildiği yıl
- **Kilometre**: Araç kilometresi
- **Renk**: Araç rengi
- **Yakıt Türü**: Araç yakıt tipi (Benzin, Dizel, vb.)
- **Kira Ücreti**: Günlük kiralama bedeli (TL)

## 🛠️ Teknik Özellikler

- **Platform**: .NET Framework 4.7.2
- **Dil**: C#
- **UI**: Windows Forms
- **Veritabanı**: SQL Server
- **ORM**: ADO.NET (SqlConnection, SqlCommand, SqlDataAdapter)

## 📦 Kurulum

### Gereksinimler

1. **Visual Studio 2019 veya daha yeni sürümü**
2. **.NET Framework 4.7.2 veya üzeri**
3. **SQL Server** (LocalDB, Express, veya tam sürüm)

### Adımlar

1. **Projeyi klonlayın**:
   ```bash
   git clone https://github.com/KeremOgzhn/ArabaKiralama.git
   cd ArabaKiralama
   ```

2. **Veritabanını kurun**:
   - SQL Server Management Studio'yu açın
   - `FormdaArabaKiralama/veri tabanı/arabaKiralama.sql` dosyasını çalıştırın
   - Bu işlem `ArabaKiralama` veritabanını ve `araba` tablosunu oluşturacaktır

3. **Bağlantı dizesini kontrol edin**:
   - `Form1.cs` dosyasındaki bağlantı dizesini kendi SQL Server ayarlarınıza göre düzenleyin:
   ```csharp
   con = new SqlConnection("server=.;initial catalog=ArabaKiralama;integrated security=sspi");
   ```

4. **Projeyi açın**:
   - Visual Studio'da `FormdaArabaKiralama/FormdaArabaKiralama.sln` dosyasını açın

5. **Projeyi derleyin ve çalıştırın**:
   - F5 tuşuna basın veya "Start" butonuna tıklayın

## 💾 Veritabanı Yapısı

### `araba` Tablosu

| Sütun | Tip | Açıklama |
|-------|-----|----------|
| id | int (IDENTITY) | Birincil anahtar, otomatik artan |
| plaka | varchar(15) | Araç plaka numarası |
| model | varchar(50) | Araç markası ve modeli |
| uretimYili | int | Üretim yılı |
| km | int | Kilometre bilgisi |
| renk | varchar(20) | Araç rengi |
| yakitTuru | varchar(20) | Yakıt türü |
| kiraUcreti | decimal(10,2) | Günlük kira bedeli |

### Örnek Veriler

Veritabanı kurulumunda aşağıdaki örnek veriler otomatik olarak eklenir:

- **34 RA 345** - Fiat Egea (2022, Beyaz, Benzin) - 1547.00 TL
- **34 KRM 02** - BMW X5 (2022, Siyah, Benzin) - 10000.00 TL  
- **34 REF 978** - Toyota Corolla (2024, Kırmızı, Benzin) - 2400.00 TL

## 🖥️ Kullanım

1. **Uygulama başladığında**: Mevcut tüm araçlar DataGridView'de listelenir

2. **Araç eklemek için**:
   - Form alanlarını doldurun
   - "Ekle" butonuna tıklayın

3. **Araç güncellemek için**:
   - DataGridView'den güncellemek istediğiniz aracı seçin
   - Form alanları otomatik doldurulur
   - Değişiklikleri yapın ve "Güncelle" butonuna tıklayın

4. **Araç silmek için**:
   - DataGridView'den silmek istediğiniz aracı seçin
   - "Sil" butonuna tıklayın

## 🔧 Geliştirme

### Proje Yapısı

```
FormdaArabaKiralama/
├── FormdaArabaKiralama.sln          # Solution dosyası
├── FormdaArabaKiralama/             # Ana proje klasörü
│   ├── Form1.cs                     # Ana form kodu
│   ├── Form1.Designer.cs            # Form tasarımı
│   ├── Form1.resx                   # Form kaynakları
│   ├── Program.cs                   # Uygulama giriş noktası
│   ├── FormdaArabaKiralama.csproj   # Proje dosyası
│   └── Properties/                  # Proje özellikleri
└── veri tabanı/                     # Veritabanı dosyaları
    └── arabaKiralama.sql            # Veritabanı kurulum scripti
```

### Kod Yapısı

- **Form1.cs**: Ana işlevsellik (CRUD operasyonları)
- **LoadData()**: Veritabanından verileri yükleme
- **btnEkle_Click()**: Yeni araç ekleme
- **btnGuncelle_Click()**: Araç bilgilerini güncelleme
- **btnSil_Click()**: Araç silme
- **dataGridView1_CellClick()**: Tablo satırı seçme

## 🤝 Katkıda Bulunma

1. Bu repository'yi fork edin
2. Yeni bir branch oluşturun (`git checkout -b feature/yeni-ozellik`)
3. Değişikliklerinizi commit edin (`git commit -am 'Yeni özellik: Açıklama'`)
4. Branch'inizi push edin (`git push origin feature/yeni-ozellik`)
5. Pull Request oluşturun

## 📄 Lisans

Bu proje MIT lisansı altında lisanslanmıştır.

## 👨‍💻 Geliştirici

**Kerem Oğuzhan** - [KeremOgzhn](https://github.com/KeremOgzhn)

## 📝 Notlar

- Veritabanı bağlantı dizesini kendi ortamınıza göre ayarlamayı unutmayın
- SQL Server servisinin çalışır durumda olduğundan emin olun
- Uygulama Windows ortamında çalışmak üzere tasarlanmıştır