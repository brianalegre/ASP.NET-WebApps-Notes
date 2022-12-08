Customize the URL
By default, each page’s URL is defined by its filename:

Index.cshtml is at localhost:8000
Privacy.cshtml is at localhost:8000/Privacy
What if we want to override those defaults?

We can add and/or change URL segments by adding a string after the @page directive. For example, if we used this line at the top of Privacy.cshtml…

@page "/Pirates"
…then Privacy.cshtml would now be available at localhost:8000/Pirates.

If we remove the forward slash (/), then we append a segment. Using this line…

@page "Pirates"
…makes Privacy.cshtml available at localhost:8000/Privacy/Pirates.

Aside from practical jokes, custom URLs are useful when you have a page deep in your folder hierarchy and you want a shorter URL. For example, if we used this line at the top of Movies/Horror/Create.cshtml…

@page "/AddScaries"
…then that file would be available at localhost:8000/AddScaries instead of localhost:8000/Movies/Horror/Create.

Just make sure to use that forward slash, /. If you don’t, it will append the segment to the end of the existing URL.

Instructions
1.
Currently, the contents of Activity.cshtml is available at /Activity.

Edit the @page directive to make Activity.cshtml available at /Days.