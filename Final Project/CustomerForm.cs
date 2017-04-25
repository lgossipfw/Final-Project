using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/* Name: Lea Gossman
 * Project: Final Project
 * Date: 4/26/17
 * Description: Displays all customers to the form. There are buttons for a user to
 * add, update, search for, or delete users from the application. Update Existing
 * and Delete buttons require a valid customer ID to be entered.
 */

namespace Final_Project
{
    public partial class CustomerForm : Form
    {
        //Hold customer ID
        private int custID;

        /// <summary>
        /// Form constructor
        /// </summary>
        public CustomerForm()
        {
            InitializeComponent();
        }

        //Declare and initialize customer table adapter
        businessDataSetTableAdapters.CustomersTableAdapter customerAdapter
              = new businessDataSetTableAdapters.CustomersTableAdapter();

        /// <summary>
        /// Closes Customer Form, opens Add New Customer form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCustomerForm frmAddCust = new AddCustomerForm();
            frmAddCust.ShowDialog();
        }

        /// <summary>
        /// Validates a customer ID and sends it to the Update
        /// Customer form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            //Check text boxes aren't blank
            if (txtCustID.Text.Equals(""))
            {
                lblStatus.Text = "ID can't be blank";
                txtCustID.Focus();
                return;
            }else
            {
                //Check input is numerical
                if(!(int.TryParse(txtCustID.Text, out custID)))
                {
                    lblStatus.Text = "Input must be numerical";
                    txtCustID.Focus();
                    return;
                }
            }

            //Check if customer id exists
            if ((customerAdapter.FindByCustID(custID).Rows.Count != 1))
            {
                lblStatus.Text = "ID not valid";
                return;
            }
            else
            {
                //Send customer ID to Update Customer form
                UpdateCustomerForm frmUpdateCust = new UpdateCustomerForm();
                frmUpdateCust.setCustomerID(custID);
                frmUpdateCust.ShowDialog();
                this.Hide();
                
            }
        }

        /// <summary>
        /// Closes Customer form, opens Main form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void File_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm frmMain = new MainForm();
            frmMain.Show();
        }

        /// <summary>
        /// Closes Customer form, opens Login Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void File_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.ShowDialog();
        }

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
        /// Closes Customer form, opens Customer Search form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCustomerSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerSearchForm csf = new CustomerSearchForm();
            csf.ShowDialog();
        }

        /// <summary>
        /// Creates a text report of customers that have not been seen in 
        /// six or more months
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Customers_CreateReport_Click(object sender, EventArgs e)
        {
            //Clear status label
            lblStatus.Text = "";
            //Declare output file
            StreamWriter outputFile;
            //Declare savefiledialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            //Set file format
            saveFileDialog.Filter = "Text | *.txt";


            //Hold customer data
            DataTable dt = new DataTable();
            //Fill with customers to be contacted
            dt = customerAdapter.SixMonths();
            //Hold customer info
            string line = "";

            //Loop through returned customers
            foreach (DataRow row in dt.Rows)
            {
                //Get first name 
                string firstName = row.Field<string>("FirstName");
                //Get last name
                string lastName = row.Field<string>("LastName");
                //Get phone number
                string phoneNumber = row.Field<string>("PhoneNumber");
                //Get email
                string email = row.Field<string>("Email");
                //Store customer information
                line += firstName + " " + lastName + Environment.NewLine +
                  "     " + phoneNumber + " " + email + Environment.NewLine;


            }
            //If user selects "OK"
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get Filename
                outputFile = File.CreateText(saveFileDialog.FileName);

                //Write data
                outputFile.WriteLine("Customers To Be Contacted");
                outputFile.WriteLine("The following customers have not been seen in 6 months:");
                outputFile.WriteLine("-------------------------------------------------------");
                outputFile.WriteLine("");
                outputFile.WriteLine(line);

                //Close file
                outputFile.Close();
            }
        }

        /// <summary>
        /// Loads customer data into datagridview control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            //initialize cutomer table adapter
            customerAdapter = new businessDataSetTableAdapters.CustomersTableAdapter();
            //Fill datagridview control with customer data
            dgvCustomers.DataSource = customerAdapter.GetData();
        }

        /// <summary>
        /// Deletes customer from the database taking a valid
        /// customer ID as input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            //Validate text boxes aren't blank
            if (txtCustID.Text.Equals(""))
            {
                lblStatus.Text = "ID can't be blank";
                txtCustID.Focus();
                return;
            }
            else
            {
                //Check input is numerical
                if (!(int.TryParse(txtCustID.Text, out custID)))
                {
                    lblStatus.Text = "Input must be numerical";
                    txtCustID.Focus();
                    return;
                }
            }

            //Check if customer id exists
            if ((customerAdapter.FindByCustID(custID).Rows.Count != 1))
            {
                lblStatus.Text = "ID not valid";
                return;
            }
            //Delete customer
            else
            {
                customerAdapter.Delete(custID);
                txtCustID.Clear();
                dgvCustomers.DataSource = customerAdapter.GetData();

            }
        }
    }
}
