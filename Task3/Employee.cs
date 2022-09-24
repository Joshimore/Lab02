using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Employee
    {
        private double staj;
        private int salary;
        public string name { get; set; }
        public string surname { get; set; }

        public Employee (string name, string surname) //constructor Employee
        {
            this.name = name;
            this.surname = surname;
        }

        public int Salary
        {
            get { return salary; }
            set
            {
                if (value >= 0)
                    Salary = value;
            }
        }

        public double Staj
        {
            get { return staj; }
            set
            {
                if (value >= 0)
                    Staj = value;
            }
        }
    }
}
