using System;
using System.Collections.Generic;

namespace Ex01
{
    public class Class
    {
        public string Name;
        public Guid UniqueTextIdentifier;
        public List<Teacher> teachers = new List<Teacher>();
        public List<Student> students = new List<Student>();

        public Class(string name, Guid uniqueTextIdentifier)
        {
            this.Name = name;
            UniqueTextIdentifier = uniqueTextIdentifier;            
        }
        public Class(string name)
        {
            this.Name = name;
            UniqueTextIdentifier = Guid.NewGuid();            
        }
    }
}
