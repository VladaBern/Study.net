using System;

namespace HomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MonthsCollection months = new MonthsCollection();

            Console.WriteLine(months[4].Name);

            foreach (var item in months.GetByDays(31))
            {
                Console.WriteLine($"In {item.Name} - {item.DaysInMonth} days");
            }

            Console.ReadKey();
        }
    }
}
