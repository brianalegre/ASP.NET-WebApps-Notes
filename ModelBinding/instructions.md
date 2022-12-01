Model Binding
In the previous exercise we typed out each parameter name in the form, then copied them over to the OnPost() method, then set them equal to properties. In some cases, we would need a fourth step to convert each value into a valid .NET type…

ASP.NET Core provides a feature that takes care of all that for us: model binding. In model binding, data is retrieved from an HTTP request, it is converted into .NET types, and it is stored in corresponding model properties.

To activate model binding in a page model, make sure that the desired property name matches the name attribute in the <form>, then label it with the attribute [BindProperty].

In the view page:

<form method="post">
  <div class="form-group">
    <label for="Title">Title</label>
    <input type="text" class="form-control" id="Title" name="Title" placeholder="Title">
  </div>
  <div class="form-group">
    <label for="Author">Author</label>
    <input type="text" class="form-control" id="Author" name="Author" placeholder="Author">
  </div>
  <button type="submit" class="btn btn-primary">Submit</button>
</form>
In the page model:

[BindProperty]
string Title { get; set; }
 
[BindProperty]
string Author { get; set; }
We can then remove the method parameters and assume that the submitted form values are set to their corresponding properties:

// No more method parameters!
// No more Author = author!
public void OnPost()
{ }
You might not be familiar with attributes in C#, but that’s okay. All you need to know is that the line [BindProperty] goes directly above each property.

Technically, you also need to use the Microsoft.AspNetCore.Mvc namespace, but that is included in default ASP.NET templates. If you’d like to learn more, read about model binding in the Microsoft documentation.

Instructions
1.
We’ll repeat the same steps as the previous exercise, but this time using model binding. Create a form by copying and pasting this code into Index.cshtml:

<form method="post">
  <div class="form-group">
    <label for="Title">Title</label>
    <input type="text" class="form-control" id="Title" name="Title" placeholder="Title">
  </div>
  <div class="form-group">
    <label for="Date">Date</label>
    <input type="date" class="form-control" id="Date" name="Date">
  </div>
  <div class="form-group">
    <label for="Body">Your post</label>
    <textarea class="form-control" id="Body" name="Body" rows="3"></textarea>
  </div>
  <button type="submit" class="btn" id="submit">Submit</button>
</form>
2.
Instead of adding method parameters, use model binding:

Mark the three properties in Index.cshtml.cs with the [BindProperty] attribute.
Remove the method parameters from OnPost().
Delete the lines assigning the method arguments to properties.
Run the code and submit the form. Check that your input shows up in the resulting page.