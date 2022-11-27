Tag Helpers
Tag Helpers are very useful ways to create HTML elements with server-side attributes. For example, when we use an anchor tag, <a>, we usually have an href attribute to direct the user to a specific page when they click it. Razor Pages provides handy Tag Helpers that help us generate links and other useful information.

So instead of writing an anchor tag as so:

<a href="/Attendee?attendeeid=10">View Attendee</a>
We can rewrite it with a Tag Helper like this:

<a asp-page="/Attendee"
   asp-route-attendeeid="10">View Attendee</a>
The syntax allows developers to easily customize the UI using HTML/CSS knowledge.

There are many available predefined Tag Helpers to help us generate links, create forms, load assets, etc. There is even one to help us render partials which we just went over! So let’s go ahead and take a look at how some of them work.

<partial name="\_ItemPartial" ... />
In the tag above, we’re using one of the predefined Tag Helpers provided by ASP.NET: <partial …>, the partial tag will take a required name attribute that searches all registered partial locations for the file with that name, and once the page is loaded, the server will render the HTML from that file. Certain tag helpers have optional attributes that they can take. The partial one has the following optional attributes:

for: Assigns an expression to be evaluated against the current model. This is one way to pass data to the partial.
<partial name="_ItemPartial" for="Item" />
Note: The model syntax is inferred so we don’t need to use @Model.Item

model: The model the partial references. This is another way to pass data into our partial. The main difference between model and for, is that model allows you to use a more specific model instead of the inferred one that for provides. HOWEVER, we can’t use it in conjunction with for. We must use one or the other:
<partial name="_ItemPartial" model="Model.Item" />
In this case, we could pass in a brand new instance of our model:

<partial name="_ItemPartial" 
model='new Item { Number = 1, Name: "Test Item, Price: 10"}'/>
view-data: Assigns a key/value pair of type ViewDataDictionary that we can pass directly into the partial view:
@{
ViewData["IsItemReadOnly"] = true;
}

<partial name="_ItemPartial" view-data="ViewData" />
During runtime, the Razor Application will process the markup and when it reads out certain Tag Helpers it will convert them into plain HTML before sending the page to the user. For reference, here is a list of all the tag helpers provided by ASP.NET!

Instructions

1.  You’re in the early stages of developing a travel agency application and you’re currently working on the homepage.

Take a look at the documentation for the Select Tag Helper. It’s ok if not everything is 100% clear! We’ll go over how to use it in this exercise. Once you’ve gone over the documentation, navigate over to the Explorella.cshtml.cs file. There’s a model with a property called Country.

Create another property of type List that stores items of data type SelectListItem. Call this property Countries and give it a setter and a getter.

Stuck? Get a hint 2.
Each instantiation of a SelectListItem will take a few optional properties. You’ll be using the Text and Value properties in this case.

There are two ways to create an instance of a SelectListItem:

By creating a property and assigning it values:

new SelectListItem { Value = "1", Text = "Admin" },
By giving it two parameters, where the first one is the Value and the second is the Text:

new SelectListItem("1", "Admin")
In your OnGet() method, assign the property Countries to a new List of 5 separate SelectListItem instances.

Set their Value and Text as follows:

Value Text
“AR” “Argentina”
“FR” “France”
“BR” “Brazil”
“GER” “Germany”
“CHI” “China”

Stuck? Get a hint 3.
Now that you have the property Countries set up with some values, you can use those values with the Select tag helper in the view page. Remove all the hardcoded option tags.

Stuck? Get a hint 4.
Within the select tag in Explorella.cshtml, we’ll be making use of two attributes.

asp-for: Refers to the model property that will be assigned the selected value.
asp-items: The collection of SelectListItems that provides the options for the list.
Add those two attributes and assign them to the appropriate property and Items.

The countries should now populate on the drop-down menu when selecting your next destination! Imagine we had a list of 50 countries? That would be a lot of <option> tags to write! With the use of Tag Helpers, we were able to consolidate our code from 8 lines, down to 2!
