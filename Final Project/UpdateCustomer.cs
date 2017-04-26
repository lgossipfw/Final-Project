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
 * Description:
 * User can update fields for a customer in the application
 */

namespace Final_Project
{

    public partial class UpdateCustomerForm : Form
    {
        //Hold customer ID
        private int customerID;

        //Declare and initialize new customer table adapter
        businessDataSetTableAdapters.CustomersTableAdapter customerAdapter =
            new businessDataSetTableAdapters.CustomersTableAdapter();

        /// <summary>
        /// Form constructor
        /// </summary>
        public UpdateCustomerForm()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Set customer ID
        /// </summary>
        /// <param name="custID"></param>
        public void setCustomerID(int custID)
        {
            customerID = custID;
        }

        /// <summary>
        /// Loads customer's data into fields on form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateCustomerForm_Load(object sender, EventArgs e)
        {
            lblID.Text = customerID.ToString();

            //Load Data into fields on form

            //Declare customer table
            businessDataSet.CustomersDataTable customerTable;
            //Fill table with customer data
            customerTable = customerAdapter.GetData();
            //Declare customer dataset row
            businessDataSet.CustomersRow row;
            //Set row equal to customer with matching customer ID
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

        /// <summary>
        /// Exits the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Updates a given customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Check input isn't blank
            foreach(Control c in Controls)
            {
              if(c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    if (t.Text == "")
                    {
                        lblStatus.Text = t.Tag + " can't be blank";
                        return;
                    }
                }
                if (c is MaskedTextBox)
                {
                    MaskedTextBox mt = (MaskedTextBox)c;
                    if (mt.MaskFull == false)
                    {
                        lblStatus.Text = mt.Tag + " can't be blank";
                        mt.Focus();
                        return;
                    }
                }
            }

            //Set to given customer ID
            int cID = customerID;

            //Set fields to entered data
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string address = txtAddress.Text;
            string city = txtCity.Text;
            string state = txtState.Text;
            string zipCode = txtZipCode.Text;
            string email = txtEmail.Text;

            //Update Customer
            customerAdapter.UpdateCust(firstName, lastName, phoneNumber, address, city, state, zipCode, email, customerID);

            //Close form and display Customer form
            this.Hide();
            CustomerForm cf = new CustomerForm();
            cf.ShowDialog();
        }

        /// <summary>
        /// Closes Update Customer form, opens Customer form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerForm frmCustomer = new CustomerForm();
            frmCustomer.ShowDialog();
        }
    }
}
