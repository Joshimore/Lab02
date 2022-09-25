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
            Employee employee = new("Briyan", "Nelson", "Junior developer", 5000, 8, 0.8);
            employee.CalculatorProg();
            return;
        }
    }
}
