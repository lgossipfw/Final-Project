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
    public partial class UpdateUserForm : Form
    {

        private int userID;

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
            lblUserID.Text = userID.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsersForm uf = new UsersForm();
            uf.ShowDialog();
        }
    }
}
