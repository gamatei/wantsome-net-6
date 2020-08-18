namespace Ex02
{
    public abstract class Animal : ISound
    {
        public int Age;
        public string Name;
        public Sex Sex;
        public string Sound { get; set; }
    }

}
