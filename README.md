# Hair Salon Management System

#### By Elijah Shawn Cartwright

## Technologies Used:

* HTML
* CSS
* JavaScript
* C#
* ASP.NET Core
* Entity Framework Core
* MySQL Database
* Visual Studio Code
* Git

## Description:

The Hair Salon Management System is a web application designed to help salon owners manage their stylists and clients effectively. The application allows salon owners to add, view, edit, and delete stylists, as well as their associated clients. Each stylist can have a specialty, and each client can have a name, phone number, and email. The system provides an organized and efficient way for salon owners to keep track of their stylists and clients, making it easier to manage appointments and services.

## Setup and Installation Guide:

1. Clone the repository to your local machine using the following command:
git clone [repository_url]

2. Navigate to the project directory:
cd HairSalon

3. Create the appsettings.json file and update it with your MySQL connection string:
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;Database=hair_salon_db;Uid=root;Pwd=your_password;"
  }
}

4. Ensure you have the .NET 6 SDK installed on your machine.

5. Restore the project dependencies by running the following command:
dotnet restore

6. Apply the database migrations:
dotnet ef database update

7. Start the application by running the following command:
dotnet watch run

8. Access the application in your web browser at:
https://localhost:5001

Known Issues:
* Depending on envrinment - Details for clients may or may not work - furthermore may not show clients names at times.

License:

MIT License<
Copyright © Elijah Shawn Cartwright 2023