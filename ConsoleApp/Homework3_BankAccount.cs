using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunmedyaAkademi
{
    internal class Homework3_BankAccount
    {
        public string AccountHolder { get; set; }
        public double Balance { get; set; }

        public virtual void CalculateInterest()
        {
        }
    }
}
