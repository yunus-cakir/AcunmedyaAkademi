using System;

namespace AcunmedyaAkademi
{
    internal class Methods
    {
        public static void Menu()
        {
            bool devam = true;
            while (devam)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nC# Metotları Ödevi Menüsü:");
                Console.WriteLine("1 - Hoş geldiniz mesajı");
                Console.WriteLine("2 - Sayının karesi");
                Console.WriteLine("3 - Yaş hesapla");
                Console.WriteLine("4 - En büyük sayıyı bul");
                Console.WriteLine("0 - Geri Dön");
                Console.Write("Seçiminiz: ");
                int secim = Convert.ToInt32(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        HosgeldinizMesaji();
                        break;
                    case 2:
                        Console.Write("Bir sayı giriniz: ");
                        int sayi = Convert.ToInt32(Console.ReadLine());
                        SayiKaresiniYazdir(sayi);
                        break;
                    case 3:
                        Console.Write("Doğum yılınızı giriniz: ");
                        int dogumYili = Convert.ToInt32(Console.ReadLine());
                        int yas = YasHesapla(dogumYili);
                        Console.WriteLine($"Yaşınız: {yas}");
                        break;
                    case 4:
                        Console.Write("Kaç adet sayı gireceksiniz?: ");
                        int adet = Convert.ToInt32(Console.ReadLine());
                        int[] sayilar = new int[adet];
                        for (int i = 0; i < adet; i++)
                        {
                            Console.Write($"{i + 1}. sayıyı giriniz: ");
                            sayilar[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        int enBuyuk = EnBuyukSayiyiBul(sayilar);
                        Console.WriteLine($"En büyük sayı: {enBuyuk}");
                        break;
                    case 0:
                        devam = false;
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyiniz.");
                        break;
                }
            }
        }

        // Görev 1: Hoş geldiniz mesajı
        public static void HosgeldinizMesaji()
        {
            Console.Write("Adınızı girin: ");
            string ad = Console.ReadLine();
            Console.WriteLine($"Merhaba, {ad}!");
        }

        // Görev 2: Sayının karesini yazdıran metot
        public static void SayiKaresiniYazdir(int sayi)
        {
            Console.WriteLine($"{sayi} sayısının karesi: {sayi * sayi}");
        }

        // Görev 3: Yaş hesaplayan metot
        public static int YasHesapla(int dogumYili)
        {
            int mevcutYil = DateTime.Now.Year;
            return mevcutYil - dogumYili;
        }

        // Görev 4: En büyük sayıyı bulan metot
        public static int EnBuyukSayiyiBul(int[] sayilar)
        {
            int enBuyuk = sayilar[0];
            foreach (int sayi in sayilar)
            {
                if (sayi > enBuyuk)
                {
                    enBuyuk = sayi;
                }
            }
            return enBuyuk;
        }
    }
}
