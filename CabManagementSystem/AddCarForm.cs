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
    public partial class AddCarForm : Form
    {
        internal Admin admin;
        internal Car NewCar { get; set; }
        public AddCarForm()
        {
            InitializeComponent();
            this.admin = new Admin();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int carID = Convert.ToInt32(carId.Text);
                string model = carModel.Text;
                string plateNumber = carNumber.Text;
                bool availability = available.Checked;

                //Creating a new car using the constructor
                NewCar = new Car(carID, model, plateNumber, availability);
                
                //Adding the new car to the list in admin class
                admin.AddCar(NewCar);
                
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch 
            {
                MessageBox.Show("Error");
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
