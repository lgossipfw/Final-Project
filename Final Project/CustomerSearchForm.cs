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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Determine which radio button is checked
            //Validate input for that radio button
            //Run query
            //Fill dgv

            if (radCustID.Checked == true)
            {
                //
                int customerID = int.Parse(txtSearchInput.Text);

                dgvCustomers.DataSource = customerAdapter.FindByCustID(customerID);
            }
            else if(radFirstName.Checked == true)
            {

            }
            else if(radLastName.Checked == true)
            {

            }
            else if(radCity.Checked == true)
            {

            }
            
        }
    }
}
