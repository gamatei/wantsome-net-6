namespace Ex03
{
    public class Student:Human
    {
        public double Grade;

        public Student(string firstname,string lastName,double grade)
        {
            this.FirstName = firstname;
            this.LastName = lastName;
            this.Grade = grade;
        }
    }
}
