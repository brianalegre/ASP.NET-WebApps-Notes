NotFound()
An HTTP response includes more than just HTML — it also includes an HTTP status code. A popular one is 404, which means that a requested resource was not found. For example, a user requests a profile page of a non-existent person.

We can generate that kind of response using NotFound().

In this example, a request with the username "Machiavelli" will lead to a 404 response:

public IActionResult OnPost(string username)
{
  if (username == "Machiavelli")
  {
    return NotFound();
  }
 
  return Page();
}
Instructions
1.
In a previous exercise, we redirected users from /OldSearch to /Search. This time, instead of redirecting, let’s show a 404 Not Found page when a user tries to submit the form on /OldSearch.

Edit the OnPost() method so that it returns a 404 response.