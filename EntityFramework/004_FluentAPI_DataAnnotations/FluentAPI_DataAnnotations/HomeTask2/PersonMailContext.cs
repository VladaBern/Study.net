using System.Data.Entity;

namespace HomeTask2
{
    public class PersonMailContext : DbContext
    {
        static PersonMailContext()
        {
            Database.SetInitializer(new DropCreatePeronMailDb());
        }

        public PersonMailContext()
            : base("name=PersonMailContext")
        {
        }
                
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Mail> Mails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new PersConfig());
            modelBuilder.Configurations.Add(new MailConfig());
        }

    }
}