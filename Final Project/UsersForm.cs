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
 * Description: Displays all users to the form. There are buttons for a user to
 * add, update, search for, or delte users from the application. Update Existing
 * and Delete buttons require a valid user ID to be entered.
 */
  
namespace Final_Project
{
    public partial class UsersForm : Form
    {
        //Hold userID
        private int userID;

        //Declare and instantiate user table adapter
        businessDataSetTableAdapters.UsersTableAdapter userAdapter =
            new businessDataSetTableAdapters.UsersTableAdapter();
        //Delcare and instantiate session table adapter
        businessDataSetTableAdapters.SessionPermissionTableAdapter sessionAdapter =
            new businessDataSetTableAdapters.SessionPermissionTableAdapter();

        /// <summary>
        /// Constructor
        /// </summary>
        public UsersForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Closes User form, opens main form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void File_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm frmMain = new MainForm();
            frmMain.ShowDialog();
        }

        /// <summary>
        /// Closes user form, opens login form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void File_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.ShowDialog();
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
        /// Closes user form, opens user search form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchFor_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserSearchForm frmUserSearch = new UserSearchForm();
            frmUserSearch.ShowDialog();
        }

        /// <summary>
        /// Close user form, opens add new user form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddUserForm frmAddUser = new AddUserForm();
            frmAddUser.Show();
        }

        /// <summary>
        /// When form loads, load datagridview control with data
        /// from user table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UsersForm_Load(object sender, EventArgs e)
        {
            dgvUsers.DataSource = userAdapter.GetData();
        }

        /// <summary>
        /// Deletes user from database based on user input of a
        /// valid user ID.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            //Check input isn't blank
            if (txtUserID.Text.Equals(""))
            {
                lblStatus.Text = "ID can't be blank";
                txtUserID.Focus();
                return;
            }
            //Check input is numerical
            else
            {
                if (!(int.TryParse(txtUserID.Text, out userID)))
                {
                    lblStatus.Text = "Input must be numiercal";
                    txtUserID.Focus();
                    return;
                }
            }

            //Check if user id exists
            if ((userAdapter.FindByUserID(userID).Rows.Count != 1))
            {
                lblStatus.Text = "ID not valid";
                return;
            }
            //Check if the current user is trying to delete themselves
            else if (userID == Convert.ToUInt32(sessionAdapter.GetUserID()))
            {
                lblStatus.Text = "Cannot delete active user";
                return;
            }
            //Delete user, get new data from user table
            else
            {
                userAdapter.Delete(userID);
                dgvUsers.DataSource = userAdapter.GetData();
            }
        }

        /// <summary>
        /// Validates and sends a user id to be updated in the 
        /// Update Users form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            //Check input isn't blank
            if (txtUserID.Text.Equals(""))
            {
                lblStatus.Text = "ID can't be blank";
                txtUserID.Focus();
                return;
            }
            //Check input is numerical
            else
            {
                if (!(int.TryParse(txtUserID.Text, out userID)))
                {
                    lblStatus.Text = "Input must be numerical";
                    txtUserID.Focus();
                    return;
                }
            }

            //Check if user id exists
            if ((userAdapter.FindByUserID(userID).Rows.Count != 1))
            {
                lblStatus.Text = "ID doesn't exist";
                return;
            }
            //Close the user form, open update user form
            else
            {
                this.Hide();
                UpdateUserForm frmUpdateUser = new UpdateUserForm();
                //Send userID to form
                frmUpdateUser.setUserID(userID);
                frmUpdateUser.Show();

            }
        }
    }
}
