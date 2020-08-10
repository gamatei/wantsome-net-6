using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp
{
    public class PizzaBase
    {
        public string Name;
        public double Cost;

        public PizzaBase(string name, double cost)
        {
            Name = name;

            if (name == "Italian")
            {
                Cost = cost * 1.5;
            }
            else
            {
                Cost = cost;
            }
        }
        
        public override string ToString()
        {
            return $"{Name} (${Cost})";
        }
    }
}
