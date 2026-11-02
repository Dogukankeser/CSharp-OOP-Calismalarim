# C# OOP Çalışmalarım

C# ve nesne yönelimli programlama öğrenirken geliştirdiğim konsol uygulamalarını bu depoda topluyorum. Her uygulama aynı çözüm içinde ayrı bir projedir.

## Alıştırmalar

| Uygulama | Açıklama | Çalıştığım konular |
|---|---|---|
| [Banka Hesabı](BankaHesabi/) | Para yatırma, para çekme ve yetersiz bakiye kontrolü. | Private field, metotlar, koşullar ve döngüler. |
| [Öğrenci Karne](OgrenciKarne/) | Üç ders için vize/final doğrulaması, ağırlıklı ortalama ve karne çıktısı. | Full property, init-only property, calculated property ve indexer. |
| [Personel Kartı](PersonelKarti/) | Kimlik numarası, ad soyad ve maaş bilgilerini içeren personel kartı. Negatif maaş atamasını engeller. | Init-only property, auto property, full property ve exception kullanımı. |

## Çalıştırma

Projeleri derlemek için .NET 8 hedefini destekleyen bir .NET SDK; çalıştırmak için .NET 8 çalışma zamanı gerekir.

### Visual Studio

1. Ana klasördeki `.sln` dosyasını Visual Studio ile açın.
2. Çalıştırmak istediğiniz projeye sağ tıklayın.
3. **Başlangıç Projesi Olarak Ayarla** seçeneğini seçin.
4. **Ctrl + F5** tuşlarına basın.

### Terminal

Ana klasörde, çalıştırmak istediğiniz uygulamanın komutunu kullanın:

```sh
dotnet run --project BankaHesabi/BankaHesabi.csproj
dotnet run --project OgrenciKarne/OgrenciKarne.csproj
dotnet run --project PersonelKarti/PersonelKarti.csproj
```

## Uygulama Notları

- **Banka Hesabı:** Bakiye uygulama açık kaldığı sürece korunur; dosyaya kaydedilmez. Para girişleri sayı olmalıdır.
- **Öğrenci Karne:** Ders ortalaması vizenin %40'ı ve finalin %60'ı alınarak hesaplanır. Ders geçme sınırı 50'dir. Üç ders ortalamasının ortalaması 50 ve üzerindeyse genel durum başarılıdır.
- **Personel Kartı:** Kimlik numarası `init` ile nesne oluşturulurken atanır. Negatif maaş atanmaya çalışılırsa `ArgumentException` fırlatılır. Örnekte temsili personel bilgileri kullanılır.

Bu depo öğrenme amacıyla hazırlanmıştır. Yeni alıştırmalar eklendikçe güncellenecektir.
