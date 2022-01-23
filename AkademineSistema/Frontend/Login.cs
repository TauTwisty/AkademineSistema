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
using AkademineSistema.Frontend;

namespace AkademineSistema
{
    public partial class Form1 : Form
    {
        public static string LoggedInAs; //Type
        public static string LoggedInName;
        public static string LoggedInSurname;
        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            ActionRepository acRepository = new ActionRepository();
            try
            {
                acRepository.CheckLogin(nameTextBox.Text, passwordTextBox.Text);
                LoggedInAs = acRepository.SetTheUsersType(nameTextBox.Text, passwordTextBox.Text);

                Main g = new Main(nameTextBox.Text);
                g.Show();
                this.Hide();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
