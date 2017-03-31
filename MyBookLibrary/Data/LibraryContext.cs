using MyBookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MyBookLibrary.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext() : base("LibraryContext")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<LibraryContext>());
        }

        public DbSet<Books> books { get; set; }
    }
}