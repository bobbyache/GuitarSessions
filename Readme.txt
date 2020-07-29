

* Use Package Manager Console to run ef stuff.

---------------------------------------------------------------------
To create a new database use:
---------------------------------------------------------------------
Run DatabaseFuncs.
* This will create the GuitarSessions localdb database
* Use SQL Server Object Explorer to see the database
* After run should show up automatically in explorer localdb databases

---------------------------------------------------------------------
To create a new migration:
---------------------------------------------------------------------
dotnet ef migrations add initial --project CygSoft.GuitarSessions.Data

---------------------------------------------------------------------
To generate a migrations script use:
---------------------------------------------------------------------
dotnet ef migrations script -i -o CygSoft.GuitarSessions.Data/safe-migrations-new.sql --project CygSoft.GuitarSessions.Data