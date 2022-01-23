using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AkademineSistema.Backend.Objects;

using System.Data.SqlClient;

namespace AkademineSistema.Backend.Repositorys
{
    class ActionRepository
    {
        UserRepository rep = new UserRepository();
        private SqlConnection conn;
        public ActionRepository()
        {
            conn = new SqlConnection(@"Server = .; Database = acadedmics; User ID = sa; Password = labas1");
        }


        /// <summary>
        /// Checks if the login is correct
        /// </summary>
        /// <param name="name">The users name</param>
        /// <param name="password">The users password</param>
        public void CheckLogin(string name, string password)
        {
            int s = 0;
            List<Users> usersList = rep.GetUsers();
            foreach (Users user in usersList)
            {
                if (name == user.GetUsersUsername() && password == user.GetPersonPassword())
                    break;
                else
                {
                    s++;
                    if(s == usersList.Count)
                    {
                        throw new Exception("Toks naudotojas neegzistuoja");
                    }
                }
            }
        }

        public string SetTheUsersType(string name, string password)
        {
            List<Users> usersList = rep.GetUsers();
            string userType = null;
            foreach(Users user in usersList)
            {
                if(user.GetUsersUsername() == name && user.GetPersonPassword() == password)
                {
                    return user.GetUsersType();
                }
            }
            return userType;
        }
        public int GetIdByUserame(string username)
        {
            int theId = 0;
            List<Users> usersList = rep.GetUsers();
            foreach(Users user in usersList)
            {
                if(user.GetUsersUsername() == username)
                {
                    theId = user.GetUsersId();
                    break;
                }
            }
            return theId;
        }

        public void CheckIfExists(string name, string surname)
        {
            UserRepository usRepository = new UserRepository();
            List<Users> userList = usRepository.GetUsers();

            foreach (Users user in userList)
            {
                if (user.GetUsersType() == "Teacher" && user.GetPersonName() == name && user.GetPersonSurname() == surname)
                {
                    throw new Exception("Dėstytojas jau egzistuoja.");
                }
            }
            
        }

