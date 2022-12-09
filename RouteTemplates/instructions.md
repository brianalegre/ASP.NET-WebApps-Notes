Route Templates
So far, we’ve seen two ways to pass data from the browser to a page model. Once a form is submitted we can:

Capture the data using method parameters, like OnPost(string title), or
Bind the data to properties using [BindProperty]
In both cases the POST request is made to a URL with a query string, like:

localhost:8000/Movies?title=Inception
We can reformat the URL so that the data is provided in URL segments instead, like:

localhost:8000/Movies/Inception
This format makes the URL more readable and more search-engine friendly. Here’s the generalized format:

localhost:8000/Movies/{title}
Inside a .cshtml file, we can specify this with the @page directive, using a kind of variable, known as a route value or route parameter, wrapped in curly braces. Assuming the page lives in Movies.cshtml, then the first line of the file would be:

@page "{title}"
Make sure that you use double quotes and curly braces: "{ }".

The way to capture these values is no different than before.

Capture with method parameters:

OnPost(string title)
Or with model-binding:

[BindProperty]
string Title { get; set; }
Instructions
1.
Currently, URL data for /Days is passed by query string. Try clicking the links. You should see your URL as something like:

localhost:8000/Days?day=1
Let’s convert the query string to a URL segment. So that it looks like this:

localhost:8000/Days/1