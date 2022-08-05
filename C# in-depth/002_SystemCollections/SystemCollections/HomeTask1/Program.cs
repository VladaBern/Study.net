using System;
namespace HomeTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BuyersCollection collection = new BuyersCollection();

            collection.Add("Alex", "Car");
            collection.Add("Sam", "Flat");
            collection.Add("Den", "Telephone");
            collection.Add("Alex", "Flat");
            collection.Add("Den", "Car");
            collection.Add("Den", "Telephone");
            collection.Add("Sam", "Car");

            foreach (var product in collection.GetProductsByBuyer("Den"))
                Console.WriteLine(product);

            foreach (var name in collection.GetBuyersByProduct("Car"))
                Console.WriteLine(name);

            Console.ReadKey();
        }
    }
}