        public void UpdateGrades(Grades grade, int studentId, int teacherId)
        {
            try
            {
                string sql = "UPDATE grades " +
                    "SET studentId=@studentId, teacherId=@teacherId, g1=@g1, g2=@g2, g3=@g3, g4=@g4, g5=@g5, g6=@g6, g7=@g8, g9=@g9, g10=@g10 " +
                    "WHERE studentId=@newStudentId and teacherId=@newTeacherId";
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
                cmd.Parameters.AddWithValue("@newStudentId", studentId);
                cmd.Parameters.AddWithValue("@newTeacherId", teacherId);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }

        public void AddGroupName(GroupName groupName)
        {
            try
            {
                string sql = "INSERT INTO groupName (name) " +
                    "VALUES (@name)";
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

        public void RemoveGroup(GroupName groupName)
        {
            try
            {
                string sql1 = "DELETE FROM groups " +
                    "WHERE groupNameId=@groupNameId";
                SqlCommand cmd1 = new SqlCommand(sql1, conn);
                cmd1.Parameters.AddWithValue("@groupNameId", groupName.GetGroupNameId());

                conn.Open();
                cmd1.ExecuteNonQuery();
                conn.Close();

                string sql2 = "DELETE FROM groupName " +
                    "WHERE name=@name";
                SqlCommand cmd2 = new SqlCommand(sql2, conn);
                cmd2.Parameters.AddWithValue("@name", groupName.GetGroupName());

                conn.Open();
                cmd2.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }

        public void RemoveSubjectWithTeacher(SubjectName subject)
        {
            try
            {
                string sql1 = "DELETE FROM subjectName " +
                    "WHERE name=@subjectNameId";
                SqlCommand cmd1 = new SqlCommand(sql1, conn);
                cmd1.Parameters.AddWithValue("@subjectNameId", subject.GetSubjectName());

                conn.Open();
                cmd1.ExecuteNonQuery();
                conn.Close();

                string sql2 = "DELETE FROM subjects " +
                    "Where subjectNameId=@subjectNameId";
                SqlCommand cmd2 = new SqlCommand(sql2, conn);
                cmd2.Parameters.AddWithValue("@subjectNameId", subject.GetSubjectNameId());

                conn.Open();
                cmd2.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }

        public void RemoveSubject(SubjectName subject)
        {
            try
            {
                string sql1 = "DELETE FROM subjectName " +
                    "WHERE name=@subjectNameId";
                SqlCommand cmd1 = new SqlCommand(sql1, conn);
                cmd1.Parameters.AddWithValue("@subjectNameId", subject.GetSubjectName());

                conn.Open();
                cmd1.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }

        public void AddSubjectName(SubjectName name)
        {
            try
            {
                string sql = "INSERT INTO subjectName (name)" +
                    "VALUES (@name)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@name", name.GetSubjectName());

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }

        public void AddGroupWithStudent(GroupName groupName, int userId)
        {
            try
            {
                string sql = "INSERT INTO groups (groupNameId, subjectId, studentId) " +
                    "VALUES (@groupNameId, @subjectId, @studentId)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@groupNameId", groupName.GetGroupNameId());
                cmd.Parameters.AddWithValue("@subjectId", "1");
                cmd.Parameters.AddWithValue("@studentId", userId);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }


        public void AddSubjectWithTeacher(SubjectName sub, int teachersId)
        {
            try
            {
                string sql = "INSERT INTO subjects (subjectNameId, teachersId) " +
                    "VALUES (@subjectNameId, @teachersId)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@subjectNameId", sub.GetSubjectNameId());
                cmd.Parameters.AddWithValue("@teachersId", teachersId);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }

        public void RemoveTeacher(Users user)
        {
            try
            {
                string sql2 = "DELETE FROM subjects " +
                    "WHERE teachersId=@theId";
                SqlCommand cmd2 = new SqlCommand(sql2, conn);
                cmd2.Parameters.AddWithValue("@theId", user.Id);

                conn.Open();
                cmd2.ExecuteNonQuery();
                conn.Close();

                string sql1 = "DELETE FROM users " +
                    "WHERE id=@usersId";
                SqlCommand cmd1 = new SqlCommand(sql1, conn);
                cmd1.Parameters.AddWithValue("@usersId", user.Id);

                conn.Open();
                cmd1.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
        }

        public void RemoveStudent(Users user)
        {
            string sql3 = "DELETE FROM grades " +
                    "WHERE studentId=@usersId";
            SqlCommand cmd3 = new SqlCommand(sql3, conn);
            cmd3.Parameters.AddWithValue("@usersId", user.Id);

            conn.Open();
            cmd3.ExecuteNonQuery();
            conn.Close();

            string sql1 = "DELETE FROM groups " +
                "WHERE studentId=@studentId";
            SqlCommand cmd1 = new SqlCommand(sql1, conn);
            cmd1.Parameters.AddWithValue("@studentId", user.Id);

            conn.Open();
            cmd1.ExecuteNonQuery();
            conn.Close();

            string sql2 = "DELETE FROM users " +
                    "WHERE id=@theId";
            SqlCommand cmd2 = new SqlCommand(sql2, conn);
            cmd2.Parameters.AddWithValue("@theId", user.Id);

            conn.Open();
            cmd2.ExecuteNonQuery();
            conn.Close();
        }

        public void ConnectStudentToGroup(int userId, GroupName groupName)
        {
            string sql1 = "INSERT INTO groups (groupNameId, subjectId, studentId)" +
                "VALUES (@groupNameId, @subjectId, @studentId)";
            SqlCommand cmd1 = new SqlCommand(sql1, conn);
            cmd1.Parameters.AddWithValue("@groupNameId", groupName.Id);
            cmd1.Parameters.AddWithValue("@subjectId", "1");
            cmd1.Parameters.AddWithValue("@studentId", userId);

            conn.Open();
            cmd1.ExecuteNonQuery();
            conn.Close();
        }

        public void ConnectStudentWithSubject(int userId, int teacherId)
        {
            string sql = "INSERT INTO grades (studentId, teacherId, g1, g2, g3, g4, g5, g6, g7, g8, g9, g10) " +
                "VALUES (@studentId, @teacherId, @g1, @g2, @g3, @g4, @g5, @g6, @g7, @g8, @g9, @g10)";
            SqlCommand cmd1 = new SqlCommand(sql, conn);
            cmd1.Parameters.AddWithValue("@studentId", userId);
            cmd1.Parameters.AddWithValue("@teacherId", teacherId);
            cmd1.Parameters.AddWithValue("@g1", "x");
            cmd1.Parameters.AddWithValue("@g2", "x");
            cmd1.Parameters.AddWithValue("@g3", "x");
            cmd1.Parameters.AddWithValue("@g4", "x");
            cmd1.Parameters.AddWithValue("@g5", "x");
            cmd1.Parameters.AddWithValue("@g6", "x");
            cmd1.Parameters.AddWithValue("@g7", "x");
            cmd1.Parameters.AddWithValue("@g8", "x");
            cmd1.Parameters.AddWithValue("@g9", "x");
            cmd1.Parameters.AddWithValue("@g10", "x");

            conn.Open();
            cmd1.ExecuteNonQuery();
            conn.Close();
        }



    }
}
