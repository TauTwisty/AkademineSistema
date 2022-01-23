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
using AkademineSistema;
using AkademineSistema.Frontend.Controlers;
using AkademineSistema.Frontend.Controlers.AdminControls;

namespace AkademineSistema.Frontend
{
    public partial class Main : Form
    {
        
        public Main(string name)
        {
            InitializeComponent();

            if(Form1.LoggedInAs == "Admin")
            {
                studentButton.Visible = true;
                teachersButton.Visible = true;
                groupsButton.Visible = true;
            }
            else if(Form1.LoggedInAs == "Teacher")
            {
                
                studentButton.Visible = false;
                teachersButton.Visible = false;
                groupsButton.Visible = false;
                
                TeacherControl tc = new TeacherControl();
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(tc);
                tc.Show();
            } 
            else if (Form1.LoggedInAs == "Student")
            {
                studentButton.Visible = false;
                teachersButton.Visible = false;
                groupsButton.Visible = false;

                StudentControl sc = new StudentControl(name);
                mainPanel.Controls.Clear();
                mainPanel.Controls.Add(sc);
                sc.Show();

            }
            nameLabelShow.Text = name;
        }

        private void studentButton_Click(object sender, EventArgs e)
        {
            StudentButtonControl sbc = new StudentButtonControl();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(sbc);
            sbc.Show();
        }

        private void teachersButton_Click(object sender, EventArgs e)
        {
            TeacherButtonControl tbc = new TeacherButtonControl();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(tbc);
            tbc.Show();
        }

        private void groupsButton_Click(object sender, EventArgs e)
        {
            GroupButtonControl gbc = new GroupButtonControl();
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(gbc);
            gbc.Show();
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
