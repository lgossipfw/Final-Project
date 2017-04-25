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
 * Description: Displays appointment information in a datagridview control based
 * on a customer ID or appointment ID provided by the user
 */

namespace Final_Project
{
    public partial class AppointmentSearchForm : Form
    {
        /// <summary>
        /// Form constructor
        /// </summary>
        public AppointmentSearchForm()
        {
            InitializeComponent();
        }

        //Declare and initialize appointment table adapter
        businessDataSetTableAdapters.AppointmentsTableAdapter appAdapter
            = new businessDataSetTableAdapters.AppointmentsTableAdapter();

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
        /// Closes Appointment Search form, opens appointment form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppointmentForm af = new AppointmentForm();
            af.ShowDialog();
        }

        /// <summary>
        /// Returns true if appointment exists based on given ID
        /// </summary>
        /// <param name="id">ID to search for</param>
        /// <returns>True if appointment exists</returns>
        private bool AppointmentIDExists(int id)
        {
            if ((appAdapter.FindByAppID(id).Rows.Count != 1))
            {
                lblStatus.Text = "ID not valid";
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Returns true if customer exists based on given ID
        /// </summary>
        /// <param name="id">ID to search for</param>
        /// <returns>True if customer exists</returns>
        private bool CustomerIDExists(int id)
        {
            if ((appAdapter.FindByCustID(id).Rows.Count != 1))
            {
                lblStatus.Text = "ID not valid";
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Displays appointments based on customer ID or appointment ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Clear status label
            lblStatus.Text = "";

            if (radCustomerID.Checked == true)
            {
                //Hold customer ID
                int customerID;

                //Check input isn't blank
                if (txtSearchInput.Text.Equals(""))
                {
                    lblStatus.Text = "ID can't be blank";
                    txtSearchInput.Focus();
                    return;
                }
                else
                {
                    //Check input is numerical
                    if (!(int.TryParse(txtSearchInput.Text, out customerID)))
                    {
                        lblStatus.Text = "Input must be numerical";
                        txtSearchInput.Focus();
                        return;
                    }
                }

                //Check if customer id exists
                if (CustomerIDExists(customerID) == false)
                {
                    lblStatus.Text = "ID not valid";
                    return;
                }
                //Display appointments based on customer ID
                else
                {
                    dgvAppointments.DataSource = appAdapter.FindByCustID(customerID);
                }
            }
            else if (radAppointmentID.Checked)
            {
                //Hold appointment ID
                int appointmentID;

                //Check input isn't blank
                if (txtSearchInput.Text.Equals(""))
                {
                    lblStatus.Text = "ID can't be blank";
                    txtSearchInput.Focus();
                    return;
                }
                else
                {
                    //Check input is numerical
                    if (!(int.TryParse(txtSearchInput.Text, out appointmentID)))
                    {
                        lblStatus.Text = "Input must be numerical";
                        txtSearchInput.Focus();
                        return;
                    }
                }
                //Check if appointment id exists
                if (AppointmentIDExists(appointmentID) == false)
                {
                    lblStatus.Text = "ID not valid";
                    return;
                }
                //Display appointments based on appointment ID
                else
                {
                    dgvAppointments.DataSource = appAdapter.FindByAppID(appointmentID);
                }

            }
        }
    }
}
