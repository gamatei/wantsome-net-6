using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex02
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Cat[] cats = new Cat[] { new Kitten(1, "Maya"), new Tomcat(2,"Jeff" ), new Kitten(5,"Lisa"),new Tomcat(4,"Tom")};
            Console.WriteLine($"The average age for the cats is {cats.Average(x => x.Age)}");

            Dog[] dogs = new Dog[] { new Dog(2, "Rex", Sex.Male), new Dog(7, "Dolly", Sex.Female), new Dog(13, "Mick", Sex.Male), new Dog(10, "Doru", Sex.Male) };
            Console.WriteLine($"The average age for the dogs is {dogs.Average(x => x.Age)}");

            Frog[] frogs = new Frog[] { new Frog(2, "john", Sex.Male), new Frog(7, "Joanna", Sex.Female), new Frog(3, "Leonardo", Sex.Male), new Frog(1, "Vasile", Sex.Male) };
            Console.WriteLine($"The average age for the frogs is {frogs.Average(x => x.Age)}");
        }
    }
}
