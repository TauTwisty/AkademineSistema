using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademineSistema.Backend.Objects
{
    public class GroupName
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public GroupName(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public GroupName(string name)
        {
            Name = name;
        }

        public int GetGroupNameId()
        {
            return Id;
        }

        public string GetGroupName()
        {
            return Name;
        }
    }
}
