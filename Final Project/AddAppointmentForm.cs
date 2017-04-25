﻿using System;
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
 * Description:
 * 
 */

namespace Final_Project
{
    public partial class AddAppointmentForm : Form
    {
        public AddAppointmentForm()
        {
            InitializeComponent();
        }

        businessDataSetTableAdapters.AppointmentsTableAdapter adapter =
            new businessDataSetTableAdapters.AppointmentsTableAdapter();

        businessDataSetTableAdapters.CustomersTableAdapter custAdapter =
            new businessDataSetTableAdapters.CustomersTableAdapter();

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppointmentForm af = new AppointmentForm();
            af.ShowDialog();
        }

        private void File_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {

            DateTime date = dtpDate.Value;
            DateTime time = dtpTime.Value;
            DateTime combined = date.Date.Add(time.TimeOfDay);

            string combinedstuff = combined.ToString();
            MessageBox.Show("Date: " + combinedstuff);

            int customerID = int.Parse(txtCustID.Text);
            string reason = cboAppReason.SelectedItem.ToString();
            adapter.Insert(customerID, reason, combined);
            custAdapter.UpdateNextAppointment(combined, customerID);

            this.Hide();
            AppointmentForm af = new AppointmentForm();
            af.ShowDialog();
        }
    }
}
