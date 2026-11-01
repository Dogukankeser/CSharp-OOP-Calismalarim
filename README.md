# C# OOP Çalışmalarım

C# ve nesne yönelimli programlama öğrenirken geliştirdiğim konsol uygulamalarını bu depoda topluyorum.

## Alıştırmalar

| Uygulama | Açıklama |
|---|---|
| [Banka Hesabı](BankaHesabi/) | Para yatırma, para çekme ve yetersiz bakiye kontrolü. |
| [Öğrenci Karne](OgrenciKarne/) | Üç ders için vize/final doğrulaması, ağırlıklı ortalama ve karne çıktısı. |

## Çalıştırma

Ana klasördeki `.sln` dosyasını Visual Studio ile açın. Çalıştırmak istediğiniz projeye sağ tıklayıp **Başlangıç Projesi Olarak Ayarla** seçeneğini seçin ve **Ctrl + F5** tuşlarına basın.

Projeler .NET 8 SDK gerektirir. Terminalden karne uygulamasını çalıştırmak için:

```sh
dotnet run --project OgrenciKarne/OgrenciKarne.csproj
```

Karne uygulamasında ders ortalaması vizenin %40'ı ve finalin %60'ı alınarak hesaplanır. Ders geçme sınırı 50'dir. Üç ders ortalamasının ortalaması 50 ve üzerindeyse genel durum başarılıdır.
