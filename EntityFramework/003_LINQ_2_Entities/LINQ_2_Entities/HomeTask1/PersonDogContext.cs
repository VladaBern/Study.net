using System.Data.Entity;

namespace HomeTask1
{
    public class PersonDogContext : DbContext
    {
        public PersonDogContext()
            : base("name=PersonDogContext")
        {
        }

        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Dog> Dogs { get; set; }
    }
}