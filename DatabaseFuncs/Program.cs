using CygSoft.GuitarSessions.Data;
using System;

namespace DatabaseFuncs
{
    class Program
    {
        static void Main(string[] args)
        {
            DataContextFactory dataContextFactory = new DataContextFactory();
            dataContextFactory.CreateDbContext(new string[] { }).Database.EnsureCreated();
            Console.WriteLine("Hello World!");
        }
    }
}
