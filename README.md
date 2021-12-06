# Minimal API Project

Data Access with Dapper and SQL. Implementing CRUD through Stored Procedures.

## How I Did It
- Created an ASP.NET Core Web API project
- using .Net 6

### Create a Database
- Added SQL Server Database Project as a new project inside the solution folder
- Inside the database I added 2 new folders <dbo> & <Tables>
- Insde dbo folder I added another folder <StoredProcedures>
- Inside Tables I added a new Table <User>
- In the User table I added FirstName, LastName & Added IDENTITY to the Primary Key
	- IDENTITY will ensure that and ID is assigned & increments by 1 for every new entry
	- Incremintation and Start number can be changed in the properties tab
- Inside StoredProcedures I added new Stored Procedures for GetAll, Get, Insert, Update and Delete
- In UserDB add a script for Post Deployment. You are only allowed one
- Right click UserDB and select publish
- Inside Publish select Edit > Browse > MSSQLLocalDB > OK
	- Keep the existing Params
- Give the DB a Name
- Select Save Profile As and then Save
	- it should allow you to add it to the root of your prject
- Press Cancel 
	- the publish file should appear in the solution explorer
	- you can double click it to bring you back to the settings page
- Open up your SQL Server Object Explorer in the view tab. You UserDb Should be visible in the localDb
- double click on the publish folder then selct Publish in the pop-up window
- Your MinimalAPIUser should now be visible in the Database as well. View the tables and they should have the information that was in the PostDeployment Scripts

### To Talk to Your Database
- Inside the Solution Folder. Add a new Clas Library project <DataAccess>
- Delete the class1 file
- Right click Solution Folder and Select Editor Config
	- It should produce a new file .editorconfig
	- Inside go to > Code Style > NamespaceDeclarations > Value 'File Scoped'
- Inside the new project add folders <Data>, <DBAccess> & <Models>
- Inside Data Create a new class <UserModel>
	- If the class is structured in block scope select namespace and Ctrl . and select refactor to File Scoped
- Add the following Nuget Packages
	- Dapper
	- System.Data.SqlClient
	- Microsoft.Extensions.Configurations.Abstractions
		- this allows us to talk to the JSON



## With Help From
- https://www.youtube.com/watch?v=dwMFg6uxQ0I&t=24s
- 