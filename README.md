# IntPatronat .net task 2023
Rest API back end application

# Technologies
- ASP.Net Core
- Microsoft Entity Framework
- Microsoft SQL server
- Swagger

# Installation
You will need SQL Server Dev edition and Visual Studio.
Clone repository to your Visual Studio and edit appsettings.json with your data source.
Edit this line, by default with your machine hostname (CMD command 'hostname')
"Data Source=<Put your data source here and remove brackets>"

If you get unable to verify leaf signature in Postman - please disable SSL verification in Postman in settings (general tab - SSL Certificate Verification) or use Swagger, I was unable to find the root cause yet.


# MISC

Postman collection can be found in main folder:
Roland Wicynski .net Patronage 2023 collection.postman_collection.json

Search book call most likely referred to searching books by author data, but I did not manage to implement it.
There is the possibility to assign authors to the books in the many to many intermediate table, but this relation is not used for other calls.
