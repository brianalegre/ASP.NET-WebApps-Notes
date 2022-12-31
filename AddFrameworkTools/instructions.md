Add Entity Framework Tools
The standard project template does not include all the tools needed to work with Entity Framework. The dotnet command line tool can install these for you. Behind the scenes this tool downloads additional libraries (DLLs) and makes a reference in the RazorCountry.csproj project file.

Instructions
1.
Run this command in the bash shell:

dotnet add package Microsoft.EntityFrameworkCore.SQLite
2.
Run this command in the bash shell:

dotnet add package Microsoft.EntityFrameworkCore.Design
3.
Run this command in the bash shell:

dotnet add package Microsoft.EntityFrameworkCore.Tools