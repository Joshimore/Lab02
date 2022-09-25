using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Employee
    {
        public Employee(int experience, string name, string surname, string ocupation, double taxes, double amount)
        {
            Name = name;
            Surname = surname;
            Ocupation = ocupation;
            YourExperience = experience;
            Taxes = taxes;
            Amount = amount;
        }

        public int YourExperience { get { return YourExperience; } set { YourExperience = value; } }
        public string Name { get { return Name; } set { Name = value; } }
        public string Surname { get { return Surname; } set { Surname = value; } }
        public string Ocupation { get { return Ocupation; } set { Ocupation = value; } }
        public double Taxes { get { return Taxes; } set { Taxes = value; } }
        public double Amount { get { return Amount; } set { Amount = value; } }

        public double CalculatorProg()
        {
            return Experience * Amount * (1 - Taxes);
        }
    }
}
