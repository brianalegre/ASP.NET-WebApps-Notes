Add the Database Connection String
The connection string is the link from the C# code to the physical database. The context must know where the database is located and how to authenticate to the database service. That information is usually stored in a string specific to an environment (development, testing, staging, or production). Each type of database service has a specific format for the connection string. ASP.NET provides a handy place to store strings like this. It is the file called appsettings.json. By convention the connection string will have the same name as the context class. We will make and explain the context class in an upcoming exercise.

Instructions
1.
In appsettings.json, add a connection string that defines the database name.

The string is placed after "AllowedHosts": "*" so you need a comma separator. Call the JSON property ConnectionStrings. This is a JSON object so it needs opening and closing {}. Inside the {}, create a property called CountryContext and set the value to Data Source=Country.db.