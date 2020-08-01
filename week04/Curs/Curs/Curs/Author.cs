using System;
using System.Collections.Generic;
using System.Text;

namespace Curs
{
    class Author
    {
        private string name;
        private string email;
        private int noOfVolumes;

        public Author()
        {
            this.name = "Default Name";
            this.email = "Default email";
            this.noOfVolumes = 2;
        }

        public Author(string name, string email, int noOfVolumes)
        {
            this.name = name;
            this.email = email;
            this.noOfVolumes = noOfVolumes;
        }

        public void PrintAuthor()
        {
            Console.WriteLine($"The author is {this.name}, the email address is {this.email} and they wrote {this.noOfVolumes} volumes!");
        }
    }
}
