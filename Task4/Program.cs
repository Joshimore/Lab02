using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type 'Info' to show an information about the user");

            switch (Console.ReadLine())
            {
                case "Info"
                    User user = new("Bryan", "Johnson", 45, "bbqd", DateTime.Now);
                    user.usrinfo();
                    break;
                default:
                    Console.WriteLine("**INPUT ERROR**");
                    break;
            }
        }
    }
}
