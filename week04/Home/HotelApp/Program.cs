using System;
using System.Collections.Generic;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            var hotels = new List<Hotel>
            {
                new Hotel("Unirii", "Iasi")
                {
                    Rooms = new List<Room>
                    {
                        new Room("Master Suite", new Rate(350, "RON"), 2, 0),
                        new Room("Room one", new Rate(200.15, "RON"), 2, 2),
                        new Room("Room two", new Rate(205.75, "RON"), 2, 1),
                        new Room("Room three", new Rate(175.25, "RON"), 2, 0),
                        new Room("Room four", new Rate(179, "RON"), 1, 2),
                        new Room("Room five", new Rate(190, "RON"), 1, 2),
                        new Room("Room six", new Rate(150.45, "RON"), 1, 1),
                        new Room("Room seven", new Rate(100, "RON"), 1, 0)
                    }
                },

                new Hotel("Decebal", "Suceava")
                {
                    Rooms = new List<Room>()
                    {
                        new Room("Master Suite", new Rate(450, "RON"), 2, 0),
                        new Room("Room one", new Rate(370, "RON"), 2, 2),
                        new Room("Room two", new Rate(365, "RON"), 2, 2),
                        new Room("Room three", new Rate(355.25, "RON"), 2, 1),
                        new Room("Room four", new Rate(350, "RON"), 1, 2),
                        new Room("Room five", new Rate(340.76, "RON"), 1, 2),
                        new Room("Room six", new Rate(320.15, "RON"), 1, 1),
                        new Room("Room seven", new Rate(300, "RON"), 1, 0)
                    }
                },
                new Hotel("Eclipse", "Iasi")
                {
                    Rooms = new List<Room>
                    {
                        new Room("Master Suite", new Rate(400, "RON"), 2, 0),
                        new Room("Room one", new Rate(270, "RON"), 2, 2),
                        new Room("Room two", new Rate(265, "RON"), 2, 2),
                        new Room("Room three", new Rate(255.25, "RON"), 2, 1),
                        new Room("Room four", new Rate(250, "RON"), 1, 2),
                        new Room("Room five", new Rate(240.76, "RON"), 1, 2),
                        new Room("Room six", new Rate(220.15, "RON"), 1, 1),
                        new Room("Room seven", new Rate(200, "RON"), 1, 0)
                    }
                }
            };

            Console.WriteLine("Please provide the name of the hotel you would want deleted :");
            var toDelete = Console.ReadLine();
            for (int i = 0; i < hotels.Count; i++)
            {
                if (hotels[i].Name == toDelete)
                {
                    hotels.RemoveAt(i);
                }
            }

            foreach (Hotel z in hotels)
            {
                Console.WriteLine(z.Name);
            }

            Console.WriteLine("Please provide the number of days :");
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine("Please provide the maximum price :");
            var price = double.Parse(Console.ReadLine());

            foreach (Hotel h in hotels)
            {
                foreach (Room r in h.Rooms)
                {
                    if (r.GetPriceForDays(n) < price)
                    {
                        Console.WriteLine($"{h.Name} {r.Name} -> {r.GetPriceForDays(n)} {r.Rate.Currency}");
                    }
                }
            }
        }
    }
}


