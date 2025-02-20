using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n--- Menü ---");
                Console.WriteLine("1: Sayının Pozitif, Negatif veya Sıfır Olduğunu Belirleme");
                Console.WriteLine("2: Gün İsmi Belirleme");
                Console.WriteLine("3: Basit Hesap Makinesi");
                Console.WriteLine("4: Üç Sayının En Büyüğünü Bulma");
                Console.WriteLine("5: Şifre Güçlülüğünü Kontrol Etme");
                Console.WriteLine("0: Çıkış");
                Console.Write("Seçiminizi yapın: ");

                int secim;
                if (!int.TryParse(Console.ReadLine(), out secim))
                {
                    Console.WriteLine("Geçerli bir seçim giriniz.");
                    continue;
                }

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
                        SifreGuclulugu();
                        break;
                    case 0:
                        Console.WriteLine("Programdan çıkılıyor...");
                        return;
                    default:
                        Console.WriteLine("Geçerli bir seçenek giriniz.");
                        break;
                }
            }
        }

        static void PozitifNegatifSifir()
        {
            Console.Write("Bir sayı girin: ");
            double sayi = Convert.ToDouble(Console.ReadLine());
            if (sayi > 0)
                Console.WriteLine("Sayı pozitiftir.");
            else if (sayi < 0)
                Console.WriteLine("Sayı negatiftir.");
            else
                Console.WriteLine("Sayı sıfırdır.");
        }

        static void GunIsmiBelirleme()
        {
            Console.Write("Bir gün numarası girin (1-7): ");
            int gun = Convert.ToInt32(Console.ReadLine());
            switch (gun)
            {
                case 1:
                    Console.WriteLine("Pazartesi");
                    break;
                case 2:
                    Console.WriteLine("Salı");
                    break;
                case 3:
                    Console.WriteLine("Çarşamba");
                    break;
                case 4:
                    Console.WriteLine("Perşembe");
                    break;
                case 5:
                    Console.WriteLine("Cuma");
                    break;
                case 6:
                    Console.WriteLine("Cumartesi");
                    break;
                case 7:
                    Console.WriteLine("Pazar");
                    break;
                default:
                    Console.WriteLine("Geçersiz gün numarası.");
                    break;
            }
        }

        static void BasitHesapMakinesi()
        {
            Console.Write("Birinci sayıyı girin: ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İkinci sayıyı girin: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İşlemi seçin (+, -, *, /): ");
            char islem = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (islem)
            {
                case '+':
                    Console.WriteLine($"Sonuç: {sayi1 + sayi2}");
                    break;
                case '-':
                    Console.WriteLine($"Sonuç: {sayi1 - sayi2}");
                    break;
                case '*':
                    Console.WriteLine($"Sonuç: {sayi1 * sayi2}");
                    break;
                case '/':
                    if (sayi2 != 0)
                        Console.WriteLine($"Sonuç: {sayi1 / sayi2}");
                    else
                        Console.WriteLine("Bir sayı sıfıra bölünemez.");
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem.");
                    break;
            }
        }

        static void UcSayininEnBuyugu()
        {
            Console.Write("Birinci sayıyı girin: ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İkinci sayıyı girin: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Üçüncü sayıyı girin: ");
            double sayi3 = Convert.ToDouble(Console.ReadLine());

            double enBuyuk = sayi1;

            if (sayi2 > enBuyuk)
                enBuyuk = sayi2;
            if (sayi3 > enBuyuk)
                enBuyuk = sayi3;

            Console.WriteLine($"En büyük sayı: {enBuyuk}");
        }

        static void SifreGuclulugu()
        {
            Console.Write("Şifreyi girin: ");
            string sifre = Console.ReadLine();

            if (sifre.Length >= 8 &&
                sifre.IndexOfAny(new char[] { '@', '#', '$', '%', '!' }) != -1 &&
                sifre.Any(char.IsUpper))
            {
                Console.WriteLine("Şifre güçlü.");
            }
            else
            {
                Console.WriteLine("Şifre zayıf. Şifre en az 8 karakter uzunluğunda olmalı, en az bir büyük harf ve özel karakter içermelidir.");
            }
        }
    }
}
