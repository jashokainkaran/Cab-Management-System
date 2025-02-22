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
    public partial class AdminDashboard : Form
    {
        private Admin admin;

        public AdminDashboard()
        {
            InitializeComponent();
            admin = new Admin();
        }

        private void viewCars_Click(object sender, EventArgs e)
        {
            CarManagementDashboard carManagementDashboard = new CarManagementDashboard();
            carManagementDashboard.ShowDialog();
        }

        private void viewDrivers_Click(object sender, EventArgs e)
        {
            DriverManagementDashboard driverManagementDashboard = new DriverManagementDashboard();
            driverManagementDashboard.ShowDialog();
        }

        private void viewOrders_Click(object sender, EventArgs e)
        {
            OrderManagementDashboard orderManagementDashboard = new OrderManagementDashboard();
            orderManagementDashboard.ShowDialog();
        }

        private void viewCustomers_Click(object sender, EventArgs e)
        {
            CustomerManagementDashboard customerManagementDashboard = new CustomerManagementDashboard();
            customerManagementDashboard.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin.Logout(this);
        }
    }
}
