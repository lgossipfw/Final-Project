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
 * Description: Adds a new customer to the database based on user input
 * 
 */

namespace Final_Project
{
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        //Declare customer table adapter
        businessDataSetTableAdapters.CustomersTableAdapter adapter;

        /// <summary>
        /// Exits the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void File_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Closes Add Customer form, opens Customer form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerForm frmCustomer = new CustomerForm();
            frmCustomer.ShowDialog();
        }

        /// <summary>
        /// Inserts new customer to database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            //Check input isn't blank
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    TextBox t = (TextBox)c;
                    if (t.Equals(""))
                    {
                        lblStatus.Text = t.Tag + " can't be blank";
                        return;
                    }
                }
            }
            //Set fields
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string address = txtAddress.Text;
            string city = txtCity.Text;
            string state = txtState.Text;
            string zipCode = txtZipCode.Text;
            string email = txtEmail.Text;

            //Add new customer to database
            try
            {
                adapter.Insert(firstName, lastName, phoneNumber, address, city, state, zipCode, email);
            }
            catch
            {
                lblStatus.Text = "Error adding customer";
            }

            //Close form, open Customer form
            this.Hide();
            CustomerForm formCustomer = new CustomerForm();
            formCustomer.ShowDialog();
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            //initialize customer table adapter
            adapter = new businessDataSetTableAdapters.CustomersTableAdapter();
        }
    }
}
