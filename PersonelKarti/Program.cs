using System;

namespace DersNotlari.Uygulamalar
{
 class PersonelKarti
    {
        public string KimlikNo { get; init; } = "";
        public string AdSoyad { get; set; }
        private int _maas;
        public int maas {
            get { return _maas; }
            set 
            { 
                if (value < 0)
                {
                    throw new ArgumentException("Maaş negatif olamaz.");
                }
                _maas = value;
            }
        }
        public void BilgileriGoster()
        {
            Console.WriteLine("Personel kartı oluşturuldu.");
            Console.Write($"Kimlik No: {KimlikNo} ");
            Console.Write($"Ad Soyad: {AdSoyad} ");
            Console.Write($"Maaş: {_maas} ");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            PersonelKarti ahmet1 = new()
            {

               KimlikNo = "12345678901",
               AdSoyad = "Ahmet Yılmaz",
               maas = 5000
            };
            ahmet1.BilgileriGoster();

        }
    }
}