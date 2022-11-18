Conditionals in Razor Pages: Switch Statements
Similar to if statements, switch cases operate the same way — by prefixing the keyword with the “@“ sign:

@{ int number = 2 }
 
@switch (number)
{
  case 1: <h1>The value is 1!</h1>
  break;
  case 2: <h1>The value is 2!</h1>
  break;
  default: ...
}
In the code above we’re evaluating an expression, number, and simply comparing the values to each case. If a value matches the expression, then the associated code block will be executed.

In this case, since the variable number is equal to 2, then the following HTML would be executed:

<h1>The value is 2!</h1>
Instructions
1.
You’ve received some exam results but there’s some useful feedback missing.

We’ll be evaluating the cases based on the value of your grade.

Open a switch statement and use the variable grade as the expression you’ll be comparing to each case.

Checkpoint 2 Passed

Stuck? Get a hint
2.
For the first case, we want to check whether the grade is equal to A. If so, display the following message in an <h4> heading:

Excellent job!
Checkpoint 3 Passed

Hint
Make sure to add a break for each case!

@switch(grade)
{
  case "A": <h4>Excellent job!</h4>
  break; 
}
3.
Continue switch cases and display the following feedback <h4> headings depending on the grade:

Grade	Feedback
“A”	“Excellent job!”
“B”	“Well done!”
“C”	“Needs some work!”
“D”	“You passed”
“F”	“You failed, better try next time”
default case	“Invalid grade!”
Checkpoint 4 Passed

Hint
Make sure you add a break after each statement, including the default case!

@switch(grade)
{
  case "A": <h4>Excellent job!</h4>
  break;
  case "B": <h4>Well done!</h4>
  break;
  ...
  default: <h4>Invalid grade!</h4>
  break;
}