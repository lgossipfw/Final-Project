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
    public partial class CustomerForm : Form
    {
        private int custID;

        public CustomerForm()
        {
            InitializeComponent();
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCustomerForm acf = new AddCustomerForm();
            //lf.Closed += (s, args) => this.Close();
            acf.Show();
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            custID = int.Parse(txtCustID.Text);

            UpdateCustomerForm ucf = new UpdateCustomerForm();
            ucf.setCustomerID(custID);
            ucf.Show();
            this.Hide();
        }

        private void File_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm();
            mf.Show();
        }
    }
}
