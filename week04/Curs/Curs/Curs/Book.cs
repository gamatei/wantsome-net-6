using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Curs
{
    class Book
    {
        private string title;
        private Author author;
        private int year;
        private double price;

        public Book()
        {
            this.title = "Default title";
            this.author = new Author();
            this.year = 2020;
            this.price = 9.99;
        }

        public Book(string title, int year, double price)
        {
            this.title = title;
            this.author = new Author();
            this.year = year;
            this.price = price;
        }

        public Book(string title, int year, double price, string authorName, string email, int noOfVolumes)
        {
            this.title = title;
            this.author = new Author(authorName, email, noOfVolumes);
            this.year = year;
            this.price = price;
        }

        public Book(string title, Author author, int year, double price)
        {
            this.title = title;
            this.author = author;
            this.year = year;
            this.price = price;
        }

        public void PrintBook()
        {
            Console.WriteLine($" The Book's title is {this.title}, written in {this.year}, and it costs {this.price}$!");
            author.PrintAuthor();
        }
    }
}
