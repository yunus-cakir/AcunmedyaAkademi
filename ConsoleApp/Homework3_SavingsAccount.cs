using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunmedyaAkademi
{
    internal class Homework3_SavingsAccount : Homework3_BankAccount
    {
        public override void CalculateInterest()
        {
            double interest = Balance * 0.05;
            Console.WriteLine($"Savings Account Interest: {interest}");
        }
    }
}
