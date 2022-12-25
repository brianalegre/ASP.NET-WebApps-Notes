Inspect the Index Page Model File
Use the file manager to open Index.cshtml.cs to see how the PageModel class is built for the page. Notice that the class name matches the Razor page name with the suffix Model. These classes must inherit from the PageModel class. By default, a logger service is injected into the constructor for the PageModel. This enables centralized error logging.

We will use the same injection approach to access our data services.

Instructions
1.
The file Index.cshtml.cs is open. This defines the PageModel for the page. Notice that the class name matches the Razor page name with the suffix Model.