using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace HomeTask1
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
            Database.SetInitializer(new DropCreateDatabaseAlways<PersonDogContext>());

            using (PersonDogContext context = new PersonDogContext())
            {
                var dog1 = new Dog { Name = "Jessy", Breed = "Bulldog" };
                var dog2 = new Dog { Name = "Jack", Breed = "Husky" };
                var dog3 = new Dog { Name = "Stormy", Breed = "Dobermann" };
                var dog4 = new Dog { Name = "Kiwi", Breed = "Dobermann" };
                var dog5 = new Dog { Name = "Luna", Breed = "Husky" };
                var dog6 = new Dog { Name = "Muhtar", Breed = "Shepherd" };
                context.Dogs.AddRange(new List<Dog> { dog1, dog2, dog3, dog4, dog5, dog6 });

                var person1 = new Person { Name = "Alex", Age = 29, Dogs = new List<Dog> { dog1, dog5 } };
                var person2 = new Person { Name = "Kate", Age = 25, Dogs = new List<Dog> { dog2, dog3 } };
                var person3 = new Person { Name = "Peter", Age = 41, Dogs = new List<Dog> { dog4 } };
                var person4 = new Person { Name = "Jenifer", Age = 36, Dogs = new List<Dog> { dog6 } };
                context.People.AddRange(new List<Person> { person1, person2, person3, person4 });

                context.SaveChanges();

                Console.WriteLine("Using  FirstOrDefault() method");
                var firstPerson = context.People.FirstOrDefault(p => p.Dogs.Count > 1);
                Console.WriteLine($"The first person who has more than 1 dog is - {firstPerson.Name}");

                DelayCleansingConsole();

                Console.WriteLine("Using OrderBy() method");
                var orderedPeople = context.People.OrderBy(p => p.Age);
                foreach (var person in orderedPeople)
                    Console.WriteLine($"{person.Name} - {person.Age}");

                DelayCleansingConsole();

                Console.WriteLine("Using  Count() method");
                var dobermannCount = context.Dogs.Where(d => d.Breed == "Dobermann").Count();
                Console.WriteLine($"There are - {dobermannCount} dobermanns");

                DelayCleansingConsole();

                Console.WriteLine("Using  Min() method");
                var minAge = context.People.Min(p => p.Age);
                Console.WriteLine($"Minimum age of dog owners is - {minAge}");

                DelayCleansingConsole();

                Console.WriteLine("Using  Max() method");
                var maxAge = context.People.Max(p => p.Age);
                Console.WriteLine($"Maximum age of dog owners is - {maxAge}");

                DelayCleansingConsole();

                Console.WriteLine("Using  Average() method");
                var averageAge = context.People.Average(p => p.Age);
                Console.WriteLine($"Average age of dog owners is - {averageAge}");
            }
        }
    }
}
