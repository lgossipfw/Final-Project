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
 * Description: Adds a new appointment to the database based on user input
 * 
 */

namespace Final_Project
{
    public partial class AddAppointmentForm : Form
    {
        /// <summary>
        /// Form constructor
        /// </summary>
        public AddAppointmentForm()
        {
            InitializeComponent();
        }

        //Declare and initialize appointment table adapter
        businessDataSetTableAdapters.AppointmentsTableAdapter adapter =
            new businessDataSetTableAdapters.AppointmentsTableAdapter();

        //Declare and initialize customer table adapter
        businessDataSetTableAdapters.CustomersTableAdapter custAdapter =
            new businessDataSetTableAdapters.CustomersTableAdapter();

        /// <summary>
        /// Closes Add Appointment form, opens Appointment form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppointmentForm frmAppointment = new AppointmentForm();
            frmAppointment.ShowDialog();
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
        /// Validates input and adds a new appointment to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            //Hold customer ID
            int customerID;

            //Check input isn't blank
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    if (t.Text == "")
                    {
                        lblStatus.Text = t.Tag + " can't be blank";
                        t.Focus();
                        return;
                    }
                }
            }

            //Check input is numerical
            if (!(int.TryParse(txtCustID.Text, out customerID)))
            {
                lblStatus.Text = "ID must be numerical";
                txtCustID.Focus();
                return;
            }

            //Check customer exists
            if(custAdapter.FindByCustID(customerID).Rows.Count < 1)
            {
                lblStatus.Text = "Customer ID does not exist";
                txtCustID.Focus();
                return;
            }

            //Check combobox has selection
            if (cboAppReason.SelectedIndex == -1)
            {
                lblStatus.Text = "Appointment reason must be selected";
                cboAppReason.Focus();
                return;
            }

            //Hold date of appointment
            DateTime date = dtpDate.Value;
            //Hold time of appointment
            DateTime time = dtpTime.Value;
            //Hold combined date and time
            DateTime combined = date.Date.Add(time.TimeOfDay);
            //Convert to string
            string combinedstuff = combined.ToString();
            //Set reason
            string reason = cboAppReason.SelectedItem.ToString();
            //Add appointment
            try
            {
             adapter.Insert(customerID, reason, combined);

            }
            catch
            {
                lblStatus.Text = "Error adding appointment";
            }

            if(adapter.FindByCustID(customerID).Rows.Count < 1)
            {
                try
                {
                    //Assign appointment to corresponding customer
                    custAdapter.UpdateNextAppointment(combined, customerID);
                }
                catch
                {
                    lblStatus.Text = "Error updating customer's next appointment";
                }
            }
        
            

            //Close form, open appointment form
            this.Hide();
            AppointmentForm frmAppointment = new AppointmentForm();
            frmAppointment.ShowDialog();
        }
    }
}
