using System;

class DersNotu
{
    private int _vize;
    private int _final;

    public string DersAdi { get; set; } = "";

    public int Vize
    {
        get
        {
            return _vize;
        }
        set
        {
            if (value >= 0 && value <= 100)
            {
                _vize = value;
            }
            else
            {
                Console.WriteLine(
                    "Vize notu 0 ile 100 arasında olmalıdır."
                );
            }
        }
    }

    public int Final
    {
        get
        {
            return _final;
        }
        set
        {
            if (value >= 0 && value <= 100)
            {
                _final = value;
            }
            else
            {
                Console.WriteLine("Final notu 0 ile 100 arasında olmalıdır.");
            }
        }
    }

    public double Ortalama => Vize * 0.4 + Final * 0.6;

    public string DurumGetir()
    {
        return Ortalama >= 50 ? "Geçti" : "Kaldı";
    }
}

class Ogrenci
{
    public string OgrenciNo { get; init; } = "";
    public string AdSoyad { get; set; } = "";

    private DersNotu[] _dersler = new DersNotu[3];

    public DersNotu this[int index]
    {
        get
        {
            return _dersler[index];
        }
        set
        {
            _dersler[index] = value;
        }
    }

    public void KarneYazdir()
    {
        Console.WriteLine("==================================================");
        Console.WriteLine("        ÖĞRENCİ BİLGİ VE KARNE SİSTEMİ");
        Console.WriteLine("==================================================");
        Console.WriteLine($"Öğrenci No : {OgrenciNo}");
        Console.WriteLine($"Ad Soyad   : {AdSoyad}");
        Console.WriteLine("==================================================");

        double toplamOrtalama = 0;

        for (int i = 0; i < _dersler.Length; i++)
        {
            DersNotu ders = _dersler[i];

            if (ders == null)
            {
                Console.WriteLine($"Ders {i + 1} henüz atanmadı.");
                return;
            }

            Console.WriteLine(
                $"Ders {i + 1}: {ders.DersAdi} | " +
                $"Vize: {ders.Vize} | Final: {ders.Final} | " +
                $"Ort: {ders.Ortalama:F2} | " +
                $"Durum: {ders.DurumGetir()}"
            );

            toplamOrtalama += ders.Ortalama;
        }

        double genelOrtalama = toplamOrtalama / _dersler.Length;

        string genelDurum = genelOrtalama >= 50
            ? "Başarılı"
            : "Başarısız";

        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine($"Genel Akademik Durum: {genelDurum}");
        Console.WriteLine("==================================================");
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        Ogrenci ogrenci = new Ogrenci
        {
            OgrenciNo = "2026001",
            AdSoyad = "Hilmi Yıldız"
        };

        ogrenci[0] = new DersNotu
        {
            DersAdi = "Matematik",
            Vize = 70,
            Final = 80
        };

        ogrenci[1] = new DersNotu
        {
            DersAdi = "Fizik",
            Vize = 40,
            Final = 45
        };

        ogrenci[2] = new DersNotu
        {
            DersAdi = "Kimya",
            Vize = 85,
            Final = 90
        };

        ogrenci.KarneYazdir();
    }
}