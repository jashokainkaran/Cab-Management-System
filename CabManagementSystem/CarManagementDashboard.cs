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
    public partial class CarManagementDashboard : Form
    {
        private Admin Admin;

        private void LoadCarsToGrid()
        {
            dataGridViewCars.DataSource = null;
            dataGridViewCars.DataSource = Admin.GetAllCars();
        }
        public CarManagementDashboard()
        {
            InitializeComponent();
            Admin = new Admin();
            LoadCarsToGrid();
        }

        private void CarManagementDashboard_Load(object sender, EventArgs e)
        {

        }

        private void addCar_Click(object sender, EventArgs e)
        {
            AddCarForm addCarForm = new AddCarForm();
            if (addCarForm.ShowDialog() == DialogResult.OK)
            {
                // Update the DataGridView with the updated list of cars
                LoadCarsToGrid();
            }
        }

            private void removeCar_Click(object sender, EventArgs e)
            {
                if (dataGridViewCars.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridViewCars.SelectedRows[0];

                    int carId = Convert.ToInt32(selectedRow.Cells["CarId"].Value);

                    bool removed = Admin.RemoveCar(carId);

                    if (removed)
                    {
                        MessageBox.Show("Car removed successfully.");
                        LoadCarsToGrid();
                    }
                    else
                    {
                        MessageBox.Show("Failed to remove car.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a car to remove.");
                }
            }




        }
    }
