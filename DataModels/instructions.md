Add Data Models
To keep things organized, folders are created to store the C# files that represent models and data handlers. Models are C# classes that define entity structure. Each class usually maps directly to a database table. Some types of databases (called no-SQL) do not have tables per se. That is why we refer to the model class as an entity and not specifically a table. All the models will go in the Models folder.

The models are simple C# classes with the name representing an entity. Think of this as a spreadsheet with tables that have columns with header names and rows with data. Each sheet is an entity. Each column in the sheet has a name. The property names in the model class are the same as the spreadsheet column names. They represent the schema. One difference is that each property must have a data type. That is a basic premise of the strongly typed C# approach. Each property has a getter and setter which means it can be written to and read from. An example model class would look like this:

public class Student
{
   public string ID { get; set; }
   public string Name { get; set; }
}
Instructions
1.
A folder called Models already exists. Edit the file called Continent.cs in the Models folder. Add the namespace for our project. This would be the project name, RazorCountry, followed by the folder path.


Stuck? Get a hint
2.
Define a public class with the name Continent. This goes inside the namespace.


Stuck? Get a hint
3.
Define public string fields for ID and Name. Don’t forget the getter and setter.


Stuck? Get a hint
4.
A folder called Models already exists. Edit the file called Country.cs in the Models folder. Add a using statement that supports System data types.


Stuck? Get a hint
5.
Add the namespace for our project. This is the same as you did for Continent.cs.


Stuck? Get a hint
6.
Define a public class named Country. This goes inside the namespace.


Stuck? Get a hint
7.
Add six public fields inside the class definition:

ID, ContinentID, and Name are strings.
Population and Area are nullable ints.
UnitedNationsDate is a nullable date.
Make a type nullable by adding a question mark. For example, bool? is a nullable boolean.