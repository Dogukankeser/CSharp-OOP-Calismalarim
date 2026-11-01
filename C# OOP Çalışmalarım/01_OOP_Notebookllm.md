# C# OOP AYRINTILI GÜNLÜK DERS NOTLARI

**Tarih:** 18.10.2026  
**Eğitim:** Gençay Yıldız – C# Nesne Yönelimli Programlama (OOP) Eğitimi  
**Geliştirme Ortamı:** Visual Studio 2022 (C# Console App, .NET 6.0 / .NET 8.0)  
**İncelenen Kaynaklar:**  
- Video #1: Nesne Tabanlı Programlama #1 - Nesne Anatomisi - Referans Türlü Değişkenler  
- Video #2: Nesne Tabanlı Programlama #2 - Class Kavramı  
- Video #3: Nesne Tabanlı Programlama #3 - Class Members #Field #Property #Encapsulation #Methot #Indexer  

---

## 1. Video Video Ayrıntılı Konu Anlatımı

---

### VİDEO #1: Nesne Anatomisi - Referans Türlü Değişkenler

#### Konu 1.1: OOP (Nesne Yönelimli Programlama) Felsefesi ve Yaklaşımı
- **Konu:** Nesne Tabanlı Programlama (OOP) kavramı ve yazılım geliştirmedeki felsefesi.
- **Açıklama:** OOP bir programlama dili, kütüphane, teknoloji veya hazır bir yapı değildir; yazılım geliştirme sürecini düzenleyen bir kodlama felsefesi ve yaklaşımdır. Prosedürel kod yazımındaki yüksek karmaşıklık ve maliyetli süreçleri sistematik, modüler ve yönetilebilir hale getirmek amacıyla kullanılır.
- **Mantığı:** Gerçek hayatta var olan her olguyu (personel, araç, satış, kitap, kolonya vb.) programlama içerisinde temsil edilebilir birer nesne olarak simüle eder.
- **Sözdizimi:** Doğrudan tek satırlık bir komut değildir; sınıflar (`class`) ve bu sınıflardan üretilen nesneler (`object`) üzerinden kurgulanan mimaridir.
- **Kod Örneği:**
```csharp
using System;

namespace DersNotlari.Video1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OOP Felsefesi: Yazılımda her olgu bir nesnedir.");
        }
    }
}
```
- **Beklenen Çıktı:**
```text
OOP Felsefesi: Yazılımda her olgu bir nesnedir.
```
- **Kod Açıklaması:** `Program` sınıfı ve `Main` metodu C# konsol uygulamalarının standart giriş noktasıdır. OOP yaklaşımını uygulamak için bu yapıların ötesinde nesne modelleri kurgulanır.
- **Önemli Kurallar:**
  - OOP'yi yalnızca ezber kalıplarla öğrenmek yerine arkasındaki felsefe ve teoriyi kavramak kritiktir.
  - Sadece pratik yapmak yeterli değildir; arka plandaki teorik kolonlar bilinmelidir.

---

#### Konu 1.2: Nesne Anatomisi (Object, Field, Metot)
- **Konu:** Bir nesnenin iç yapısı ve anatomik bileşenleri.
- **Açıklama:** Nesne, merkezde yer alan ana ekosistemdir. İçerisinde veri tutabilen **Field** (alan) yapılarını ve bu alanlardaki verileri işleyen **Metot/Fonksiyon** eylemlerini barındırır.
- **Mantığı:** Prosedürel programlamada değişken karmaşası yaşanırken, nesne kendi verisini ve bu veri üzerinde çalışan eylemleri tek bir bünyede toplar.
- **Sözdizimi:**
```csharp
class NesneAnatomisi
{
    public int VeriAlani; // Field (Alan)

    public void Eylem()   // Metot (Fonksiyon)
    {
        // Operasyonel işlem
    }
}
```
- **Kod Örneği:**
```csharp
using System;

namespace DersNotlari.Video1
{
    class Ogrenci
    {
        // Field (Veri alanı)
        public string Ad;
        public int Yas;

        // Metot (Eylem)
        public void BilgiYazdir()
        {
            Console.WriteLine($"Öğrenci Adı: {Ad}, Yaşı: {Yas}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.Ad = "Hilmi";
            ogr.Yas = 22;
            ogr.BilgiYazdir();
        }
    }
}
```
- **Beklenen Çıktı:**
```text
Öğrenci Adı: Hilmi, Yaşı: 22
```
- **Kod Açıklaması:** `Ogrenci` sınıfında tanımlanan `Ad` ve `Yas` alanları veriyi saklar. `BilgiYazdir` metodu ise o nesnenin kendi alanlarındaki değerleri işleyerek ekrana yazdırır.
- **Önemli Kurallar:** Field'lar veri saklar, metotlar ise bu verileri operasyonel süreçlerden geçirir.

---

#### Konu 1.3: Class ve Nesne (Object) İlişkisi
- **Konu:** Sınıf (Class) modeli ile bu modelden türetilen nesne (Object) arasındaki ilişki.
- **Açıklama:** Sınıf bir modeldir (taslak/şablon); Nesne ise bu modelden üretilen somut varlıktır.
- **Mantığı:** T.C. Kimlik Kartı basım şablonu tek bir `Class` iken, vatandaşların elindeki her bir kimlik kartı bağımsız birer `Nesne`dir. Tek bir sınıf modelinden bellek dolana kadar sınırsız sayıda nesne üretilebilir.
- **Sözdizimi:** `SınıfAdı nesneAdı = new SınıfAdı();`
- **Kod Örneği:**
```csharp
using System;

namespace DersNotlari.Video1
{
    class Araba
    {
        public string Marka;
        public int MotorGucu;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Araba araba1 = new Araba();
            araba1.Marka = "Mercedes";
            araba1.MotorGucu = 300;

            Araba araba2 = new Araba();
            araba2.Marka = "Tofaş";
            araba2.MotorGucu = 75;

            Console.WriteLine($"Araba 1: {araba1.Marka} ({araba1.MotorGucu} HP)");
            Console.WriteLine($"Araba 2: {araba2.Marka} ({araba2.MotorGucu} HP)");
        }
    }
}
```
- **Beklenen Çıktı:**
```text
Araba 1: Mercedes (300 HP)
Araba 2: Tofaş (75 HP)
```
- **Kod Açıklaması:** Aynı `Araba` sınıfından türetilen `araba1` ve `araba2` nesneleri aynı alan isimlerine sahiptir ancak bellekte tamamen bağımsız değerler tutarlar.
- **Önemli Kurallar:** Sınıf soyut bir tanımdır, nesne ise bellekte yer kaplayan somut çıktıdır.

---

#### Konu 1.4: Stack & Heap Bellek Mimarisi ve Referans Türlü Değişkenler
- **Konu:** Nesnelerin RAM üzerindeki konumu ve referans mekanizması.
- **Açıklama:** Nesneler **Referans Türlü** yapılardır. RAM iki ana bölüme ayrılır: **Stack** ve **Heap**. Değer türlü değişkenler ve referans değişkenlerinin kendileri Stack'te dururken, nesnelerin kendisi Heap alanında saklanır.
- **Mantığı:** Yazılımcıların Heap'teki nesnelere doğrudan erişim yetkisi kısıtlanmıştır. Bu nedenle Stack'te tanımlanan bir referans değişkeni, Heap'teki nesnenin adresini işaret eder (referans gösterir).
- **Sözdizimi:** `SınıfAdı referansDeğişkeni;`
- **Kod Örneği:**
```csharp
using System;

namespace DersNotlari.Video1
{
    class Urun
    {
        public string UrunAdi;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // u1 Stack'te bir referanstır; new Urun() ise Heap'te bir nesne oluşturur
            Urun u1 = new Urun();
            u1.UrunAdi = "Laptop";

            // u2, u1'in işaret ettiği aynı Heap adresini işaret etmeye başlar
            Urun u2 = u1;
            u2.UrunAdi = "Masaüstü Bilgisayar";

            Console.WriteLine($"u1 Ürün Adı: {u1.UrunAdi}");
            Console.WriteLine($"u2 Ürün Adı: {u2.UrunAdi}");
        }
    }
}
```
- **Beklenen Çıktı:**
```text
u1 Ürün Adı: Masaüstü Bilgisayar
u2 Ürün Adı: Masaüstü Bilgisayar
```
- **Kod Açıklaması:** `u2 = u1` ataması nesneyi kopyalamaz; Stack'teki `u2` referansının, `u1` ile aynı Heap nesnesini işaret etmesini sağlar. `u2` üzerinden yapılan değişiklik `u1` üzerinden de görülür.
- **Önemli Kurallar:** Stack'teki değişken nesnenin kendisi değil, adrestir.

---

### VİDEO #2: Class Kavramı

#### Konu 2.1: Class (Sınıf) Tanımı ve Kullanım Amacı
- **Konu:** Sınıf yapısı ve nesne yönelimli programlamadaki merkezi rolü.
- **Açıklama:** Sınıf, nesne oluşturmamızı sağlayan mimari şablondur (AutoCAD çizimi/projesi benzetmesi).
- **Mantığı:** Nesnenin hangi verileri tutacağını (field), bu verilerin nasıl korunacağını (property), eylemlerini (metot) ve dizisel davranışlarını (indexer) belirleyen ana merkezdir.
- **Sözdizimi:**
```csharp
class SınıfAdı
{
    // Sınıf Üyeleri (Members)
}
```
- **Kod Örneği:**
```csharp
using System;

namespace DersNotlari.Video2
{
    class Ev
    {
        public int OdaSayisi;
        public int KatNo;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Ev ev1 = new Ev();
            ev1.OdaSayisi = 3;
            ev1.KatNo = 2;

            Console.WriteLine($"Ev Özellikleri: {ev1.OdaSayisi} odalı, {ev1.KatNo}. kat.");
        }
    }
}
```
- **Beklenen Çıktı:**
```text
Ev Özellikleri: 3 odalı, 2. kat.
```
- **Kod Açıklaması:** `Ev` sınıfı, yapılacak ev nesnelerinin ortak mimarisini tanımlar.
- **Önemli Kurallar:** Sınıf tek bir defa tanımlanır, nesneler çoğaltılır.

---

#### Konu 2.2: Class Tanımlama Sözdizimi ve Yeni Bir Referans Türü Oluşturma
- **Konu:** `class` anahtar kelimesi ile tür (type) oluşturma mantığı.
- **Açıklama:** C# dilinde bir `class` tanımlandığında, C# tip sistemine `int`, `string` veya `bool` gibi yepyeni bir **referans türü** kazandırılmış olur.
- **Mantığı:** Geliştiricinin kendi karmaşık veri türlerini (Complex Types) oluşturmasını sağlar.
- **Sözdizimi:**
```csharp
class OzelTurAdı
{
    // Üyeler
}
```
- **Kod Örneği:**
```csharp
using System;

namespace DersNotlari.Video2
{
    class Ahmet
    {
        public int Sayi;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Ahmet türünden bir değişken/referans tanımlanıyor
            Ahmet a = new Ahmet();
            a.Sayi = 100;

            Console.WriteLine($"Özel 'Ahmet' türündeki nesne değeri: {a.Sayi}");
        }
    }
}
```
- **Beklenen Çıktı:**
```text
Özel 'Ahmet' türündeki nesne değeri: 100
```
- **Kod Açıklaması:** `Ahmet` ismiyle tanımlanan sınıf, C# derleyicisi için `int` gibi geçerli bir türe dönüşür.
- **Önemli Kurallar:** Sınıf adları PascalCase standartlarına uygun yazılmalıdır.

---

#### Konu 2.3: Sınıfların Tanımlandığı Yerler
- **Konu:** Bir C# projesinde sınıfların tanımlanabileceği 3 farklı konum.
- **Açıklama:** Sınıflar şu 3 konumda tanımlanabilir:
  1. `namespace` içinde (en yaygın, %99.99 kullanım).
  2. `namespace` dışında.
  3. Bir `class` içinde (**Nested Class** / İç İçe Sınıf).
- **Mantığı:** Kodun erişim sınırlarını ve modüler organizasyonunu düzenler.
- **Sözdizimi:**
```csharp
// 1. Namespace Dışı
class NamespaceDisiClass { }

namespace DersNotlari.Video2
{
    // 2. Namespace İçi
    class NamespaceIciClass
    {
        // 3. Class İçi (Nested Class)
        class IcClass { }
    }
}
```
- **Kod Örneği:**
```csharp
using System;

// Namespace dışında tanımlanan sınıf
class DisSınıf
{
    public string Mesaj = "Namespace dışı sınıf";
}

namespace DersNotlari.Video2
{
    // Namespace içinde tanımlanan sınıf
    class AnaSınıf
    {
        // Class içinde tanımlanan (Nested) sınıf
        public class IcSınıf
        {
            public string IcMesaj = "İç (Nested) sınıf";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            DisSınıf ds = new DisSınıf();
            Console.WriteLine(ds.Mesaj);

            AnaSınıf.IcSınıf ic = new AnaSınıf.IcSınıf();
            Console.WriteLine(ic.IcMesaj);
        }
    }
}
```
- **Beklenen Çıktı:**
```text
Namespace dışı sınıf
İç (Nested) sınıf
```
- **Kod Açıklaması:** İç içe (nested) sınıflara erişirken `DışSınıf.İçSınıf` sözdizimi kullanılır.
- **Önemli Kurallar:** Aynı etki alanında (scope) aynı isimde iki farklı sınıf tanımlanamaz.

---

#### Konu 2.4: Class ile Nesne Modeli Tasarımı
- **Konu:** Sınıf içerisine veri alanları ve metotlar yerleştirerek nesne tasarımı yapılması.
- **Açıklama:** Sınıf tasarımı esnasında nesnenin taşıyacağı alanlar (field) ve sergileyeceği eylemler (metot) belirlenir.
- **Mantığı:** Tasarım aşamasındaki kodlar çalışır vaziyette değildir; nesne üretildiğinde canlılık kazanırlar.
- **Sözdizimi:**
```csharp
class ModelTasarimi
{
    public int Sayi1;
    public int Sayi2;

    public int Topla()
    {
        return Sayi1 + Sayi2;
    }
}
```
- **Kod Örneği:**
```csharp
using System;

namespace DersNotlari.Video2
{
    class Hesaplayici
    {
        public int A;
        public int B;

        public void Yazdir()
        {
            Console.WriteLine($"A: {A}, B: {B}");
        }

        public int Carp()
        {
            return A * B;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Hesaplayici h1 = new Hesaplayici();
            h1.A = 5;
            h1.B = 4;
            h1.Yazdir();
            Console.WriteLine($"Çarpım Sonucu: {h1.Carp()}");

            Hesaplayici h2 = new Hesaplayici();
            h2.A = 10;
            h2.B = 2;
            h2.Yazdir();
            Console.WriteLine($"Çarpım Sonucu: {h2.Carp()}");
        }
    }
}
```
- **Beklenen Çıktı:**
```text
A: 5, B: 4
Çarpım Sonucu: 20
A: 10, B: 2
Çarpım Sonucu: 20
```
- **Kod Açıklaması:** Sınıf içerisindeki metotlar, çalıştırıldıkları o anki nesnenin field değerlerini baz alırlar.
- **Önemli Kurallar:** Metotlar sınıf içerisindeki field'lara doğrudan erişip işleyebilir.

---

#### Konu 2.5: Referans Noktası Oluşturma ve Null Kavramı
- **Konu:** Referans değişkeni bildirme ve nesnesiz referansın `null` durumu.
- **Açıklama:** `SınıfAdı refVar;` bildirimi Stack üzerinde ilgili sınıf türünden bir referans alanı açar. Henüz Heap'te `new` operatörü ile bir nesneye bağlanmadıysa bu referans `null` değerini taşır.
- **Mantığı:** Referans tanımlamak ile nesneyi üretmek ayrı adımlardır.
- **Sözdizimi:** `SınıfAdı referansAdı;` veya `SınıfAdı referansAdı = null;`
- **Kod Örneği:**
```csharp
using System;

namespace DersNotlari.Video2
{
    class OrnekModel
    {
        public string Metin = "Merhaba C#";
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Referans noktası oluşturuldu ancak nesne üretilmedi (null)
            OrnekModel refNoktası = null;

            Console.WriteLine($"Referans null mı?: {refNoktası == null}");

            // Nesne üretilip referansa bağlanıyor
            refNoktası = new OrnekModel();
            Console.WriteLine($"Nesne bağlandıktan sonra metin: {refNoktası.Metin}");
        }
    }
}
```
- **Beklenen Çıktı:**
```text
Referans null mı?: True
Nesne bağlandıktan sonra metin: Merhaba C#
```
- **Kod Açıklaması:** `null` durumundaki bir referans üzerinden üyelere erişilmeye çalışılırsa çalışma zamanında `NullReferenceException` hatası alınır.
- **Önemli Kurallar:** Referans değişkenleri nesnenin kendisi değil, adres tutucusudur.

---

### VİDEO #3: Class Members (#Field #Property #Encapsulation #Methot #Indexer)

#### Konu 3.1: Field (Alan) ve Varsayılan (Default) Değerler
- **Konu:** Sınıf düzeyindeki değişkenler ve otomatik başlangıç değerleri.
- **Açıklama:** Sınıf gövdesinde tanımlanan değişkenlere **Field** denir. Metot veya property içinde tanımlanan değişkenler yerel değişkendir, field değildir. Field'lar atanmasalar dahi türlerine özgü varsayılan (default) değerleri otomatik alırlar.
- **Mantığı:** Sayısal türler `0`, bool `false`, char `\0`, referans türleri `null` başlangıç değerine sahip olur.
- **Sözdizimi:** `[ErişimBelirleyici] Tür FieldAdı;`
- **Kod Örneği:**
```csharp
using System;

namespace DersNotlari.Video3
{
    class Deneme
    {
        public int Sayi;       // Default: 0
        public bool Durum;     // Default: false
        public string Metin;   // Default: null
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Deneme d = new Deneme();
            Console.WriteLine($"Sayi Default: {d.Sayi}");
            Console.WriteLine($"Durum Default: {d.Durum}");
            Console.WriteLine($"Metin Default Null mı?: {d.Metin == null}");
        }
    }
}
```
- **Beklenen Çıktı:**
```text
Sayi Default: 0
Durum Default: False
Metin Default Null mı?: True
```
- **Kod Açıklaması:** Metot içindeki yerel değişkenler atanmadan okunamazken, field'lar derleyici tarafından otomatik varsayılan değerlerle başlatılır.
- **Önemli Kurallar:** Yerel değişkenler varsayılan değer almaz; field'lar otomatik varsayılan değer alır.

---

#### Konu 3.2: Encapsulation (Kapsülleme) ve Property Kavramı
- **Konu:** Veri güvenliği ve kontrollü erişim sağlama ilkesi.
- **Açıklama:** **Encapsulation**, bir nesne içindeki field'lara dışarıdan doğrudan müdahaleyi engelleyip, veriyi kontrollü bir şekilde dışarı açmak veya içeri almaktır. **Property** ise bu kapsüllemeyi sağlayan özel yapıdır.
- **Mantığı:** Dış dünyanın nesne field'ına doğrudan erişmesi engellenir (`private`). Cüzdandan izinsiz para çekilmesi yerine sahibinin kontrol ederek vermesi benzetmesi ve baba-çocuk ilişkisi buna örnektir.
- **Sözdizimi:**
```csharp
private int _fieldAdi; // Gizlenmiş Field

public int PropertyAdi // Dışarıya Açık Property
{
    get { return _fieldAdi; }
    set { _fieldAdi = value; }
}
```
- **Kod Örneği:**
```csharp
using System;

namespace DersNotlari.Video3
{
    class Banka
    {
        private decimal _bakiye; // Gizli field

        public decimal Bakiye
        {
            get
            {
                return _bakiye;
            }
            set
            {
                if (value >= 0)
                    _bakiye = value;
                else
                    Console.WriteLine("Hata: Negatif bakiye atanamaz!");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Banka b = new Banka();
            b.Bakiye = 1000;
            Console.WriteLine($"Bakiye: {b.Bakiye}");

            b.Bakiye = -500; // Kontrole takılır
            Console.WriteLine($"Son Bakiye: {b.Bakiye}");
        }
    }
}
```
- **Beklenen Çıktı:**
```text
Bakiye: 1000
Hata: Negatif bakiye atanamaz!
Son Bakiye: 1000
```
- **Kod Açıklaması:** `set` bloğunda geçen `value` keyword'ü atanan değeri temsil eder ve koşul kontrolüyle hatalı veri girişi engellenir.
- **Önemli Kurallar:** Field'lar `private` yapılmalı, dışarıya `Property` açılmalıdır.

---

#### Konu 3.3: Full Property (`fullprop`) ve Get/Set Blokları
- **Konu:** Arka planda açıkça tanımlanmış private bir field tutan tam kapsamlı property yapısı.
- **Açıklama:** Arka plandaki field ile birebir ilişki kuran, `get` (okuma) ve `set` (yazma) bloklarında özel mantıklar çalıştırılabilen property türüdür.
- **Mantığı:** `get` bloğu değer okunduğunda tetiklenir ve `return` eder. `set` bloğu değer atandığında tetiklenir ve `value` parametresiyle gelen değeri alır.
- **Sözdizimi:**
```csharp
private Tür _field;

public Tür PropertyName
{
    get { return _field; }
    set { _field = value; }
}
```
- **Kod Örneği:**
```csharp
using System;

namespace DersNotlari.Video3
{
    class Personel
    {
        private int _yas;

        public int Yas
        {
            get
            {
                return _yas;
            }
            set
            {
                if (value > 0 && value < 120)
                    _yas = value;
                else
                    _yas = 18;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Personel p = new Personel();
            p.Yas = 25;
            Console.WriteLine($"Personel Yaşı: {p.Yas}");

            p.Yas = 200; // Geçersiz veri
            Console.WriteLine($"Hatalı atama sonrası Yaş: {p.Yas}");
        }
    }
}
```
- **Beklenen Çıktı:**
```text
Personel Yaşı: 25
Hatalı atama sonrası Yaş: 18
```
- **Kod Açıklaması:** Visual Studio içerisinde `fullprop` yazıp Tab-Tab yapıldığında bu kalıp otomatik oluşturulur.
- **Önemli Kurallar:** `get` bloğu mutlaka temsil ettiği türde bir değer `return` etmelidir.

---

#### Konu 3.4: Auto Property (`prop`) ve Auto-Property Initializer
- **Konu:** Pratik property oluşturma ve varsayılan değer ilklendirme.
- **Açıklama:** Özel bir doğrulama mantığı gerekmeyen durumlarda kullanılır. Arka plandaki gizli field derleyici (compiler) tarafından otomatik oluşturulur. C# 6.0 ile gelen Initializer sayesinde tanımlandığı anda ilk değer verilebilir.
- **Mantığı:** Manuel field tanımlama zorunluluğunu ortadan kaldırır ve kod kalabalığını engeller.
- **Sözdizimi:** `public Tür PropertyAdı { get; set; } = İlkDeğer;`
- **Kod Örneği:**
```csharp
using System;

namespace DersNotlari.Video3
{
    class Kitap
    {
        public string Ad { get; set; }
        public string Tur { get; set; } = "Roman"; // Initializer
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Kitap k = new Kitap();
            k.Ad = "Nutuk";

            Console.WriteLine($"Kitap Adı: {k.Ad}, Türü: {k.Tur}");
        }
    }
}
```
- **Beklenen Çıktı:**
```text
Kitap Adı: Nutuk, Türü: Roman
```
- **Kod Açıklaması:** `prop` yazıp Tab-Tab yapıldığında arka planda field'ı derleyici tarafından yönetilen property tanımlanır.
- **Önemli Kurallar:** Auto property kullanılırken ayrıca manual field tanımlanmaz.

---

#### Konu 3.5: Özel Property Türleri (Read-Only, Calculated, Expression-Bodied, Ref Readonly, Init-Only)
- **Konu:** İhtiyaca yönelik özelleştirilmiş property türleri.
- **Açıklama:**
  - **Read-Only / Write-Only:** Sadece `get` veya sadece `set` bloğuna sahip yapılardır.
  - **Calculated Property:** Diğer alanları kullanarak anlık hesaplama yapan property'dir.
  - **Expression-Bodied Property:** Lambda (`=>`) operatörü ile tek satırda yazılan okunabilir yapılardır.
  - **Ref Readonly Returns (C# 7.2):** *Ek bilgi (Kurumsal düzeyde binde bir karşılaşılan derin bellek ve referans optimizasyonu yapısı)*.
  - **Init-Only Property (C# 9.0):** Sadece nesne ilklendirme anında (`init`) değer atanabilen, sonrasında değiştirilemeyen yapıdır.
- **Sözdizimi:**
```csharp
// Calculated & Expression-Bodied
public decimal Toplam => Fiyat * Adet;

// Init-Only (C# 9.0)
public string SeriNo { get; init; }
```
- **Kod Örneği:**
```csharp
using System;

namespace DersNotlari.Video3
{
    class Siparis
    {
        public decimal Fiyat { get; set; }
        public int Adet { get; set; }

        // Calculated & Expression-Bodied
        public decimal ToplamTutar => Fiyat * Adet;

        // Init-Only Property (C# 9.0)
        public string Kod { get; init; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Siparis s = new Siparis
            {
                Fiyat = 100,
                Adet = 3,
                Kod = "SIP-2026-001" // Sadece ilklendirme anında atanır
            };

            Console.WriteLine($"Sipariş Kodu: {s.Kod}");
            Console.WriteLine($"Toplam Tutar: {s.ToplamTutar} TL");

            // s.Kod = "SIP-NEW"; // DERLEME HATASI! (Init-Only değiştirilemez)
        }
    }
}
```
- **Beklenen Çıktı:**
```text
Sipariş Kodu: SIP-2026-001
Toplam Tutar: 300 TL
```
- **Kod Açıklaması:** `init` erişimcisi, nesne oluşturulduktan sonra dışarıdan değer değiştirilmesini engelleyerek immutability (değişmezlik) sağlar.
- **Önemli Kurallar:** `init` kullanılan bir property'ye nesne oluşturulduktan sonra yeni değer atanamaz.

---

#### Konu 3.6: Metot (Method) Kullanımı ve Property ile Farkları
- **Konu:** Sınıf içinde prosedürel eylemleri çalıştırma.
- **Açıklama:** Sınıf üyeleri arasında algoritmaları ve eylemleri yürüten ana bloklardır.
- **Mantığı:** Property'den farkı: Parametre alabilir, `void` (değer dönmeyen) olabilir ve tetiklenirken parantez `()` kullanılır.
- **Sözdizimi:** `[ErişimBelirleyici] GeriDönüşTürü MetotAdı(Parametreler) { ... }`
- **Kod Örneği:**
```csharp
using System;

namespace DersNotlari.Video3
{
    class Islem
    {
        public void BilgiVer(string mesaj)
        {
            Console.WriteLine($"[SİSTEM]: {mesaj}");
        }

        public int Topla(int s1, int s2)
        {
            return s1 + s2;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Islem i = new Islem();
            i.BilgiVer("İşlem başlatıldı.");
            int sonuc = i.Topla(15, 35);
            Console.WriteLine($"Sonuç: {sonuc}");
        }
    }
}
```
- **Beklenen Çıktı:**
```text
[SİSTEM]: İşlem başlatıldı.
Sonuç: 50
```
- **Kod Açıklaması:** Metotlar parametre alıp geriye `void` dahil her türde değer dönebilirken, property'lerin mutlaka bir türü olmak zorundadır.
- **Önemli Kurallar:** Property'lerde `void` olamaz, metotlarda `void` kullanılabilir.

---

#### Konu 3.7: Indexer (İndeksleyici - `this[]`) Kullanımı
- **Konu:** Nesneye dizi gibi `[i]` indeks operatörü yeteneği kazandırma.
- **Açıklama:** Sınıf içerisinde `this[int index]` sözdizimiyle tanımlanan ve nesneyi koleksiyonel davranışa kavuşturan özel üyedir.
- **Mantığı:** Fıtrat olarak property yapısına benzer. `get` ve `set` blokları barındırır ancak ismi yoktur, `this` anahtar kelimesiyle tanımlanır.
- **Sözdizimi:**
```csharp
public Tür this[int index]
{
    get { return ...; }
    set { ... = value; }
}
```
- **Kod Örneği:**
```csharp
using System;

namespace DersNotlari.Video3
{
    class OzelListe
    {
        private string[] _elemanlar = new string;

        public string this[int index]
        {
            get
            {
                return _elemanlar[index];
            }
            set
            {
                _elemanlar[index] = value;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            OzelListe liste = new OzelListe();
            liste = "Gençay"; // Indexer set
            liste = "Hilmi";  // Indexer set

            Console.WriteLine($"0. İndeks: {liste}"); // Indexer get
            Console.WriteLine($"1. İndeks: {liste}"); // Indexer get
        }
    }
}
```
- **Beklenen Çıktı:**
```text
0. İndeks: Gençay
1. İndeks: Hilmi
```
- **Kod Açıklaması:** `this` kelimesi o anki nesneyi temsil eder. `[int index]` parametresi ile nesne bir diziymiş gibi `liste[i]` şeklinde kullanılabilir.
- **Önemli Kurallar:** Indexer özel bir property türüdür; ismi `this` olarak belirlenmiştir.

---

## 2. Komut ve Kavram Tablosu

| Kavram / Komut | Görevi ve Tanımı | Kullanım Amacı | Kısa Kod Örneği |
| :--- | :--- | :--- | :--- |
| **OOP** | Nesne Tabanlı Programlama felsefesi. | Kodları modüler, sistematik ve sürdürülebilir kılmak. | `class Personel { }` |
| **Class** | Nesne mimari şablonu/modeli. | Nesnelerin alan ve eylemlerini tanımlamak. | `class Araba { }` |
| **Object (Nesne)** | Class'tan türetilen somut varlık. | Verileri depolamak ve eylemleri çalıştırmak. | `Araba a = new Araba();` |
| **Stack** | Hızlı bellek alanı. | Değer türlü değişkenleri ve referans adreslerini tutmak. | `int x = 10;` |
| **Heap** | Dinamik bellek alanı. | Nesnelerin (Object instances) kendisini saklamak. | `new Araba();` |
| **Referans Değişkeni** | Stack'teki adres tutucu. | Heap'teki nesneye dolaylı erişim sağlamak. | `Araba a;` |
| **Field** | Sınıf düzeyindeki değişken. | Nesneye ait ham verileri depolamak. | `public int Yas;` |
| **Default Value** | Varsayılan başlangıç değeri. | Field'lara otomatik ilk değer atamak. | `int -> 0`, `bool -> false` |
| **Encapsulation** | Kapsülleme / Sarmalama. | Field verisini dış müdahalelerden korumak. | `private int _bakiye;` |
| **Property** | Kapsülleme sağlayan üye. | Kontrollü veri okuma (`get`) ve yazma (`set`). | `public int A { get; set; }` |
| **`value` Keyword** | Property `set` parametresi. | Dışarıdan atanan değeri yakalamak. | `_yas = value;` |
| **`prop`** | Auto Property imzası. | Kontrol gerektirmeyen pratik kapsülleme. | `public string Ad { get; set; }` |
| **`init` (C# 9.0)** | Init-Only Accessor. | Sadece ilklendirme anında atama izni vermek. | `public int Id { get; init; }` |
| **Method** | Prosedürel eylem bloğu. | Algoritmaları ve iş mantığını çalıştırmak. | `public void Topla() { }` |
| **Indexer (`this[]`)** | İndeksleyici eleman. | Nesneye `[i]` biçiminde dizi erişimi kazandırmak. | `public string this[int i]` |
| **`null`** | Boş referans durumu. | Henüz nesneye bağlanmamış referansı temsil etmek. | `Araba a = null;` |

---

## 3. Uygulamalı Kod Örnekleri

### Örnek 1: Sınıf Tanımlama, Field Varsayılan Değerleri ve Nesne Örnekleme
```csharp
using System;

namespace DersNotlari.Uygulamalar
{
    class Calisan
    {
        // Field tanımlamaları (Sınıf gövdesinde)
        public string Ad;
        public decimal Maas;
        public bool AktifMi;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Calisan c1 = new Calisan();

            Console.WriteLine("--- Varsayılan (Default) Değerler ---");
            Console.WriteLine($"Ad (string): '{(c1.Ad == null ? "null" : c1.Ad)}'");
            Console.WriteLine($"Maaş (decimal): {c1.Maas}");
            Console.WriteLine($"Aktif Mi (bool): {c1.AktifMi}");

            // Field'lara değer atanıyor
            c1.Ad = "Ahmet Yılmaz";
            c1.Maas = 45000;
            c1.AktifMi = true;

            Console.WriteLine("\n--- Değer Atandıktan Sonra ---");
            Console.WriteLine($"Ad: {c1.Ad}, Maaş: {c1.Maas} TL, Aktif: {c1.AktifMi}");
        }
    }
}
```

---

### Örnek 2: Full Property ile Encapsulation ve Doğrulama Mantığı
```csharp
using System;

namespace DersNotlari.Uygulamalar
{
    class Urun
    {
        private string _urunAd;
        private decimal _fiyat;

        public string UrunAd
        {
            get { return _urunAd; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _urunAd = value;
                else
                    _urunAd = "Tanımsız Ürün";
            }
        }

        public decimal Fiyat
        {
            get { return _fiyat; }
            set
            {
                if (value >= 0)
                    _fiyat = value;
                else
                    _fiyat = 0;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Urun u1 = new Urun();
            u1.UrunAd = "Mekanik Klavye";
            u1.Fiyat = 1500;

            Urun u2 = new Urun();
            u2.UrunAd = "";     // Doğrulamaya takılır
            u2.Fiyat = -400;    // Doğrulamaya takılır

            Console.WriteLine($"Ürün 1: {u1.UrunAd} - {u1.Fiyat} TL");
            Console.WriteLine($"Ürün 2: {u2.UrunAd} - {u2.Fiyat} TL");
        }
    }
}
```

---

### Örnek 3: Auto Property, Metot ve Indexer Kullanımı
```csharp
using System;

namespace DersNotlari.Uygulamalar
{
    class OgrenciKarnesi
    {
        public string OgrenciAd { get; set; }
        public string OkulAd { get; set; } = "Atatürk Lisesi";

        private int[] _notlar = new int;

        // Indexer tanımlaması
        public int this[int dersIndex]
        {
            get { return _notlar[dersIndex]; }
            set
            {
                if (value >= 0 && value <= 100)
                    _notlar[dersIndex] = value;
            }
        }

        public double OrtalamaHesapla()
        {
            int toplam = 0;
            foreach (int n in _notlar)
            {
                toplam += n;
            }
            return (double)toplam / _notlar.Length;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            OgrenciKarnesi karne = new OgrenciKarnesi();
            karne.OgrenciAd = "Hilmi Yıldız";

            // Indexer ile not ataması
            karne = 85;
            karne = 90;
            karne = 95;

            Console.WriteLine($"Okul: {karne.OkulAd}");
            Console.WriteLine($"Öğrenci: {karne.OgrenciAd}");
            Console.WriteLine($"Notlar: Ders1={karne}, Ders2={karne}, Ders3={karne}");
            Console.WriteLine($"Not Ortalaması: {karne.OrtalamaHesapla():F2}");
        }
    }
}
```

---

## 4. Uygulamalı Alıştırmalar

*(Not: Çözümler verilmemiştir.)*

### Kolay Seviye Sorular

#### Soru 1: Araba Sınıfı Oluşturma
- **Amaç:** Temel `class` ve `field` tanımlamayı pekiştirmek.
- **Gereksinimler:**
  - `Araba` adında bir sınıf oluşturun.
  - İçerisinde `Marka` (string), `Model` (string) ve `Yil` (int) adında public field'lar tanımlayın.
  - `Main` metodu içerisinde bir nesne oluşturup değerlerini atayın ve bilgileri konsola yazdırın.
- **Örnek Çıktı:**
```text
Marka: Toyota, Model: Corolla, Yıl: 2022
```

#### Soru 2: Dikdörtgen Alan Hesaplama
- **Amaç:** Sınıf içinde metot kullanımını uygulamak.
- **Gereksinimler:**
  - `Dikdortgen` adında bir sınıf tanımlayın (`Genislik` ve `Yukseklik` field'ları olsun).
  - `AlanHesapla()` adında geriye `int` dönen bir metot yazın.
- **Örnek Çıktı:**
```text
Genişlik: 5, Yükseklik: 10 -> Hesaplanan Alan: 50
```

#### Soru 3: Varsayılan Değer Kontrolü
- **Amaç:** Field'ların varsayılan (default) değer davranışını gözlemlemek.
- **Gereksinimler:**
  - `TestModel` adında bir sınıf oluşturup `int`, `double`, `bool` ve `string` türünde birer field ekleyin.
  - Atama yapmadan nesneyi ilklendirin ve varsayılan değerleri ekrana yazdırın.
- **Örnek Çıktı:**
```text
Int: 0 | Double: 0 | Bool: False | String: (null)
```

---

### Orta Seviye Sorular

#### Soru 4: Kapsüllemeli Termometre (Property Kontrolü)
- **Amaç:** `Full Property` kullanarak veri doğrulaması yapmak.
- **Gereksinimler:**
  - `Termometre` sınıfında `private double _celcius` field'ı tanımlayın.
  - `Celcius` property'si `-50` ile `100` derece arasındaki değerleri kabul etsin; bu aralık dışındaki girişlerde uyarı verip mevcut değeri değiştirmesin.
- **Örnek Çıktı:**
```text
Sıcaklık 25°C olarak ayarlandı.
Hata: Geçersiz sıcaklık (-80°C)! Mevcut değer korundu: 25°C
```

#### Soru 5: Otomatik Kütüphane Kitap Takibi
- **Amaç:** `Auto Property` ve `Auto Property Initializer` kullanımı.
- **Gereksinimler:**
  - `KitapKayıt` sınıfı oluşturun.
  - `KitapAd` (prop), `Yazar` (prop) ve `KutuphaneAd` (varsayılan değeri "Milli Kütüphane" olan prop) özelliklerini ekleyin.
- **Örnek Çıktı:**
```text
Kitap: Safahat | Yazar: Mehmet Akif Ersoy | Kütüphane: Milli Kütüphane
```

#### Soru 6: Banka Hesabı Para Çekme / Yatırma
- **Amaç:** Metotlar aracılığıyla field durumunu güvenli şekilde yönetmek.
- **Gereksinimler:**
  - `BankaHesabi` sınıfında private `_bakiye` tutun.
  - `ParaYatir(decimal miktar)` ve `ParaCek(decimal miktar)` metotları yazın. Yetersiz bakiyede çekim engellensin.
- **Örnek Çıktı:**
```text
500 TL yatırıldı. Mevcut Bakiye: 500 TL
800 TL çekilmek istendi. Hata: Yetersiz bakiye!
```

---

### Zor Seviye Sorular

#### Soru 7: Özel İndeksleyici ile Takım Oyuncu Listesi
- **Amaç:** `Indexer` (`this[]`) kullanarak dizimsel veri kapsüllemesi yapmak.
- **Gereksinimler:**
  - `FutbolTakimi` sınıfı oluşturun. İçerisinde 11 elemanlı `string[] _oyuncular` private dizisi bulunsun.
  - `TakimAd` adında auto property ekleyin.
  - Sınıfa bir indexer (`this[int index]`) yazarak forma numarasına (0-10) göre oyuncu ismi atanmasını ve okunmasını sağlayın. Geçersiz indekste uyarı verin.
- **Örnek Çıktı:**
```text
Takım: Şampiyon FC
1 No'lu Forma (Kaleci): Muslera
15 No'lu Forma: Hata: Geçersiz forma numarası (0-10 arası olmalı)!
```

#### Soru 8: Ürün Fiyat Hesaplama (Calculated & Init-Only Property)
- **Amaç:** `Calculated Property` ve `Init-Only Property` kavramlarını harmanlamak.
- **Gereksinimler:**
  - `SiparisKalemi` sınıfı oluşturun.
  - `UrunKodu` (init-only string), `BirimFiyat` (decimal), `Miktar` (int) özelliklerini ekleyin.
  - `KdvDahilToplam` adında salt-okunur calculated property ekleyerek `%20` KDV eklenmiş tutarı döndürün.
  - Nesne örneklendikten sonra `UrunKodu` değiştirilmeye çalışıldığında oluşan derleme hatasını gözlemleyin.
- **Örnek Çıktı:**
```text
Ürün Kodu: PRD-101 (Init-only)
Birim Fiyat: 100 TL, Miktar: 2 Adet
KDV Dahil Toplam Tutar (%20): 240 TL
```

---

## 5. Günün Mini Projesi

### Proje Adı: Konsol Öğrenci Bilgi ve Not Takip Sistemi (Console SMS)

*(Not: Projenin hazır kodu verilmemiştir; gereksinimleri ve yapısı tanımlanmıştır.)*

#### 1. Projenin Amacı
Bugün öğrenilen **Class, Object, Field, Full/Auto Property, Encapsulation, Metot ve Indexer** konularını tek bir C# konsol uygulamasında harmanlayarak uygulamaya geçirmek.

#### 2. Oluşturulacak Sınıflar ve Mimarileri

1. **`DersNotu` Sınıfı:**
   - **Properties:**
     - `DersAdi` (string - Auto Property)
     - `Vize` (int - Full Property: 0-100 arası kontrolü)
     - `Final` (int - Full Property: 0-100 arası kontrolü)
     - `Ortalama` (double - Calculated Read-Only Property: `%40 Vize + %60 Final`)
   - **Metotlar:**
     - `DurumGetir()` (string - Ortalama >= 50 ise "Geçti", değilse "Kaldı")

2. **`Ogrenci` Sınıfı:**
   - **Properties & Fields:**
     - `OgrenciNo` (string - Init-Only Property)
     - `AdSoyad` (string - Auto Property)
     - `_dersler` (DersNotu[] - 3 elemanlı private dizi field)
   - **Indexer:**
     - `this[int index]` -> Öğrencinin 0, 1, 2 indeksli ders notlarına erişim ve atama sağlar.
   - **Metotlar:**
     - `KarneYazdir()` -> Öğrencinin tüm derslerini, notlarını, ortalamalarını ve geçme/kalma durumunu konsola basar.

#### 3. Beklenen Ekran Çıktısı
```text
==================================================
        ÖĞRENCİ BİLGİ VE KARNE SİSTEMİ
==================================================
Öğrenci No : 2026001
Ad Soyad   : Hilmi Yıldız
--------------------------------------------------
Ders 1: Matematik | Vize: 70 | Final: 80 | Ort: 76,00 | Durum: Geçti
Ders 2: Fizik     | Vize: 40 | Final: 45 | Ort: 43,00 | Durum: Kaldı
Ders 3: Kimya     | Vize: 85 | Final: 90 | Ort: 88,00 | Durum: Geçti
--------------------------------------------------
Genel Akademik Durum: Başarılı
==================================================
```

---

## 6. Gün Sonu Tekrarı

- **OOP Nedir?:** Bir dil veya teknoloji değil; kodu modüler, sistematik ve gerçek hayatı simüle ederek inşa etme yaklaşımıdır.
- **Class vs Object:** Class bir model/taslaktır; Object ise bu modelden bellekte (Heap) üretilen somut varlıktır.
- **Stack & Heap:** Değer türlü değişkenler ve referans adresleri Stack'te; nesnelerin kendisi Heap'te saklanır.
- **Field & Default Value:** Class gövdesinde tanımlanan değişkenlerdir. Otomatik varsayılan değer (`0`, `false`, `null`) alırlar.
- **Encapsulation & Property:** Field verisini gizleyip (`private`), dışarıya `get` ve `set` bloklarına sahip `Property` ile kontrollü açma işlemidir.
- **`prop` vs `fullprop`:** Özel veri doğrulaması yoksa `prop` (Auto Property); özel mantık/kontrol kurulacaksa `fullprop` kullanılır.
- **Method vs Property:** Metotlar `void` olabilir, parametre alabilir ve `()` ile çağrılır. Property'lerin mutlaka türü vardır ve parantezsiz kullanılır.
- **Indexer (`this[]`):** Nesneye `nesne[i]` biçiminde dizi/koleksiyon erişim yeteneği kazandırır.

---

## 7. Eksik Konu ve Teknik Hata Kontrolü

- **Eksiksiz İçerik İncelemesi:** Videolar 1–3 içerisindeki tüm konular (OOP felsefesi, Class kavramı, Class konumları, Stack/Heap bellek mimarisi, Referans değişkenleri, Field, Default değerler, Encapsulation, Full Property, Auto Property, Property Initializer, Read-Only/Write-Only/Init-Only Property, Expression-Bodied Property, Ref Readonly Returns, Indexer ve Metotlar) taranmış ve nota aktarılmıştır.
- **Sözdizimi ve Uyumluluk Denetimi:** Tüm C# kod örnekleri .NET 6.0 / .NET 8.0 ve Visual Studio 2022 Console App standartlarına uygun yazılmıştır.
- **Erişim Belirleyicileri ve Statik Durum:** Henüz işlenmeyen `static` üyeler yerine nesneye bağlı (`instance`) üyeler kullanılmıştır. `public` ve `private` belirleyicilerinin kapsülleme ile ilişkisi doğru kurgulanmıştır.
- **Top-Level Statements & Main Metodu:** Karışıklığı önlemek amacıyla örnek kodlarda `namespace`, `class Program` ve `static void Main` şablonu eksiksiz korunmuştur.
- **Eski / Yeni Sözdizimi Ayrımı:** C# 6.0 (Auto-property initializer), C# 7.2 (Ref Readonly) ve C# 9.0 (`init` accessor) gibi sürümlerle gelen özellikler açıkça belirtilmiştir.
- **Ek Bilgi Ayrımı:** Binde bir karşılaşılan kurumsal ref readonly property yapısı "Ek bilgi" notuyla sınıflandırılmıştır.

---

🎯 Ders notlarınız tam Markdown kaynak formatında Visual Studio 2022 Markdown Preview ile tam uyumlu olarak hazırlanmıştır. Dosyanızı `.md` uzantısıyla kaydedip doğrudan kullanabilirsiniz. Dilerseniz bu notlar üzerinden alıştırmaları çözmeye veya mini projeyi geliştirmeye başlayabiliriz!