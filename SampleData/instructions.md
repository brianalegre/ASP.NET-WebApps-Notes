Add Sample Data
It is useful to have repeatable data for test driven development. This can happen through a series of commands in a C# class. The class file is a bit large so we will provide it to you. This class uses basic methods from the database context to Add() new records and SaveChanges(). It also uses the LINQ statement Any() to see if any records currently exist.

The file Data/DbInitializer.cs is open. The using statements reference our model classes and System.Linq. We will learn a lot more about the use of LINQ with a database context in an upcoming lesson.

Line 11 calls the context EnsureCreated() method to make sure the database file exists. We used this in an earlier exercise to force creation of the database. This new class will now replace that line in Program.cs.

Line 14 uses LINQ to check for the existence of any Continents. If they exist, the sample data does not need creation so the method ends (return statement).

The next two sections create arrays of Continent and Country objects. The context then uses Add() to include them in the DbSet for the associated List. The final step is to SaveChanges() which persists the new data items into the database file.

You are welcome to add any other Continents or Countries at this time. Make up the numbers and dates, you will be able to edit these later when we create an Edit page.

Once you are satisfied with this file, we can add it to Program.cs so that it is called before the app is run.

Instructions
1.
Instead of using the built-in EnsureCreated() method, we’ll use the new DbInitializer class. Its Initialize() method also calls EnsureCreated(), then it adds some sample data to the database.

Edit the Program.cs file to call DbInitializer.Initialize(context) instead of EnsureCreated(). We can comment that line so it does not execute.