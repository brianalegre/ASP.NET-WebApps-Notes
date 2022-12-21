Build a Project from a Template
Larger ASP.NET projects often work with data stored in a database. A database is a program that allows data to be easily accessed, manipulated, and updated. The database can persist data in memory or on disk and is managed by a service that runs on a server or in the cloud. Our goal is to attach a database to an ASP.NET web site and store some data in row and column format.

An ASP.NET Core starter site is needed to demonstrate this concept. The .NET Core command line utility dotnet can create a new project and build all the files necessary to get us up and running. The checkpoints below walk you through the starter site and explain the folder and file structure. Every one of these items will be used in some way as we develop a complete database connected solution.

There is a basic sequence of tasks required to create the database and a set of pages necessary to Create, Read, Update, and Delete data items (often referred to by the acronym CRUD). All the tasks are managed by C# code in a set of NuGet packages. The following exercises demonstrate these tasks.

Not all ASP.NET sites need database management so this feature is added separately. Our sample uses an open source database called SQLite and the Microsoft open source Entity Framework tools (often called EF). EF is a Microsoft data framework that uses C# classes and methods to represent data entities. There are many alternative frameworks including micro-ORMs (Object Relational Mapping) like Dapper, NHibernate, and SQLAlchemy.

Our sample site will store the names of continents and countries so it will be called RazorCountry.

Instructions
1.
Use the dotnet command to create a new project in the current directory with the namespace RazorCountry:

dotnet new webapp -o . -n RazorCountry