Working with ViewImports
On top of sharing layouts, we’re also provided with a file where we can include directives that will become available globally throughout the rest of our pages. This saves us work in typing and makes maintenance easier.

There are a number of directives that you’ll be able to include in _ViewImports.cshtml, three of the most common ones that are added by default are @namespace, @using, and @addTagHelpers.

@namespace: Namespaces help us organize our code into groups by giving them some context. With namespaces, we’re able to avoid any naming collision with other classes of the same name. In this case, the namespace is used to declare the root namespace for your Pages. The default generated _ViewImports.cshtml file for most projects will have:
@namespace YourProjectName.Pages
You can only have one @namespace directive per _ViewImports.cshtml file, the directive is necessary for the models to work.
@using: Allows us to add imports to all of our Pages instead of having to add them individually per page. For example, if our _ViewImports.cshtml file contains:
@using Microsoft.Extensions.Localization;
then any pages under that folder will have access to members under Microsoft.Extensions.Localization namespace without having to explicitly import them with @using.
@addTagHelper: This directive is used to give access to Tag Helpers throughout our pages. The default directive includes:
@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers
which imports all Tag Helpers to our Pages. We will look more into Tag Helpers later in the lesson.
You might be wondering why not combine both _ViewStart.cshtml file and _ViewImports.cshtml into a single file and share that globally? Well this comes back to the idea of separation of concerns; ViewImports cares about imports, ViewStart cares about logic required for the view pages. Using ViewImports allows us to keep our code more concise and help us create a more scalable application.

Instructions
1.
The current app looks like it’s missing a few things! If you take a look at Index.cshtml and Privacy.cshtml you can see that we are still including our @namespace, @using, and @addTagHelpers here. Let’s consolidate this code.

Remove the three directives from Privacy.cshtml
Remove the three directives from Index.cshtml
Add the three directives at the top of _ViewImports.cshtml.