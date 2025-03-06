using System;
using System.Collections.Generic;
using System.Linq;

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
                Console.WriteLine("\nNET& REACT ÖDEV 2 Menüsü:");
                Console.WriteLine("1 - Sayının Rakamlarının Toplamı");
                Console.WriteLine("2 - 10 ile 100 Arasında Sayı Alma");
                Console.WriteLine("3 - Yaş Kategorisi Belirleme");
                Console.WriteLine("4 - Tekrar Eden Elemanları Bulma");
                Console.WriteLine("5 - En Uzun ve En Kısa Kelimeyi Bulma");
                Console.WriteLine("6 - Cümleyi Alfabetik Sıralama");
                Console.WriteLine("7 - Dinamik Dizi Genişletme");
                Console.WriteLine("8 - Kelimeleri Tersten Yazdırma");
                Console.WriteLine("9 - Sayıların Ortalamasını Alma ve Sıralama");
                Console.WriteLine("10 - 10’dan Küçük Sayıları Silme");
                Console.WriteLine("11 - 50’nin Altındaki Notları Güncelleme");
                Console.WriteLine("0 - Geri Dön");
                Console.WriteLine("Seçiminiz: ");
                int secim = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n");

                switch (secim)
                {
                    case 1:
                        RakamlarToplami();
                        break;
                    case 2:
                        SayiAlma();
                        break;
                    case 3:
                        YasKategorisi();
                        break;
                    case 4:
                        TekrarEdenElemanlar();
                        break;
                    case 5:
                        UzunKisaKelime();
                        break;
                    case 6:
                        CumleyiSiralama();
                        break;
                    case 7:
                        DinamikDizi();
                        break;
                    case 8:
                        KelimeleriTerstenYazdir();
                        break;
                    case 9:
                        OrtalamaVeSiralama();
                        break;
                    case 10:
                        KucukleriSil();
                        break;
                    case 11:
                        NotlariGuncelle();
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

        private static void RakamlarToplami()
        {
            Console.Write("Bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            foreach (char rakam in sayi.ToString())
            {
                toplam += int.Parse(rakam.ToString());
            }
            Console.WriteLine("Rakamların toplamı: " + toplam);
        }

        private static void SayiAlma()
        {
            int sayi;
            do
            {
                Console.Write("10 ile 100 arasında bir sayı giriniz: ");
                sayi = Convert.ToInt32(Console.ReadLine());
            } while (sayi < 10 || sayi > 100);
            Console.WriteLine("Girilen sayı: " + sayi);
        }

        private static void YasKategorisi()
        {
            int[] yaslar = { 5, 16, 25, 70 };
            foreach (int yas in yaslar)
            {
                string kategori = yas switch
                {
                    <= 12 => "Çocuk",
                    <= 19 => "Genç",
                    <= 64 => "Yetişkin",
                    _ => "Yaşlı"
                };
                Console.WriteLine($"Yaş: {yas}, Kategori: {kategori}");
            }
        }

        private static void TekrarEdenElemanlar()
        {
            int[] dizi = { 1, 2, 3, 4, 2, 3, 5 };
            var tekrarlar = dizi.GroupBy(x => x).Where(g => g.Count() > 1).Select(g => g.Key);
            Console.WriteLine("Tekrar eden elemanlar: " + string.Join(", ", tekrarlar));
        }

        private static void UzunKisaKelime()
        {
            string[] kelimeler = { "elma", "armut", "çilek", "muz" };
            string enUzun = kelimeler.OrderByDescending(k => k.Length).First();
            string enKisa = kelimeler.OrderBy(k => k.Length).First();
            Console.WriteLine($"En Uzun: {enUzun}, En Kısa: {enKisa}");
        }

        private static void CumleyiSiralama()
        {
            Console.Write("Bir cümle giriniz: ");
            string cumle = Console.ReadLine();
            string[] kelimeler = cumle.Split(' ');
            Array.Sort(kelimeler);
            Console.WriteLine(string.Join(" ", kelimeler));
        }

        private static void DinamikDizi()
        {
            List<string> liste = new List<string> { "a", "b", "c" };
            liste.Add("d");
            Console.WriteLine(string.Join(", ", liste));
        }

        private static void KelimeleriTerstenYazdir()
        {
            List<string> liste = new List<string> { "elma", "armut", "muz" };
            liste.Reverse();
            Console.WriteLine(string.Join(", ", liste));
        }

        private static void OrtalamaVeSiralama()
        {
            List<int> sayilar = new List<int> { 45, 78, 12, 67, 89 };
            Console.WriteLine("Ortalama: " + sayilar.Average());
            sayilar.Sort();
            Console.WriteLine(string.Join(", ", sayilar));
        }

        private static void KucukleriSil()
        {
            List<int> sayilar = new List<int> { 5, 15, 25, 3, 20 };
            sayilar.RemoveAll(x => x < 10);
            Console.WriteLine(string.Join(", ", sayilar));
        }

        private static void NotlariGuncelle()
        {
            List<int> notlar = new List<int> { 45, 78, 32, 67, 89 };
            notlar = notlar.Select(n => n < 50 ? 50 : n).ToList();
            Console.WriteLine(string.Join(", ", notlar));
        }
    }
}
