using System;
using System.Collections.Generic;

namespace PizzaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pizza> pizzaList = new List<Pizza>
            {
                new Pizza("Mady pizza", new PizzaBase("Regular", 12))
                {
                    Toppings = new List<PizzaTopping>
                    {
                        new PizzaTopping("Mozzarella", 2, false),
                        new PizzaTopping("Pomodoro Sauce", 6, false),
                        new PizzaTopping("Summer Salami", 10, true),
                        new PizzaTopping("Ham", 5, true),
                        new PizzaTopping("Spicy sausages", 7, true)
                    }
                },
                new Pizza("Quattro Stagione Pizza", new PizzaBase("Italian", 15))
                {
                    Toppings = new List<PizzaTopping>
                    {
                        new PizzaTopping("Mozzarella", 2, false),
                        new PizzaTopping("Pomodoro Sauce", 6, false),
                        new PizzaTopping("Sausages", 6, true),
                        new PizzaTopping("Mushrooms", 3, false),
                        new PizzaTopping("Olives", 2, false)
                    }
                },

                new Pizza("Carnivore Pizza", new PizzaBase("Thick", 22))
                {
                    Toppings = new List<PizzaTopping>
                    {
                        new PizzaTopping("Mozzarella", 2, false),
                        new PizzaTopping("Pomodoro Sauce", 6, false),
                        new PizzaTopping("Summer Salami", 10, true),
                        new PizzaTopping("Ham", 5, true),
                        new PizzaTopping("Bacon", 15, true),
                        new PizzaTopping("Mushrooms", 3, false),
                        new PizzaTopping("Olives", 2, false)
                   }
                }
            };

            foreach (var pizza in pizzaList)
            {
                Console.WriteLine(pizza);
            }
        }
    }
}
