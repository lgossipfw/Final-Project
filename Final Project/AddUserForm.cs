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
 * Description: Adds a user to the database using data based on user input
 * 
 */

namespace Final_Project
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
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
        /// Closes add user form, opens users form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsersForm uf = new UsersForm();
            uf.ShowDialog();
        }

        /// <summary>
        /// Adds a user to the database based on user input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            //Make sure text boxes aren't empty
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    if (t.Equals(""))
                    {
                        lblStatus.Text = t.Tag + " can't be blank";
                        return;
                    }
                }
            }

            //Make sure combo box value is selected
            if (cboPermission.SelectedIndex == -1)
            {
                lblStatus.Text = "Permission level must be selected";
                cboPermission.Focus();
                return;
            }

            //Assign values
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string permissions = cboPermission.SelectedItem.ToString();

            //Create new user with input values
            User newUser = new Final_Project.User(username, password, permissions);
            
            //Add user to database
            if(newUser.AddUserToDB() == true)
            {
                //Close form
                this.Hide();
                //Go back to users form
                UsersForm frmUsers = new UsersForm();
                frmUsers.ShowDialog();
            }
            //Display error message
            else
            {
                lblStatus.Text = "Error Adding to Database";
            }
        } 
    }
}
