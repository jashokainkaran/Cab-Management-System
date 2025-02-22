using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CabManagementSystem
{
    public partial class AddCustomerForm : Form
    {

        internal Admin admin;
        internal Customer NewCustomer { get; set; }
        public AddCustomerForm()
        {
            InitializeComponent();
            this.admin = new Admin();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = customerName.Text;
                string number = contactNumber.Text;
                string CurrentLocation = currentLocation.Text;
                string Destination = destination.Text;
                string Password = password.Text;

                //Creating a new customer using the constructor
                NewCustomer = new Customer(name, number, CurrentLocation, Destination, Password);

                //Adding the new car to the list in admin class
                admin.AddCustomer(NewCustomer);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
