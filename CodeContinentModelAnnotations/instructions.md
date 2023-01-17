Code Continent Model Annotations
We now have a full working set of CRUD pages. But, there are some problems with our approach. There is no data validation so the user could enter numbers where letters are required. They could enter bad dates or negative population values.

We will enhance our data models with annotations. That will refine the database schema and ensure that the correct data types, string lengths, and character types are stored. This is coupled with some validation tag helpers that display helpful messages to the user if the incorrect data is entered in each field.

Thankfully, Entity Framework provides those enhancements to data models that can make our display and editing more consistent and robust. Model annotations are included in the System.ComponentModel.DataAnnotations library. They can be used to force a column to accept certain data patterns or display more efficiently. There are many of these annotations and we will focus on the following.

Field must contain a value:

[Required]
Set minimum and maximum lengths:

[StringLength]
Match input patterns for things like email addresses and zip codes:

[RegularExpression]
Numeric or date limits:

[Range]
Define a data type which determines the database column type:

[DataType]
Change the field label:

[Display]
Change how the value is displayed:

[DisplayFormat]
The annotations are entered in the EF model class above each property field. Some annotations accept additional parameters like ErrorMessage.

Once the model is annotated, the database must be recreated to allow EF to modify the table schema to match the model design. This ensures that data is validated on the server using ModelState.IsValid and again when it is persisted to the database. We will see in the next exercise that validation can also happen in the browser.

Instructions
1.
In Models/Continent.cs, add a using statement to support annotations:

System.ComponentModel.DataAnnotations

Stuck? Get a hint
2.
Add the [Required] annotation to the Name property.


Stuck? Get a hint
3.
Multiple annotations can be joined on a single line or on separate lines. For the ID property:

Make it
[Required]
Force it to be 2 characters
StringLength(2, MinimumLength = 2)
Accept uppercase letters only using a regular expression annotation
RegularExpression(@"[A-Z]+", ErrorMessage = "Only upper case characters are allowed.")
Make the display name more friendly
Display(Name = "Code")
Delete the Country.db file from the root of the project. Annotation changes to the models will need to be reflected in the database schema. Don’t worry, the sample data will reload on next use.

You can try this out in the Continent Create page (/Continents/Edit). See if you can make a Continent with a numeric ID or an ID with more than 2 characters. The Save button will not see a valid model and the page will never redirect back to the Continent list.