using System.Collections.Generic;
using System.Linq;

namespace Ex04
{
    public class Store : IStore
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public List<Order> StoreOffers { get; set; }

        public Order GetOffer(string vehicleModel, int year)
        {
            var order = StoreOffers.FirstOrDefault(x => x.Vehicle.Model == vehicleModel && x.Vehicle.Year == year && x.IsAvailable == true);
            return order;
        }

        public void AcceptOrder(Order order, Person person)
        {
            order.Person = person;
            order.IsAvailable = false;
        }

        public void CancelOrder(Order order)
        {
            order.Person = null;  // remove person from order
            order.IsAvailable = true;
        }

        public void CarReceived(Order order) {
            StoreOffers.Remove(order);
        }
    }
}
