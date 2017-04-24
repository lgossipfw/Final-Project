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

        businessDataSetTableAdapters.AppointmentsTableAdapter appointmentAdapter
            = new businessDataSetTableAdapters.AppointmentsTableAdapter();

        businessDataSetTableAdapters.CustomersTableAdapter customerAdapter =
          new businessDataSetTableAdapters.CustomersTableAdapter();

        private void File_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm frmLogin = new LoginForm();
            frmLogin.ShowDialog();
        }

        private void File_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Customers_ViewAll_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerForm frmCustomers = new CustomerForm();
            frmCustomers.ShowDialog();
        }

        private void Appointments_ViewAll_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppointmentForm frmAppointments = new AppointmentForm();
            frmAppointments.ShowDialog();
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
            //Update a customer's next and last appointment dates
            customerAdapter.UpdateLastAppointment();


            businessDataSet bDataSet = new businessDataSet();
            
            bDataSet.Clear();
            appointmentAdapter.Fill(bDataSet.Appointments);

            dgvSchedule.DataSource = appointmentAdapter.TodaysAppointments();
            
            

        }

        private void dtpAppointmentsDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime sDate = dtpAppointmentsDate.Value.Date;
            string selectedDate = sDate.ToString();

            businessDataSet bDataSet = new businessDataSet();
            bDataSet.Clear();
            appointmentAdapter.Fill(bDataSet.Appointments);
            dgvSchedule.DataSource = appointmentAdapter.GetSelectedDateAppointments(selectedDate);
        }
    }
}
