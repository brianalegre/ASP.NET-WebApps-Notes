Using Partials
In certain cases, we might end up reusing snippets of HTML, such as forms, on different pages. We can also use these “partials” to break up more complex pages into smaller sections. This is another way to reduce duplication of common markup content across different files and keep our code DRY. “D.R.Y” (Don’t Repeat Yourself), is a software development principle, the main aim of which is to reduce the repetition of code.

Partial file names also begin with an underscore in their name (through convention). And in order to render the content we can use the following syntax in our content page:

<partial name="_PartialName" />
Where name refers to the filename of the partial.

Let’s look at an example:

Picture an application with the following folder structure:

Razor App
│   Startup.cs
│   Program.cs
│   RazorApp.sln
│   ...
│
└───Pages
│   │   _ViewStart.cshtml
│   │   MyPage.cshtml
│   │   MyPage.cshtml.cs
│   │  ...
│   │
│   └───Shared
│       │   _Layout.cshtml
│       │   _MyPartial.cshtml.
│       │   ...
│   
└───Properties
If our partial has the following content:

_MyPartial.cshtml:

<div>Here's some content from a partial!</div>
We can use the partial in a separate page as follows:

MyPage.cshtml:

<div>
  <h1>Welcome to My Page!</h1>
  <partial name="_MyPartial"/>
</div>
Similarly to Layouts, Razor Pages will search all registered partial locations for a file with the supplied name and if it finds it, it will render its content resulting in:

<div>
  <h1>Welcome to My Page!</h1>
  <div>Here's some content from a partial!</div>
</div>
Instructions
1.
A very reusable component in many applications is a <form>. Let’s imagine we’re working on an app that will use a simple form to register and log in users. The form will be used throughout different pages. If we explore our folder structure, you’ll see that we have a “Registration” page: Register.cshtml, and a “Login” page: Login.cshtml.

Copy the content in the <form> tags and paste it in the partial page: _Form.cshtml


Stuck? Get a hint
2.
Remove the <form> content from the Login.cshtml and Register.cshtml pages.


Stuck? Get a hint
3.
Use the <partial> tag to add the form in both Register.cshtml and Login.cshtml.


Stuck? Get a hint