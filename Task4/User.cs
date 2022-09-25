using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class User
    {
        public string Login
        {
            get { return Login; }
            set { Login = value; }
        }
        public string Name
        {
            get { return Name; }
            set { Name = value; }
        }
        public string Surname
        {
            get { return Surname; }
            set { Surname = value; }
        }
        public int Age
        {
            get { return Age; }
            set { Age = value; }
        }
        public DateTime CreationTime
        {
            get { return CreationTime; }
            set { CreationTime = value; }
        }

        //constructor
        public User(string login, string name, string surname, int age, DateTime creationtime)
        {
            Login = login;
            Name = name;
            Surname = surname;
            Age = age;
            CreationTime = creationtime;
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
