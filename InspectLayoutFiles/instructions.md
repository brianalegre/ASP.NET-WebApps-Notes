Inspect the _Layout File
Use the file manager to expand the Shared folder and open _Layout.cshtml. This hidden page defines the HTML for the header, left navigation, and footer. There are two special directives used in this page. @RenderBody() is replaced with the markup from each page that uses _Layout. In this case it lives inside a <div class="container">. This is a bootstrap CSS convention that provides correct spacing and padding. The second directive is @RenderSection. This will be replaced by <script> blocks as needed for things like input validation.

Instructions
1.
The file manager _Layout.cshtml is open in the Pages/Shared folder. This hidden page defines the HTML for the header, left navigation, and footer.