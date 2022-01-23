using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AkademineSistema.Backend.Repositorys;
using AkademineSistema.Backend.Objects;

namespace AkademineSistema.Frontend.Controlers.AdminControls
{
    public partial class TeacherButtonControl : UserControl
    {
        public TeacherButtonControl()
        {
            InitializeComponent();
        }

        private void TeacherButtonControl_Load(object sender, EventArgs e)
        {
            //Loads the teaching subjects comboBox
            subjectList.Items.Clear();
            UserRepository usRepository = new UserRepository();

            List<SubjectName> subjectNamesList = usRepository.GetSubjecNames();
            List<Users> usersList = usRepository.GetUsers();

            for (int i = 0; i < subjectNamesList.Count; i++)
            {
                subjectList.Items.Add(subjectNamesList[i].Name);
            }

            teachersCheckList.Items.Clear();
            //Loads the teachers comboBox
            for (int i = 0; i < usersList.Count; i++)
            {
                if(usersList[i].Type == "Teacher")
                    teachersCheckList.Items.Add(usersList[i].Name +" "+usersList[i].Surname);
            }
        }

        //The plus button
        private void button1_Click(object sender, EventArgs e)
        {
            subjectList.Items.Clear();
            UserRepository usRepository = new UserRepository();
            ActionRepository acRepository = new ActionRepository();

            SubjectName newSubject = new SubjectName(subjectTextBox.Text);

            acRepository.AddSubjectName(newSubject);

            List<SubjectName> subjectNamesList = usRepository.GetSubjecNames();

            for (int i = 0; i < subjectNamesList.Count; i++)
            {
                subjectList.Items.Add(subjectNamesList[i].Name);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = teacherNameTextBox.Text;
                string surname = teacherSurnameTextBox.Text;

                UserRepository usRepository = new UserRepository();
                ActionRepository acRepository = new ActionRepository();

                acRepository.CheckIfExists(name, surname);

                if (subjectList.CheckedItems.Count < 1)
                    throw new Exception("Prašome pasirinkti dėstomą/dėstomus dalykus.");
                //Adds teacher to the Users
                usRepository.SaveUser(new Users(name, name, surname, surname, "Teacher"));

                List<Users> usersList = usRepository.GetUsers();
                List<SubjectName> subjectNameList = usRepository.GetSubjecNames();
                List<Subjects> subjectsList = usRepository.GetSubjects();

                //Adds teacher to the designated subject
                foreach (string check in subjectList.CheckedItems)
                {
                    foreach(SubjectName subjectName in subjectNameList)
                    {
                        if(check == subjectName.Name)
                        {
                            foreach(Users user in usersList)
                            {
                                if(user.GetUsersType() == "Teacher" && user.GetPersonSurname() == surname && user.GetPersonName() == name)
                                {
                                    acRepository.AddSubjectWithTeacher(subjectName, user.GetUsersId());
                                    break;
                                }
                            }
                        }
                    }
                }

                //Loads the teachers comboBox
                teachersCheckList.Items.Clear();
                for (int i = 0; i < usersList.Count; i++)
                {
                    if (usersList[i].Type == "Teacher")
                        teachersCheckList.Items.Add(usersList[i].Name + " " + usersList[i].Surname);
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

                    var checkList = teachersCheckList.CheckedItems;


                    for (int i = 0; i < checkList.Count; i++)
                    {
                        for (int j = 0; j < usersList.Count; j++)
                        {
                            if (checkList[i].ToString() == (usersList[j].Name + " " + usersList[j].Surname))
                            {
                                acRepository.RemoveTeacher(usersList[j]);
                            }
                        }
                    }

                    teachersCheckList.Items.Clear();
                    //Loads teachers checkList
                    usersList = usRepository.GetUsers();
                    for (int i = 0; i < usersList.Count; i++)
                    {
                        if (usersList[i].Type == "Teacher")
                            teachersCheckList.Items.Add(usersList[i].Name + " " + usersList[i].Surname);
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Hide();
                }
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message);
            }
            
        }

        private void removeSubject_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tikrai norite pašalinti?", "Pašalinimas", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                UserRepository usRepository = new UserRepository();
                ActionRepository acRepository = new ActionRepository();

                List<SubjectName> subjectNameList = usRepository.GetSubjecNames();
                var checkedList = subjectList.CheckedItems;

                foreach (string check in checkedList)
                {
                    foreach (SubjectName subject in subjectNameList)
                    {
                        if (check == subject.GetSubjectName())
                        {
                            acRepository.RemoveSubject(subject);
                        }
                    }
                }

                //Shows subjects after removing
                subjectList.Items.Clear();

                List<SubjectName> subjectNamesList = usRepository.GetSubjecNames();

                for (int i = 0; i < subjectNamesList.Count; i++)
                {
                    subjectList.Items.Add(subjectNamesList[i].Name);
                }
            } else if (dialogResult == DialogResult.No)
            {
                this.Hide();
            }

        }

        private void subjectList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
