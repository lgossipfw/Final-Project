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

namespace Final_Project
{
    public partial class CustomerForm : Form
    {
        private int custID;

        public CustomerForm()
        {
            InitializeComponent();
        }

        businessDataSetTableAdapters.CustomersTableAdapter customerAdapter;

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            //this.Hide();
            AddCustomerForm frmAddCust = new AddCustomerForm();
            frmAddCust.ShowDialog();
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {

            if (txtCustID.Text.Equals(""))
            {
                lblStatus.Text = "ID can't be blank";
                txtCustID.Focus();
                return;
            }else
            {
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
                UpdateCustomerForm ucf = new UpdateCustomerForm();
                ucf.setCustomerID(custID);
                ucf.ShowDialog();
                //this.Hide();
                
            }

           
        }

        private void File_Home_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm();
            mf.Show();
        }

        private void File_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.ShowDialog();
        }

        private void File_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCustomerSearch_Click(object sender, EventArgs e)
        {
            //this.Hide();
            CustomerSearchForm csf = new CustomerSearchForm();
            csf.ShowDialog();
        }

        private void Customers_CreateReport_Click(object sender, EventArgs e)
        {

            lblStatus.Text = "";
            StreamWriter outputFile;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text | *.txt";

            businessDataSet bDataSet = new businessDataSet();
            customerAdapter = new businessDataSetTableAdapters.CustomersTableAdapter();
            bDataSet.Clear();
            customerAdapter.Fill(bDataSet.Customers);
            DataTable dt = new DataTable();
            dt = customerAdapter.SixMonths();
            string line = "";

            foreach (DataRow row in dt.Rows)
            {
                //Get first name 
                string firstName = row.Field<string>("FirstName");
                //Get last name
                string lastName = row.Field<string>("LastName");
                string phoneNumber = row.Field<string>("PhoneNumber");
                string email = row.Field<string>("Email");
                line += firstName + " " + lastName + Environment.NewLine +
                  "     " + phoneNumber + " " + email + Environment.NewLine;


            }
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                outputFile = File.CreateText(saveFileDialog.FileName);

                outputFile.WriteLine("Customers To Be Contacted");
                outputFile.WriteLine("The following customers have not been seen in 6 months:");
                outputFile.WriteLine("-------------------------------------------------------");
                outputFile.WriteLine("");
                outputFile.WriteLine(line);

                outputFile.Close();
            }





        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            customerAdapter = new businessDataSetTableAdapters.CustomersTableAdapter();

            dgvCustomers.DataSource = customerAdapter.GetData();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (txtCustID.Text.Equals(""))
            {
                lblStatus.Text = "ID can't be blank";
                txtCustID.Focus();
                return;
            }
            else
            {
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
            else
            {
                customerAdapter.Delete(custID);
                dgvCustomers.DataSource = customerAdapter.GetData();

            }
        }
    }
}
