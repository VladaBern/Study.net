using System;
using System.Collections.Generic;

// Несколькими способами создайте коллекцию, в которой можно хранить только целочисленные и
// вещественные значения, по типу «счет предприятия – доступная сумма» соответственно. 

namespace HomeTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, double> collection1 = new Dictionary<int, double>();
            collection1.Add(154, 68.25);
            collection1.Add(178, 45.69);
            collection1.Add(240, 79.3);
            foreach (var item in collection1)
                Console.WriteLine($"{item.Key} - {item.Value}");

            Console.WriteLine(new string('-', 15));

            SortedDictionary<int, double> collection2 = new SortedDictionary<int, double>();
            collection2.Add(154, 36.2);
            collection2.Add(178, 14.9);
            collection2.Add(240, 9.37);
            foreach (var item in collection2)
                Console.WriteLine($"{item.Key} - {item.Value}");

            Console.WriteLine(new string('-', 15));

            SortedList<int, double> collection3 = new SortedList<int, double>();
            collection3.Add(154, 8.7);
            collection3.Add(178, 12.813);
            collection3.Add(240, 54.11);
            foreach (var item in collection3)
                Console.WriteLine($"{item.Key} - {item.Value}");

            Console.ReadKey();
        }
    }
}
