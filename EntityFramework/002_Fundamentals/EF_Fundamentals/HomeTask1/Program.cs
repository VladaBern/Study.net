using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace HomeTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<MotherChildrenModel>());

            using (MotherChildrenModel db = new MotherChildrenModel())
            {
                Mother m1 = new Mother { Name = "Ann", Phone = "+37025968450" };
                Mother m2 = new Mother { Name = "Kate", Phone = "+37064891277" };
                Mother m3 = new Mother { Name = "Lily", Phone = "+37021036900" };

                db.Mothers.AddRange(new List<Mother> { m1, m2, m3 });

                Child ch1 = new Child { Name = "John", Age = 11, Mother = m1 };
                Child ch2 = new Child { Name = "Bob", Age = 3, Mother = m2 };
                Child ch3 = new Child { Name = "Lucy", Age = 6, Mother = m1 };

                m1.Children.Add(ch1);
                m1.Children.Add(ch3);
                m2.Children.Add(ch2);

                db.SaveChanges();

                var mothers = db.Mothers.ToList();

                foreach (var mother in mothers)
                {
                    Console.WriteLine($"{mother.Id}.{mother.Name} - {mother.Phone}");

                    if (mother.Children == null) continue;

                    foreach (var child in mother.Children)
                    {
                        Console.WriteLine($"\t{child.Name} {child.Age}");
                    }
                    Console.WriteLine("-----------------------------------------");
                }
                Console.ReadKey();
            }
        }
    }
}
