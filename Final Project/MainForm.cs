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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        businessDataSetTableAdapters.SessionPermissionTableAdapter adapter
       = new businessDataSetTableAdapters.SessionPermissionTableAdapter();

        private void File_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            //lf.Closed += (s, args) => this.Close();
            lf.Show();
        }

        private void File_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Customers_ViewAll_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerForm cf = new CustomerForm();
            //lf.Closed += (s, args) => this.Close();
            cf.Show();
        }

        private void Appointments_ViewAll_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppointmentForm af = new AppointmentForm();
            af.ShowDialog();
        }

        private void Users_ViewAll_Click(object sender, EventArgs e)
        {
            //TODO: Check permissions
            businessDataSet.SessionPermissionDataTable table;
            table = adapter.GetData();


            int i = Convert.ToInt32(table.Rows[0]["Permission"]);
            MessageBox.Show("Permission Level: " + i);
            if(i == 1)
            {
                this.Hide();
                UsersForm uf = new UsersForm();
                uf.ShowDialog();
            }
            else
            {
                lblStatus.Text = "You do not have permission to enter this area";
                return;
            }
           

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Load today's schedule
            //Use foreach loop to go through Appointments table
            //Convert date field to DateTime
            //Compare if equal to Today's date
            //.Compare method

            
        }

        private void dtpAppointmentsDate_ValueChanged(object sender, EventArgs e)
        {
            //Compare dates for current entry
        }
    }
}
