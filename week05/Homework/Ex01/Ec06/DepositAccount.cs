using System;
using System.Collections.Generic;
using System.Text;

namespace Ex06
{
    public class DepositAccount:Account
    {
        public int NoOfMonths;
        public DepositAccount(Customer customer, decimal balance)
        {
            this.Customer = customer;
            this.Balance = balance;
            InterestRate = 0.88m;
        }
    }
}
