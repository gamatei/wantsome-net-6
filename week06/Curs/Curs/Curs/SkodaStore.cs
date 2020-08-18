using System;
using System.Collections.Generic;
using System.Text;

namespace Curs
{
    class SkodaStore : Store
    {
        public string Name { get => typeof(SkodaStore).Name; }

        private Dictionary<ICustomer, List<IOrder>> orderList;

        public SkodaStore()
        {
            orderList = new Dictionary<ICustomer, List<IOrder>>();
        }

        public override void CancelOrder(IOrder order, ICustomer customer)
        {

            if (orderList[customer].Contains(order))
            {
                orderList[customer].Remove(order);
            }
            else
            {
                Console.WriteLine("No order found. Please review the order ID");
            }
        }

        public override void ProcessOrder(IOrder order, ICustomer customer)
        {
            order.NumberOfWeeks = new Random().Next();
            if (!orderList.ContainsKey(customer))
            {
                orderList.Add(customer, new List<IOrder> { order });
            }
            else
            {
                orderList[customer].Add(order);
            }
        }
    }
}
