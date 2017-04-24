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
    public partial class UpdateAppointmentForm : Form
    {
        private int appointmentID;
        businessDataSetTableAdapters.AppointmentsTableAdapter appAdapter;
        businessDataSetTableAdapters.CustomersTableAdapter custAdapter;

        public UpdateAppointmentForm()
        {
            InitializeComponent();
        }
        public void SetAppointmentID(int appID)
        {
            appointmentID = appID;
        }

        private void File_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppointmentForm af = new AppointmentForm();
            af.ShowDialog();
        }

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

        private void btnUpdateAppointment_Click(object sender, EventArgs e)
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

            DateTime date = dtpDate.Value;
            DateTime time = dtpTime.Value;
            DateTime combined = date.Date.Add(time.TimeOfDay);

            int customerID = int.Parse(txtCustID.Text);
            string reason = cboAppReason.Text;

            appAdapter.UpdateAppointment(customerID, reason, combined, appointmentID);
            custAdapter.UpdateNextAppointment(combined, customerID);

            this.Hide();
            AppointmentForm frmAppointment = new AppointmentForm();
            frmAppointment.ShowDialog();
        }
    }
}
