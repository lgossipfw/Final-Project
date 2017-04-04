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

        }
    }
}
