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
        private int appointmentID;

        public AppointmentForm()
        {
            InitializeComponent();
        }

        businessDataSetTableAdapters.AppointmentsTableAdapter appAdapter =
                       new businessDataSetTableAdapters.AppointmentsTableAdapter();

        businessDataSetTableAdapters.CustomersTableAdapter custAdapter;

        private void File_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm();
            mf.ShowDialog();
        }

        private void File_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.ShowDialog();
        }

        private void File_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddNewAppointment_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddAppointmentForm aaf = new AddAppointmentForm();
            aaf.ShowDialog();
        }

        private void btnUpdateAppointment_Click(object sender, EventArgs e)
        {
            if (txtAppointmentID.Text.Equals(""))
            {
                lblStatus.Text = "ID can't be blank";
                txtAppointmentID.Focus();
                return;
            }
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

        private void btnSearchFor_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppointmentSearchForm asf = new AppointmentSearchForm();
            asf.ShowDialog();
        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            custAdapter = new businessDataSetTableAdapters.CustomersTableAdapter();

            //dgvAppointments.DataSource = appAdapter.GetData();
            //dgvAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            //dgvAppointments.AutoResizeColumns();

            businessDataSetTableAdapters.AppointmentsTableAdapter a =
                new businessDataSetTableAdapters.AppointmentsTableAdapter();
            dgvAppointments.DataSource = a.GetData();
        }

        private void btnDeleteAppointment_Click(object sender, EventArgs e)
        {
            if (txtAppointmentID.Text.Equals(""))
            {
                lblStatus.Text = "ID can't be blank";
                txtAppointmentID.Focus();
                return;
            }
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
                //Delete corresponding customer appointment

                int custID = -1;
                custID = Convert.ToInt32(appAdapter.GetCustID(appointmentID));
                //custAdapter.UpdateNextAppointment(null, custID);
                MessageBox.Show("Cust ID: " + custID);
                custAdapter.UpdateNextAppointment(null,custID);
                appAdapter.Delete(appointmentID);
                dgvAppointments.DataSource = appAdapter.GetData();
            }


        }

    }
}
