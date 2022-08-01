using System;

namespace HomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MonthsCollection months = new MonthsCollection();

            Console.WriteLine(months[4].NameOfMonth);

            foreach (var item in months.GetByDays(31))
            {
                Console.WriteLine($"In {item.NameOfMonth} - {item.DaysInMonth} days");
            }

            Console.ReadKey();
        }
    }
}
