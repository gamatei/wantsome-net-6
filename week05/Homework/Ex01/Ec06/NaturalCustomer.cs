using System;
using System.Collections.Generic;
using System.Text;

namespace Ex06
{
    public class NaturalCustomer:Customer
    {
        public NaturalCustomer(string name)
        {
            {
                this.Name = name;
                this.Type = "Individual";
            }
        }
    }
}
