Conditionals in Razor Pages: If Statements
You can use the if statement in your Razor code pretty much the same way you would in regular C# code — just prefix the keyword with the “@“ sign:

@{
  int value = 4;
}
 
@if (value % 2 == 0)
{
  <p> The value is even!</p> 
}
When writing if/else statements, we don’t need to prepend the else if or else lines with an “@“ sign:

@if (value % 2 == 0)
{
  <p>The value was even.</p>
}
else if (value >= 1337)
{
  <p>The value is large.</p>
}
else
{
  <p>The value is odd and small.</p>
}
Instructions
1.
Let’s imagine we’re at a stoplight and we want to display a message depending on the color of the streetlight.

Below the commented line in the code editor, open a code block and create a variable of type string called stopLight. Assign it to the string "green".


Stuck? Get a hint
2.
Open an if statement and check if the stopLight is green if so, display an <h5> heading, with the message: The stoplight is green, go!.


Stuck? Get a hint
3.
Write an else if statement, check if the stopLight is red and if so, display an <h5> heading, with the message: The stoplight is red, stop!

Make sure to change the variable stopLight to ensure the case works!


Stuck? Get a hint
4.
Write another else if statement to check if the stopLight is yellow and if so, display an <h5> heading, with the message: The stoplight is yellow, slow down!

Make sure to change the variable stopLight to ensure the else case works!


Stuck? Get a hint
5.
For the last else of the series of if/else statements, display an <h5> heading with the message: That stoplight doesn't exist!

Make sure to change the variable stopLight to a string that is not “green”, “yellow”, or “red” to ensure the else case works!