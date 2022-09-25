using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class User
    {
        public User(string name, string surname, int age, string login, string password, DateTime registrationDate)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Login = login;
            Password = password;
            RegistrationDate = registrationDate;
        }

        public string Name { get; }
        public string Surname { get; }
        public int Age { get; }
        public string Login { get; }
        public string Password { get; }
        public DateTime RegistrationDate { get; }
    }
}
