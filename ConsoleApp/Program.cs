using System;

namespace AcunmedyaAkademi
{
    class Program
    {
        static void Main()
        {
            bool devam = true;

            while (devam)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nYunus Emre Çakır");
                Console.WriteLine("Github: yunus-cakir");
                Console.WriteLine("\nAcunmedya Akademi Ödevleri Ana Menüsü:");
                Console.WriteLine("1 - Homework1");
                Console.WriteLine("2 - Operators");
                Console.WriteLine("3 - Homework2");
                Console.WriteLine("4 - Methods");
                Console.WriteLine("0 - Çıkış");
                Console.Write("Seçiminiz: ");
                int secim = Convert.ToInt32(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        Homework1.Menu();
                        break;
                    case 2:
                        Operators.Menu();
                        break;
                    case 3:
                        Homework2.Menu();
                        break;
                    case 4:
                        Methods.Menu();
                        break;
                    case 0:
                        Console.WriteLine("Programdan çıkılıyor...");
                        devam = false;
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim, lütfen tekrar deneyiniz.");
                        break;

                }
            }
        }
    }
}
