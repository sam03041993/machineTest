Dot Net core
version 3.1

Database
MS-SQL

Steps to run project
Once cloned or downloaded from git hub

Restore the project using command "dotnet restore" and build using command "dotnet build"

After restore update connection string in appsettings.json
Once the connection string is updated in package manager console use this command to create database with inital value in db from context class using command "update-database"
After above step run the project and replace URL with "http://localhost:56390/swagger/index.html" to play with API using swagger.

please be not for now the value to be passed should be in lower case
Units in master for now.
"celsius","fahrenheit","meter","feet"

If any other value passed other than above details API will return 400.

Thanks.