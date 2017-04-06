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
        private int userID;

        //businessDSTableAdapters.UsersTableAdapter adapter = new businessDSTableAdapters.UsersTableAdapter();
        businessDataSetTableAdapters.UsersTableAdapter adapter =
            new businessDataSetTableAdapters.UsersTableAdapter();
        DataSet ds = new DataSet();

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

        private void btnSearchFor_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserSearchForm usf = new UserSearchForm();
            usf.ShowDialog();
        }

        private void btnUpdateAppointment_Click(object sender, EventArgs e)
        {
            userID = int.Parse(txtUserID.Text);
         
            this.Hide();
            UpdateUserForm uuf = new UpdateUserForm();
            uuf.setUserID(userID);
            uuf.Show();
            
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddUserForm auf = new AddUserForm();
            auf.Show();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
          
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
           // adapter.Delete(int.Parse(txtUserID.Text));
          
        }
    }
}
