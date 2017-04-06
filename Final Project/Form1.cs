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
            businessDataSet.UsersDataTable userTable = userAdapter.GetData();

            userAdapter.Fill(userTable);
            //Check database for valid credentials
            string username = "User1";
            string password = "derp";

            foreach (DataRow row in userTable.Rows)
            {
                int userIDInTable = row.Field<int>("Id");
                MessageBox.Show(userIDInTable.ToString());
                string permisionLevelInTable = row.Field<string>("Permission");
                permisionLevelInTable = permisionLevelInTable.TrimEnd();
                string usernameInTable = row.Field<string>("Username");
                usernameInTable = usernameInTable.TrimEnd();
                String passwordInTable = row.Field<string>("Password");
                passwordInTable = passwordInTable.TrimEnd();

                if (username.Equals(usernameInTable) && password.Equals(passwordInTable))
                {
                    //Set Permission Level
                    if (permisionLevelInTable.Equals("Admin")){
                        adapter.UpdateQuery(1);
                    }

                    MessageBox.Show("success");
                    MainForm mf = new MainForm();
                    mf.Show();
                    this.Hide();
                    //Break Out of checking users
                    break;

                }
            }



          

          
            //int i = -1;
            //adapter.UpdateQuery(7);

            //businessDataSet.SessionPermissionDataTable table;
            //table = adapter.GetData();
             
          
            //i = Convert.ToInt32(table.Rows[0]["Permission"]);
            //MessageBox.Show(i + "");

        }

        private void File_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //Everytime this form loads, write the permissions level of the
            //first record of the SessionPermission to -1 or 0
            adapter.UpdateQuery(0);
        }
    }
}
