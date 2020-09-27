using System;

namespace UnitTesting.Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            var converter = new BirdLanguageConverter();
            var result=converter.Convert("salut");

            Console.WriteLine(result);
        }
    }
}
