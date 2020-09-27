using System;
using System.Collections.Generic;
using System.Text;

namespace Ex06
{
    public class CompanyCustomer : Customer
    {              
        public CompanyCustomer(string name)
        {
            this.Name = name;
            this.Type="Company";
        }
    }
    

}
