using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }

        private void File_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm();
            mf.ShowDialog();
        }

        private void File_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.ShowDialog();
        }

        private void File_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddUserForm auf = new AddUserForm();
            auf.ShowDialog();
        }

        private void btnSearchFor_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserSearchForm usf = new UserSearchForm();
            usf.ShowDialog();
        }

        private void btnUpdateAppointment_Click(object sender, EventArgs e)
        {

        }
    }
}
