using System.Collections.Generic;

namespace HomeWork1
{
    internal interface IMonthsCollection
    {
        Months this[int index] { get; }
        IEnumerable<Months> GetByDays(int days);
    }
}
