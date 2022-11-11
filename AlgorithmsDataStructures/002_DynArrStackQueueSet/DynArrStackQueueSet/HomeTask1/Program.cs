using System;

namespace HomeTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DynamicArr<int> arr = new DynamicArr<int>();

            for (int i = 1; i <= 4; i++)
                arr.Add(i);

            Console.WriteLine($"Capacity before removal = {arr.Capacity}");

            arr.RemoveAt(2);

            Console.WriteLine($"Capacity after removal = {arr.Capacity}");

            Console.ReadKey();
        }
    }
}
