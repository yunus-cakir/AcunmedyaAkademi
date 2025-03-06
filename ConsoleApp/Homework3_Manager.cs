using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunmedyaAkademi
{
    internal class Homework3_Manager : Homework3_Employee
    {
        public int TeamSize { get; set; }

        public override double CalculateBonus()
        {
            return Salary * 0.20;
        }

        public void DisplayManagerInfo()
        {
            DisplayInfo();
            Console.WriteLine($"Team Size: {TeamSize}, Bonus: {CalculateBonus()}");
        }
    }
}
