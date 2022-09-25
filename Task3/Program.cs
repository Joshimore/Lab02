using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee inform = new Employee();
            inform.Name = "John";
            inform.Surname = "Dorian"
            inform.Ocupation = "Junior dev."
            inform.YourExperience = "10"
            inform.Taxes = "0.5"
            inform.Amount = "300"

            Console.WriteLine("Employee's name: {0} {1}", inform.Name, inform.Surname);
            Console.WriteLine("Ocupation: {0}", inform.Ocupation);
            Console.WriteLine("Experience: {0}", inform.YourExperience)
            Console.WriteLine("An amount: {0}", CalculatorProg());
        }
    }
}
