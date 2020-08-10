using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp
{
    public class Pizza
    {
        public string Name;
        public PizzaBase Base;
        public List<PizzaTopping> Toppings;

        public Pizza(string name, PizzaBase pizzaBase)
        {
            Name = name;
            Base = pizzaBase;
        }

        public void AddTopping(PizzaTopping newTopping)
        {
            Toppings.Add(newTopping);
        }

        public double CalculateTotalCosts()
        {
            double totalCosts = 0;

            totalCosts += Base.Cost;

            foreach (var pizzaTopping in Toppings)
            {
                totalCosts += pizzaTopping.Cost;
            }

            return totalCosts;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{Name}");
            sb.AppendLine($"Pizza Base: {Base}");

            sb.AppendLine("Toppings:");
            foreach (var pizzaTopping in Toppings)
            {
                sb.AppendLine(pizzaTopping.ToString());
            }

            sb.AppendLine("-------------------------");
            sb.AppendLine($"Total Cost: ${CalculateTotalCosts()}");
            return sb.ToString();
        }
    }
}
