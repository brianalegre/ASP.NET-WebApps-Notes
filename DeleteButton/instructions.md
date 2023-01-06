Markup the Delete Button
Our code should now handle a delete. The next step is to change the HTML to pass in the ID. The ID must be passed in the <form> postback. This is triggered by a submit button in an <a> tag. A hidden <input> tag can be used to store the ID in the browser until the user clicks Delete and does the <form> postback.

One new Bootstrap trick:

btn btn-danger btn-sm - make a small red button
Instructions
1.
In Pages/Continents/Index.cshtml, change the <div> surrounding the Details and Edit buttons to a <form>. Add the attribute method="post".


Stuck? Get a hint
2.
Add an <input> of type "submit" under the Edit <a> tag.

The value attribute should equal "Delete"
Its classes should be btn, btn-danger, and btn-sm.
The btn-danger class is Bootstrap CSS for the color red.


Stuck? Get a hint
3.
Next add a hidden <input> that can return the ID back to the server during the post.

The type should be "hidden"
The name should be "ID"
The value should be set to the current Continent item’s ID