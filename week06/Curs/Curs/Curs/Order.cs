using System;
using System.Collections.Generic;
using System.Text;

namespace Curs
{
    internal class Order : IOrder
    {
        private IVehicle vehicle;
        private ICustomer customer;
        public int NumberOfWeeks { get; set; }
        public Order(IVehicle fordVehicle, ICustomer alexAutoConsult)
        {           
            this.vehicle = fordVehicle;
            this.customer = alexAutoConsult;
        }
    }
}
                              