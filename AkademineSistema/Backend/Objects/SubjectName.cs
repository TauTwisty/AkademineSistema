using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademineSistema.Backend.Objects
{
    public class SubjectName
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        public SubjectName(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public SubjectName( string name)
        {
            Name = name;
        }

        public int GetSubjectNameId()
        {
            return Id;
        }

        public string GetSubjectName()
        {
            return Name;
        }
    }
}
