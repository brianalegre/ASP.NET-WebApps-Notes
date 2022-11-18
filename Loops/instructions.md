Working with Loops
Let’s not forget about loops!

There are a number of different types of loops in C# that can be written in Razor syntax. Let’s say we have a list of names we’ll be looping over:

@{
  List<string> names = new List<string>()
  {
    "Scott Allen",
    "James Dorf",
    "Tim Alston",
    "Jane Rashid",
    "John Doe"
  };
}
We can iterate over the names with a for loop, which is useful when we need to keep track of how far in the looping process we are:

<ul>
  @for (int i = 0; i < names.Count; i++)
  {
    <li>@names[i]</li>
  }
</ul>
Resulting HTML from the above example:

<ul>
  <li>Scott Allen</li>
  <li>James Dorf</li>
  <li>Tim Alston</li>
  <li>Jane Rashid</li>
  <li>John Doe</li>
</ul>
Similarly, we can use a foreach loop:

<ul>
  @foreach(string name in names)
  {
    <li>@name</li>
  }
</ul>
Resulting HTML from the above example:

<ul>
  <li>Scott Allen</li>
  <li>James Dorf</li>
  <li>Tim Alston</li>
  <li>Jane Rashid</li>
  <li>John Doe</li>
</ul>
Lastly, we can iterate over the names with a while loop:

<ul>
  @{ 
    int counter = 0;
  }
  @while(counter < names.Count)
  {
    <li>@names[counter++]</li>
  }
</ul>
Resulting HTML from the above example:

<ul>
  <li>Scott Allen</li>
  <li>James Dorf</li>
  <li>Tim Alston</li>
  <li>Jane Rashid</li>
  <li>John Doe</li>
</ul>
Instructions
1.
Create a list of 4 of your favorite foods and assign them to a variable called favoriteFoods.

Checkpoint 2 Passed

Stuck? Get a hint
2.
You’re going to iterate through the favoriteFoods list and display each food item in an unordered list. For each item in the loop, you’ll be adding an unordered list tag.

Open some tags for an unordered list under the <h4> heading with the text: “Results from your for loop”.

Checkpoint 3 Passed

Hint
Unordered List tags are

<ul>...</ul>
3.
Inside the unordered list, you’ll be looping over 4 of your favorite foods and display them as list items. Start by creating a for loop with the following conditions:

An initial variable, i, with a count starting at 0
A terminating condition that ends when we reach the count of our favoriteFoods length.
An iteration statement that increases our initial value by 1.
After the for loop expression, open some curly brackets where you’ll write the rest of your C# code.

Checkpoint 4 Passed

Hint
Do not forget the “@“ sign!

@for (int i = 0; i < names.Count; i++)
4.
Within your code blocks, open a list item tag. Inside it, access each element in the favoriteFoods list using the initial variable, i.

Checkpoint 5 Passed

Hint
We’ll be iterating over each index variable, i, so our list tag should look like this:

<li>@variableName[i]</li>
5.
Now you have your favoriteFoods displayed! Let’s rewrite this loop in a different way. Instead of creating a for loop, open a pair of <ul> tags and use a foreach loop and call each item on the list.

Checkpoint 6 Passed

Hint
The foreach loop looks like this:

 @foreach(string name in names)
{
  <li>@name</li>
}
6.
Awesome! Now, try using a while loop. Start out by creating a variable called counter and assign it to 0. You’ll iterate over your favorite foods while the counter is less than the length of favoriteFoods.

Checkpoint 7 Passed

Hint
Don’t forget to increase the counter after each iteration!

<ul>
    @{ 
        int counter = 0;
    }
    @while(counter < names.Count)
    {
        <li>@names[counter++]</li>
    }
</ul>