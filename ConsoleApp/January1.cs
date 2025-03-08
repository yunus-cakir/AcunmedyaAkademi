using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunmedyaAkademi
{
    internal class January1
    {
        public static void Menu()
        {
            Console.Write("Adınızı girin: ");
            string ad = Console.ReadLine();
            Console.WriteLine($"Merhaba, {ad}!");
        }
    }
}

/* 
 * 1️-) C# programlama dili nedir? Hangi alanlarda kullanılır?
 * C#; Microsoft tarafından geliştirilen, nesne yönelimli bir programlama dilidir. Modern, esnek ve güçlü bir yapıya sahiptir.
 * Genellikle Masaüstü uygulamaları, Web uygulamaları, Oyun geliştirme, Mobil uygulamalar, Bulut ve veritabanı sistemleri gibi alanlarda kullanılır.
 * 
 * 2️-) Bir programın çalışması için temel bileşenler nelerdir?
 * Bir programın çalışması için gereken temel bileşenler sırasıyla Derleyici, Bellek, İşlemci, İşletim Sistemi ve .NET Runtime sistemidir.
 * Derleyici; kaynak kodunu makineye çevirir.
 * Bellek; program çalışırken geçici olarak verilerin depolandığı alandır.
 * İşlemci; kodun işlenmesini ve çalıştırılmasını sağlar.
 * İşletim Sistemi; Programın donanım ve yazılım ile uyumlu çalışmasını yönetir.
 * .NET Runtime; C# kodlarının çalıştırılması için gerekli ortamdır.
 */
