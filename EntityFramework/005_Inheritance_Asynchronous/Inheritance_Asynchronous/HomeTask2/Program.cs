using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTask2
{
    internal class Program
    {
        public static async Task GetWomenAsync()
        {
            using (var db = new WomanRingContext())
            {
                await db.Women.ForEachAsync(w =>
                {
                    Console.WriteLine($"{w.Id}.{w.Name} {w.Phone}");
                });
            }
        }
        public static async Task GetRingsAsync()
        {
            using (var db = new WomanRingContext())
            {
                await db.Rings.ForEachAsync(r =>
                {
                    Console.WriteLine($"{r.SerialNumber}.{r.Size} - {r.Material}");
                });
            }
        }

        static void Main(string[] args)
        {
            using (var db = new WomanRingContext())
            {
                db.Rings.Add(new Ring { Size = 16, Material = "Gold" });
                db.Rings.Add(new Ring { Size = 18, Material = "Silver" });
                db.Rings.Add(new Ring { Size = 15, Material = "Gold" });

                Task task = db.SaveChangesAsync();
                task.Wait();

                db.Women.Add(new Woman { Name = "Kate", Phone = "+37025984612", Rings = new List<Ring> { db.Rings.First(r => r.SerialNumber == 2) } });
                db.Women.Add(new Woman { Name = "Sara", Phone = "+37098966103", Rings = new List<Ring> { db.Rings.First(r => r.SerialNumber == 1) } });
                db.Women.Add(new Woman { Name = "Kira", Rings = new List<Ring> { db.Rings.First(r => r.SerialNumber == 3) } });

                task = db.SaveChangesAsync();
                task.Wait();

                Console.WriteLine("Women:");
                task = GetWomenAsync();
                task.Wait();

                Console.WriteLine("Rings:");
                task = GetRingsAsync();
                task.Wait();
            }
        }
    }
}
