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
    public partial class CustomerDashboard : Form
    {
        private string userName;
        private Admin admin;

        private Customer currentCustomer;
        public CustomerDashboard(string userName)
        {
            InitializeComponent();
            this.userName = userName;
            this.admin = new Admin();
            this.currentCustomer = admin.FindCustomerById(Admin.LoggedCustomerId);

        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
            // Shows the welcome message
            welcomeLabel.Text = $"Welcome, {userName}!";

            LoadAvailableCarsAndDrivers();
        }

        private void LoadAvailableCarsAndDrivers()
        {
            //Enter data into the combo boxes for cars and driver
            List<Car> availableCars = admin.GetAvailableCars();
            List<Driver> availableDrivers = admin.GetAvailableDrivers();

            foreach (Car car in availableCars)
            {
                carComboBox.Items.Add(car);
            }

            foreach (Driver driver in availableDrivers)
            {
                driverComboBox.Items.Add(driver);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void placeOrder_Click(object sender, EventArgs e)
        {
            if (carComboBox.SelectedItem != null && driverComboBox.SelectedItem != null)
            {
                Car selectedCar = (Car)carComboBox.SelectedItem;
                Driver selectedDriver = (Driver)driverComboBox.SelectedItem;

                if (selectedCar != null && selectedDriver != null)
                {
                    DateTime selectedDate = dateTimePicker1.Value;
                    Order newOrder = new Order(currentCustomer, selectedDriver, selectedDate);
                    admin.AddOrder(newOrder, selectedCar);
                    MessageBox.Show("Order placed successfully.");

                    carComboBox.Items.Clear();
                    driverComboBox.Items.Clear();
                    LoadAvailableCarsAndDrivers();
                }
                else
                {
                    MessageBox.Show("Invalid car or driver selection.");
                }
            }
            else
            {
                MessageBox.Show("Please select both a car and a driver.");
            }
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            Admin.Logout(this);
        }
    }
}
