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
    public partial class LoginForm : Form
    {
       

        public LoginForm()
        {
            InitializeComponent();
            
        }
        businessDataSetTableAdapters.SessionPermissionTableAdapter adapter
         = new businessDataSetTableAdapters.SessionPermissionTableAdapter();

        businessDataSetTableAdapters.UsersTableAdapter userAdapter = new businessDataSetTableAdapters.UsersTableAdapter();
     
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Clear status label
            lblStatus.Text = String.Empty;

            businessDataSet.UsersDataTable userTable = userAdapter.GetData();

            userAdapter.Fill(userTable);
            //Check database for valid credentials

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            //Check username isn't blank
            if (username.Equals(String.Empty))
            {
                lblStatus.Text = "Username can't be blank";
                return;
            }
            //Check password isn't blank
            if (password.Equals(String.Empty))
            {
                lblStatus.Text = "Password can't be blank";
                return;
            }
     
            //Check each row in users table
            foreach (DataRow row in userTable.Rows)
            {
                //Get permission level from row
                string permisionLevelInTable = row.Field<string>("Permission");
                //Get username from row
                string usernameInTable = row.Field<string>("Username");
                //Get password from row
                string passwordInTable = row.Field<string>("Password");

                //Remove whitespace from row data
                permisionLevelInTable = permisionLevelInTable.Trim();
                usernameInTable = usernameInTable.Trim();
                passwordInTable = passwordInTable.Trim();

                //Check if row data matches user input for username and password
                if (username.Equals(usernameInTable) && password.Equals(passwordInTable))
                {
                    //If match
                    //Set Permission Level
                    if (permisionLevelInTable.Equals("Admin")){
                        adapter.UpdateQuery(1);
                    }

                    //Go to main form
                    MainForm frmMain = new MainForm();
                    frmMain.ShowDialog();
                    //Close Login Form
                    this.Hide();
                    //Break Out of checking users
                    break;

                }
            }
            lblStatus.Text = "Invalid credentials";
        }

        private void File_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //Everytime this form loads, write the permissions level of the
            //first record of the SessionPermission table to 0
            adapter.UpdateQuery(0);
        }
    }
}
