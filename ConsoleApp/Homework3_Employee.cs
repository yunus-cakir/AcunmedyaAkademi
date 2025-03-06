using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcunmedyaAkademi
{
    internal class Homework3_Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }

        public virtual double CalculateBonus()
        {
            return 0;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Salary: {Salary}, Department: {Department}");
        }
    }
}
