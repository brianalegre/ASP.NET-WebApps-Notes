Inspect the Startup File
The file Startup.cs has a class constructor that is passed a configuration object defined by the interface IConfiguration. This interface requires the ConfigureServices() and Configure() methods. Services are bodies of C# code that are accessible to all pages and classes in your project. In this case, the AddRazorPages() service is added to support UI pages with Razor syntax. The Configure() method adds additional features:

UseHttpRedirection (reroutes HTTP requests to HTTPS)
UseStaticFiles (allows JS, CSS, images, and other static files)
UseRouting (manages the URL in the browser)
UseAuthorization (allows login and user personalization)
UseEndpoints (which calls MapRazorPages() to establish URL routing).
Instructions
1.
The file Startup.cs is open. Look for the ConfigureServices() and Configure() methods.