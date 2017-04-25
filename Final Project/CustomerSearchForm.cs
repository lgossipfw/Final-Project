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
 * Description: Displays customer information in a datagridview control based
 * on a customer ID, first name, last name, or city provided by the user
 */

namespace Final_Project
{
    public partial class CustomerSearchForm : Form
    {
        /// <summary>
        /// Form constructor
        /// </summary>
        public CustomerSearchForm()
        {
            InitializeComponent();
        }
        //Declare and initialize customer table adapter
        businessDataSetTableAdapters.CustomersTableAdapter customerAdapter =
                new businessDataSetTableAdapters.CustomersTableAdapter();

        /// <summary>
        /// Closes Customer search form, opens Customer form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerForm cf = new CustomerForm();
            cf.ShowDialog();
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
        /// Returns true if customer exists based on given ID
        /// </summary>
        /// <param name="id">ID to search for</param>
        /// <returns>True if customer exists</returns>
        private bool IDExists(int id)
        {
            if ((customerAdapter.FindByCustID(id).Rows.Count != 1))
            {
                lblStatus.Text = "ID not valid";
                return false;
            }else
            {
                return true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Clear status label
            lblStatus.Text = "";
            //Determine which radio button is checked
            if (radCustID.Checked == true)
            {
                //Hold customer ID
                int customerID;

                //Check input isn't blank
                if (txtSearchInput.Text.Equals(""))
                {
                    lblStatus.Text = "ID can't be blank";
                    txtSearchInput.Focus();
                    return;
                }
                else
                {
                    //Check input is numerical
                    if (!(int.TryParse(txtSearchInput.Text, out customerID)))
                    {
                        lblStatus.Text = "Input must be a valid customer ID";
                        txtSearchInput.Focus();
                        return;
                    }
                }

                //Check if customer id exists
                if (IDExists(customerID) == false)
                {
                    lblStatus.Text = "ID not valid";
                    return;
                }
                else
                {
                    //Display customers based on customer ID
                    dgvCustomers.DataSource = customerAdapter.FindByCustID(customerID);
                }

            }
            else if(radFirstName.Checked == true)
            {
                //Get and set first name from textbox
                string firstName = txtSearchInput.Text;

                //Check if input is blank
                if (txtSearchInput.Text.Equals(""))
                {
                    lblStatus.Text = "First name can't be blank";
                    txtSearchInput.Focus();
                    return;
                }
                else
                {
                    //Display customers based on first name
                    dgvCustomers.DataSource = customerAdapter.FindByFirstName(firstName);
                }
            }
            else if(radLastName.Checked == true)
            {
                //Get and set last name from textbox
                string lastName = txtSearchInput.Text;

                //Check input isn't blank
                if (txtSearchInput.Text.Equals(""))
                {
                    lblStatus.Text = "Last name can't be blank";
                    txtSearchInput.Focus();
                    return;
                }
                else
                {
                    //Display customers based on last name
                    dgvCustomers.DataSource = customerAdapter.FindByLastName(lastName);
                }

            }
            else if(radCity.Checked == true)
            {
                //Get and set cityfrom textbox
                string city = txtSearchInput.Text;

                //Check if input is blank
                if (txtSearchInput.Text.Equals(""))
                {
                    lblStatus.Text = "City can't be blank";
                    txtSearchInput.Focus();
                    return;
                }
                else
                {
                    //Display customers based on city
                    dgvCustomers.DataSource = customerAdapter.FindByCity(city);
                }

            }
            
        }
    }
}
