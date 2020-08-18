namespace Ex03
{
    public class Worker:Human
    {
        public double WeekSalary;
        public int WorkHoursPerDay;
        public double MoneyPerH;


        public Worker(string firstname, string lastName, double WeekSalary,int WorkHoursPerDay)
        {
            this.FirstName = firstname;
            this.LastName = lastName;
            this.WeekSalary = WeekSalary;
            this.WorkHoursPerDay = WorkHoursPerDay;
            this.MoneyPerH=MoneyPerHour(this.WeekSalary, this.WorkHoursPerDay);
        }  
        
        private double MoneyPerHour(double WeekSalary, int WorkHoursPerDay)
        {
            return WeekSalary / (WorkHoursPerDay * 5);
        }
    }
}
