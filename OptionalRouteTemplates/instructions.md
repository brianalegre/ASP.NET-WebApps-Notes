Add Optional Route Templates
We can make route values optional with a question mark ?.

For example, this defines an optional title template:

@page "{title?}"
In order to capture that in a method parameter, you’ll need to also use the question mark there:

public void OnGet(string? title) { }
When combining with an if - else statement, your handler method can change behavior based on whether the value was provided:

public void OnGet(string? title)
{
  if (String.IsNullOrEmpty(title))
  {
    IsGeneralDisplay = true;
  }
  else
  {
    Title = title.Value;
    IsGeneralDisplay = false;
  }
}
In the if condition, we use String.IsNullOrEmpty() to check the value of title. It returns true if the title is not provided in the URL or it is empty (""). For non-string types, we use the HasValue property. For example:

public void OnPost(bool? b)
{
  if (b.HasValue)
  {
    // Access b.Value
  }
  else
  {
    // b is null
  }
}
You can read more about nullable types in the Microsoft documentation.

Instructions
1.
In Activity.cshtml, the current @page directive specifies a required route value. If you navigate to a URL without one, like localhost:8000/Days, the app returns an error.

Add a question mark to the route value to make it optional.


Stuck? Get a hint
2.
In Activity.cshtml.cs in OnGet(), add a question mark to the method parameter’s type. This makes it optional, or nullable.

(If you do this correctly you’ll get an error CS0266. We’ll fix that next.)


Stuck? Get a hint
3.
Within the method, we need to adjust our code to handle the new parameter type.

Set CurrentDay to day.Value.

This converts the nullable int? type to int.


Stuck? Get a hint
4.
Within the method, create an if statement that is executed if day is not null.

Move all of the method’s existing code into that if block.


Stuck? Get a hint
5.
Add an else statement below that will be used when a route value is not provided. Add this code within the else block:

CurrentDay = 0;
IsWeeklyDisplay = true;
DisplaySteps = Days.Sum(d => d.Steps);
DisplayMinutesExercise = Days.Sum(d => d.MinutesExercise);
PercentProgressSteps = PercentProgress(DisplaySteps, idealSteps * Days.Count);
PercentProgressMinutesExercise = PercentProgress(DisplayMinutesExercise, idealMinutesExercise * Days.Count);
You should see that navigating to localhost:8000/Days gives you the weekly total and localhost:8000/Days/0 gives you specific exercise information for day 0.