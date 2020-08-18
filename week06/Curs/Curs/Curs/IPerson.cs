using System;
using System.Collections.Generic;
using System.Text;

namespace Curs
{
    public interface IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int age { get; set; }
    }
}
