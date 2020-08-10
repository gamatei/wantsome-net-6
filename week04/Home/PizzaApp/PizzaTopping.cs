using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp
{
    public class PizzaTopping
    {
        public string Name;
        public double Cost;
        public bool IsMeat;

        public PizzaTopping(string name, double cost, bool isMeat)
        {
            Name = name;
            Cost = cost;
            IsMeat = isMeat;
        }

        public override string ToString()
        {
            if (IsMeat)
            {
                return $"{Name.ToUpper()} (${Cost})";
            }
            else
            {
                return $"{Name} (${Cost})";
            }
        }
    }
}
