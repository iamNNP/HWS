namespace HW3_3
{
    public class WeekDay : IPrinter
    {
        private string[] WeekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        private string Name;
        public WeekDay(string name)
        {
            if (!(Array.Exists(WeekDays, element => element == name)))
            {
                Name = "Monday";
            } else
            {
                Name = name;
            }
        }
        public void Print()
        {
            Console.WriteLine(Name);
        }
    }
}