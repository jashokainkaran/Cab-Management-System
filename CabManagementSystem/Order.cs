using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabManagementSystem
{
    internal class Order
    {
        private int orderId;
        private Customer customer;
        private Driver driver;
        private DateTime? date;

        public int OrderId 
        {
            get;
            internal set; 
        }

        public Customer Customer
        {
            get { return customer; } 
            set { customer = value; } 
        }

        public Driver Driver
        {
            get { return driver; }
            set { driver = value; }
        }

        public DateTime? Date
        { 
            get { return date; } 
            set { date = value; } 
        }

        public Order(Customer customer, Driver driver, DateTime date) 
        {
            this.customer = customer;
            this.driver = driver;
            this.date = date;
        }
    }
}
