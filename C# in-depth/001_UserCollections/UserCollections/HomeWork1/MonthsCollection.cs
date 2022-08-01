using System.Collections.Generic;

namespace HomeWork1
{
    internal class MonthsCollection : IMonthsCollection
    {
        Months[] months = new Months[]
        {
            new Months("January", 31),
            new Months("February", 28),
            new Months("March", 31),
            new Months("April", 30),
            new Months("May", 31),
            new Months("June", 30),
            new Months("July", 31),
            new Months("August", 31),
            new Months("September", 30),
            new Months("October", 31),
            new Months("November", 30),
            new Months("December", 31)
        };

        public Months this[int index]
        {
            get { return months[index - 1]; }
        }

        public IEnumerable<Months> GetByDays(int days)
        {
            foreach (var month in months)
            {
                if (month.DaysInMonth == days)
                    yield return month;
            }
        }
    }
}
