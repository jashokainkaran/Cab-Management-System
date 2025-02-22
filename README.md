🚖 Cab Management System 🚖
A simple and efficient way to manage your cab services!

Welcome to the Cab Management System, where we make booking rides smoother than a freshly waxed cab! Whether you’re a driver or a manager, this system is designed to make your life easier. Let’s get rolling! 🏎️💨

🚀 Getting Started
1️⃣ Clone the Repo
Ready to hit the road? First, grab the code! Open your terminal and run:

git clone https://github.com/jashokainkaran/Cab-Management-System.git

Navigate into the folder:

cd your-repo

2️⃣ Open the Project
Open the solution file in Visual Studio:

Double-click on the CabManagementSystem.sln file (or use File > Open > Project/Solution in Visual Studio).

3️⃣ Restore Dependencies
Your cab management system might have a few dependencies. Don’t worry; Visual Studio has you covered! If prompted, click Restore NuGet Packages. You can also do it manually by right-clicking the solution in Solution Explorer and selecting Restore NuGet Packages.

4️⃣ Setting Up the MySQL Database
Our cab management system comes with a MySQL database to store all your ride information. Here’s how to get it set up:

Create a New Database:

Open phpMyAdmin (or your preferred MySQL client).
Create a new database (e.g., CabManagementDB).
Run the SQL Script:

Find the database_setup.sql file in the project folder.
Open it in MySQL Workbench and run the script to set up the necessary tables and data.
5️⃣ Configure Connection String
You might need to tweak the connection string in your application. Open the appsettings.json file and adjust the connection string to point to your newly created MySQL database:

json
Copy
Edit
"ConnectionStrings": {
  "DefaultConnection": "Server=your_server_name;Database=CabManagementDB;User ID=your_username;Password=your_password;"
}
6️⃣ Run the Project
Now you’re ready to roll! Press F5 or click the Start button in Visual Studio to run the application. 🚦

🎯 Troubleshooting
❓ Something went wrong?

Make sure your MySQL Server is running and the connection string is correctly configured.
Check the Output Window in Visual Studio for any error messages.
🏆 Contributing
Want to add new features or improve existing ones? Fork the repo, make your changes, and send a pull request! Just remember to keep it fun and fabulous! 🎉

🤝 Credits
Built with love ❤️ in C# and MySQL. Special thanks to all the cab drivers keeping our rides smooth!
