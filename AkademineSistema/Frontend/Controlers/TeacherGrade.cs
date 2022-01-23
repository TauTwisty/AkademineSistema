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
    public partial class TeacherGrade : UserControl
    {
        public Users us;
        public Grades gr;
        public TeacherGrade(Users user, Grades grade)
        {
            InitializeComponent();
            us = user;
            gr = grade;
        }

        private void TeacherGrade_Load(object sender, EventArgs e)
        {
            UserRepository usRepository = new UserRepository();
            ActionRepository acRepository = new ActionRepository();

            nameSurnameLabel.Text = us.GetPersonName() + " "+ us.GetPersonSurname();

            g1TextBox.Text = gr.GetGrades()[0].ToString();
            g2TextBox.Text = gr.GetGrades()[1].ToString();
            g3TextBox.Text = gr.GetGrades()[2].ToString();
            g4TextBox.Text = gr.GetGrades()[3].ToString();
            g5TextBox.Text = gr.GetGrades()[4].ToString();
            g6TextBox.Text = gr.GetGrades()[5].ToString();
            g7TextBox.Text = gr.GetGrades()[6].ToString();
            g8TextBox.Text = gr.GetGrades()[7].ToString();
            g9TextBox.Text = gr.GetGrades()[8].ToString();
            g10TextBox.Text = gr.GetGrades()[9].ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            ActionRepository acRepository = new ActionRepository();
            acRepository.UpdateGrades(new Grades(gr.StudentId, gr.TeacherId,
                g1TextBox.Text, g2TextBox.Text, g3TextBox.Text, g4TextBox.Text, g5TextBox.Text, g6TextBox.Text, g7TextBox.Text, g8TextBox.Text, g9TextBox.Text, g10TextBox.Text), gr.StudentId, gr.TeacherId);
        }
    }
}
