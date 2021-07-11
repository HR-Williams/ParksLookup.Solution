<div align="center">

# Parks Lookup API
</div>

<h3 align="center">An API for state and National Parks, 7-10-2021</h3>
<h4 align="center"> By HR Williams</h4>

## Description

This is an independet project for Epicodus to demonstrate new skills in Building an API in C#/.NET. This API allows a user to view Park data and allows users to add, edit and delete Parks.
## Setup/Installation Requirements

##### Software Requirements

1. Internet browser
2. A code editor such as VSCode to view and edit the code
3. .NET or follow along with the Installing .NET instructions to install .NET

##### Open Locally

- Open your terminal and use the command `git clone https://github.com/HR-Williams/ParksLookup.Solution` into the directory you would like to clone the repository

##### Installing .NET

In order to run the application, please install .NET for your computer to recognize the `dotnet` command.

1. Download [.NET Core SDK (Software Development Kit)](https://dotnet.microsoft.com/download/dotnet). Clicking this link will prompt a file download for your particular OS from Microsoft.
2. Open the file. Follow the installation steps.
3. Confirm the installation is successful by opening your terminal and running the command `dotnet --version`. The response should be something similar to this:`5.0.100`. This means it was successfully installed.

##### Installing MySQL

MySQL is a type of database software used to create, edit, query, and manage SQL data.

- For Mac Users please [Click Here](https://dev.mysql.com/downloads/file/?id=484914) to download MySQL Installer
- For Windows Users please [Click Here](https://dev.mysql.com/downloads/file/?id=484919)

- Verify MySQL installation by opening the terminal and entering the command `mysql -uroot -p[THEPASSWORDYOUSELECTED]`
- If you gain access you will see see the MYSQL command line!

##### Installing MySQL Workbench

- Please [Click Here](https://dev.mysql.com/downloads/workbench/) to install the correct version for your machine
- Open MySQL Workbench and select `Local instance 3306 server`. You will need to enter the password you selected

##### Compiling

- Navigate to the `ParksLookup` folder in the command line
- Use the command `dotnet build` to compile

##### Installing Packages

- Navigate to the `ParksLookup` folder in the command line
- Use the command `dotnet restore`

<details>

  <summary>Expand for Database Installation Essentials!</summary>

### Database Connection

Create a connection string to connect the database to the web application

1. Create a file in the root directory called `appsettings.json`
2. Add the code below:

```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[your_database_name_here];uid=root;pwd=[YOUR-PASSWORD-HERE];"
  }
}
```

- Update all the information above in the square brackets. Put in your MySQL password in `pwd=YourPassword`. If you named the database the same name as the .sql file that was imported, then `database =` should be `parks_lookup`. Change the server, port, and uid if necessary.

### Import/Update Database Using Entity Framework Core

- Navigate to `ParksLookup` directory in terminal
- To create a migration in the root directory of the project, use the command: `dotnet ef migrations add Initial`
- Use the command `dotnet ef database update` to update the database migration through Entity Framework Core


### Update Database Using MySQL Workbench

1. Open MySQL Workbench
2. Click on Server > Data Import in the top navigation bar
3. Select `Import from Self-Contained File`
4. Select the `Default Target Schema` or create new schema
5. Select all Schema Objects you would like to import
6. Select `Dump Structure and Data`
7. Click `Start Import`

</details>

##### Swagger
This project utilizes swagger documentation. To view the documentation while the API is running locally open your browser to `http://localhost:5000/swagger/`
To run the API locally:
1. In your terminal navigate to the ParksLookup folder
2. run dotnet run
Then to view the swagger documentation open http://localhost:5000/swagger/
![Swagger documentation](/images/swagger.png)

## Known Bugs

I would like to change the schema and and more parameters to the get route to make for more user friendly queries.

## Support and Contact Details

If any errors or bugs occur with installation, delete both bin and obj folders and follow the Compiling and Installing Packages instructions again. Get help or report a bug you have found in the .NET platform at [.NET Support](https://dotnet.microsoft.com/platform/support).

## Technologies Used

- .NET Core 5.0.1
- ASP.NET Core MVC
- ASP.NET Core Razor Pages
- Entity Framework Core
- GitHub
- MySQL
- MySQL Workbench
- VS Code
- Swagger/Swashbuckle

### License

This software is licensed under the [MIT License](https://choosealicense.com/licenses/mit/).

Copyright (c) 2021 HR Williams