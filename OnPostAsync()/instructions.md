OnGetAsync()
An asynchronous operation is one that allows the computer to “move on” to other tasks while waiting for the asynchronous operation to complete. Asynchronous programming means that time-consuming operations don’t have to bring everything else in our programs to a halt.

There are countless examples of asynchronicity in our everyday lives. Cooking, for example, involves asynchronous operations such as a toaster toasting our bread or a rice cooker making our rice. While we wait on the completion of those operations, we’re free to do other tasks.

Similarly, web development makes use of asynchronous operations. Operations like making a network request or querying a database are done asynchronously so that we can work on other tasks.

C# enables this using async, await, and the Task type.

For example, this code uses an asynchronous operation, ReadLineAsync(), to read from the file storage.txt. We use the keyword await to tell our app to “wait” for that operation to complete:

if (System.IO.File.Exists("storage.txt"))
{
  using (StreamReader reader = System.IO.File.OpenText("storage.txt"))
  {
    string content = await reader.ReadtoEndAsync();
  }
}
To do this within a request handler like OnGet(), we have to label it as an asynchronous method using async, switch the return type to Task, and rename it OnGetAsync():

public async Task OnGetAsync()
{
  if (System.IO.File.Exists("storage.txt"))
  {
    using (StreamReader reader = System.IO.File.OpenText("storage.txt"))
    {
      string content = await reader.ReadtoEndAsync();
    }
  }
}
The last step — renaming it to OnGetAsync() — is optional but conventional.

In summary, if you are performing some asynchronous task within your GET handler method:

Add async to the signature
Change the return type to Task
Rename the method to OnGetAsync()
You cannot have both OnGet() and OnGetAsync(). Use one or the other.

By the way, our code used using, which we won’t require you to learn, but if you’re interested, read this Microsoft article on using.

Instructions
1.
In Index.cshtml.cs, the app isn’t working because we are trying to do an asynchronous action within a synchronous method (OnGet()).

Run the code to see the error.


Stuck? Get a hint
2.
Fix the code by adding an async prefix, changing the return type to Task, and renaming the method to OnGetAsync().