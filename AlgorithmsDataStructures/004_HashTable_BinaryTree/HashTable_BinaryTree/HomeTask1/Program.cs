using System;

namespace HomeTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashTable<string, string> hashtable = new HashTable<string, string>(2);
            hashtable.Add("Butoreva", "Vasilina");
            hashtable.Add("Naumovskaya", "Olya");
            hashtable.Add("Achepovskaya", "Anna");
            hashtable.Add("Korolev", "Artyom");
            hashtable.Add("Kireykov", "Hleb");
            hashtable.Add("Narbut", "Maksim");
            hashtable.Add("Smolyak", "Dima");

            Console.WriteLine($"There are {hashtable.Count} students");

            foreach (var key in hashtable.GetKey())
            {
                Console.WriteLine($"{key} {hashtable.GetValue(key)}");
            }

            Console.ReadKey();
        }
    }
}
