asp-route-{value}
The Input Tag Helper, with asp-for, allows us to easily create a form that submits data with a POST request.

What Tag Helper and attribute(s) would help us with GET requests?

Similarly, the Anchor Tag Helper, with asp-page and asp-route-{value} attributes, allows us to create <a> links that submit data with a GET request.

asp-page — Sets an anchor tag’s href attribute value to a specific page.
asp-route-{value} — Adds route values to an href. The {value} placeholder is interpreted as a potential route parameter.
This markup in a view page…

<a asp-page="./Authors" asp-route-fullname="Roald Dahl">Roald</a>
…would render as this HTML…

<a href="./Authors?fullname=Roald+Dahl">Roald</a>
Like before, we can capture the query values via method parameters:

public void OnGet(string fullname)
{ }
Technically we could also use model binding with the attribute [BindProperty(SupportsGet=true)] but we generally avoid that because allowing users to set values in GET requests can be dangerous. If GET requests can set attributes, then it would be too easy to mistakenly edit our app’s data by browsing to a URL. We prefer to set attributes in POST requests because they have built-in security from ASP.NET.

To recap: Anchor Tag Helpers generate GET requests. They use asp-page and asp-route-{value}:

<a asp-page="./Authors" asp-route-fullname="Roald Dahl">Roald</a>
Input Tag Helpers (along with a form) generate POST requests. They use asp-for:

<input asp-for="Title">
Instructions
1.
In Archive.cshtml, the <a> links just go to /Archive.

Use Anchor Tag Helpers to formulate the correct, unique link for each post:

Replace the href attribute with an asp-page attribute of the same value
Add an asp-route-index and use the @for loop index as the value
If done correctly, the “One Pot Thai-Style Rice” should link to /Archive?index=0, “Balsamic Glazed Salmon Fillets” should link to /Archive?index=1, etc.


Stuck? Get a hint
2.
We need to access that index value in the page model.

In Archive.cshtml.cs, add an index method parameter to OnGet().

3.
Add this code to the end of OnGet(). It uses the index to search the Archive:

if (index >= Archive.Count || index < 0)
{
  Displayed = new BlogPost("n/a", new DateTime(0001, 01, 01), "n/a");
}
else
{
  Displayed = Archive[index];
}
Try clicking the links. They should bring up different blog posts.