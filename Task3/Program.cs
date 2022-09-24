using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, surname;
            int salary;
            double staj;

            Console.WriteLine("                                           ****GLOBAL TRADE&co****" +
                "\n\nIt is a vacancy search program. \n For more info try to register below, follow the instructions:");


            Console.WriteLine("\nName:");
                name = Console.ReadLine();
           

            Console.WriteLine("\nSurname:");
                surname = Console.ReadLine();

            Console.WriteLine("\nPlease state your seniority (in years):");
                staj = double.Parse(Console.ReadLine());
            if (staj < 0)
            {
                Console.WriteLine("Are you sure?");
                return;
            }
            else if (staj > 64)
            {
                Console.WriteLine("Are you sure?");
                return;
            }
            else
            {
                Console.WriteLine("**INPUT ERROR**");
            }

            //Console.WriteLine();
        }
    }
}
