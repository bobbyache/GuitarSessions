using CygSoft.GuitarSessions.Data;
using System;

namespace DatabaseFuncs
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataContextFactory = new DataContextFactory();
            var dataContext = dataContextFactory.CreateDbContext(new string[] { });

            dataContext.Database.EnsureDeleted();
            dataContext.Database.EnsureCreated();
            Console.WriteLine("Database has successfully been created");
        }
    }
}
