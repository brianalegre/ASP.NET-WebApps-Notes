DATA VALIDATION
Code Country Model Annotations
There are more validation patterns that we can apply to the Country data model. This will change the display name for headers and <label> tags.

[Display(Name = "Code")]
The format of numeric and date data strings can be applied like this:

[DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]
Ranges with minimum and maximum values can be applied to numbers, dates, and strings:

[Range(1, 10000000000)]
Specific data types can be applied to fields:

[DataType(DataType.Date)]
Once the model is annotated, the database must be recreated to allow EF to modify the table schema to match the model design. This ensures that data is validated on the server using ModelState.IsValid and again when it is persisted to the database. We will see in the next exercise that validation can also happen in the browser.

Instructions
1.
Open the file Models/Country.cs. Add a using statement to support annotations:

System.ComponentModel.DataAnnotations

Stuck? Get a hint
2.
Add [Required] to the first 3 properties.


Stuck? Get a hint
3.
Force ID to be 2 characters uppercase letters only using StringLength and RegularExpression annotations. This matches what was added to the Continent model.


Stuck? Get a hint
4.
Force ContinentID to be 2 characters uppercase letters only using StringLength and RegularExpression annotations.


Stuck? Get a hint
5.
Make the display name more friendly by placing these above the corresponding field names:

Code instead of ID
UN Date instead of UnitedNationsDate
Continent instead of ContinentID

Stuck? Get a hint
6.
Set a [Range] on Population so negatives are not allowed.


Stuck? Get a hint
7.
Set [DisplayFormat] strings on Population and UN Date.


Stuck? Get a hint
8.
Set a minimum date of 10/24/1945 on UN Date with a friendly message, using this format:

[Range(typeof(YOURTYPE), MIN, MAX, ErrorMessage = "MESSAGE")]

Stuck? Get a hint
9.
Force DateTime? to use just the date — no time portion — by using [DataType(DataType.Date)].

Delete the Country.db file from the root of the project. Annotation changes to the models will need to be reflected in the database schema. Don’t worry, the sample data will reload on next use.