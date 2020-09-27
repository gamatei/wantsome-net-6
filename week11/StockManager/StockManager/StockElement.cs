using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace StockManager
{
    public class StockElement
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double PricePerUnit { get; set; }
        public string Currency { get; set; }            
    }
}
