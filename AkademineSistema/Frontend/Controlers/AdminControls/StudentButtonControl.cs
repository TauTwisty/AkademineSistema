using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AkademineSistema.Backend.Objects;
using AkademineSistema.Backend.Repositorys;

namespace AkademineSistema.Frontend.Controlers.AdminControls
{
    public partial class StudentButtonControl : UserControl
    {
        public StudentButtonControl()
        {
            InitializeComponent();
        }

        private void StudentButtonControl_Load(object sender, EventArgs e)
        {
            UserRepository usRepository = new UserRepository();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            studentsComboBox.Items.Clear();

            List<GroupName> groupNameList = usRepository.GetGroupsName();
            List<Users> usersList = usRepository.GetUsers();
            List<Groups> groupList = usRepository.GetGroups();

            foreach(GroupName gName in groupNameList)
            {
                comboBox2.Items.Add(gName.Name);
                comboBox3.Items.Add(gName.Name);
            }
            #region Shows available students
            List<Users> newUsers1 = new List<Users>();
            for(int i = 0; i < usersList.Count; i++)
            {
                if(usersList[i].GetUsersType() == "Student")
                {
                    newUsers1.Add(usersList[i]);
                }
            }

            List<Users> newUsers2 = new List<Users>();
            for (int i = 0; i < newUsers1.Count; i++)
            {
                for(int j = 0; j < groupList.Count; j++)
                {
                    if(newUsers1[i].Id == groupList[j].StudentId)
                    {
                        newUsers2.Add(newUsers1[i]);
                        break;
                    }
                }
            }

            for(int i = 0; i < newUsers2.Count; i++)
            {
                newUsers1.Remove(newUsers2[i]);
            }
            #endregion

            for(int i = 0; i < newUsers1.Count; i++)
            {
                studentsComboBox.Items.Add(newUsers1[i].Name + " " + newUsers1[i].Surname);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(nameTextBox.Text == null)
                    throw new Exception("Be vardo, negalite sukurti studento.");
                if(surnameTextBox.Text == null)
                    throw new Exception("Be pavardės, negalite sukurti studento.");
                

                string name = nameTextBox.Text;
                string surname = surnameTextBox.Text;

                UserRepository usRepository = new UserRepository();
                ActionRepository acRepository = new ActionRepository();

                usRepository.SaveUser(new Users(name, name, surname, surname, "Student"));
                MessageBox.Show("Sėkmingai pridėtas studentas.");

                //Shows available students
                studentsComboBox.Items.Clear();
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();

                List<GroupName> groupNameList = usRepository.GetGroupsName();
                List<Users> usersList = usRepository.GetUsers();
                List<Groups> groupList = usRepository.GetGroups();

                foreach (GroupName gName in groupNameList)
                {
                    comboBox2.Items.Add(gName.Name);
                    comboBox3.Items.Add(gName.Name);
                }
                #region Shows available students complex
                List<Users> newUsers1 = new List<Users>();
                for (int i = 0; i < usersList.Count; i++)
                {
                    if (usersList[i].GetUsersType() == "Student")
                    {
                        newUsers1.Add(usersList[i]);
                    }
                }

                List<Users> newUsers2 = new List<Users>();
                for (int i = 0; i < newUsers1.Count; i++)
                {
                    for (int j = 0; j < groupList.Count; j++)
                    {
                        if (newUsers1[i].Id == groupList[j].StudentId)
                        {
                            newUsers2.Add(newUsers1[i]);
                            break;
                        }
                    }
                }

                for (int i = 0; i < newUsers2.Count; i++)
                {
                    newUsers1.Remove(newUsers2[i]);
                }
                #endregion

                for (int i = 0; i < newUsers1.Count; i++)
                {
                    studentsComboBox.Items.Add(newUsers1[i].Name + " " + newUsers1[i].Surname);
                }

            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            try
            {
                UserRepository usRepository = new UserRepository();

                List<Groups> groupsList = usRepository.GetGroups();
                List<Users> usersList = usRepository.GetUsers();
                List<GroupName> groupNameList = usRepository.GetGroupsName();


                studentCheckList.Items.Clear();
                groupsList = usRepository.GetGroups();

                for(int i = 0; i < usersList.Count; i++)
                {
                    for (int j = 0; j < groupsList.Count; j++)
                    {
                        for (int k = 0; k < groupNameList.Count; k++)
                        {
                            if (usersList[i].Id == groupsList[j].StudentId &&
                                groupsList[j].GroupNameId == groupNameList[k].Id &&
                                groupNameList[k].Name == comboBox2.Text &&
                                usersList[i].GetUsersType() == "Student")
                            {
                                studentCheckList.Items.Add(usersList[i].Name + " " + usersList[i].Surname);
                            }
                        }
                    }
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Tikrai norite pašalinti?", "Pašalinimas", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    UserRepository usRepository = new UserRepository();
                    ActionRepository acRepository = new ActionRepository();


                    List<Users> usersList = usRepository.GetUsers();

                    var checkList = studentCheckList.CheckedItems;

                    for (int i = 0; i < checkList.Count; i++)
                    {
                        for (int j = 0; j < usersList.Count; j++)
                        {
                            if (checkList[i].ToString() == (usersList[j].Name + " " + usersList[j].Surname))
                            {
                                acRepository.RemoveStudent(usersList[j]);
                            }
                        }
                    }
                    //Shows the list of students via selected group combo box
                    List<Groups> groupsList = usRepository.GetGroups();                    
                    List<GroupName> groupNameList = usRepository.GetGroupsName();

                    studentCheckList.Items.Clear();
                    groupsList = usRepository.GetGroups();

                    for (int i = 0; i < usersList.Count; i++)
                    {
                        for (int j = 0; j < groupsList.Count; j++)
                        {
                            for (int k = 0; k < groupNameList.Count; k++)
                            {
                                if (usersList[i].Id == groupsList[j].StudentId &&
                                    groupsList[j].GroupNameId == groupNameList[k].Id &&
                                    groupNameList[k].Name == comboBox2.Text &&
                                    usersList[i].GetUsersType() == "Student")
                                {
                                    studentCheckList.Items.Add(usersList[i].Name + " " + usersList[i].Surname);
                                }
                            }
                        }
                    }


                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Hide();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void showButton2_Click(object sender, EventArgs e)
        {
            UserRepository usRepository = new UserRepository();
            List<SubjectName> subjectNameList = usRepository.GetSubjecNames();

            subjectComboBox.Items.Clear();
            for (int i = 0; i < subjectNameList.Count; i++)
            {
                subjectComboBox.Items.Add(subjectNameList[i].Name);
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            UserRepository usRepository = new UserRepository();
            ActionRepository acRepository = new ActionRepository();

            List<Users> userList = usRepository.GetUsers();            
            List<GroupName> groupsNameList = usRepository.GetGroupsName();
            List<SubjectName> subjectsnameList = usRepository.GetSubjecNames();
            List<Subjects> subjectsList = usRepository.GetSubjects();
            List<Grades> gradesList = usRepository.GetGrades();

            try
            {
                if (studentsComboBox.Text == null)
                    throw new Exception("Prašom pasirinkti norima sujungti studentą.");
                if (comboBox3.Text == null)
                    throw new Exception("Prašom pasirinkti grupę.");
                

                string selectedStudent = studentsComboBox.Text;
                string selectedGroup = comboBox3.Text;
                var selectedSubjects = subjectComboBox.CheckedItems;

                //Gauna studento ID
                int studentsId = 0;
                for (int i = 0; i < userList.Count; i++)
                {
                    if((userList[i].Name + " " + userList[i].Surname) == selectedStudent)
                    {
                        studentsId = userList[i].Id;
                    }
                }

                //Sets the student to a group
                for(int i = 0; i < groupsNameList.Count; i++)
                {
                    if(groupsNameList[i].Name == selectedGroup)
                    {
                        acRepository.ConnectStudentToGroup(studentsId, groupsNameList[i]);
                        break;
                    }
                }
                
                for(int i = 0; i < selectedSubjects.Count; i++)
                {
                    for(int j = 0; j < subjectsList.Count; j++)
                    {
                        for( int k = 0; k < subjectsnameList.Count; k++)
                        {
                            if(subjectsList[j].Id == subjectsnameList[k].Id && selectedSubjects[i].ToString() == subjectsnameList[k].Name)
                            {
                                acRepository.ConnectStudentWithSubject(studentsId, subjectsList[j].TeachersId);
                            }
                            
                        }
                    }
                }

                MessageBox.Show("Sėkmingai pridėtas(-ta) į sąrašą.");

            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
