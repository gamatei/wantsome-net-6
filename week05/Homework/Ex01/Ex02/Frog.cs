namespace Ex02
{
    public class Frog : Animal
    {
        public Frog(int age, string name, Sex sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
            this.Sound = "croak";
        }
    }
}
