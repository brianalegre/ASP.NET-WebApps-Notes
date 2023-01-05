Code Delete in the Index Page Model
Deleting a row in the database is handled by the EF Remove() method. This takes a row object as the parameter so we need to know which row to remove and somehow need to load that row.

We can find the row using the built-in EF method FindAsync() which takes the row ID as a parameter and returns a single row. For example, this code finds the country with ID 001 and removes it from the database:

Country country = await _context.Countries.FindAsync(001);
_context.Remove(country);
The ID must be passed in the <form> postback. This is triggered by a submit button in an <a> tag. A hidden <input> tag can be used to store the ID in the browser until the user clicks Delete and does the <form> postback.

All EF changes are only in memory until the SaveChangesAsync() method is called, which persists changes to the database file. Here’s the same code as above, with SaveChangesAsync() added to ensure the changes are persisted:

Country country = await _context.Countries.FindAsync(001);
_context.Remove(country);
await _context.SaveChangesAsync();
Once all this is done, the Index page needs to refresh and call OnGetAsync() which will load all the rows in the table and display them in the loop. This provides visual confirmation that the deletion was a success.

Instructions
1.
In Pages/Contintents/Index.cshtml.cs, create a public, asynchronous OnPostAsync() method. It should:

Have string parameter named id
Return an object of type Task<IActionResult>
if the parameter is null, return a NotFound() action result
Otherwise, return a RedirectToPage() result that redirects to the "./Index" page
The final return statement makes the page reload, which triggers the OnGetAsync() method, which reloads the Continents list that will no longer include the deleted row.


Stuck? Get a hint
2.
In OnPostAsync(), after the if check and before the RedirectToPage() expression, retrieve a single row from the Continents DbSet.

Pass the id parameter to the FindAsync() method, which is part of the EF context and makes it easy to get a row given the unique ID.


Stuck? Get a hint
3.
if the returned row is not null, use it as an argument to the EF Remove() method. This flags the row as deleted in the in-memory DbSet.


Stuck? Get a hint
4.
Finally, call SaveChangesAsync() to really remove the row from the database table.