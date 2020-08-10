using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    public class Rate
    {
        public double Amount;
        public string Currency;

        public Rate()
        {
        }
        public Rate(double amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }
    }
}
