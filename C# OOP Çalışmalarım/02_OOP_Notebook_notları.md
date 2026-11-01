# C# OOP AYRINTILI GÜNLÜK DERS NOTLARI

**Tarih:** 31.10.2026  
**Eğitim:** Gençay Yıldız – C# Nesne Yönelimli Programlama (OOP) Eğitimi  
**Geliştirme Ortamı:** Visual Studio 2022 (C# Console App, .NET 6.0 / .NET 8.0)  
**İncelenen Kaynaklar:**  
- Video #4: Nesne Tabanlı Programlama #4 - Class Yapısına Dair Son Dokunuşlar  
- Video #5: Nesne Tabanlı Programlama #5 - this Keyword'ü Nedir? İşlevleri Nelerdir?  
- Video #6: Nesne Tabanlı Programlama #6 - Nesne Kavramı Nedir? Nesne Nasıl Oluşturulur? | new Operatörü  

---

## 1. Video Video Ayrıntılı Konu Anlatımı

---

### VİDEO #4: Class Yapısına Dair Son Dokunuşlar

#### Konu 4.1: Sınıf İçinde Tanımlanan İç İçe (Nested) Sınıf Bir Sınıf Elemanı (Class Member) mıdır?
- **Konu:** İç içe sınıf (Nested Class) kavramı ve sınıf elemanlığı (Class Member) statüsü.
- **Açıklama:** Bir sınıfın elemanları (Class Members); o sınıftan üretilecek olan nesneye veri saklama, kapsülleme veya operasyonel yetenek kazandıran **Field**, **Property**, **Metot**, **Indexer** (ve ileride görülecek kurucu/yıkıcı metotlar) gibi yapılardır. Bir sınıf gövdesi içerisinde başka bir `class` tanımlanabilir (Nested Class); ancak bu iç sınıf **kesinlikle sınıfın bir elemanı (member) değildir**.
- **Mantığı:** İç sınıf nesnenin bir üyesi olmadığı için, türetilen nesne referansı üzerinden (`nesne.IcSinif`) erişilemez. İç sınıflar yalnızca tanımlandıkları yer bakımından dış sınıfın süslü parantezleri arasındadır ve tür erişimi dış sınıfın ismi üzerinden (`DisSinif.IcSinif`) gerçekleştirilir. Amacı kategorize edilmiş özel tür gruplamaları oluşturmaktır.
- **Sözdizimi:**
```csharp
class DisSinif
{
    public class IcSinif
    {
        // İç sınıf elemanları
    }
}
```
- **Kod Örneği:**
```csharp
using System;

namespace DersNotlari.Video4
{
    class MyClass
    {
        // Sınıf Elemanları (Class Members)
        public int FieldVar;
        public int PropertyVar { get; set; }

        public void MethodVar()
        {
            Console.WriteLine("Metot çalıştı.");
        }

        // Nested Class (Sınıf Elemanı DEĞİLDİR!)
        public class MyNestedClass
        {
            public string IcMesaj = "İç sınıftan merhaba!";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass();
            m.FieldVar = 10;
            m.MethodVar();

            // m.MyNestedClass -> DERLEME HATASI VERİR! Nesne üyesi değildir.

            // Tür erişimi DışSınıf.İçSınıf şeklinde yapılır:
            MyClass.MyNestedClass nested = new MyClass.MyNestedClass();
            Console.WriteLine(nested.IcMesaj);
        }
    }
}
```
- **Beklenen Çıktı:**
```text
Metot çalıştı.
İç sınıftan merhaba!
```
- **Kod Açıklaması:** `MyClass` nesnesi `m` üzerinden `FieldVar` ve `MethodVar` üyelerine doğrudan ulaşılabilirken, `MyNestedClass` nesne üzerinden görünmez. İç sınıfa erişmek için `MyClass.MyNestedClass` tür ismi kullanılmıştır.
- **Önemli Kurallar:**
  - Sınıf elemanları yalnızca `field`, `property`, `metot` ve `indexer` yapılarıdır.
  - İç içe tanımlanan sınıflar sınıf elemanı sayılmaz; nesne üzerinden çağrılamazlar.

---

#### Konu 4.2: Sınıfa ve Sınıf Elemanlarına Açıklama Satırı (XML Documentation / Summary) Ekleme
- **Konu:** `///` (üç bölü) ile XML Açıklama Satırları (XML Summary Comments).
- **Açıklama:** Sınıfların, metotların, property'lerin ve parametrelerin hemen üzerine eklenen ve Visual Studio IntelliSense (kod tamamlama/ipucu) penceresinde geliştiriciye dökümantasyon sunan özel yorum bloklarıdır.
- **Mantığı:** Geliştiricinin kendi yazdığı koda aylar sonra baktığında ne iş yaptığını hızla anlamasını sağlar. Takım çalışmasında ise diğer geliştiricilere metodun amacını ve parametre gereksinimlerini doğrudan Visual Studio arayüzünde gösterir.
- **Sözdizimi:**
```csharp
/// <summary>
/// Yapılan açıklama buraya yazılır.
/// </summary>
/// <param name="parametreAdi">Parametre açıklaması.</param>
```
- **Kod Örneği:**
```csharp
using System;

namespace DersNotlari.Video4
{
    /// <summary>
    /// Bu sınıf matematiksel işlemler gerçekleştirmek amacıyla tasarlanmış örnek bir modeldir.
    /// </summary>
    class MatematikIslem
    {
        /// <summary>
        /// Verilen iki tam sayıyı toplayıp sonucu döndürür.
        /// </summary>
        /// <param name="s1">Toplanacak birinci sayı.</param>
        /// <param name="s2">Toplanacak ikinci sayı.</param>
        /// <returns>Toplama sonucunu verir.</returns>
        public int Topla(int s1, int s2)
        {
            return s1 + s2;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MatematikIslem islem = new MatematikIslem();
            // VS 2022'de Topla yazarken veya üzerine gelindiğinde XML açıklaması görünür.
            int sonuc = islem.Topla(15, 25);
            Console.WriteLine($"Toplam Sonucu: {sonuc}");
        }
    }
}
```
- **Beklenen Çıktı:**
```text
Toplam Sonucu: 40
```
- **Kod Açıklaması:** `///` yazıldığı anda Visual Studio otomatik olarak `<summary>`, `<param>` ve `<returns>` etiketlerini üretir. Bu etiketlerin arasına yazılan metinler kütüphane dökümantasyonu gibi davranır.
- **Önemli Kurallar:** Standart çift bölü `//` yorum satırları IntelliSense menüsünde görünmez. Dökümantasyon için mutlaka `///` kullanılmalıdır.

---

### VİDEO #5: this Keyword'ü Nedir? İşlevleri Nelerdir?

#### Konu 5.1: `this` Keyword'ünün 1. İşlevi – Sınıfın O Anki Canlı Nesne Örneğini (Current Instance) Temsil Etmesi
- **Konu:** `this` anahtar kelimesi ile o anki aktif nesneye erişim.
- **Açıklama:** Sınıf şablonu içerisinde yazılan kodlarda, o sınıftan Heap üzerinde üretilmiş/üretilecek olan canlı nesne örneğini (current instance) temsil eden özel bir referans göstericidir.
- **Mantığı:** Bir sınıftan bellek sınırları dahilinde binlerce nesne üretilebilir. Metot veya property çalıştığında, `this` kelimesi tam olarak o metot hangi nesne üzerinden çağrıldıysa o nesneyi işaret eder.
- **Sözdizimi:** `this.UyeAdi`
- **Kod Örneği:**
```csharp
using System;

namespace DersNotlari.Video5
{
    class NesneTemsilcisi
    {
        public string NesneAdi { get; set; }

        public void KendiniTanit()
        {
            // 'this' kelimesi o an hangi nesne çalışıyorsa onun NesneAdi değerini alır.
            Console.WriteLine($"Çalışan Nesne: {this.NesneAdi}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            NesneTemsilcisi n1 = new NesneTemsilcisi();
            n1.NesneAdi = "Nesne-1";

            NesneTemsilcisi n2 = new NesneTemsilcisi();
            n2.NesneAdi = "Nesne-2";

            n1.KendiniTanit(); // this -> n1 nesnesini temsil eder
            n2.KendiniTanit(); // this -> n2 nesnesini temsil eder
        }
    }
}
```
- **Beklenen Çıktı:**
```text
Çalışan Nesne: Nesne-1
Çalışan Nesne: Nesne-2
```
- **Kod Açıklaması:** `n1.KendiniTanit()` çağrıldığında `this` kelimesi Heap'teki `n1` nesnesini temsil eder. `n2.KendiniTanit()` çağrıldığında ise `n2` nesnesini temsil eder.
- **Önemli Kurallar:** `this` o anki nesne örneğini temsil ettiğinden nesnesiz olan `static` metot veya sınıflar içerisinde kullanılamaz.

---

#### Konu 5.2: `this` Keyword'ünün 2. İşlevi – Field İsmi ile Metot Parametresi / Yerel Değişken İsim Çakışmasını Çözme
- **Konu:** İsim çakışması (Name Shadowing) durumunda `this.` kullanımı.
- **Açıklama:** Bir metodun parametre ismi ile sınıfın field/property ismi birebir aynı olduğunda, C# derleyicisi en yakın kapsama alanındaki (scope) parametreyi esas alır. Sınıf düzeyindeki field'a erişebilmek için başına `this.` eklenir.
- **Mantığı:** `this.a` sınıf düzeyindeki field olan `a`'yı temsil ederken; yalın `a` ise metodun parametresi olan `a`'yı temsil eder.
- **Sözdizimi:** `this.fieldAdi = parametreAdi;`
- **Kod Örneği:**
```csharp
using System;

namespace DersNotlari.Video5
{
    class Ogrenci
    {
        private string ad; // Sınıf seviyesindeki Field

        public void AdAta(string ad) // Metot parametresi ile Field adı aynı
        {
            // ad = ad; -> Yanlış! Parametre kendisine atanır, field değişmez.
            this.ad = ad; // 'this.ad' sınıfın field'ını, sağdaki 'ad' ise parametreyi temsil eder.
        }

        public void AdYazdir()
        {
            Console.WriteLine($"Öğrenci Adı: {this.ad}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.AdAta("Görkem");
            ogr.AdYazdir();
        }
    }
}
```
- **Beklenen Çıktı:**
```text
Öğrenci Adı: Görkem
```
- **Kod Açıklaması:** `AdAta` metodunda `this.ad = ad;` satırı ile dışarıdan gelen parametre değeri, sınıfın `private string ad` field'ına güvenle aktarılmıştır.
- **Önemli Kurallar:** C# dilinde isim çakışması olmadığı sürece field'ların başına `this.` yazmak zorunlu değildir; derleyici arka planda otomatik ekler. İsim çakışması durumunda yazılmazsa değer atanmaz.

---

#### Konu 5.3: `this` Keyword'ünün 3. İşlevi – Constructor'lar Arası Geçiş (Constructor Chaining - Giriş)
- **Konu:** Aynı sınıf içindeki kurucu metotların (Constructor) `this(...)` ile birbirini tetiklemesi.
- **Açıklama:** Bir kurucu metodun içerisinden aynı sınıftaki başka bir kurucu metodu çalıştırmak için kullanılan sözdizimidir.
- **Mantığı:** Kod tekrarını önlemek amacıyla ortak ilklendirme mantığı tek bir ana kurucu metoda yazılır; diğer kurucular `this(...)` ile bu ana kurucuyu çağırır.
- **Sözdizimi:** `public SinifAdi(int a) : this(a, "Varsayılan") { }`
- **Kod Örneği:**
```csharp
using System;

namespace DersNotlari.Video5
{
    class Araba
    {
        public string Marka { get; set; }
        public int ModelYili { get; set; }

        // Ana Constructor (2 Parametreli)
        public Araba(string marka, int modelYili)
        {
            this.Marka = marka;
            this.ModelYili = modelYili;
            Console.WriteLine("Ana Constructor Çalıştı.");
        }

        // Tek Parametreli Constructor -> Ana Constructor'ı tetikler
        public Araba(string marka) : this(marka, 2026)
        {
            Console.WriteLine("Tek parametreli Kurucu çalıştı (Varsayılan yıl 2026 atandı).");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Araba a = new Araba("BMW");
            Console.WriteLine($"Marka: {a.Marka}, Yıl: {a.ModelYili}");
        }
    }
}
```
- **Beklenen Çıktı:**
```text
Ana Constructor Çalıştı.
Tek parametreli Kurucu çalıştı (Varsayılan yıl 2026 atandı).
Marka: BMW, Yıl: 2026
```
- **Kod Açıklaması:** `new Araba("BMW")` çağrıldığında tek parametreli kurucu çalışmadan önce `: this(marka, 2026)` sözdizimi nedeniyle iki parametreli ana kurucu tetiklenmiş ve varsayılan değerler atanmıştır.
- **Önemli Kurallar:** Kurucu metotlar (Constructor) konusu ileride detaylı işlenecektir. `this(...)` yönlendirmesi kurucu metod imzasından hemen sonra iki nokta (`:`) konularak yazılır.

---

### VİDEO #6: Nesne Kavramı Nedir? Nesne Nasıl Oluşturulur? | new Operatörü

#### Konu 6.1: Nesne (Object) Kavramı ve "Canlı Organizma / Ekosistem" Tanımı
- **Konu:** Nesne kavramı, OOP felsefesindeki yeri ve Karmaşık Tür (Complex Type) niteliği.
- **Açıklama:** Nesne; içerisinde birbiriyle ilişkili ve anlamlı verileri (field/property) tutan ve bu veriler üzerinde eylemler (metotlar) gerçekleştirebilen canlı bir organizma/ekosistemdir. Nesne tek başına **Karmaşık Veri (Complex Data)**, sınıf ise onun **Karmaşık Tür Tanımı (Complex Type)** yapısıdır.
- **Mantığı:** Prosedürel programlamadaki ilişkisiz ve dağınık değişken kalabalığını tek bir bütünsel yapıda birleştirir. Yalnızca o olguyla doğrudan ilgili verileri barındırır; lüzumsuz/ilişkisiz verileri içermez (Örn: Personel nesnesinde Ad/Soyad anlamlıdır ancak her personelin arabası olmayacağı için Araba Markası field'ı doğrudan Personel nesnesine eklenmez).
- **Sözdizimi:** `class Sinif { ... }` (Tür) -> `new Sinif()` (Nesne Verisi)
- **Kod Örneği:**
```csharp
using System;

namespace DersNotlari.Video6
{
    // Sınıf = Complex Type (Karmaşık Tür Tanımı)
    class Personel
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public decimal Maas { get; set; }

        public void IslemYap()
        {
            Console.WriteLine($"{Ad} {Soyad} isimli personele {Maas} TL maaş ödendi.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // p = Complex Data (Canlı Organizma Nesne)
            Personel p = new Personel();
            p.Ad = "Gençay";
            p.Soyad = "Yıldız";
            p.Maas = 50000;
            p.IslemYap();
        }
    }
}
```
- **Beklenen Çıktı:**
```text
Gençay Yıldız isimli personele 50000 TL maaş ödendi.
```
- **Kod Açıklaması:** `Personel` sınıfı karmaşık bir tür tanımlarken, `p` referansı üzerinden Heap'te oluşturulan nesne ise kendi verisini ve metodunu yöneten canlı bir organizmadır.
- **Önemli Kurallar:**
  - OOP'de bir nesne oluşturmak için **TEK ve ZORUNLU** kaynak `Class`'tır.
  - Interface veya Abstract Class yapılardan doğrudan `new` ile nesne türetilemez.

---

#### Konu 6.2: Sınıftan Nesne Örnekleme (Instantiation) ve `new` Operatörü
- **Konu:** `new` operatörü ile RAM'in Heap bölgesinde fiziksel nesne tahsisi.
- **Açıklama:** Sınıf şablonundan belleğin **Heap** alanında somut bir nesne örneği türetmek için `new` operatörü kullanılır.
- **Mantığı:** `new` operatörü C# derleyicisine *"Heap alanında bu sınıfın boyutunda yeni bir yer ayır"* emrini verir. Yanındaki `SınıfAdı()` ifadesi ise o nesnenin kurucu metodunu (constructor) çalıştırır.
- **Sözdizimi:** `new SınıfAdı();` veya `SınıfAdı refVar = new SınıfAdı();`
- **Kod Örneği:**
```csharp
using System;

namespace DersNotlari.Video6
{
    class Urun
    {
        public string Ad { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Referanslı Nesne Oluşturma (Heap'te üretilir, Stack'teki u1 adresi tutar)
            Urun u1 = new Urun();
            u1.Ad = "Telefon";

            // 2. Referanssız Nesne Oluşturma (Heap'te üretilir fakat adresi tutulmaz)
            // Kısa ömürlüdür, Garbage Collector tarafından bellekten silinir.
            new Urun();

            Console.WriteLine($"u1 Ürün Adı: {u1.Ad}");
        }
    }
}
```
- **Beklenen Çıktı:**
```text
u1 Ürün Adı: Telefon
```
- **Kod Açıklaması:** `new Urun()` komutu doğrudan Heap bölgesinde nesne oluşturur. `u1` değişkeni ise Stack bölgesinde durup o nesneyi işaret eden referanstır.
- **Önemli Kurallar:** Referansa bağlanmayan (referanssız) nesneler bellekte kalıcı olmaz, ilk erişim sonrası veya Garbage Collector temizliğinde silinirler.

---

#### Konu 6.3: C# 9.0 Target-Typed New Expressions (`new()` Kullanımı)
- **Konu:** C# 9.0 (.NET 5.0+) ile gelen pratik nesne oluşturma sözdizimi.
- **Açıklama:** Sol tarafta referansın türü açıkça belirtilmişse, sağ tarafta sınıf adını tekrar yazmaya gerek kalmadan yalnızca `new()` yazılarak nesne üretilmesini sağlayan özelliktir.
- **Mantığı:** Özellikle uzun ve karmaşık sınıf isimlerinde kod kalabalığını azaltır ve daha okunabilir kod yazılmasını sağlar.
- **Sözdizimi:** `SınıfAdı nesne = new();`
- **Kod Örneği:**
```csharp
using System;

namespace DersNotlari.Video6
{
    class Musteri
    {
        public string Unvan { get; set; } = "Bireysel Müşteri";
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Geleneksel Yöntem: Musteri m1 = new Musteri();
            
            // C# 9.0 Target-Typed New Yöntemi:
            Musteri m2 = new();
            m2.Unvan = "Kurumsal Müşteri";

            Console.WriteLine($"Müşteri Ünvanı: {m2.Unvan}");
        }
    }
}
```
- **Beklenen Çıktı:**
```text
Müşteri Ünvanı: Kurumsal Müşteri
```
- **Kod Açıklaması:** Sol tarafta `Musteri` türü açıkça yazıldığı için sağ tarafta derleyici `new()` ifadesinden hangi türün üretileceğini otomatik olarak yakalar.
- **Önemli Kurallar:**
  - Bu özellik .NET 5.0 / C# 9.0 ve üzeri projelerde geçerlidir.
  - Sol tarafta `var` kullanılıyorsa `var m = new();` şeklinde yazılamaz (hedef tür belirsiz olur).

---

## 2. Komut ve Kavram Tablosu

| Kavram / Komut | Görevi ve Tanımı | Kullanım Amacı | Kısa Kod Örneği |
| :--- | :--- | :--- | :--- |
| **Nested Class** | İç içe sınıf tanımı. | Dış sınıfla ilişkili özel alt türleri gruplamak. | `class A { class B { } }` |
| **Class Member** | Sınıf elemanları. | Nesneye veri saklama, kapsülleme veya metot eylemi kazandırmak. | `Field`, `Property`, `Metot`, `Indexer` |
| **`///` (XML Summary)** | Dökümantasyon yorum satırı. | IntelliSense menüsünde geliştiriciye açıklama sunmak. | `/// <summary>...</summary>` |
| **`this` Keyword** | O anki canlı nesne referansı. | O an çalışan nesneye erişmek veya isim çakışmasını çözmek. | `this.ad = ad;` |
| **Name Shadowing** | İsim çakışması durumu. | Parametre ismi ile field ismi aynı olduğunda oluşan çakışma. | `this.sayi = sayi;` |
| **Constructor Chaining** | Kurucular arası geçiş. | Bir kurucudan aynı sınıftaki diğer kurucuyu tetiklemek. | `public A() : this(5) { }` |
| **Complex Type** | Karmaşık tür tanımı. | Sınıf (Class) yapıları üzerinden özel türler kurgulamak. | `class Personel { }` |
| **Complex Data (Object)** | Karmaşık veri (Nesne). | Heap üzerinde verileri ve metotları yöneten canlı ekosistem. | `Personel p = new Personel();` |
| **`new` Operatörü** | Nesne oluşturma operatörü. | Heap belleğinde yeni bir nesne alanı tahsis etmek. | `new MyClass();` |
| **Target-Typed New** | C# 9.0 pratik nesne oluşturma. | Tür adını tekrarlamadan `new()` ile nesne türetmek. | `MyClass m = new();` |
| **Referanssız Nesne** | Adresi tutulmayan nesne. | Anlık tek kullanımlık veya geçici nesne üretmek. | `new MyClass().Method();` |

---

## 3. Uygulamalı Kod Örnekleri

### Örnek 1: Nested Class, XML Documentation ve Sınıf Elemanı Kontrolü
```csharp
using System;

namespace DersNotlari.Uygulamalar
{
    /// <summary>
    /// Şirket organizasyon şemasını temsil eden model sınıf.
    /// </summary>
    class Sirket
    {
        /// <summary>
        /// Şirket resmi unvanı.
        /// </summary>
        public string Unvan { get; set; } = "Teknoloji A.Ş.";

        // Nested Class (Sınıf üyesi değildir, tür tanımıdır)
        public class Departman
        {
            public string DepartmanAd { get; set; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Sirket s = new Sirket();
            Console.WriteLine($"Şirket: {s.Unvan}");

            // İç sınıfa dış sınıf üzerinden erişim:
            Sirket.Departman dep = new Sirket.Departman();
            dep.DepartmanAd = "Yazılım Geliştirme";

            Console.WriteLine($"Departman: {dep.DepartmanAd}");
        }
    }
}
```

---

### Örnek 2: `this` Keyword ile İsim Çakışmasını Çözme ve Parametre Aktarımı
```csharp
using System;

namespace DersNotlari.Uygulamalar
{
    class ArabaSatis
    {
        private string marka;
        private decimal fiyat;

        // Metot parametre isimleri ile Field isimleri birebir aynı
        public void BilgiGuncelle(string marka, decimal fiyat)
        {
            // 'this.' vasıtasıyla sınıf seviyesindeki field'lar hedeflenir
            this.marka = marka;
            this.fiyat = fiyat;
        }

        public void RaporYazdir()
        {
            Console.WriteLine($"Satıştaki Araba: {this.marka} - Fiyat: {this.fiyat} TL");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ArabaSatis satis = new ArabaSatis();
            satis.BilgiGuncelle("Audi A4", 2400000);
            satis.RaporYazdir();
        }
    }
}
```

---

### Örnek 3: C# 9.0 Target-Typed New ve Constructor Chaining Kullanımı
```csharp
using System;

namespace DersNotlari.Uygulamalar
{
    class Kullanici
    {
        public string KullaniciAd { get; set; }
        public string Rol { get; set; }

        // Ana Kurucu
        public Kullanici(string kullaniciAd, string rol)
        {
            this.KullaniciAd = kullaniciAd;
            this.Rol = rol;
        }

        // Yardımcı Kurucu (this(...) kullanımı)
        public Kullanici(string kullaniciAd) : this(kullaniciAd, "Standart Üye")
        {
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // C# 9.0 Target-Typed New ifadesi:
            Kullanici k1 = new("admin", "Sistem Yöneticisi");
            Kullanici k2 = new("hilmi26"); // Varsayılan rol tetiklenir

            Console.WriteLine($"Kullanıcı 1: {k1.KullaniciAd} ({k1.Rol})");
            Console.WriteLine($"Kullanıcı 2: {k2.KullaniciAd} ({k2.Rol})");
        }
    }
}
```

---

## 4. Uygulamalı Alıştırmalar

*(Not: İsteğiniz doğrultusunda alıştırma sorularının çözümleri verilmemiştir.)*

### Kolay Seviye Sorular

#### Soru 1: C# 9.0 Target-Typed New Nesne Oluşturma
- **Amaç:** C# 9.0 `new()` sözdizimini uygulamak.
- **Gereksinimler:**
  - `Bilgisayar` adında bir sınıf oluşturun (`RAM` int, `Islemci` string property'leri bulunsun).
  - `Main` içerisinde geleneksel `new Bilgisayar()` yerine C# 9.0 target-typed `new()` sözdizimini kullanarak iki nesne türetin ve bilgilerini yazdırın.
- **Örnek Çıktı:**
```text
Bilgisayar 1: 16 GB RAM, Intel i7
Bilgisayar 2: 32 GB RAM, AMD Ryzen 9
```

#### Soru 2: İsim Çakışmalı Kullanıcı Kaydı (`this.` Kullanımı)
- **Amaç:** Field ve parametre isim çakışmalarında `this` anahtar kelimesinin rolünü pekiştirmek.
- **Gereksinimler:**
  - `KullaniciKayit` sınıfında `private string kullaniciAdi` ve `private string eposta` field'ları tanımlayın.
  - `KayitYap(string kullaniciAdi, string eposta)` metodunda `this.` kullanarak atamaları gerçekleştirin ve bilgileri konsola basın.
- **Örnek Çıktı:**
```text
Kayıt Başarılı: Kullanıcı Adı: ahmet123, E-Posta: ahmet@mail.com
```

#### Soru 3: XML Dökümantasyon Ekleme
- **Amaç:** Sınıf ve metotlara `///` XML özeti ekleme pratikliği kazanmak.
- **Gereksinimler:**
  - `Hesaplama` adında bir sınıf ve içerisinde `KareAl(int sayi)` metodu oluşturun.
  - Sınıfa ve metoda `///` kullanarak Türkçe summary dökümantasyon açıklamaları yazın.
- **Örnek Çıktı:**
```text
5 sayısının karesi: 25
```

---

### Orta Seviye Sorular

#### Soru 4: Nested Class Erişim Kontrolü
- **Amaç:** İç içe sınıfların nesne üyesi olmadığını doğrulamak ve doğru tür erişimi sağlamak.
- **Gereksinimler:**
  - `Kutuphane` adında dış sınıf, içerisinde `Raf` adında public bir nested sınıf oluşturun.
  - `Kutuphane` nesnesi üzerinden `Raf` sınıfına erişilemediğini görün; `Kutuphane.Raf` tür ismi üzerinden bir raf nesnesi türetip raf numarasını ekrana yazdırın.
- **Örnek Çıktı:**
```text
Kütüphane Bölümü: Tarih | Raf No: A-12
```

#### Soru 5: Constructor Chaining ile Varsayılan Değer Atama
- **Amaç:** `this(...)` vasıtasıyla kurucu metotlar arası yönlendirme yapmak.
- **Gereksinimler:**
  - `UrunModel` sınıfı oluşturun (`Ad` string, `Fiyat` decimal).
  - İki parametreli kurucunun yanında, tek parametre (`Ad`) alan bir kurucu yazın. Tek parametreli kurucu `: this(ad, 100)` biçiminde varsayılan 100 TL fiyat atasın.
- **Örnek Çıktı:**
```text
Ürün Adı: Kulaklık, Fiyat: 100 TL (Varsayılan atandı)
```

#### Soru 6: Referanslı ve Referanssız Nesne Karşılaştırması
- **Amaç:** Heap bellekteki referanssız nesnelerin davranışını gözlemlemek.
- **Gereksinimler:**
  - `Sayaç` sınıfı içerisinde `Artır()` adında ekrana mesaj basan bir metot yazın.
  - `Main` içerisinde hem `Sayac s = new(); s.Artir();` şeklinde referanslı nesne hem de `new Sayac().Artir();` şeklinde referanssız nesne çağrısı yapın.
- **Örnek Çıktı:**
```text
Referanslı Nesne: Sayaç Artırıldı.
Referanssız Nesne: Sayaç Artırıldı.
```

---

### Zor Seviye Sorular

#### Soru 7: Bütünsel Personel Organizasyon Modeli (Complex Type Tasarımı)
- **Amaç:** Nesnenin anlamlı ve ilişkili veriler bütünü olduğunu (Complex Data) mimari olarak kurgulamak.
- **Gereksinimler:**
  - `PersonelKarti` adında karmaşık bir tür tasarlayın.
  - İçerisinde `KimlikNo` (init-only), `AdSoyad` (prop), `Maas` (fullprop: negatif olamaz) üyeleri yer alsın.
  - Metot parametre çakışmalarını önlemek için `this.` kullanın. C# 9.0 `new()` ile nesneler türetip durumu raporlayın.
- **Örnek Çıktı:**
```text
Personel Kartı Oluşturuldu.
Kimlik No: 11223344556 | Ad Soyad: Caner Deniz | Maaş: 42000 TL
```

#### Soru 8: Nested Class ve `this` ile Çok Katmanlı Sipariş Yönetimi
- **Amaç:** Sınıf mimarisi, nested class tür erişimi ve `this` nesne temsilini bir arada kullanmak.
- **Gereksinimler:**
  - `SiparisYonetici` adında dış sınıf ve içerisinde `SiparisDetay` adında nested sınıf tanımlayın.
  - Dış sınıfta `SiparisKodu` ve `SiparisDetay` türünde bir field tutun.
  - Metot içerisinde `this.SiparisKodu` kullanarak atama yapın ve sipariş özetini ekrana yazdırın.
- **Örnek Çıktı:**
```text
Sipariş Kodu: SP-2026-99 | Ürün: Laptop | Adet: 1
```

---

## 5. Günün Mini Projesi

### Proje Adı: Konsol Otopark ve Araç Kayıt Yönetim Sistemi (Console ParkMaster)

*(Not: İsteğiniz doğrultusunda projenin hazır kodu verilmemiştir; mimarisi ve gereksinimleri tanımlanmıştır.)*

#### 1. Projenin Amacı
Bugün öğrenilen **Nested Class Ayrımı, XML Dökümantasyonu, `this` Keyword İşlevleri (İsim çakışması & Nesne Temsili), `new` Operatörü ve C# 9.0 Target-Typed New (`new()`)** konularını bir konsol uygulamasında birleştirmek.

#### 2. Oluşturulacak Sınıflar ve Mimarileri

1. **`Otopark` Sınıfı (Dış Sınıf):**
   - **Properties & Fields:**
     - `OtoparkAd` (string - Auto Property)
     - `Kapasite` (int - Auto Property)
   - **Nested Class (`Otopark.Arac`):**
     - *(Önemli: Dış sınıfın nesne elemanı değildir, tür tanımıdır.)*
     - `Plaka` (string - Auto Property)
     - `Marka` (string - Auto Property)
     - `GirisSaati` (int - Full Property: 0-23 arası kontrolü)
   - **Metotlar:**
     - `///` XML Summary ile dökümante edilmiş `AracKabul(string plaka, string marka, int girisSaati)` metodu.
     - Metot içerisinde field ve parametre çakışmalarını önlemek için `this.` sözdizimi kullanılmalıdır.
     - `FişYazdır()` metodu ile o anki çalışan nesnenin (`this`) araç fişi konsola basılmalıdır.

#### 3. Beklenen Ekran Çıktısı
```text
==================================================
      OTOPARK ARAÇ GİRİŞ VE FİŞ SİSTEMİ
==================================================
Otopark  : Merkez Otoparkı (Kapasite: 50 Araç)
--------------------------------------------------
[BİLGİ] Araç Girişi Yapıldı.
Plaka      : 34 ABC 789
Marka      : Volvo XC90
Giriş Saati: 14:00
--------------------------------------------------
Fiş Durumu : Kayıtlı Araç İşlemi Tamamlandı.
==================================================
```

---

## 6. Gün Sonu Tekrarı

- **Nested Class Eleman mıdır?:** İç içe tanımlanan sınıflar sınıfın elemanı (Class Member) **DEĞİLDİR**. Nesne üzerinden erişilemez; yalnızca `DışSınıf.İçSınıf` şeklinde tür erişimi sağlanır.
- **XML Summary (`///`):** Kod içine 3 bölü konularak eklenir. Visual Studio IntelliSense penceresinde geliştiriciye dökümantasyon ve ipucu sunar.
- **`this` Keyword 3 Ana İşlevi:**
  1. Sınıf modellemesi içerisinde Heap'teki o anki canlı nesne örneğini (current instance) temsil eder.
  2. Parametre ismi ile field ismi aynı olduğunda (`Name Shadowing`) isim çakışmasını `this.field = parametre` şeklinde çözer.
  3. `this(...)` sözdizimi ile kurucu metotlar arası yönlendirme (Constructor Chaining) sağlar.
- **`this` ve Static:** `this` canlı nesneyi temsil ettiği için nesnesiz `static` metot veya sınıflarda **kullanılamaz**.
- **Nesne (Object) Nedir?:** İçerisinde anlamlı/ilişkili verileri ve metotları barındıran canlı bir organizma/ekosistemdir. Nesne bir **Complex Data**'dır.
- **Nesnenin Tek Kaynağı:** OOP'de nesne türetmek için TEK ve ZORUNLU kaynak **`Class`** yapılarıdır.
- **`new` Operatörü:** RAM'in Heap bölgesinde fiziksel nesne alanı tahsis eden operatördür.
- **C# 9.0 Target-Typed New (`new()`):** Sol tarafta tür belirtilmişse sağ tarafta `new()` yazılarak pratik nesne türetmeyi sağlar (.NET 5.0+ gerektirir).

---

## 7. Eksik Konu ve Teknik Hata Kontrolü

- **Eksiksiz İçerik İncelemesi:** Videolar 4–6 içerisindeki tüm başlıklar (Nested Class ve Class Member ayrımı, XML Documentation `///`, `this` keyword'ünün 3 farklı işlevi, isim çakışması çözümü, constructor chaining girişi, nesne kavramı, complex type / complex data ayrımı, `new` operatörü ile Heap tahsisi, referanslı/referanssız nesne ve C# 9.0 Target-Typed New `new()`) eksiksiz işlenmiştir.
- **Sözdizimi ve Uyumluluk Denetimi:** Tüm C# kod örnekleri .NET 6.0 / .NET 8.0 ve Visual Studio 2022 Console App standartlarına uygun biçimde derlenebilir ve çalışabilir durumdadır.
- **Top-Level Statements & Main Metodu:** Kod örneklerinde kafa karışıklığını önlemek adına `using System;`, `namespace`, `class Program` ve `static void Main` şablonu korunmuştur.
- **Versiyon ve Sürüm Belirtimi:** C# 9.0 ve .NET 5.0+ gerektiren Target-Typed New `new()` özelliği açıkça vurgulanmıştır.
- **Statik ve Nesne Ayrımı:** `this` keyword'ünün statik yapılarda çalışmayacağı kuralı denetlenmiş, örneklerin tümü nesne seviyesinde (`instance`) kurgulanmıştır.

---

🎯 *Ders notlarınız Visual Studio 2022 Markdown Preview ile tam uyumlu `.md` formatında hazırlanmıştır. Notları saklayabilir, alıştırma sorularını çözerek ve mini projeyi kurgulayarak C# OOP bilginizi pekiştirebilirsiniz!*