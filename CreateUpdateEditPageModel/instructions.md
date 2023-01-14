Code Create and Update in the Edit Page Model
The edit page in our example has two roles: edit and create. For edit, it displays most or all fields from the current record and allows the user to edit fields in <input> tags. The column names are placed in <label> tags. The ID of the desired record arrives in the URL as a query parameter or URL segment. This ID automatically becomes part of the page model. The OnGetAsync() method accepts the ID as a parameter, makes sure it is not null, and retrieves the matching record with the EF context FindAsync() method. The record is passed to a public member which is referenced in the HTML markup. Since the record can be changed by the user, the [BindProperty] annotation is applied to the member so it can return to the server on <form> post back.

The create mode is similar but uses an empty record as a starting point. Our OnGetAsync() method must check for a value in ID. If it is null, then a new empty member record is created. If it has a value, then FindAsync() is used to retrieve the current row. When the user clicks the Save button, the <form> posts back with a copy of all <input> tag values. The OnPostAsync() again checks for an ID, If it is null, we call the EF method Add(). If the ID has a value, we call Attach() with a chained State value set to Modified. In either case, SaveChangesAsync() must be called to persist the record to the database.

Note that OnPostAsync() returns a Task of IActionResult. This is an ASP.NET trick for redirection. In simpler terms, once the record is saved, we display the Index page with our new or modified record.

Instructions
1.
Open the file Pages/Continents/Edit.cshtml.cs and add these namespaces:

Microsoft.EntityFrameworkCore
RazorCountry.Models
RazorCountry.Data

Stuck? Get a hint
2.
Add the Entity Framework context and inject into the class constructor.


Stuck? Get a hint
3.
Add code for retrieval of a single record. You can also copy this from Pages/Continents/Detail.cshtml.cs. A simple change is needed to make the page support both Create and Edit mode. Check for the existence of an id passed in the URL. If none exists, we need an empty Continent for the create. The [BindProperty] annotation is needed in this case to allow the data row to pass to the browser and return back when the form is posted.


Stuck? Get a hint
4.
Add a method that mimics what we did on the Detail page. The only difference is the check for an empty id. In that case, return a new empty Continent object.


Stuck? Get a hint
5.
When the user clicks Save and posts back a new or updated row, the OnPostAsync() method is triggered. Add that method syntax.


Stuck? Get a hint
6.
Always check for a valid model before applying changes (more on this in the upcoming validation exercise).

If ModelState.IsValid is false, return the current Page().


Stuck? Get a hint
7.
Again, we must check for the existence of an id value. This determines whether we Add() or Attach() the Continent row.


Stuck? Get a hint
8.
Once the row is added or attached, it must be saved to the database with SaveChangesAsync().


Stuck? Get a hint
9.
The final step is to return a Task object that loads the Index page so we can see the changes in the Continent list.