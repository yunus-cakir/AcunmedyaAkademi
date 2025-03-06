using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunmedyaAkademi
{
    internal class Homework3_CheckingAccount : Homework3_BankAccount
    {
        public override void CalculateInterest()
        {
            Console.WriteLine("Checking accounts do not earn interest.");
        }
    }
}
