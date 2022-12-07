Introduction to Routing
Imagine that you were building an exercise app to track your activity. You could store each of your day’s steps and workouts in the app and you could view both your total activity for the week and individual activity for each day.

With the page-based framework of Razor Pages,

How would you duplicate the individual-day view? Would you need to write a new page for every day?
How could you customize your URLs to match each day?
These questions can be solved with routing. Instead of URLs like /Activity you can rename it to Days and make variable route parameters like /Days/1, /Days/2, etc. In this lesson you’ll do the following:

Define custom URL segments
Define route templates
Add Constraints on route templates
Understand how Tag Helpers adapt to custom routing
Instructions
In the browser to the right, navigate to the Daily Activity tracker. Check out how the URL changes with each link