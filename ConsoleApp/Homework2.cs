using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunmedyaAkademi
{
    internal class Homework2
    {
        public static void Menu()
        {
            bool devam = true;

            while (devam)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nNET& REACT ÖDEV 1 Menüsü:");
                Console.WriteLine("1 - Sayının Pozitif, Negatif veya Sıfır Olduğunu Belirleme");
                Console.WriteLine("2 - Gün İsmi Belirleme");
                Console.WriteLine("3 - Basit Hesap Makinesi");
                Console.WriteLine("4 - Üç Sayının En Büyüğünü Bulma");
                Console.WriteLine("5 - Şifre Güçlülüğünü Kontrol Etme");
                Console.WriteLine("0 - Geri Dön");
                Console.Write("Seçiminiz: ");
                int secim = Convert.ToInt32(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        RakamToplami();
                    case 0:
                        devam = false;
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyiniz.");
                        break;
                }
            }
        }

        RakamToplami();
        Console.Write("Bir sayı giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
            for(int i=sayi, i>0, i--)
            {
                sayi+=sayi;
            }



    }
}
