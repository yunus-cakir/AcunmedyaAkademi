using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunmedyaAkademi
{
    internal class January4
    {
        public static void Menu()
        {
            Console.WriteLine("1’den 10’a kadar olan sayılar:");
            for (int i = 1; i <= 10; i++)
                Console.Write(i + " ");

            Console.WriteLine("\n");

            Console.Write("Bir sayı girin: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int toplam = 0;
            for (int i = 1; i <= sayi; i++)
                toplam += i;

            Console.WriteLine($"1'den {sayi}'e kadar olan sayıların toplamı: {toplam}");
        }
    }
}

/*
 * 1️-) Döngüler (for, while) ne işe yarar?
 * Döngüler, belirli bir işlemi tekrar tekrar çalıştırmak için kullanılır.
 * 
 * For döngüsü, iterasyon sayısı belli olduğunda kullanılır.
 * While döngüsü, koşul sağlandığı sürece çalışır, kaç kez döneceği belli olmayabilir.
 */
