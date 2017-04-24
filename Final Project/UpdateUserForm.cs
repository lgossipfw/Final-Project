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
 * Description:
 * 
 */


namespace Final_Project
{
    public partial class UpdateUserForm : Form
    {

        private int userID;
        private User userToUpdate;


        public UpdateUserForm()
        {
            InitializeComponent();
        }

        public void setUserID(int uID)
        {
            userID = uID;
        }

        private void File_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UpdateUserForm_Load(object sender, EventArgs e)
        {
            userToUpdate = new Final_Project.User();
            userToUpdate = userToUpdate.GetUser(userID);
            lblUserID.Text = userID.ToString();

            txtUsername.Text = userToUpdate.Username;
            txtPassword.Text = userToUpdate.Password;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsersForm uf = new UsersForm();
            uf.ShowDialog();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
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

            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string permission = cboPermisssions.SelectedItem.ToString();

            if(userToUpdate.UpdateUserInDB(userID, username, password, permission) == true)
            {
                this.Hide();
                UsersForm frmUsers = new UsersForm();
                frmUsers.ShowDialog();
            }
            else
            {
                lblStatus.Text = "Error updating database";
                return;
            }
        }
    }
}
