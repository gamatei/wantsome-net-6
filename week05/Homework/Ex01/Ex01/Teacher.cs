using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Ex01
{
    public class Teacher:People
    {
        public List<Discipline> disciplines = new List<Discipline>();

        public Teacher(string name)
        {
            this.Name = name;
        }
    }
}
