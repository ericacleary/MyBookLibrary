using MyBookLibrary.Models;
using System;
using System.Collections.Generic;


//This is for Seeding my database
namespace MyBookLibrary.Data
{
    public class LibraryInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<LibraryContext>
    {
        protected override void Seed(LibraryContext context)
        {
            var books = new List<Books>
            {
                new Books { Title ="Pride and Prejudice", Author = "Jane Austen", DatePublished = DateTime.Parse("1/28/1813") },
                new Books { Title ="The Valley of the Horses", Author = "Jean Auel", DatePublished = DateTime.Parse("4/13/1982") },
                new Books { Title ="The Silver Wolf", Author = "Alice Borchardt", DatePublished = DateTime.Parse("1/1/1993") },
                new Books { Title ="The Tale of the Body Thief", Author = "Anne Rice", DatePublished = DateTime.Parse("1/1/1992") },
                new Books { Title ="The Order of the Phoenix", Author = "J.K. Rowling", DatePublished = DateTime.Parse("6/21/2003") },
                new Books { Title ="Gone With the Wind", Author = "Margaret Mitchell", DatePublished = DateTime.Parse("6/30/1936") }


            };
            books.ForEach(b => context.books.Add(b));
            context.SaveChanges();
        }
    }
}