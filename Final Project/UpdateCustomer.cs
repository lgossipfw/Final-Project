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

    public partial class UpdateCustomerForm : Form
    {
        private int customerID;

        businessDataSetTableAdapters.CustomersTableAdapter customerAdapter =
            new businessDataSetTableAdapters.CustomersTableAdapter();

        public UpdateCustomerForm()
        {
            InitializeComponent();

        }

        public void setCustomerID(int custID)
        {
            customerID = custID;
        }

        private void UpdateCustomerForm_Load(object sender, EventArgs e)
        {
            lblID.Text = customerID.ToString();

            //Load Data into fields on form

            //Declare employee table
            businessDataSet.CustomersDataTable customerTable;
            //Fill table with employee data
            customerTable = customerAdapter.GetData();
            //Declare employee dataset row
            businessDataSet.CustomersRow row;
            //Set row equal to employee with matching employeeID
            row = customerTable.FindByCustomerID(customerID);
            //Set fields to existing data
            txtFirstName.Text = row.FirstName;
            txtLastName.Text = row.LastName;
            txtPhoneNumber.Text = row.PhoneNumber;
            txtAddress.Text = row.Address;
            txtCity.Text = row.City;
            txtState.Text = row.State;
            txtZipCode.Text = row.ZipCode;
            txtEmail.Text = row.Email;


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void txtUpdate_Click(object sender, EventArgs e)
        {
            int cID = customerID;
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string address = txtAddress.Text;
            string city = txtCity.Text;
            string state = txtState.Text;
            string zipCode = txtZipCode.Text;
            string email = txtEmail.Text;

            foreach(Control c in Controls)
            {
              if(c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    if (t.Equals(""))
                    {
                        lblStatus.Text = t.Tag + " can't be blank";
                        return;
                    }
                }
            }

            customerAdapter.UpdateCust(firstName, lastName, phoneNumber, address, city, state, zipCode, email, customerID);

            this.Hide();
            CustomerForm cf = new CustomerForm();
            cf.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
