using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace HomeTask2
{
    internal class Program
    {
        public static void DelayCleansingConsole()
        {
            Console.ReadKey();
            Console.Clear();
        }

        static void Main(string[] args)
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<PersonCarContext>());

            using (PersonCarContext context = new PersonCarContext())
            {
                var car1 = new Car { CarModel = "Audi", ReleaseYear = 2020 };
                var car2 = new Car { CarModel = "Ferrari", ReleaseYear = 2016 };
                var car3 = new Car { CarModel = "Audi", ReleaseYear = 2016 };
                var car4 = new Car { CarModel = "BMW", ReleaseYear = 2005 };
                var car5 = new Car { CarModel = "BMW", ReleaseYear = 2021 };
                var car6 = new Car { CarModel = "Audi", ReleaseYear = 2021 };
                context.Cars.AddRange(new List<Car> { car1, car2, car3, car4, car5, car6 });

                var person1 = new Person { Name = "John", Age = 48, Cars = new List<Car> { car1, car3, car4 } };
                var person2 = new Person { Name = "Ann", Age = 30, Cars = new List<Car> { car2 } };
                var person3 = new Person { Name = "Roger", Age = 52, Cars = new List<Car> { car5, car6 } };
                var person4 = new Person { Name = "Rita", Age = 24 };
                context.People.AddRange(new List<Person> { person1, person2, person3, person4 });

                context.SaveChanges();

                Console.WriteLine("Using  Include() method");
                var includeCars = context.People.Include(x => x.Cars);
                foreach (var person in includeCars)
                {
                    Console.WriteLine($"{person.Name} has:");
                    foreach (var car in person.Cars)
                        Console.WriteLine($"\t{car.CarModel} - {car.ReleaseYear}");
                }
                DelayCleansingConsole();

                Console.WriteLine("Using Select() method");
                var selectPerson = context.People.Select(p => new {p.Name, p.Age});
                foreach (var person in selectPerson)
                    Console.WriteLine($"{person.Name} - {person.Age}");

                DelayCleansingConsole();

                Console.WriteLine("Using Find() method");
                var findPerson = context.People.Find(2);
                Console.WriteLine($"Found person with id 2 is {findPerson.Name}");
            }
        }
    }
}
