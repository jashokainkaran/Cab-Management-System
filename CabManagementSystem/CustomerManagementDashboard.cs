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
    public partial class CustomerManagementDashboard : Form
    {
        private Admin Admin;
        private void LoadCustomersToGrid()
        {
            dataGridCustomers.DataSource = null;
            dataGridCustomers.DataSource = Admin.GetAllCustomers();

        }
        public CustomerManagementDashboard()
        {
            InitializeComponent();
            Admin = new Admin();
            LoadCustomersToGrid();
        }


        //Adding Customers 
        private void addCustomer_Click_1(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            if (addCustomerForm.ShowDialog() == DialogResult.OK)
            {
                // Update the DataGridView with the updated list of cars
                LoadCustomersToGrid();
            }
        }
        
        private void addCustomer_Click(object sender, EventArgs e)
        {
        }

        //Removing Customer
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridCustomers.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridCustomers.SelectedRows[0];

                int customerId = Convert.ToInt32(selectedRow.Cells["CustomerId"].Value);

                bool removed = Admin.RemoveCustomer(customerId);

                if (removed)
                {
                    MessageBox.Show("Customer removed successfully.");
                    LoadCustomersToGrid();
                }
                else
                {
                    MessageBox.Show("Failed to remove Customer.");
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to remove.");
            }
        }

        
    }
}
