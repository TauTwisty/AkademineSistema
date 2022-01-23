using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademineSistema.Backend.Objects
{
    public class Grades
    {
        public int Id { get; private set; }
        public int StudentId { get; private set; }
        public int TeacherId { get; private set; }
        public string P1 { get; private set; }
        public string P2 { get; private set; }
        public string P3 { get; private set; }
        public string P4 { get; private set; }
        public string P5 { get; private set; }
        public string P6 { get; private set; }
        public string P7 { get; private set; }
        public string P8 { get; private set; }
        public string P9 { get; private set; }
        public string P10 { get; private set; }

        public Grades(int id, int studentId, int teacherId, string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8, string p9, string p10)
        {
            Id = id;
            StudentId = studentId;
            TeacherId = teacherId;
            P1 = p1;
            P2 = p2;
            P3 = p3;
            P4 = p4;
            P5 = p5;
            P6 = p6;
            P7 = p7;
            P8 = p8;
            P9 = p9;
            P10 = p10;
        }

        public Grades(int studentId, int teacherId, string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8, string p9, string p10)
        {
            StudentId = studentId;
            TeacherId = teacherId;
            P1 = p1;
            P2 = p2;
            P3 = p3;
            P4 = p4;
            P5 = p5;
            P6 = p6;
            P7 = p7;
            P8 = p8;
            P9 = p9;
            P10 = p10;
        }

        /// <summary>
        /// Get grades id from data base
        /// </summary>
        /// <returns></returns>
        public int GetGradesId()
        {
            return Id;
        }

        /// <summary>
        /// Get students id from grades data table
        /// </summary>
        /// <returns></returns>
        public int GetStudentsId()
        {
            return StudentId;
        }

        /// <summary>
        /// Get teachers id from grades data table
        /// </summary>
        /// <returns></returns>
        public int GetTeacherId()
        {
            return TeacherId;
        }

        /// <summary>
        /// Get a string array of the grades themselves. Ranking from 1 to 10
        /// </summary>
        /// <returns></returns>
        public string[] GetGrades()
        {
            string[] grade = {P1, P2, P3, P4, P5, P6, P7, P8, P9, P10 };
            return grade;
        }


    }
}
