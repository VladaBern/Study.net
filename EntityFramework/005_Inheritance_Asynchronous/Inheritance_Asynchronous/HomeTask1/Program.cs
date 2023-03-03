using System;

namespace HomeTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AnimalContext())
            {
                db.Animals.Add(new Animal { Name = "Rocksy", Age = 2 });
                db.Animals.Add(new Animal { Name = "Charly", Age = 5 });

                var dog1 = new Dog { Name = "Lucy", Age = 4, Breed = "Dobermann" };
                db.Dogs.Add(dog1);

                db.Dogs.Add(new Dog { Name = "Aperol", Age = 1, Breed = "Basenji" });

                db.SaveChanges();

                Console.WriteLine("Animals:");
                foreach (var animal in db.Animals)
                    Console.WriteLine($"\t{animal.AnimalNumber} - {animal.Name}({animal.Age})");

                Console.WriteLine(new string('-', 25));

                Console.WriteLine("Dogs:");
                foreach (var dog in db.Dogs)
                    Console.WriteLine($"\t{dog.AnimalNumber} - {dog.Name}({dog.Age}) : {dog.Breed}");

                Console.ReadKey();
            }
        }
    }
}
