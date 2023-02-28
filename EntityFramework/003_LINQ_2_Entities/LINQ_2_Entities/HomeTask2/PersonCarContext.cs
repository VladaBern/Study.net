using System.Data.Entity;

namespace HomeTask2
{
    public class PersonCarContext : DbContext
    {
        public PersonCarContext()
            : base("name=PersonCarContext")
        {
        }

        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
    }
}