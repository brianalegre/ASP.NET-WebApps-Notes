OnPostAsync()
Just as OnGet() has an asynchronous version, OnGetAsync(), OnPost() has its own asynchronous version named OnPostAsync().

The same async/await / Task concepts apply to this method:

Mark the method with async
Define the return type as Task
Rename it OnPostAsync()
Instructions
1.
In Index.cshtml.cs, define an empty OnPostAsync() method.


Stuck? Get a hint
2.
In the body of the method, use the below code to asynchronously write to a text file:

using (StreamWriter writer = new StreamWriter("log.txt", append: true))
{
  await writer.WriteLineAsync($"OnPostAsync() called at {DateTime.Now}.");
}