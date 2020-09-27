using System;
using System.Collections.Generic;
using System.Text;

namespace Ex06
{
    public class MortgageAccount : Account
    {
        public int NoOfMonths;
        public MortgageAccount(Customer customer, decimal balance)
        {
            this.Customer = customer;
            this.Balance = balance;
            InterestRate = 5.16m;
        }
    }
}
