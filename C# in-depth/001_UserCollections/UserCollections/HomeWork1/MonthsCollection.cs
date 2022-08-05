using System.Collections.Generic;

namespace HomeWork1
{
    internal class MonthsCollection : IMonthsCollection
    {
        Month[] months = new Month[]
        {
            new Month("January", 31),
            new Month("February", 28),
            new Month("March", 31),
            new Month("April", 30),
            new Month("May", 31),
            new Month("June", 30),
            new Month("July", 31),
            new Month("August", 31),
            new Month("September", 30),
            new Month("October", 31),
            new Month("November", 30),
            new Month("December", 31)
        };

        public Month this[int index]
        {
            get { return months[index - 1]; }
        }

        public IEnumerable<Month> GetByDays(int days)
        {
            foreach (var month in months)
            {
                if (month.DaysInMonth == days)
                    yield return month;
            }
        }
    }
}
