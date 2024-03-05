using HW3_3.Interfaces;

namespace HW3_3.Implementations
{
    public class WeekDays : IPrinter
    {
        private string[] week_days;
        public WeekDays()
        {
            week_days = new string[7] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        }
        public void Print()
        {
            Console.WriteLine("Printing days of the week: ");
            for (int i = 0; i < week_days.Length; i++)
            {
                Console.WriteLine(week_days[i]);
            }
        }
    }
}