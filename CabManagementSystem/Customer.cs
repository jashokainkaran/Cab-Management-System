using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabManagementSystem
{
    internal class Customer
    {
        private string name;
        private string contactNumber;
        private string currentLocation;
        private string destination;

        public int CustomerId 
        {
            get;
            internal set; 
        }
        public string Password
        {
            get;
            internal set;
        }
        public string Name
        {   get { return name; } 
            set { name = value; } 
        }

        public string ContactNumber
        {
            get { return contactNumber; }
            set { contactNumber = value; }
        }

        public string CurrentLocation
        {
            get { return currentLocation; }
            set { currentLocation = value; }
        }

        public string Destination
        { 
            get { return destination; }
            set { destination = value; }
        }

        public Customer(string name, string contactNumber, string currentLocation, string destination, string password)
        {
            this.name = name;
            this.contactNumber = contactNumber;
            this.currentLocation = currentLocation;
            this.destination = destination;
            this.Password = password;
        }



    }
}
