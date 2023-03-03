using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new PersonPhoneContext())
            {
                db.Phones.Add(new Phone { BrandName = "Apple", PhoneModel = "iPhone 14" });
                db.Phones.Add(new Phone { BrandName = "Apple", PhoneModel = "iPhone 12 pro" });
                db.Phones.Add(new Phone { BrandName = "Google", PhoneModel = "Pixel 7" });
                db.Phones.Add(new Phone { BrandName = "Samsung", PhoneModel = "Galaxy A52" });
                db.SaveChanges();

                db.People.Add(new Person { FirstName = "Alex", LastName = "Romanov", Phones = new List<Phone> { db.Phones.Find(2) } });
                db.People.Add(new Person { FirstName = "Roman", Phones = new List<Phone> { db.Phones.Find(3), db.Phones.Find(4) } });
                db.People.Add(new Person { FirstName = "Ann", LastName = "Kotova", Phones = new List<Phone> { db.Phones.Find(1) } });
                db.SaveChanges();

                var people = db.People.ToList();
                
                foreach (var person in people)
                {
                    Console.WriteLine($"{person.PersonalNumber}.{person.FirstName} {person.LastName}");

                    if (person.Phones.Count > 0)
                    {
                        foreach (var phone in person.Phones)
                            Console.WriteLine($"\t{phone.BrandName} - {phone.PhoneModel}");
                    }
                    Console.WriteLine(new string('-', 25));
                }


            }
            Console.ReadKey();
        }
    }
}
