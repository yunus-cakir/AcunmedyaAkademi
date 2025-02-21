using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            Operators operators = new Operators();
            bool devam = true;

            while (devam)
            {
                Console.WriteLine("\nLütfen yapmak istediğiniz işlemi seçiniz:");
                Console.WriteLine("1 - Sayı Pozitif, Negatif veya Sıfır mı?");
                Console.WriteLine("2 - Basit Hesap Makinesi");
                Console.WriteLine("3 - Not Sistemi");
                Console.WriteLine("4 - Çift mi, Tek mi?");
                Console.WriteLine("5 - Gün Adı Bulma");
                Console.WriteLine("6 - Maaş Zammı Hesaplama");
                Console.WriteLine("0 - Çıkış");

                Console.Write("Seçiminiz: ");
                int secim = Convert.ToInt32(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        operators.PozitifNegatifSifir();
                        break;
                    case 2:
                        operators.BasitHesapMakinesi();
                        break;
                    case 3:
                        operators.NotSistemi();
                        break;
                    case 4:
                        operators.CiftMiTekMi();
                        break;
                    case 5:
                        operators.GunAdiBulma();
                        break;
                    case 6:
                        operators.MaasZammiHesaplama();
                        break;
                    case 0:
                        Console.WriteLine("Programdan çıkılıyor...");
                        devam = false;
                        break;
                    default:
                        Console.WriteLine("Geçersiz bir seçim yaptınız. Lütfen tekrar deneyiniz.");
                        break;
                }
            }
        }
    }
}
