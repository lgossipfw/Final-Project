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
    public partial class CustomerSearchForm : Form
    {
        public CustomerSearchForm()
        {
            InitializeComponent();
        }

        businessDataSetTableAdapters.CustomersTableAdapter customerAdapter =
                new businessDataSetTableAdapters.CustomersTableAdapter();


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerForm cf = new CustomerForm();
            cf.ShowDialog();
        }

        private void File_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Determine which radio button is checked
            //Validate input for that radio button
            //Run query
            //Fill dgv

            if (radCustID.Checked == true)
            {
                int customerID;

                if (txtSearchInput.Text.Equals(""))
                {
                    lblStatus.Text = "ID can't be blank";
                    txtSearchInput.Focus();
                    return;
                }
                else
                {
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
                    dgvCustomers.DataSource = customerAdapter.FindByCustID(customerID);
                }

            }
            else if(radFirstName.Checked == true)
            {
                string firstName = txtSearchInput.Text;

                if (txtSearchInput.Text.Equals(""))
                {
                    lblStatus.Text = "First name can't be blank";
                    txtSearchInput.Focus();
                    return;
                }
                else
                {
                    dgvCustomers.DataSource = customerAdapter.FindByFirstName(firstName);
                }



            }
            else if(radLastName.Checked == true)
            {
                string lastName = txtSearchInput.Text;

                if (txtSearchInput.Text.Equals(""))
                {
                    lblStatus.Text = "Last name can't be blank";
                    txtSearchInput.Focus();
                    return;
                }
                else
                {
                    dgvCustomers.DataSource = customerAdapter.FindByLastName(lastName);
                }

            }
            else if(radCity.Checked == true)
            {

                string city = txtSearchInput.Text;

                if (txtSearchInput.Text.Equals(""))
                {
                    lblStatus.Text = "City can't be blank";
                    txtSearchInput.Focus();
                    return;
                }
                else
                {
                    dgvCustomers.DataSource = customerAdapter.FindByCity(city);
                }

            }
            
        }
    }
}
