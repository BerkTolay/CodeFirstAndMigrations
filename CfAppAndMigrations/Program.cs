using System;

namespace CfAppAndMigrations
{
    class Program
    {
        #region Migrations
        //Install-Package Microsoft.EntityFrameworkCore 5.0.15
        //Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 5.0.15
        //Install-Package Microsoft.EntityFrameworkCore.Tools -Version 5.0.15

        //add-migration
        //update-database

        //migrations üzerine yazmak için add-migration [Migration İsmi] -force

        //migrations down metodu için Update-database -context [Context ismi] -migration [Migration İsmi]
        //                            Update-database -context FootballContext -migration 20220313170810_CreateCountriesTable
        //up metodları için update-database

        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
