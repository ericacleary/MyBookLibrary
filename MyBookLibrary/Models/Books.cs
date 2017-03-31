﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyBookLibrary.Models
{
    public class Books
    {
        
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime DatePublished { get; set; }

    }
}