namespace Ex01
{
    public class Discipline
    {
        public string Name;
        public int NoOfLectures;
        public int NoOfExercises;

        public Discipline(string name, int lectures,int exercises)
        {
            this.Name = name;
            this.NoOfLectures = lectures;
            this.NoOfExercises = exercises;
        }
    }
}
