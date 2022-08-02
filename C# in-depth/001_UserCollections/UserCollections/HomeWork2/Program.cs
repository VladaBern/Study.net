using System;
namespace HomeWork2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CitizensCollection citizens = new CitizensCollection();

            int index;

            citizens.Add(new Student("MP123456789", "Alex", "Alexeev", 20));
            citizens.Add(new Pensioner("MP741523698", "Ivan", "Ivanov", 75));
            citizens.Add(new Worker("MP971658212", "Sam", "Smith", 41));

            foreach (var item in citizens)
                Console.WriteLine(item);

            Console.WriteLine(new string('-', 10));

            citizens.Remove();
            foreach (var item in citizens)
                Console.WriteLine(item);

            Console.WriteLine(new string('-', 10));

            citizens.Add(new Worker("MP458762381", "Roman", "Romanov", 34));
            citizens.Remove(new Worker("MP971658212", "Sam", "Smith", 41));
            Console.WriteLine($"{citizens.ReturnLast(out index)} - {index}");

            Console.WriteLine(new string('-', 10));

            citizens.Add(new Pensioner("MP964851327", "Andrey", "Andreev", 80));
            try
            {
                citizens.Add(new Worker("MP458762381", "Roman", "Romanov", 34));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(new string('-', 10));

            Console.WriteLine(citizens.Contains(new Pensioner("MP741523698", "Ivan", "Ivanov", 75), out index));
            Console.WriteLine(citizens.Contains(new Student("MP123456789", "Alex", "Alexeev", 20), out index));

            citizens.Clear();

            Console.WriteLine($"{citizens.ReturnLast(out index)} - {index}");

            Console.ReadKey();
        }
    }
}
