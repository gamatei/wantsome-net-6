using System.Collections.Generic;

namespace Ex01
{
    public class School
    {
        public string Name;
        public List<Class> classes = new List<Class>();
        public School(string name)
        {
            this.Name = name;
        }
    }
}
