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
using AkademineSistema.Frontend;

namespace AkademineSistema.Frontend.Controlers
{
    public partial class TeacherControl : UserControl
    {
        public TeacherControl()
        {
            InitializeComponent();
        }

        private void TeacherControl_Load(object sender, EventArgs e)
        {
            UserRepository usRepository = new UserRepository();
            List<GroupName> groupNamesList = usRepository.GetGroupsName();

            for(int i = 0; i < groupNamesList.Count; i++)
            {
                groupBox.Items.Insert(i, groupNamesList[i].Name);
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            teacherGradesPanel.Controls.Clear();
            UserRepository repository = new UserRepository();

            List<Users> usersList = repository.GetUsers();
            List<Grades> gradesList = repository.GetGrades();
            List<Groups> groupsList = repository.GetGroups();
            List<GroupName> groupNameList = repository.GetGroupsName();

            string currentCombo = groupBox.Text;

            int s = 0;
            //Rodo langus kuriame turi būti studentai su pažymiais
            foreach(Users user in usersList)
            {
                foreach (GroupName groupName in groupNameList)
                {
                    if (groupName.GetGroupName() == currentCombo) {
                        
                        foreach(Groups group in groupsList)
                        {
                            if(group.GetGroupNameId() == groupName.GetGroupNameId())
                            {
                                if(group.GetStudentId() == user.GetUsersId())
                                {
                                    foreach(Grades grade in gradesList)
                                    {
                                        if (user.GetUsersId() == grade.GetStudentsId())
                                        {
                                            TeacherGrade tg = new TeacherGrade(user, grade);
                                            teacherGradesPanel.Controls.Add(tg);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
