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

namespace AkademineSistema.Frontend.Controlers
{
    public partial class StudentGrade : UserControl
    {
        Grades gr;
        public StudentGrade(Grades grade)
        {
            InitializeComponent();
            gr = grade;
            
        }

        private void StudentGrade_Load(object sender, EventArgs e)
        {
            Grades grade = gr;
            UserRepository usRepository = new UserRepository();

            List<Users> usersList = usRepository.GetUsers();
            List<SubjectName> subjectsNameList = usRepository.GetSubjecNames();
            List<Subjects> subjectsList = usRepository.GetSubjects();

            foreach (Subjects subject in subjectsList)
            {
                foreach (Users user in usersList)
                {
                    if (user.GetUsersId() == grade.GetTeacherId())
                    {
                        foreach (SubjectName subjectN in subjectsNameList)
                        {
                            if (subjectN.GetSubjectNameId() == subject.GetSubjectsId())
                            {
                                if (subject.GetTeachersId() == user.GetUsersId())
                                {
                                    subjectNameLabel.Text = subjectN.GetSubjectName();
                                }
                            }
                        }
                    }
                }
            }
            g1Label.Text = grade.GetGrades()[0].ToString();
            g2Label.Text = grade.GetGrades()[1].ToString();
            g3Label.Text = grade.GetGrades()[2].ToString();
            g4Label.Text = grade.GetGrades()[3].ToString();
            g5Label.Text = grade.GetGrades()[4].ToString();
            g6Label.Text = grade.GetGrades()[5].ToString();
            g7Label.Text = grade.GetGrades()[6].ToString();
            g8Label.Text = grade.GetGrades()[7].ToString();
            g9Label.Text = grade.GetGrades()[8].ToString();
            g10Label.Text = grade.GetGrades()[9].ToString();
        }
    }
}
