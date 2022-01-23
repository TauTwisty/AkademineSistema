using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademineSistema.Backend.Objects
{
    public class Subjects
    {
        public int Id { get; private set; }
        public int SubjectNameId { get; private set; }
        public int TeachersId { get; private set; }

        public Subjects(int id, int subjectNameId, int teachersId)
        {
            Id = id;
            SubjectNameId = subjectNameId;
            TeachersId = teachersId;
        }
        public Subjects(int subjectNameId, int teachersId)
        {
            SubjectNameId = subjectNameId;
            TeachersId = teachersId;
        }

        public int GetSubjectsId()
        {
            return Id;
        }

        public int GetSubjectsNameId()
        {
            return SubjectNameId;
        }

        public int GetTeachersId()
        {
            return TeachersId;
        }
    }
}
