using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Employee
    {
        public int YourExperience { get; set; }
        public string Name { get; set { Name = value}; }
        public string Surname { get; set { Surname = value}; }
        public string Ocupation { get; set { Ocupation = value}; }
        public double Taxes { get; set { Taxes = value}; 
        public double Amount { get; set { Amount = value}; }

        //constructor
        public Employee(int experience, string name, string surname, string ocupation, double taxes, double amount)
        {
            this.Name = name;
            this.Surname = surname;
            this.Ocupation = ocupation;
            this.YourExperience = experience;
            this.Taxes = taxes;
            this.Amount = amount;
        }

        public double CalculatorProg()
        {
            return Experience * Amount * (1 - Taxes)
        }

        public void MainInfo()
        {
            Console.WriteLine("Name:", Name, Surname);
            Console.WriteLine("Ocupation:", Ocupation);
            Console.WriteLine("Amount:", CalculatorProg());
        }
    }
}
