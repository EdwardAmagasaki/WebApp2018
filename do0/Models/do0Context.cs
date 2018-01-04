using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using do0.Migrations;

namespace do0.Models
{
    public class do0Context : DbContext
    {
        public do0Context()
            : base("do0Context")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<do0Context, Configuration>());
            //Database.SetInitializer<Do0Context>(new DropCreateDatabaseIfModelChanges<do0Context>());
            //Database.SetInitializer<Do0Context>(new DropCreateDatabaseAlways<do0Context>());
            //Database.SetInitializer<SchoolDBContext>(new DropCreateDatabaseIfModelChanges<do0Context>());
            //Database.SetInitializer<SchoolDBContext>(new DropCreateDatabaseAlways<do0Context>());
            //Database.SetInitializer<SchoolDBContext>(new SchoolDBInitializer());
        }
        public DbSet<do0Client> do0Clients { get; set; }

    }
}