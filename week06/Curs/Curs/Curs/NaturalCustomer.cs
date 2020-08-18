using System;
using System.Collections.Generic;
using System.Text;

namespace Curs
{
    class NaturalCustomer:ICustomer,IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int age { get; set; }

        public NaturalCustomer(string firstname,string lastname,int age)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.age = age;
        }
    }
}
