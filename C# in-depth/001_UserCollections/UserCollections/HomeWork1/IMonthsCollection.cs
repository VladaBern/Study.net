using System.Collections.Generic;

namespace HomeWork1
{
    internal interface IMonthsCollection
    {
        Month this[int index] { get; }
        IEnumerable<Month> GetByDays(int days);
    }
}
