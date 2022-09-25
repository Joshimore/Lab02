using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User info = new User();
            info.Login = "ypuppew";
            info.Name = "Eric";
            info.Surname = "Nordwitch";
            info.Age = 24;
            info.CreationTime = "now";

            info.usrinfo();
        }
    }
}
