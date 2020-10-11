using System;
using System.Collections.Generic;
using System.Text;

namespace InsertPublisherApp.Entities
{
    public class Book
    {
        public int BookID { get; set; }
        public string Name { get; set; }
        public int PublisherID { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
    }
}
