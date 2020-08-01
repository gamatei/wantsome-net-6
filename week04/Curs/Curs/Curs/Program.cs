using System;

namespace Curs
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b2 = new Book("IT", 1995, 19.99);
            Library l = new Library();
            Library l2 = new Library("Iasi2", b2);

        }

        static void Ex1()
        {
            Author arghezi = new Author();
            Author creanga = new Author("Ion Creanga", "ion@creanga.ltd", 5);

            arghezi.PrintAuthor();
            creanga.PrintAuthor();
        }

        static void Ex2()
        {
            Author arghezi = new Author();
            Author creanga = new Author("Ion Creanga", "ion@creanga.ltd", 5);

            Book b1 = new Book();
            b1.PrintBook();
            Console.WriteLine("======================================================================================================================");

            Book b2 = new Book("IT", 1995, 19.99);
            b2.PrintBook();
            Console.WriteLine("======================================================================================================================");

            Book b3 = new Book("Inferno", creanga, 2000, 25.5);
            b3.PrintBook();
            Console.WriteLine("======================================================================================================================");

            Book b4 = new Book("Morometii", 1900, 21.2, "Marin Preda", "m@preda.ltd", 7);
            b4.PrintBook();
            Console.WriteLine("======================================================================================================================");
        }
    }
}
