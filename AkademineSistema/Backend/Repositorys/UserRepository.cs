using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AkademineSistema.Backend.Objects;
using System.Data.SqlClient;
using AkademineSistema;

namespace AkademineSistema.Backend.Repositorys
{
    public class UserRepository
    {
        private SqlConnection conn;
        public UserRepository()
        {            
            conn = new SqlConnection(@"Server = .; Database = acadedmics; User ID = sa; Password = labas1");
        }

        #region Get Components Region
        public List<Users> GetUsers()
        {
            List<Users> usersList = new List<Users>();

            try
            {
                string sql = "select id, username, name, surname, password, type from users";
                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = int.Parse(reader["id"].ToString());
                    string username = reader["username"].ToString();
                    string name = reader["name"].ToString();
                    string surname = reader["surname"].ToString();
                    string password = reader["password"].ToString();
                    string type = reader["type"].ToString();
                    usersList.Add(new Users(name, username, surname, password, id, type));
                }
                conn.Close();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }                     
            return usersList;
        }

        public List<Subjects> GetSubjects()
        {
            List<Subjects> subjectsList = new List<Subjects>();

            try
            {
                string sql = "select id, subjectNameId, teachersId from subjects";
                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["id"].ToString());
                    int subjectNameId = int.Parse(reader["subjectNameId"].ToString());
                    int teachersId = int.Parse(reader["teachersId"].ToString());
                    subjectsList.Add(new Subjects(id, subjectNameId, teachersId));
                }
                conn.Close();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
            return subjectsList;
        }

        public List<SubjectName> GetSubjecNames()
        {
            List<SubjectName> subjectNamesList = new List<SubjectName>();
            try
            {
                string sql = "select id, name from subjectName";
                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["id"].ToString());
                    string name = reader["name"].ToString();
                    subjectNamesList.Add(new SubjectName(id, name));
                }
                conn.Close();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }

            return subjectNamesList;
        }

        public List<Groups> GetGroups()
        {
            List<Groups> groupsList = new List<Groups>();

            try
            {
                string sql = "select id, groupNameId, subjectId, studentId from groups";
                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["id"].ToString());
                    int groupNameId = int.Parse(reader["groupNameId"].ToString());
                    int subjectId = int.Parse(reader["subjectId"].ToString());
                    int studentId = int.Parse(reader["studentId"].ToString());
                    groupsList.Add(new Groups(id, groupNameId, subjectId, studentId));
                }
                conn.Close();
            }

            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }

            return groupsList;
        }

        public List<GroupName> GetGroupsName()
        {
            List<GroupName> groupNameList = new List<GroupName>();

            try
            {
                string sql = "select id, name from groupName";
                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["id"].ToString());
                    string name = reader["name"].ToString();
                    groupNameList.Add(new GroupName(id, name));
                }
                conn.Close();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
            return groupNameList;
        }

        public List<Grades> GetGrades()
        {
            List<Grades> gradesList = new List<Grades>();

            try
            {
                string sql = "select id, studentId, teacherId, g1, g2, g3, g4, g5, g6, g7, g8, g9, g10 from grades";
                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["id"].ToString());
                    int studentId = int.Parse(reader["studentId"].ToString());
                    int teacherId = int.Parse(reader["teacherId"].ToString());
                    string g1 = reader["g1"].ToString();
                    string g2 = reader["g2"].ToString();
                    string g3 = reader["g3"].ToString();
                    string g4 = reader["g4"].ToString();
                    string g5 = reader["g5"].ToString();
                    string g6 = reader["g6"].ToString();
                    string g7 = reader["g7"].ToString();
                    string g8 = reader["g8"].ToString();
                    string g9 = reader["g9"].ToString();
                    string g10 = reader["g10"].ToString();
                    gradesList.Add(new Grades(id, studentId, teacherId, g1, g2, g3, g4, g5, g6, g7, g8, g9, g10));

                }
                conn.Close();
            }
            catch(Exception exc)
            {
                throw new Exception(exc.Message);
            }

            return gradesList;
        }
        #endregion

#region Save Compotents region

        public void SaveUser(Users user)
        {
            try
            {
                string sql = "insert into users (username, name, surname, password, type) " +
                    "values (@username, @name, @surname, @password, @type)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", user.GetPersonName());
                cmd.Parameters.AddWithValue("@surname", user.GetPersonSurname());
                cmd.Parameters.AddWithValue("@username", user.GetUsersUsername());
                cmd.Parameters.AddWithValue("@password", user.GetPersonPassword());
                cmd.Parameters.AddWithValue("@type", user.GetUsersType());

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }

        public void SaveSubjects(Subjects subject)
        {
            try
            {
                string sql = "insert into subjects (subjectNameId, teachersId) " +
                    "values (@subjectNameId, @teachersId)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@subjectNameId", subject.GetSubjectsNameId());
                cmd.Parameters.AddWithValue("@teachersId", subject.GetTeachersId());

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }

        public void SaveSubjectName(SubjectName subName)
        {
            try
            {
                string sql = "insert into subjectName (name) " +
                    "values (@name)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", subName.GetSubjectName());

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }

        public void SaveGroups(Groups group)
        {
            try
            {
                string sql = "insert into groups (groupNameId, subjectId, studentId) " +
                    "values (@groupNameId, @subjectId, @studentId)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@groupNameId", group.GetGroupNameId());
                cmd.Parameters.AddWithValue("@subjectId", group.GetSubjectId());
                cmd.Parameters.AddWithValue("@studentId", group.GetStudentId());

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }

        }

        public void SaveGroupsName(GroupName groupName)
        {
            try
            {
                string sql = "inset into groupName (name) " +
                    "values (@name)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", groupName.GetGroupName());

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }

        public void SaveGrades(Grades grade)
        {
            try
            {
                string sql = "insert into grades (studentId, teacherId, g1, g2, g3, g4, g5, g6, g7, g8, g9, g10) " +
                    "values (@studentId, @teacherId, @g1, @g2, @g3, @g4, @g5, @g6, @g7, @g8, @g9, @g10)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@studentId", grade.GetStudentsId());
                cmd.Parameters.AddWithValue("@teacherId", grade.GetTeacherId());
                cmd.Parameters.AddWithValue("@g1", grade.GetGrades()[0]);
                cmd.Parameters.AddWithValue("@g2", grade.GetGrades()[1]);
                cmd.Parameters.AddWithValue("@g3", grade.GetGrades()[2]);
                cmd.Parameters.AddWithValue("@g4", grade.GetGrades()[3]);
                cmd.Parameters.AddWithValue("@g5", grade.GetGrades()[4]);
                cmd.Parameters.AddWithValue("@g6", grade.GetGrades()[5]);
                cmd.Parameters.AddWithValue("@g7", grade.GetGrades()[6]);
                cmd.Parameters.AddWithValue("@g8", grade.GetGrades()[7]);
                cmd.Parameters.AddWithValue("@g9", grade.GetGrades()[8]);
                cmd.Parameters.AddWithValue("@g10", grade.GetGrades()[9]);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }
#endregion       
    }
}
