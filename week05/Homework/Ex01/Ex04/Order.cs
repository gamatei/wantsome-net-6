namespace Ex04
{
    public class Order : IOrder
    {
        public Vehicle Vehicle { get; set; }
        public Person Person { get; set; }
        public int NoOfWeeks { get; set; }
        public int Price { get; set; }
        public bool IsAvailable;
        public Order()
        {
            IsAvailable = true;
        }
    }
}
