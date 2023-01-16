Markup the Edit Page
Tag helpers are used as attributes of the <label> and <input> tags. The asp-for attribute needs the column name from the record schema so it can bind the column name for the <label> or the record data for the <input>. The helper uses the data type and other information from the EF model to determine which control type to display. This is clearly evident in the Population and UnitedNationsDate fields.

Bootstrap CSS note:

form-control - built-in class that rounds corners and shows a colored border while editing a field
Instructions
1.
In Pages/Continents/Edit.cshtml, add a <form> with a method of "post" after the jumbotron title block.


Stuck? Get a hint
2.
Add some flex <div> tags to display the row members. The side by side <label> and <input> pair are used with flexbox styling. All inputs and the submit button live inside a form so they post back as a unit.


Stuck? Get a hint
3.
Copy the form group you just added and place it directly beneath the first one. Change the asp-for attribute from ID to Name.


Stuck? Get a hint
4.
The last piece inside the <form> is a submit <input> button. This goes below the form groups but still inside the </form> closing tag.

This last piece should include:

A <div> wrapped around an <input> element
The <input> should have attributes type="submit" and a value="Save"