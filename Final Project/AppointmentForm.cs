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
 * Description: Displays all appointments to the form. There are buttons for a user to
 * add, update, search for, or delete appointments from the application. Update Existing
 * and Delete buttons require a valid appointment ID to be entered.
 */

namespace Final_Project
{
    public partial class AppointmentForm : Form
    {
        //Hold appointment ID
        private int appointmentID;

        /// <summary>
        /// form constructor
        /// </summary>
        public AppointmentForm()
        {
            InitializeComponent();
        }

        //Declare and initialize appointment table adapter;
        businessDataSetTableAdapters.AppointmentsTableAdapter appAdapter =
                       new businessDataSetTableAdapters.AppointmentsTableAdapter();

        //Declare and initialize customer table adapter
        businessDataSetTableAdapters.CustomersTableAdapter custAdapter =
                       new businessDataSetTableAdapters.CustomersTableAdapter();

        /// <summary>
        /// Close Appointment form, open Main form
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
        /// Close Appointment form, opens Login form
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
        /// Exits application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void File_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Closes Appointment form, opens Add Appointment form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddNewAppointment_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddAppointmentForm frmAddAppointment = new AddAppointmentForm();
            frmAddAppointment.ShowDialog();
        }

        /// <summary>
        /// Open Update Appointment form and sends a valid appointment id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateAppointment_Click(object sender, EventArgs e)
        {
            //Check input isn't blank
            if (txtAppointmentID.Text.Equals(""))
            {
                lblStatus.Text = "ID can't be blank";
                txtAppointmentID.Focus();
                return;
            }
            //Check input is numerical
            else
            {
                if (!(int.TryParse(txtAppointmentID.Text, out appointmentID)))
                {
                    lblStatus.Text = "Input must be a valid ID";
                    txtAppointmentID.Focus();
                    return;
                }
            }

            //Check if appointment id exists
            if ((appAdapter.FindByAppID(appointmentID).Rows.Count != 1))
            {
                lblStatus.Text = "ID not valid";
                return;
            }
            else
            {
                this.Hide();
                UpdateAppointmentForm frmUpdateApp = new UpdateAppointmentForm();
                frmUpdateApp.SetAppointmentID(appointmentID);
                frmUpdateApp.ShowDialog();
            }
        }

        /// <summary>
        /// Closes Appointment form, opens Appointment Search form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearchFor_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppointmentSearchForm frmAppointmentSearch = new AppointmentSearchForm();
            frmAppointmentSearch.ShowDialog();
        }
        /// <summary>
        /// On from load fill datagridview control with appointment table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AppointmentForm_Load(object sender, EventArgs e)
        {

            dgvAppointments.DataSource = appAdapter.GetData();
        }

        /// <summary>
        /// Deletes an appointment based on valid user input, deletes
        /// customer's next appointment that was deleted
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteAppointment_Click(object sender, EventArgs e)
        {
            //Check input isn't blank
            if (txtAppointmentID.Text.Equals(""))
            {
                lblStatus.Text = "ID can't be blank";
                txtAppointmentID.Focus();
                return;
            }
            else
            {
                //Check input is numerical
                if (!(int.TryParse(txtAppointmentID.Text, out appointmentID)))
                {
                    lblStatus.Text = "Input must be numerical";
                    txtAppointmentID.Focus();
                    return;
                }
            }

            //Check if appointment id exists
            if ((appAdapter.FindByAppID(appointmentID).Rows.Count != 1))
            {
                lblStatus.Text = "ID not valid";
                return;
            }
            else
            {
                //Delete corresponding customer appointment
                //Hold customer id from database
                int custID = -1;
                //Get customer id from database with the appointment id to be deleted
                custID = Convert.ToInt32(appAdapter.GetCustID(appointmentID));
                //Delete the next appointment from the customer
                try
                {
                    custAdapter.UpdateNextAppointment(null, custID);

                }
                catch
                {
                    lblStatus.Text = "Error deleting appointment from customer";
                }
                //Delete appointment
                try
                {
                    appAdapter.Delete(appointmentID);
                }
                catch
                {
                    lblStatus.Text = "Error deleting appointment";
                }
               
                //Display updated appointment table
                dgvAppointments.DataSource = appAdapter.GetData();
            }


        }

    }
}
