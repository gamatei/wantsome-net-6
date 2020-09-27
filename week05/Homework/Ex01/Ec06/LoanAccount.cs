using System;
using System.Collections.Generic;
using System.Text;

namespace Ex06
{
    public class LoanAccount:Account
    {
        public int NoOfMonths;
        public LoanAccount(Customer customer, decimal balance)
        {
            this.Customer = customer;
            this.Balance = balance;
            InterestRate = 8.5m;
        }
}
