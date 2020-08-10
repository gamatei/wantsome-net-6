using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Homework
{
    public class Room
    {
        public string Name;
        public Rate Rate;
        public int Adults;
        public int Children;

        public Room()
        {
        }

        public Room(string name, Rate rate, int adults, int children)
        {
            Name = name;
            Rate = rate;
            Adults = adults;
            Children = children;
        }

        public double GetPriceForDays(int numberOfDays)
        {
            return numberOfDays * Rate.Amount;
        }


        public void Print()
        {
            Console.WriteLine($" Room name: {this.Name}, rate {Rate} per day, fits {Adults} adults and {Children} children");
        }
    }
}



