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
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        businessDataSetTableAdapters.CustomersTableAdapter adapter;

        private void File_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerForm cf = new CustomerForm();
            cf.Show();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            //add customer
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string address = txtAddress.Text;
            string city = txtCity.Text;
            string state = txtState.Text;
            string zipCode = txtZipCode.Text;
            string email = txtEmail.Text;
            
            adapter.Insert(firstName,lastName,phoneNumber,address,city,state,zipCode,email);




            this.Hide();
            CustomerForm cf = new CustomerForm();
            cf.ShowDialog();
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            adapter = new businessDataSetTableAdapters.CustomersTableAdapter();
        }
    }
}
