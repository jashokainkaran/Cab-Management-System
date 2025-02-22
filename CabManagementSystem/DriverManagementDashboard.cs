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
    public partial class DriverManagementDashboard : Form
    {

        private Admin Admin;

        private void LoadDriversToGrid()
        {
            dataGridDrivers.DataSource = null;
            dataGridDrivers.DataSource = Admin.GetAllDrivers();
        }
        public DriverManagementDashboard()
        {
            InitializeComponent();
            Admin = new Admin();
            LoadDriversToGrid();
        }

        private void addDriver_Click(object sender, EventArgs e)
        {
            AddDriverForm addDriverForm = new AddDriverForm();
            if (addDriverForm.ShowDialog() == DialogResult.OK)
            {
                // Update the DataGridView with the updated list of cars
                LoadDriversToGrid();
            }
        }

        private void removeDriver_Click(object sender, EventArgs e)
        {
            if (dataGridDrivers.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridDrivers.SelectedRows[0];

                int driverId = Convert.ToInt32(selectedRow.Cells["DriverId"].Value);

                bool removed = Admin.RemoveDriver(driverId);

                if (removed)
                {
                    MessageBox.Show("Driver removed successfully.");
                    LoadDriversToGrid();
                }
                else
                {
                    MessageBox.Show("Failed to remove driver.");
                }
            }
            else
            {
                MessageBox.Show("Please select a driver to remove.");
            }
        }
    }
}
