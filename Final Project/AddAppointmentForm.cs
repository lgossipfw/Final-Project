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
            String test = dtpTime.Value.TimeOfDay.ToString();
            string test2 = dtpDate.Value.ToShortDateString();
            string test3 = dtpDate.Value.ToString();
            DateTime t = Convert.ToDateTime(test2);
            //string m = dtpTime.ToString("tt");
            DateTime date = dtpDate.Value;
            DateTime time = dtpTime.Value;
            string mn = time.ToString("tt");

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

            //MessageBox.Show("Time: " + test + " Date: " + test2 + " Test: " + t + " New Thing: " + mn);
        }
    }
}
