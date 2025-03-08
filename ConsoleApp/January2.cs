using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunmedyaAkademi
{
    internal class January2
    {
        public static void Menu()
        {
            Console.Write("Birinci sayıyı girin: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci sayıyı girin: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int toplam = sayi1 + sayi2;
            Console.WriteLine($"Toplam: {toplam}");
        }
    }
}

/*
 * 1️-) C#’ta kullanılan temel veri tipleri nelerdir?
 * Tam sayılar için int,
 * Ondalıklı sayılar için double,
 * Yüksek hassasiyetli ondalık sayılar için decimal,
 * Tek bir karakter için char,
 * Karakter dizileri için string,
 * True veya false değeri için bool en yaygın kullanılan temel veri tipleri arasındadır.
 * 
 * 2️-) Aşağıdaki değişkenlerin bellek kullanımını karşılaştırın:
 * int x = 5; -> 4 byte kullanır
 * double y = 5.2; -> 8 byte kullanır
 * string name = "Mehmet"; -> Dinamik boyut kullanır, her karakter Unicode olduğu için 2 byte'tır.
 */