using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Name: Lea Gossman
 * Project: Final Project
 * Date: 4/26/17
 * Description: Opens the Main Form of application if username and password are valid
 */

namespace Final_Project
{
    public partial class LoginForm : Form
    {
       
        /// <summary>
        /// Form constructor
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
            
        }

        //Declare and intantiate session table adapter
        businessDataSetTableAdapters.SessionPermissionTableAdapter adapter
         = new businessDataSetTableAdapters.SessionPermissionTableAdapter();

        //Declare and instantiate user table adapter
        businessDataSetTableAdapters.UsersTableAdapter userAdapter 
            = new businessDataSetTableAdapters.UsersTableAdapter();
     
        /// <summary>
        /// Opens the Main Form of application if username and password
        /// are valid. Checks and validates user input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Clear status label
            lblStatus.Text = String.Empty;

            //Declare user table
            businessDataSet.UsersDataTable userTable = userAdapter.GetData();
            //Fill with user data
            userAdapter.Fill(userTable);
            
            //Get input from fields on form
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
     
            //Check each data row
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

                int userID = row.Field<int>("Id");

                //Check if row data matches user input for username and password
                if (username.Equals(usernameInTable) && password.Equals(passwordInTable))
                {
                    //If match
                    //Set Permission Level
                    if (permisionLevelInTable.Equals("Admin")){
                        adapter.UpdateQuery(1, userID);
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
            //Display error message
            lblStatus.Text = "Invalid credentials";
        }

        /// <summary>
        /// Exits the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void File_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Writes the permissions level of the first record of the 
        /// SessionPermission table to 0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginForm_Load(object sender, EventArgs e)
        {
            adapter.UpdateQuery(0, 0);
        }
    }
}
