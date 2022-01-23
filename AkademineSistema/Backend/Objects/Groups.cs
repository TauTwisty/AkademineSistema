using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademineSistema.Backend.Objects
{
    public class Groups
    {
        public int Id { get; private set; }
        public int GroupNameId { get; private set; }
        public int SubjectId { get; private set; }
        public int StudentId { get; private set; }

        public Groups(int id, int groupNameId, int subjectId, int studentId)
        {
            Id = id;
            GroupNameId = groupNameId;
            SubjectId = subjectId;
            StudentId = studentId;
        }
        public Groups(int groupNameId, int studentId)
        {
            GroupNameId = groupNameId;
            StudentId = studentId;
        }

        public int GetGroupsId()
        {
            return Id;
        }

        public int GetGroupNameId()
        {
            return GroupNameId;
        }

        public int GetSubjectId()
        {
            return SubjectId;
        }

        public int GetStudentId()
        {
            return StudentId;
        }
    }
}
