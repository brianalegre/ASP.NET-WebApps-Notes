ViewData
ViewData allows us to pass information from the page model into the view page. ViewData is of type ViewDataDictionary, which acts as a generic dictionary. What exactly is a dictionary in C#? Well, you can think of a dictionary in the same way as you would think of an English dictionary: a collection of words and their definitions. In a similar fashion, a Dictionary in C# is a collection of keys and values, where the key is typically a string and the value is its definition. For more information please refer to the following documentation.

We can add key/value pairs to our ViewData in the PageModel as so:

public class IndexModel : PageModel
{
  public void OnGet()
  {
    ViewData["MyDogsName"] = "Alfie";
    ViewData["MyDogsAge"] = 7;
  }
}
ViewData is accessible in the view page and we can refer to the values stored in them by calling the key names:

@page
@model RazorTest.Pages.ExampleModel
<div>
  <p>My dog @ViewData["MyDogsName"] is @ViewData["MyDogsAge"] years old</p>
...
</div>
This might look similar to the way you would access properties in the class from the page model, however, ViewData becomes very useful when we’re working with layout pages or partials which we’ll cover in the following exercise.

Instructions
1.
Let’s take a look at Profile.cshtml.cs. There’s currently an empty OnGet() method. Let’s add certain information for a user’s profile.

Add a key/value pair to ViewData for each of the following:

myName: a string containing your full name.
username: A string containing your personal username (can be as simple as your first name).
myOccupation: Your occupation or study.
myAge: Your age.
currentDate: A string with today’s date in the following format: “MM/DD/YY”.

Stuck? Get a hint
2.
In Profile.cshtml there are commented lines for you to fill out. Go ahead and access each of the properties in ViewData and fill out the blanks!