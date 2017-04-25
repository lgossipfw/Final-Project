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
 * Description: Main form for the application. Displays the schedule of appointments
 * for the current date or a selected date from the calendar. Can access the three
 * main parts of the application: Appointments, Customers, and Users (if able).
 */

namespace Final_Project
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Form constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        //Declare and initialize session table adapter
        businessDataSetTableAdapters.SessionPermissionTableAdapter adapter
       = new businessDataSetTableAdapters.SessionPermissionTableAdapter();

        //Declare and initialize appointment table adapter
        businessDataSetTableAdapters.AppointmentsTableAdapter appointmentAdapter
            = new businessDataSetTableAdapters.AppointmentsTableAdapter();

        //Declare and initialize customer table adapter
        businessDataSetTableAdapters.CustomersTableAdapter customerAdapter =
          new businessDataSetTableAdapters.CustomersTableAdapter();

        /// <summary>
        /// Closes main form, opens login form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void File_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm frmLogin = new LoginForm();
            frmLogin.ShowDialog();
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
        /// Closes main form, opens Customer form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Customers_ViewAll_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerForm frmCustomers = new CustomerForm();
            frmCustomers.ShowDialog();
        }

        /// <summary>
        /// Closes Main form, opens Appointments form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Appointments_ViewAll_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppointmentForm frmAppointments = new AppointmentForm();
            frmAppointments.ShowDialog();
        }

        /// <summary>
        /// Opens User form, if logged in user has 
        /// adequate permission level 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Users_ViewAll_Click(object sender, EventArgs e)
        {
            //Declare session permission table
            businessDataSet.SessionPermissionDataTable table;
            //Fill table with session permission data
            table = adapter.GetData();

            //Get current user's permission level
            int permissionLevel = Convert.ToInt32(table.Rows[0]["Permission"]);
            //If user has administrator privileges
            if(permissionLevel == 1)
            {
                //Close form, display User form
                this.Hide();
                UsersForm frmUsers = new UsersForm();
                frmUsers.ShowDialog();
            }
            //Block access
            else
            {
                lblStatus.Text = "You do not have permission to enter this area";
                return;
            }
        }

        /// <summary>
        /// On form load fill datagridview control with today's appointments.
        /// If a customer's appointment was the day before the current date, 
        /// it moves the next appointment field to the last appointment field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            //Update a customer's next and last appointment dates
            customerAdapter.UpdateLastAppointment();
            //Fill with today's appointments
            dgvSchedule.DataSource = appointmentAdapter.TodaysAppointments();
        }

        /// <summary>
        /// Fill datagridview control with appointments from selected date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpAppointmentsDate_ValueChanged(object sender, EventArgs e)
        {
            //Get selected date
            DateTime sDate = dtpAppointmentsDate.Value.Date;
            //Convert to string
            string selectedDate = sDate.ToString();
            //Fill datagridview control with appointments on selected date
            dgvSchedule.DataSource = appointmentAdapter.GetSelectedDateAppointments(selectedDate);
        }
    }
}
