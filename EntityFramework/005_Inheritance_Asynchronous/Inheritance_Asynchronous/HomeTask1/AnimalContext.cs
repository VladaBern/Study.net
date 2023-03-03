using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace HomeTask1
{
    public class AnimalContext : DbContext
    {
        static AnimalContext()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<AnimalContext>());
        }

        public AnimalContext()
            : base("name=AnimalContext")
        {
        }

        public virtual DbSet<Animal> Animals { get; set; }
        public virtual DbSet<Dog> Dogs { get; set; }
    }

    public class Animal
    {
        [Key]
        public int AnimalNumber { get; set; }
        [Required, MaxLength(20)]
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Dog : Animal
    {
        [MaxLength(35)]
        public string Breed { get; set; }
    }


}