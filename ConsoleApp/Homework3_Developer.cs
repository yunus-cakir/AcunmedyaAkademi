using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunmedyaAkademi
{
    internal class Homework3_Developer : Homework3_Employee
    {
        public string About { get; set; }

        public override double CalculateBonus()
        {
            return Salary * 0.10;
        }

        public void DisplayDeveloperInfo()
        {
            DisplayInfo();
            Console.WriteLine($"About: {About}, Bonus: {CalculateBonus()}");
        }
    }
}
