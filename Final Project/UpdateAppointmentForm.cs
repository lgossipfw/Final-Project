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
 * Description:mUser can update fields for an appointment in the application
 */

namespace Final_Project
{
    public partial class UpdateAppointmentForm : Form
    {

        //Hold appointment ID
        private int appointmentID;
        //Declare appointment table adapter
        businessDataSetTableAdapters.AppointmentsTableAdapter appAdapter;
        //Declare customer table adapter
        businessDataSetTableAdapters.CustomersTableAdapter custAdapter;

        /// <summary>
        /// Form constructor
        /// </summary>
        public UpdateAppointmentForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Set appointment ID
        /// </summary>
        /// <param name="appID"></param>
        public void SetAppointmentID(int appID)
        {
            appointmentID = appID;
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
        /// Closes Update Appointment Form, opens Appointment form
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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateAppointmentForm_Load(object sender, EventArgs e)
        {
            lblappID.Text = appointmentID.ToString();
            custAdapter = new businessDataSetTableAdapters.CustomersTableAdapter();
            appAdapter = new businessDataSetTableAdapters.AppointmentsTableAdapter();
            //Load Data into fields on form

            //Declare appointment table
            businessDataSet.AppointmentsDataTable appointmentTable;
            //Fill table with appointment data
            appointmentTable = appAdapter.GetData();
            //Declare appointment dataset row
            businessDataSet.AppointmentsRow row;
            //Set row equal to appointment with matching appointment ID
            row = appointmentTable.FindByAppointmentID(appointmentID);
            //Set fields to existing data
            txtCustID.Text = row.CustomerID.ToString();
            cboAppReason.SelectedText = row.AppointmentReason.TrimEnd();
            dtpDate.Value = row.Date.Date;
            dtpTime.Value = row.Date;
        }

        /// <summary>
        /// Updates an existing appointments information and the
        /// corresponding customer's next appointment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateAppointment_Click(object sender, EventArgs e)
        {
            //Check input isn't blank
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

            //Hold date of appointment
            DateTime date = dtpDate.Value;
            //Hold time of appointment
            DateTime time = dtpTime.Value;
            //Hold combinted date and time of appointment
            DateTime combined = date.Date.Add(time.TimeOfDay);

            //Get customer ID
            int customerID = int.Parse(txtCustID.Text);
            //Get appointment reason
            string reason = cboAppReason.Text;
            
            //Update appointment information
            appAdapter.UpdateAppointment(customerID, reason, combined, appointmentID);
            //Update customer's next appointment
            custAdapter.UpdateNextAppointment(combined, customerID);

            //Close form, display Appointment form
            this.Hide();
            AppointmentForm frmAppointment = new AppointmentForm();
            frmAppointment.ShowDialog();
        }
    }
}
