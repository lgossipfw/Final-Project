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
    public partial class AppointmentForm : Form
    {
        private int appointmentID;

        public AppointmentForm()
        {
            InitializeComponent();
        }

        businessDataSetTableAdapters.AppointmentsTableAdapter adapter;

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
            appointmentID = int.Parse(txtAppointmentID.Text);

            this.Hide();
            UpdateAppointmentForm uaf = new UpdateAppointmentForm();
            uaf.SetAppointmentID(appointmentID);
            uaf.ShowDialog();

        }

        private void btnSearchFor_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppointmentSearchForm asf = new AppointmentSearchForm();
            asf.ShowDialog();
        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            adapter = new businessDataSetTableAdapters.AppointmentsTableAdapter();

            dgvAppointments.DataSource = adapter.GetData();


        }
    }
}
