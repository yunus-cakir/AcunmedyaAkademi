using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunmedyaAkademi
{
    internal class Homework3
    {
        public static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nInheritance Ödevi Menüsü:");
            Console.WriteLine("1 - Manager Bilgileri");
            Console.WriteLine("2 - Developer Bilgileri");
            Console.WriteLine("3 - Savings Account Faiz Hesaplama");
            Console.WriteLine("4 - Checking Account Faiz Hesaplama");
            Console.WriteLine("0 - Çıkış");
            Console.WriteLine("Seçiminiz: ");
            int secim = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");

            switch (secim)
            {
                case 1:
                    Homework3_Manager manager = new Homework3_Manager()
                    {
                        Id = 1,
                        Name = "Yunus",
                        Salary = 10000,
                        Department = "IT",
                        TeamSize = 5
                    };
                    manager.DisplayManagerInfo();
                    break;

                case 2:
                    Homework3_Developer dev = new Homework3_Developer()
                    {
                        Id = 2,
                        Name = "Kerem",
                        Salary = 8000,
                        Department = "Software",
                        About = "Backend Developer"
                    };
                    dev.DisplayDeveloperInfo();
                    break;

                case 3:
                    Homework3_SavingsAccount saving = new Homework3_SavingsAccount()
                    {
                        AccountHolder = "Duriye",
                        Balance = 20000
                    };
                    saving.CalculateInterest();
                    break;

                case 4:
                    Homework3_CheckingAccount checking = new Homework3_CheckingAccount()
                    {
                        AccountHolder = "Serhat",
                        Balance = 5000
                    };
                    checking.CalculateInterest();
                    break;

                case 0:
                    Console.WriteLine("Çıkış yapılıyor...");
                    break;

                default:
                    Console.WriteLine("Geçersiz Seçim!");
                    break;
            }
        }
    }
}
