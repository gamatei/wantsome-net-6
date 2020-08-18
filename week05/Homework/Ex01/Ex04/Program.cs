using System;
using System.Collections.Generic;

namespace Ex04
{
    class Program
    {
        //SIMPLE VERSION

        //static void Main()
        //{

        //    // -Alex intended to buy a Ford Focus 2015 model.
        //    Person person = new Person { Name = "Alex" };
        //    Vehicle fordVehicle = new Vehicle { Model = "Focus", Producer = new Producer { Brand = "Ford" }, Year = 2015 };

        //    //- He walked to the FordStore in Bucuresti and agreed to buy one for 15000Euro.

        //    Store fordStore = new Store { Location = "Bucuresti", Name = "Ford Store" };
        //    fordStore.Vehicles.Add(fordVehicle);

        //    //- They informed him it will take 4 weeks for delivery.

        //    Order order1 = new Order { NoOfWeeks = 4, Person = person, Price = 15000, Vehicle = fordVehicle };

        //    //- He then decided to visit another store SkodaStore and agreed to buy one for 14000Euro and 3 weeks delivery.

        //    Store skodaStore = new Store { Location = "Iasi", Name = "Skoda Store" };
        //    Vehicle skodaVehicle = new Vehicle { Model = "Octavia", Producer = new Producer { Brand = "Skoda" }, Year = 2014 };
        //    skodaStore.Vehicles.Add(skodaVehicle);
        //    Order order2 = new Order { NoOfWeeks = 3, Person = person, Price = 14000, Vehicle = skodaVehicle };

        //    //- He then canceled his original order from the FordStore.

        //    if (order1.NoOfWeeks > order2.NoOfWeeks)
        //    {
        //        //cancel order 1
        //        order1.Person = null;
        //    }
        //    else {
        //        order2.Person = null; 
        //    }

        //    //- After 3 weeks, he received the model.
        //}



        //DETAIL-ORIENTATED VERSION
        static void Main()
        {
            Person person = new Person { Name = "Alex" };

            Producer fordProducer = new Producer { Brand = "Ford" };
            Producer skodaProducer = new Producer { Brand = "Skoda" };

            Store fordStore = new Store
            {
                Location = "Bucuresti",
                Name = "Ford Store",
                StoreOffers = new List<Order> {
                    new Order
                    {
                        NoOfWeeks = 4,
                        Price = 15000,
                        Vehicle = new Vehicle {
                            Model = "Focus",
                            Producer = fordProducer,
                            Year = 2015
                        }
                    },
                    new Order
                    {
                        NoOfWeeks = 6,
                        Price = 10000,
                        Vehicle = new Vehicle {
                            Model = "Fiesta",
                            Producer = fordProducer,
                            Year = 2015
                        }
                    },
                }
            };

            Store skodaStore = new Store
            {
                Location = "Iasi",
                Name = "Skoda Store",
                StoreOffers = new List<Order> {
                    new Order{
                        NoOfWeeks = 3,
                        Price = 14000,
                        Vehicle = new Vehicle {
                            Model = "Octavia",
                            Producer = skodaProducer,
                            Year = 2014
                        }
                    }
                }
            };


            // get offer for the car
            Order fordOrder = fordStore.GetOffer("Focus", 2015);
            if (fordOrder == null)
            {
                Console.WriteLine($"2015 Focus not found in this store. End Process.");
                return;
            }

            Console.WriteLine($"Car will be delivered in {fordOrder.NoOfWeeks} weeks.");

            // accept order
            fordStore.AcceptOrder(fordOrder, person);


            // get order for the new car
            var skodaOrder = skodaStore.GetOffer("Octavia", 2014);

            if(skodaOrder == null)
            {
                Console.WriteLine($"2014 Octavia not found in this store. End Process.");
                return;
            }

            Console.WriteLine($"Car will be delivered in {skodaOrder.NoOfWeeks} weeks.");
            skodaStore.AcceptOrder(skodaOrder, person);

            if (fordOrder.NoOfWeeks > skodaOrder.NoOfWeeks)
            {
                // cancel ford order
                fordStore.CancelOrder(fordOrder);
            }
            else {
                skodaStore.CancelOrder(skodaOrder);
            }

            // after 3 weeks
            skodaStore.CarReceived(skodaOrder);
        }
    }
}
