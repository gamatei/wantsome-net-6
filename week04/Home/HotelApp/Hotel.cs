using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    public class Hotel
    {
        public string Name;
        public string City;
        public List<Room> Rooms = new List<Room>();

        public Hotel()
        {
        }

        public Hotel(string name, string city)
        {
            Name = name;
            City = city;
        }

    }
}
