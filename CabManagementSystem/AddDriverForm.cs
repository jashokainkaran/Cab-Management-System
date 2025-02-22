using Org.BouncyCastle.Asn1.X509;
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
    public partial class AddDriverForm : Form
    {
        internal Admin admin;
        internal Driver NewDriver { get; set; }
        
        public AddDriverForm()
        {
            InitializeComponent();
            this.admin = new Admin();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int driverID = Convert.ToInt32(driverId.Text);
                string name = driverName.Text;
                string number = contactNumber.Text;
                bool availability = available.Checked;

                //Creating a new car using the constructor
                NewDriver = new Driver(driverID, name, number, availability);

                //Adding the new car to the list in admin class
                admin.AddDriver(NewDriver);

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
