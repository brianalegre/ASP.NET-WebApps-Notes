Add Constrained Route Templates
Like everywhere else in C#, strict type constraints help us avoid errors. Imagine if someone sent a POST request to this URL:

localhost:8000/veggies/YES/fruits/NO/grains/IDUNNO/protein/SORTA/dairy/NEVER
It would break our application, which expects integers for each of those route values. Within our @page directive we can specify that constraint like the below, where int stands for “integer” (we’ll show an abbreviated version here):

@page "/veggies/{veggies:int}..."
The general format is:

@page "{routevalue:constraint}"
If you want the route value to remain optional, use the question mark after the constraint, like:

@page "/veggies/{veggies:int?}..."
There are a lot of constraints out there, but here are a few to get started:

int — value must be any integer
alpha — value must consist of one or more alphabetical characters (a-z, case-insensitive)
bool — value must be true or false (case-insensitive)
A longer (but not exhaustive) list of constraints is available in the Microsoft documentation.

Instructions
1.
The current @page directive specifies a route value without constraints. For example, what happens when you navigate to the below “illegal” URL?

localhost:8000/Days/all
Add the proper constraint so that it only accepts integers (and is still optional).