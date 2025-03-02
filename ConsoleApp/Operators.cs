using System;

namespace AcunmedyaAkademi
{
    internal class Operators
    {
        public static void Menu()
        {
            bool devam = true;

            while (devam)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nOperatörler Ödevi Menüsü:");
                Console.WriteLine("1 - Sayı Pozitif, Negatif veya Sıfır mı?");
                Console.WriteLine("2 - Basit Hesap Makinesi");
                Console.WriteLine("3 - Not Sistemi");
                Console.WriteLine("4 - Çift mi, Tek mi?");
                Console.WriteLine("5 - Gün Adı Bulma");
                Console.WriteLine("6 - Maaş Zammı Hesaplama");
                Console.WriteLine("0 - Geri Dön");
                Console.Write("Seçiminiz: ");
                int secim = Convert.ToInt32(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        PozitifNegatifSifir();
                        break;
                    case 2:
                        BasitHesapMakinesi();
                        break;
                    case 3:
                        NotSistemi();
                        break;
                    case 4:
                        CiftMiTekMi();
                        break;
                    case 5:
                        GunAdiBulma();
                        break;
                    case 6:
                        MaasZammiHesaplama();
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

        private static void PozitifNegatifSifir()
        {
            Console.Write("Bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi > 0)
                Console.WriteLine("Sayı pozitiftir.");
            else if (sayi < 0)
                Console.WriteLine("Sayı negatiftir.");
            else
                Console.WriteLine("Sayı sıfırdır.");
        }

        private static void BasitHesapMakinesi()
        {
            Console.Write("Birinci sayıyı giriniz: ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İşlem türünü giriniz (+, -, *, /): ");
            char islem = Convert.ToChar(Console.ReadLine());

            double sonuc = islem switch
            {
                '+' => sayi1 + sayi2,
                '-' => sayi1 - sayi2,
                '*' => sayi1 * sayi2,
                '/' when sayi2 != 0 => sayi1 / sayi2,
                '/' => throw new DivideByZeroException("Bir sayı sıfıra bölünemez!"),
                _ => throw new InvalidOperationException("Geçersiz işlem!")
            };

            Console.WriteLine("Sonuç: " + sonuc);
        }

        private static void NotSistemi()
        {
            Console.Write("0 ile 100 arasında bir not giriniz: ");
            int not = Convert.ToInt32(Console.ReadLine());
            string harfNotu = not switch
            {
                >= 90 => "A",
                >= 80 => "B",
                >= 70 => "C",
                >= 60 => "D",
                _ => "F"
            };
            Console.WriteLine("Harf notu: " + harfNotu);
        }

        private static void CiftMiTekMi()
        {
            Console.Write("Bir tam sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sayi % 2 == 0 ? "Sayı çifttir." : "Sayı tektir.");
        }

        private static void GunAdiBulma()
        {
            Console.Write("1 ile 7 arasında bir sayı giriniz: ");
            int gun = Convert.ToInt32(Console.ReadLine());
            string gunAdi = gun switch
            {
                1 => "Pazartesi",
                2 => "Salı",
                3 => "Çarşamba",
                4 => "Perşembe",
                5 => "Cuma",
                6 => "Cumartesi",
                7 => "Pazar",
                _ => "Geçersiz bir sayı girdiniz!"
            };
            Console.WriteLine(gunAdi);
        }

        private static void MaasZammiHesaplama()
        {
            Console.Write("Mevcut maaşınızı giriniz: ");
            double maas = Convert.ToDouble(Console.ReadLine());
            double zamliMaas = maas switch
            {
                <= 10000 => maas * 1.20,
                < 20000 => maas * 1.15,
                _ => maas * 1.10
            };
            Console.WriteLine("Zamlı maaşınız: " + zamliMaas);
        }
    }
}
