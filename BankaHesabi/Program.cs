using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace BankaHesabi
{
        class BankaHesabi
        {
            private decimal _bakiye;

            public void ParaYatir(decimal miktar)
            {
                if (miktar <= 0)
                {
                    Console.WriteLine("Yatırılacak miktar pozitif olmalıdır.");
                    return;
                }

                _bakiye += miktar;

                Console.WriteLine(
                    $"{miktar} TL yatırıldı. Mevcut Bakiye: {_bakiye} TL"
                );
            }

            public void ParaCek(decimal miktar)
            {
                if (miktar <= 0)
                {
                    Console.WriteLine("Çekilecek miktar pozitif olmalıdır.");
                    return;
                }

                if (miktar > _bakiye)
                {
                    Console.WriteLine(
                        $"{miktar} TL çekilmek istendi. Hata: Yetersiz bakiye!"
                    );
                    return;
                }

                _bakiye -= miktar;

                Console.WriteLine(
                    $"{miktar} TL çekildi. Mevcut Bakiye: {_bakiye} TL"
                );
            }
        }
    

    internal class Program
    {
        static void Main(string[] args)
        {
            BankaHesabi hesap = new BankaHesabi();
            do
            {
                Console.WriteLine("işlem türü seçin: " +
                "\n1. Para Yatırma\n2. Para Çekme");
                string secim = Console.ReadLine();
                
                if (secim == "1")
                {
                    Console.Write("Yatırmak istediğiniz miktarı girin:");
                    hesap.ParaYatir(decimal.Parse(Console.ReadLine()));
                }
                else if (secim == "2")
                {
                    Console.Write("Çekmek istediğiniz miktarı girin: ");
                    hesap.ParaCek(decimal.Parse(Console.ReadLine()));
                }
                else
                {
                    Console.WriteLine("Geçersiz seçim.");
                }
                Console.WriteLine("Devam edecekmisiniz?: " +
                "\n1. Devam\n2. Çıkış");
                secim = Console.ReadLine();
                if (secim == "2")
                {
                    break;
                }
            } while (true);
        }
    }
}