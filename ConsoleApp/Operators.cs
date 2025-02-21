using System;

namespace ConsoleApp
{
    internal class Operators
    {
        public void PozitifNegatifSifir()
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

        public void BasitHesapMakinesi()
        {
            Console.Write("Birinci sayıyı giriniz: ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("İkinci sayıyı giriniz: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("İşlem türünü giriniz (+, -, *, /): ");
            char islem = Convert.ToChar(Console.ReadLine());

            double sonuc = 0;
            switch (islem)
            {
                case '+':
                    sonuc = sayi1 + sayi2;
                    break;
                case '-':
                    sonuc = sayi1 - sayi2;
                    break;
                case '*':
                    sonuc = sayi1 * sayi2;
                    break;
                case '/':
                    if (sayi2 != 0)
                        sonuc = sayi1 / sayi2;
                    else
                    {
                        Console.WriteLine("Bir sayı sıfıra bölünemez!");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem!");
                    return;
            }

            Console.WriteLine("Sonuç: " + sonuc);
        }

        public void NotSistemi()
        {
            Console.Write("0 ile 100 arasında bir not giriniz: ");
            int not = Convert.ToInt32(Console.ReadLine());

            if (not >= 90)
                Console.WriteLine("Harf notu: A");
            else if (not >= 80)
                Console.WriteLine("Harf notu: B");
            else if (not >= 70)
                Console.WriteLine("Harf notu: C");
            else if (not >= 60)
                Console.WriteLine("Harf notu: D");
            else
                Console.WriteLine("Harf notu: F");
        }

        public void CiftMiTekMi()
        {
            Console.Write("Bir tam sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            string sonuc = (sayi % 2 == 0) ? "Sayı çifttir." : "Sayı tektir.";
            Console.WriteLine(sonuc);
        }

        public void GunAdiBulma()
        {
            Console.Write("1 ile 7 arasında bir sayı giriniz: ");
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
                    Console.WriteLine("Geçersiz bir sayı girdiniz!");
                    break;
            }
        }

        public void MaasZammiHesaplama()
        {
            Console.Write("Mevcut maaşınızı giriniz: ");
            double maas = Convert.ToDouble(Console.ReadLine());

            double zamliMaas;

            if (maas <= 10000)
                zamliMaas = maas * 1.20;
            else if (maas < 20000)
                zamliMaas = maas * 1.15;
            else
                zamliMaas = maas * 1.10;

            Console.WriteLine("Zamlı maaşınız: " + zamliMaas);
        }
    }
}
