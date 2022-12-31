Wire EF Context to Project
A web site might have many services that perform different functions for any number of pages. ASP.NET uses a technique called dependency injection to expose these middle-men services to each page as needed. We will add our newly created EF context (a C# class) so it can be injected into all the pages that need it.

Instructions
1.
Edit Startup.cs. This is where the services are created so they can be injected into pages. Start with additional using statements that add EF specific code and the ability to inject services for these namespaces:

Microsoft.EntityFrameworkCore
RazorCountry.Data

Stuck? Get a hint
2.
Within ConfigureServices(), add the database context service, by placing this code below the line services.AddRazorPages():

services.AddDbContext<CountryContext>(options => options.UseSqlite(Configuration.GetConnectionString("CountryContext")));
This code adds an instance of the context class (CountryContext) to the injectable services object.

Note that this relies on the connection string configuration setting in appsettings.json.


Stuck? Get a hint
3.
Edit Program.cs. This is the starting point for our site. We need to have it check for an existing database. If it does not find one, then create it. Add a using statement to help with dependency injection and another that enables the context class:

Microsoft.Extensions.DependencyInjection
RazorCountry.Data

Stuck? Get a hint
4.
Create a private static CreateDbIfNotExists() method under the Main() method. It should:

Return nothing

Have one parameter host of type IHost

Have a using block with a scope variable of type var set to host.Services.CreateScope(). As an example, this using block has an x variable set to rand.Next():

using (var x = rand.Next())
{
}
The using block should contain the following lines:

var services = scope.ServiceProvider;
var context = services.GetRequiredService<CountryContext>();
context.Database.EnsureCreated();
The EnsureCreated() method calls the OnModelCreating() method of the context created in a previous exercise.


Stuck? Get a hint
5.
Change the Main() method to check if the database should be created. This will run each time the site starts. Start by breaking apart the chain of methods on CreateHostBuilder().

Store the result of Build() in a variable host
Call CreateDbIfNotExists() and pass in host
Call Run() on host
When you run the site and inspect the Files directory to see the newly created Country.db database file.