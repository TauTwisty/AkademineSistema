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
using AkademineSistema.Frontend.Controlers;

namespace AkademineSistema.Frontend.Controlers
{
    public partial class StudentControl : UserControl
    {
        public StudentControl(string name)
        {
            InitializeComponent();
            UserRepository repository = new UserRepository();
            ActionRepository acRepository = new ActionRepository();
            List<Grades> gradesList = repository.GetGrades();

            foreach(Grades grade in gradesList)
            {
                if(grade.GetStudentsId() == acRepository.GetIdByUserame(name))
                {
                    StudentGrade sg = new StudentGrade(grade);
                    studentGradePanel.Controls.Add(sg);
                }
            }
            
        }

        private void stundetGradePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StudentControl_Load(object sender, EventArgs e)
        {

        }
    }
}
