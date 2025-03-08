using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunmedyaAkademi
{
    internal class January3
    {
        public static void Menu()
        {
            Console.Write("Bir sayı girin: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi % 2 == 0)
                Console.WriteLine("Sayı çifttir.");
            else
                Console.WriteLine("Sayı tektir.");

            if (sayi > 0)
                Console.WriteLine("Sayı pozitiftir.");
            else if (sayi < 0)
                Console.WriteLine("Sayı negatiftir.");
            else
                Console.WriteLine("Sayı sıfırdır.");
        }
    }
}

/*
 * 1️-) Koşullu ifadeler (if-else) ne işe yarar?
 * Belirli bir koşula göre kodun farklı yollar izlemesini sağlar.
 * Örneğin: "Hava yağmurluysa şemsiye al, değilse şemsiye alma."
 */
