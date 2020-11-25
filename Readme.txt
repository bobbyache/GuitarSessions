

* Use Package Manager Console to run ef stuff.

---------------------------------------------------------------------
To create a new database via code use:
---------------------------------------------------------------------
Run DatabaseFuncs.
* This will create the GuitarSessions localdb database
* CAUTION: If the database has been created it will be deleted.
* Use SQL Server Object Explorer to see the database
* After run should show up automatically in explorer localdb databases

---------------------------------------------------------------------
To create a new migration:
---------------------------------------------------------------------
Use the package manager console and run the following command:

dotnet ef migrations add initial --project CygSoft.GuitarSessions.Data

---------------------------------------------------------------------
To generate a migrations script use:
---------------------------------------------------------------------
dotnet ef migrations script -i -o CygSoft.GuitarSessions.Data/safe-migrations-new.sql --project CygSoft.GuitarSessions.Data


---------------------------------------------------------------------
Manualy deleting the database
---------------------------------------------------------------------
- Please look at the SQL Server Object Explorer 
- Visual Studio -> View -> SQL Server Object Explorer
- If it contains the 'DatabaseName' database then right click on it to delete it.

*********************************************************************
Possible Issues
*********************************************************************

Database '[DatabaseName]' already exists. Choose a different database name

	- Please look at the SQL Server Object Explorer 
	- Visual Studio -> View -> SQL Server Object Explorer
	- If it contains the 'DatabaseName' database then please try to delete it.