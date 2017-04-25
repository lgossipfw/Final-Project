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
 * Description: Can search for a user by username or permission level and
 * have the results displayed in the form
 * 
 */

namespace Final_Project
{
    public partial class UserSearchForm : Form
    {
        public UserSearchForm()
        {
            InitializeComponent();
        }

        //Declare and instantiate new user table adapter
        businessDataSetTableAdapters.UsersTableAdapter userAdapter =
            new businessDataSetTableAdapters.UsersTableAdapter();

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
        /// Closes the user search form, opens Users form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsersForm frmUsers = new UsersForm();
            frmUsers.ShowDialog();
        }

        /// <summary>
        /// Enables permission combo box if permission radio button is checked.
        /// Disables search textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radPermissions_CheckedChanged(object sender, EventArgs e)
        {
            cboPermission.Enabled = true;
            txtSearchInput.Enabled = false;
        }

        /// <summary>
        /// Enables search text box if username radio button is checked.
        /// Disables permission combo box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radUsername_CheckedChanged(object sender, EventArgs e)
        {
            cboPermission.Enabled = false;
            txtSearchInput.Enabled = true;
        }

        /// <summary>
        /// Checks if a username exists in the database
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        private bool UsernameExists(string username)
        {
            if ((userAdapter.FindByUsername(username).Rows.Count != 1))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Searches for a user based on username or permission level.
        /// Fill datagridview control with results.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //If username is selected
            if (radUsername.Checked)
            {
                //Input criteria is username
                string username = "";

                //Check input isn't blank
                if (txtSearchInput.Text.Equals(""))
                {
                    lblStatus.Text = "Username can't be blank";
                    txtSearchInput.Focus();
                    return;
                }
                //Assign input from textbox
                else
                {
                    username = txtSearchInput.Text;
                }

                //Check if username exists
                if (UsernameExists(username) == false)
                {
                    lblStatus.Text = "Username does not exist";
                    return;
                }
                //If it exists, display results in dgv control
                else
                {
                    dgvUsers.DataSource = userAdapter.FindByUsername(username);
                }
            }
            //If searching by permission level
            else if (radPermissions.Checked)
            {
                //Criteria is string
                string permission;

                //Make sure combo box value is selected
                if(cboPermission.SelectedIndex == -1)
                {
                    lblStatus.Text = "Permission level must be selected";
                    cboPermission.Focus();
                    return;
                }
                //Set permission to selected level
                else
                {
                    permission = cboPermission.SelectedItem.ToString();
                }
                //Display data based on permission
                dgvUsers.DataSource = userAdapter.FindByPermission(permission);
            }
        }
    }
}
