namespace Ex04
{
    public class Vehicle : IVehicle
    {
        public IProducer Producer { get ; set ; }
        public string Model { get ; set ; }
        public int Year { get; set; }
    }
}
