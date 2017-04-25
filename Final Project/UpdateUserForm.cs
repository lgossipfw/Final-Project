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
 * Description: User can update fields for a user in the application
 */


namespace Final_Project
{
    public partial class UpdateUserForm : Form
    {

        private int userID;         //Hold user id to update
        private User userToUpdate;  //User to hold updated information

        /// <summary>
        /// Form constructor
        /// </summary>
        public UpdateUserForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Set user ID
        /// </summary>
        /// <param name="uID">User ID to be set</param>
        public void setUserID(int uID)
        {
            userID = uID;
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
        /// Loads user data into fields on form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateUserForm_Load(object sender, EventArgs e)
        {
            //Initialize new user
            userToUpdate = new Final_Project.User();
            //Update user with information from user with given user ID
            userToUpdate = userToUpdate.GetUser(userID);
            //Display username
            lblUserID.Text = userID.ToString();

            //Display user information in form
            txtUsername.Text = userToUpdate.Username;
            txtPassword.Text = userToUpdate.Password;
            cboPermissions.DisplayMember = userToUpdate.Permission;
        }

        /// <summary>
        /// Closes Update User form, opens Users form
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
        /// Updates user in database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            //Check text boxes aren't blank
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

            //Validate combo box selection
            if(cboPermissions.SelectedText == "")
            {
                lblStatus.Text = "Permission level must be selected";
                return;
            }

            //Set fields to user input
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string permission = cboPermissions.SelectedItem.ToString();

            //Update User
            if (userToUpdate.UpdateUserInDB(userID, username, password, permission) == true)
            {
                this.Hide();
                UsersForm frmUsers = new UsersForm();
                frmUsers.ShowDialog();
            }
            else
            {
                //Display error message
                lblStatus.Text = "Error updating database";
                return;
            }
        }
    }
}
