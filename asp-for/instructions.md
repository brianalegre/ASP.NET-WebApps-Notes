asp-for
So far, we’ve built an HTML form in the view page. When submitted it sends a URL query string to our app according to the name attributes of the form. We captured the query values first using method parameters, then using model binding.

We can make that first step (writing a form) even easier using Tag Helpers. We expect you to be familiar with the general concept of Tag Helpers, but we’ll show you a new use for them here.

Instead of using the name and id attributes in each <input> element, we’ll use the asp-for attribute:

Take this Input Tag Helper, which uses the asp-for attribute:

<input asp-for="Author">
It will render as this HTML:

<input type="text" name="Author" id="Author">
Why is this Tag Helper better than basic HTML? The benefits will become clearer as we create more advanced properties, but:

It saves you the hassle of writing HTML attributes.
Integrated Development Environments (IDEs), like Visual Studio, can check for errors before you run the code.
Changes to the property (in a model) are automatically carried into the view page.
Advanced settings on properties, such as data validation, are converted into additional HTML attributes. We won’t be covering those yet, so we won’t see this benefit in this lesson.
Instructions
1.
In Index.cshtml, edit the form so that it uses asp-for instead of id and name attributes.

Make sure that you change all three <input> tags.


Stuck? Get a hint
2.
In Index.cshtml.cs, label each property with [BindProperty].

Run the code and submit the form. Check that your input shows up in the resulting page.