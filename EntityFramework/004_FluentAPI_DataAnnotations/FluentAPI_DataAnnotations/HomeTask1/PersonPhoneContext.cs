using System.Data.Entity;

namespace HomeTask1
{
    public class PersonPhoneContext : DbContext
    {   
        static PersonPhoneContext()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<PersonPhoneContext>());
        }

        public PersonPhoneContext()
            : base("name=PersonPhoneContext")
        {
        }

        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Phone> Phones { get; set; }
    }
}