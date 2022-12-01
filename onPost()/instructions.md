OnPost()
The OnPost() handler method is invoked when a POST request is sent to a page. This usually happens when a user submits a form (an HTML <form> element).

Just like with OnGet(), the default behavior of an empty OnPost() method is to send the corresponding page. Without a return statement, this method also returns void.

public void OnPost()
{ }
Usually POST requests come with some information in the form of a query string. For example, say that a form at www.library.com/favorite asks for a book and an author:

<form method="post">
  <div class="form-group">
    <label for="Title">Title</label>
    <input type="text" class="form-control" id="Title" name="Title">
  </div>
  <div class="form-group">
    <label for="Author">Author</label>
    <input type="text" class="form-control" id="Author" name="Author">
  </div>
  <button type="submit" class="btn btn-primary">Submit</button>
</form>
Notice that each <input> has a name attribute — Title and Author, respectively.

In a browser it would look like:

title

If a user provided the input Where The Wild Things Are and Maurice Sendak, the URL would look like this (+ represents a space):

www.library.com/favorite?Title=Where+The+Wild+Things+Are&Author=Maurice+Sendak
OnPost() can capture the values in the query string via matching method parameters. To capture the above values, the method would look like this:

public void OnPost(string title, string author)
{
  Title = title;
  Author = author;
}
Those method parameters are matched case-insensitively; author or Author or aUTHOR would have worked.

Instructions
1.
Create a form by copying and pasting this code into Index.cshtml:

<form method="post">
  <div class="form-group">
    <label for="Title">Title</label>
    <input type="text" class="form-control" id="Title" name="Title" placeholder="Title">
  </div>
  <div class="form-group">
    <label for="Date">Date</label>
    <input type="date" class="form-control" id="Date" name="Date">
  </div>
  <div class="form-group">
    <label for="Body">Your post</label>
    <textarea class="form-control" id="Body" name="Body" rows="3"></textarea>
  </div>
  <button type="submit" class="btn" id="submit">Submit</button>
</form>
The place to paste is denoted with comments.

If done correctly, submitting the form will a produce a query string with the values: Title, Date, and Body. For example:

localhost:8000?Title=Example+Title&Date=2020-03-24&Body=just+some+words+here
Checkpoint 2 Passed

Stuck? Get a hint
2.
In Index.cshtml.cs, modify the OnPost() method by adding matching method parameters.

They should match the name attributes used in the <form>.

Checkpoint 3 Passed

Hint
public void OnPost(string title, DateTime date, string body)
3.
Within the method, assign each value to its corresponding property.

If done correctly, you can submit the form and see your data displayed on the page.

Checkpoint 4 Passed

Hint
The three properties are Title, Date, and Body.

As an example, this code sets the Title property to the title parameter:

Title = title;