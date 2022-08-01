namespace HomeWork1
{
    internal class Months
    {
        public string NameOfMonth { get; }
        public int IndexOfMonth { get; }
        public int DaysInMonth { get; }

        public Months(string nameOfMonth, int indexOfMonth, int daysInMonth)
        {
            NameOfMonth = nameOfMonth;
            IndexOfMonth = indexOfMonth;
            DaysInMonth = daysInMonth;
        }
    }
}
