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
        }
    }
}
