using System;

namespace Ex01
{
    public class Student : People
    {
        public Guid UniqueClassNumber;

        public Student(string name, Guid uniqueClassNumber)
        {
            this.Name = name;
            this.UniqueClassNumber = uniqueClassNumber;
        }

        public Student(string name)
        {            
            this.Name = name;
            this.UniqueClassNumber = Guid.NewGuid();
        }

    }
}
