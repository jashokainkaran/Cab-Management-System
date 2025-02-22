using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabManagementSystem
{
    internal class Car
    {
        private int carId;
        private string model;
        private string plateNumber;
        private bool availability;

        public int CarId
        {

            get { return carId; }
            set { carId = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string PlateNumber
        {
            get { return plateNumber; }
            set { plateNumber = value; }
        }

        public bool Availability
        {
            get { return availability; }
            set { availability = value; }
        }

        //Constructor
        public Car(int carId, string model, string plateNumber, bool availability)
        {
            this.carId = carId;
            this.model = model;
            this.plateNumber = plateNumber;
            this.availability = availability;
        }

        public override string ToString() 
        {
            return $"ID: {carId} Model: {Model}";
        }
    }
}
    

