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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void File_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            //lf.Closed += (s, args) => this.Close();
            lf.Show();
        }

        private void File_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Customers_ViewAll_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerForm cf = new CustomerForm();
            //lf.Closed += (s, args) => this.Close();
            cf.Show();
        }

        private void Appointments_ViewAll_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppointmentForm af = new AppointmentForm();
            af.ShowDialog();
        }

        private void Users_ViewAll_Click(object sender, EventArgs e)
        {
            //TODO: Check permissions

            this.Hide();
            UsersForm uf = new UsersForm();
            uf.ShowDialog();

        }
    }
}
