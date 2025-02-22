using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabManagementSystem
{
    internal class Admin
    {
        private static int loggedCustomerId;
        public static int LoggedCustomerId 
        {
            get { return loggedCustomerId; } 
            set { loggedCustomerId = value; }
        }

        //Database connection
        private string connectionString = "server=127.0.0.1;user=root;database=cab_management_system;port=3306;password=;";

        //Creating lists for each class
        private List<Car> cars { get; set; } = new List<Car>();
        private List<Customer> customers { get; set; } = new List<Customer>();
        private List<Order> orders { get; set; } = new List<Order>();
        private List<Driver> drivers { get; set; } = new List<Driver>();


        //Add cars 
        public void AddCar(Car car)
        {
            cars.Add(car);

            //Inserting into the database
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO cars (id, model, plate_number, availability) VALUES (@CarId, @Model, @PlateNumber, @Availability)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@CarId", car.CarId);
                command.Parameters.AddWithValue("@Model", car.Model);
                command.Parameters.AddWithValue("@PlateNumber", car.PlateNumber);
                command.Parameters.AddWithValue("@Availability", car.Availability);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Car Added Succesfully");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"MySQL Exception: {ex.Message}");
                }
            }
        }
        //Adding Customers
        public void AddCustomer(Customer customer) 
        { 
            customers.Add(customer);
            //Inserting into the database
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO customers (name, contact_number, current_location, destination, password) VALUES (@Name, @ContactNumber, @CurrentLocation, @Destination, @Password)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", customer.Name);
                command.Parameters.AddWithValue("@ContactNumber", customer.ContactNumber);
                command.Parameters.AddWithValue("@CurrentLocation", customer.CurrentLocation);
                command.Parameters.AddWithValue("@Destination", customer.Destination);
                command.Parameters.AddWithValue("@Password", customer.Password);


                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Customer Added Succesfully");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"MySQL Exception: {ex.Message}");
                }
            }
        }

        //Add orders
        public void AddOrder(Order order, Car selectedCar)
        {
            orders.Add(order);
            order.Driver.Availability = false;
            selectedCar.Availability = false;

            // Updates the car availability in database
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string carQuery = "UPDATE cars SET availability = false WHERE id = @CarId";
                string driverQuery = "UPDATE drivers SET availability = false where id = @DriverId";
                string orderQuery = "INSERT INTO orders (customer_id, driver_id, date) VALUES (@CustomerId, @DriverId, @Date)";
                
                MySqlCommand carCommand = new MySqlCommand(carQuery, connection);
                MySqlCommand driverCommand = new MySqlCommand(driverQuery, connection);
                MySqlCommand orderCommand = new MySqlCommand(orderQuery, connection);

                //Parameters for the car command
                carCommand.Parameters.AddWithValue("@CarId", selectedCar.CarId);

                //Parameters for the driver command
                driverCommand.Parameters.AddWithValue("@DriverId", order.Driver.DriverId);

                //Parameters for order command
                orderCommand.Parameters.AddWithValue("@CustomerId", order.Customer.CustomerId);
                orderCommand.Parameters.AddWithValue("DriverId", order.Driver.DriverId);
                orderCommand.Parameters.AddWithValue("@Date", order.Date);

                try
                {
                    connection.Open();
                    carCommand.ExecuteNonQuery();
                    driverCommand.ExecuteNonQuery();
                    orderCommand.ExecuteNonQuery();

                    MessageBox.Show("Order placed successfully and availability updated");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"MySQL Exception: {ex.Message}");
                }
            }


        }

        //Adding driver to the database
        public void AddDriver(Driver driver)
        {

        drivers.Add(driver);

            //Inserting into the database
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO drivers (id, name, contact_number, availability) VALUES (@DriverId, @Name, @ContactNumber, @Availability)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@DriverId", driver.DriverId);
                command.Parameters.AddWithValue("@Name", driver.DriverName);
                command.Parameters.AddWithValue("@ContactNumber", driver.ContactNumber);
                command.Parameters.AddWithValue("@Availability", driver.Availability);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Driver Added Succesfully");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"MySQL Exception: {ex.Message}");
                }
            }
        }

        //FInding items by id
        public Car FindCarById(int carId)
        {
            Car carToFind = cars.Find(car => car.CarId == carId);
            return carToFind;
        }

        public Driver FindDriverById(int driverId)
        {
            Driver driverToFind = drivers.Find(driver => driver.DriverId == driverId);
            return driverToFind;
        }

        public Customer FindCustomerById(int customerId)
        {
            Customer customerToFind = customers.Find(customer => customer.CustomerId == customerId);
            return customerToFind;
        }

        public Order FindOrderById(int orderId)
        {
            Order orderToFind = orders.Find(order => order.OrderId == orderId);
            return orderToFind;
        }



        //Removing Cars
        public bool RemoveCar(int carId)
        {
            Car carToRemove = FindCarById(carId);

            if (carToRemove != null)
            {
                cars.Remove(carToRemove);

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "DELETE FROM cars WHERE id = @CarId";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CarId", carId);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show($"MySQL Exception: {ex.Message}");
                        return false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Car not found.");
            }
            return false;
        }



        //Removing Drivers
        public bool RemoveDriver(int driverId)
        {
            Driver driverToRemove = FindDriverById(driverId);
            if (driverToRemove != null)
            {
                drivers.Remove(driverToRemove);

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "DELETE FROM drivers WHERE id = @DriverId";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@DriverId", driverId);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show($"MySQL Exception: {ex.Message}");
                        return false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Driver not found.");
            }
            return false;
        }
        

        //Removing Customers
        public bool RemoveCustomer(int customerId)
        {
            Customer customerToRemove = FindCustomerById(customerId);
            if (customerToRemove != null)
            {
                customers.Remove(customerToRemove);
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "DELETE FROM customers WHERE id = @CustomerId";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CustomerId", customerId);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show($"MySQL Exception: {ex.Message}");
                        return false;
                    }
                }
            }
            return false;
        }

        //Removing orders
        public bool RemoveOrder(int orderId)
        {
            Order orderToRemove = FindOrderById(orderId);
            if (orderToRemove != null)
            {
                orders.Remove(orderToRemove);
                return true;
            }
            return false;
        }



        //Getting details of a specific car
        public string GetDetails(int carId)
        {
            Car carInfo = FindCarById(carId);
            if (carInfo != null)
            {
                return $"Car ID: {carInfo.CarId}, Model: {carInfo.Model}, Plate Number: {carInfo.PlateNumber}, Available: {carInfo.Availability}";
            }
            return $"Car with ID {carId} not found.";
        }


        //Gets the details from the database
        internal Admin()
        {
            // Load information from the database into the in-memory list
            cars = GetAllCars();
            drivers = GetAllDrivers();
            customers = GetAllCustomers();
            
        }

        public List<Car> GetAllCars()
        {
            List<Car> cars = new List<Car>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM cars";
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int carId = reader.GetInt32("id");
                            string model = reader.GetString("model");
                            string plateNumber = reader.GetString("plate_number");
                            bool availability = reader.GetBoolean("availability");

                            Car car = new Car(carId, model, plateNumber, availability);
                            cars.Add(car);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"MySQL Exception: {ex.Message}");
                }
            }

            return cars;
        }

        //Gets the details of the drivers from the database
        public List<Driver> GetAllDrivers()
        {
            List<Driver> drivers = new List<Driver>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM drivers";
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int driverId = reader.GetInt32("id");
                            string driverName = reader.GetString("name");
                            string contactNumber = reader.GetString("contact_number");
                            bool availability = reader.GetBoolean("availability");

                            Driver driver = new Driver(driverId, driverName, contactNumber, availability);
                            drivers.Add(driver);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"MySQL Exception: {ex.Message}");
                }
            }

            return drivers;
        }

        //Gets the details of the customers from the database
        public List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM customers";
                MySqlCommand command = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int customerId = reader.GetInt32("id");
                            string customerName = reader.GetString("name");
                            string contactNumber = reader.GetString("contact_number");
                            string currentLocation = reader.GetString("current_location");
                            string destination = reader.GetString("destination");
                            string password = reader.GetString("password");

                            Customer customer = new Customer(customerName, contactNumber, currentLocation, destination, password);
                            //Gets the id from the tabel and assigns it to the customer before adding to the list
                            customer.CustomerId= customerId;
                            customers.Add(customer);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"MySQL Exception: {ex.Message}");
                }
            }

            return customers;
        }


        //New Customer Registartion
        public void RegisterCustomer(Customer customer)
        {

            customers.Add(customer);
            //Inserting into the database
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO customers (name, contact_number, current_location, destination, password) VALUES (@Name, @ContactNumber, @CurrentLocation, @Destination, @Password)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", customer.Name);
                command.Parameters.AddWithValue("@ContactNumber", customer.ContactNumber);
                command.Parameters.AddWithValue("@CurrentLocation", customer.CurrentLocation);
                command.Parameters.AddWithValue("@Destination", customer.Destination);
                command.Parameters.AddWithValue("@Password", customer.Password);


                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Registered Successfully");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"MySQL Exception: {ex.Message}");
                }
            }
        }

        public bool LoginCustomer(string name, string password)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM customers WHERE name = @Name";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);

                try
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedPassword = reader.GetString("password");
                            if (storedPassword == password)
                            {

                                loggedCustomerId = reader.GetInt32("id");
                                MessageBox.Show("Login Successful");
                                return true;
                            }
                            else
                            {
                                MessageBox.Show("Invalid Credentials");
                            }
                        }
                        else
                        {
                            MessageBox.Show("User not found");
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"MySQL Exception: {ex.Message}");
                }
            }
            return false;
        }



        //Get available cars
        public List<Car> GetAvailableCars()
        {
            return cars.FindAll(car => car.Availability);
        }

        //Get available drivers
        public List<Driver> GetAvailableDrivers()
        {
            return drivers.FindAll(driver => driver.Availability);
        }

        //Logging out
        public static void Logout(Form currentForm)
        {
            // Close the current form
            currentForm.Close();

            // Open the login form
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}

