using System;

namespace AcunmedyaAkademi
{
    internal class Homework1
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
                        PozitifNegatifSifir();
                        break;
                    case 2:
                        GunIsmiBelirleme();
                        break;
                    case 3:
                        BasitHesapMakinesi();
                        break;
                    case 4:
                        UcSayininEnBuyugu();
                        break;
                    case 5:
                        SifreGuclulukKontrolu();
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

        private static void GunIsmiBelirleme()
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

        private static void UcSayininEnBuyugu()
        {
            Console.Write("Birinci sayıyı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Üçüncü sayıyı giriniz: ");
            int sayi3 = Convert.ToInt32(Console.ReadLine());

            int enBuyuk = (sayi1 > sayi2) ? (sayi1 > sayi3 ? sayi1 : sayi3) : (sayi2 > sayi3 ? sayi2 : sayi3);
            Console.WriteLine("En büyük sayı: " + enBuyuk);
        }

        private static void SifreGuclulukKontrolu()
        {
            Console.Write("Şifre giriniz: ");
            string sifre = Console.ReadLine();

            if (sifre.Length >= 8 &&
                sifre.IndexOfAny(new char[] { '@', '#', '$', '%', '!' }) != -1 &&
                sifre.Any(char.IsUpper))
            {
                Console.WriteLine("Şifre güçlüdür.");
            }
            else
            {
                Console.WriteLine("Şifre zayıftır.");
            }
        }
    }
}
