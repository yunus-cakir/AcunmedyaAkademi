using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunmedyaAkademi
{
    internal class February1
    {
        public static void Menu()
        {
            int[] numbers = new int[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Dizinin {i + 1}. elemanını girin: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nGirilen dizi:");
            foreach (int num in numbers)
                Console.Write(num + " ");

            int maxNumber = numbers[0];
            foreach (int num in numbers)
                if (num > maxNumber)
                    maxNumber = num;

            Console.WriteLine($"\nDizideki en büyük sayı: {maxNumber}");
        }
    }
}

/*
 * 1️-) Dizi (Array) nedir? Ne işe yarar?
 * Dizi, aynı türdeki verileri tek bir değişkende saklamayı sağlayan veri yapısıdır.
 * Örneğin, bir sınıftaki 30 öğrencinin notlarını tek tek değişkenlerde tutmak yerine bir dizi içinde saklamak daha pratiktir.
 */
