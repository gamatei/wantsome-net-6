using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Home01
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Person(string name)
        {
            this.Name = name;
            this.Age = default;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{Name}");
            if (Age == default)
                sb.AppendLine("No age was provided");
            else
                sb.AppendLine($"{Age} years old");
            return sb.ToString();
        }
    }
}
