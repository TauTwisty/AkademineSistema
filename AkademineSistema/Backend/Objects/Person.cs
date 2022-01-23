using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademineSistema.Backend.Objects
{
    public class Person
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Password { get; private set; }

        public Person(string name, string surname, string password)
        {
            Name = name;
            Surname = surname;
            Password = password;
        }

        public string GetPersonName()
        {
            return Name;
        }

        public string GetPersonSurname()
        {
            return Surname;
        }

        public string GetPersonPassword()
        {
            return Password;
        }
    }
}
