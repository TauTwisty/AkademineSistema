using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademineSistema.Backend.Objects
{
    public class Users : Person
    {
        public int Id { get; private set; }
        public string Username { get; private set; }
        public string Type { get; private set; }

        //Sitas panaudojimui
        public Users (string name, string username, string surname, string password, int id, string type) : base (name, surname, password)
        {
            Id = id;
            Username = username;
            Type = type;
        }
        //Registracijai
        public Users(string name, string username, string surname, string password, string type) : base(name, surname, password)
        {
            Username = username;
            Type = type;
        }

        public int GetUsersId()
        {
            return Id;
        }

        public string GetUsersUsername()
        {
            return Username;
        }

        public string GetUsersType()
        {
            return Type;
        }
    }
}
