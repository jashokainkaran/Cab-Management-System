using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabManagementSystem
{
    internal class Driver
    {
        private int driverId;
        private string driverName;
        private string contactNumber;
        private bool availability;

        public int DriverId 
        {  
            get { return driverId; } 
            set { driverId = value; }
        }

        public string DriverName
        {
            get { return driverName; }
            set { driverName = value; }
        }

        public string ContactNumber
        {
            get { return contactNumber; }
            set { contactNumber = value; }
        }

        public bool Availability
        {
            get { return availability; }
            set { availability = value; }
        }

        public Driver(int driverId, string driverName, string contactNumber, bool availability)
        {
            DriverId = driverId;
            DriverName = driverName;
            ContactNumber = contactNumber;
            Availability = availability;
        }

        public override string ToString() 
        {
            return $"ID: {DriverId} Name: {DriverName}";
        }
    }
}
