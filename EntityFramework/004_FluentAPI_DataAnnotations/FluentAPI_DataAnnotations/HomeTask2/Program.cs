using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new PersonMailContext())
            {
                var mail1 = new Mail { Address = "student@gmail.com" };
                var mail2 = new Mail { Address = "kate.popova@gmail.com" };
                var mail3 = new Mail { Address = "ritka-margaritka@gmail.com" };
                db.People.Where(p => p.FirstName == "Rita").First().Mails.Add(mail3);
                db.People.Where(p => p.FirstName == "Roman").First().Mails.Add(mail1);
                db.People.Add(new Person { FirstName = "Kate", Mails = new List<Mail> { mail2 } });
                db.People.Where(p => p.FirstName == "Rita").First().Mails.Add(new Mail { Address = "rita.work@gmail.com" });
                db.SaveChanges();

                foreach (var person in db.People)
                {
                    Console.WriteLine($"{person.PersonalId}.{person.FirstName} {person.LastName}");

                    if (person.Mails.Count > 0)
                    {
                        foreach (var mail in person.Mails)
                            Console.WriteLine($"\t{mail.Address}");
                    }
                    Console.WriteLine(new string('*', 25));
                }
            }

            Console.ReadKey();
        }
    }
}
