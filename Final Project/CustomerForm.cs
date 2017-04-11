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

        businessDataSetTableAdapters.CustomersTableAdapter adapter;

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCustomerForm acf = new AddCustomerForm();
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
            this.Hide();
            CustomerSearchForm csf = new CustomerSearchForm();
            csf.ShowDialog();
        }

        private void Customers_CreateReport_Click(object sender, EventArgs e)
        {
            //Loop through all customers and compare last appointment date to 6 months before current date
            DateTime currentDate = DateTime.Today;
            DateTime compareDate = currentDate.AddMonths(-6);

            //Check that the customer has a last appointment date not null

            //Compare times
            String lastAppDateString = "9/8/2016";
            String lastAppDate2String = "2/14/2017";
            DateTime lastAppDate = Convert.ToDateTime(lastAppDate2String);
            int i = (int)(lastAppDate - DateTime.Now).TotalDays;
            i = i * -1;
            MessageBox.Show("Total days: " +i);
            if (((lastAppDate - DateTime.Now).TotalDays *-1)  > 183) 
            {

            }


        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            adapter = new businessDataSetTableAdapters.CustomersTableAdapter();

            dgvCustomers.DataSource = adapter.GetData();
        }
    }
}
