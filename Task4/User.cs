using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public DateTime CreationTime { get; set; }

        //constructor
        public User(string login, string name, string surname, int age, DateTime creationtime)
        {
            this.Login = login;
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.CreationTime = creationtime;
        }

        public void usrinfo()
        {
            Console.WriteLine("Name: ", Name, Surname);
            Console.WriteLine("Age: ", Age);
            Console.WriteLine("Login: ", Login);
            Console.WriteLine("Creation time: ", CreationTime);
        }
    }
}
