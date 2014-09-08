using DatabaseBit.Contexts;
using DatabaseBit.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace DatabaseBit
{
    /// <summary>
    /// this sets the database to mighrate automaticatlly
    /// </summary>
   public static class DatabaseSetup
    {
       public static void MagicallyMigrate()
       {
           Database.SetInitializer(new MigrateDatabaseToLatestVersion<SomeDBContext, Configuration>()); 

       }
    }
}
