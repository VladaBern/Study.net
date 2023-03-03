using System.Data.Entity;

namespace HomeTask2
{
    public class WomanRingContext : DbContext
    {
        static WomanRingContext()
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<WomanRingContext>());
        }

        public WomanRingContext()
            : base("name=WomanRingContext")
        {
        }

        public virtual DbSet<Woman> Women { get; set; }
        public virtual DbSet<Ring> Rings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new WomanConfig());
            modelBuilder.Configurations.Add(new RingConfig());
        }
    }
}