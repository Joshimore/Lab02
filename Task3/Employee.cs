using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Employee
    {
        private string name;
        private string surname;
        private string post;
        private int salary;
        private int experience;
        private int taxe;

        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public string Surname
        {
            set
            {
                surname= value;
            }
            get
            {
                return surname;
            }
        }
    }
}
