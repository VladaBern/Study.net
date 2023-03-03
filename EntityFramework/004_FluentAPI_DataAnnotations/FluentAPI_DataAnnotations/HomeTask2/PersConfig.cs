using System.Data.Entity.ModelConfiguration;

namespace HomeTask2
{
    internal class PersConfig : EntityTypeConfiguration<Person>
    {
        public PersConfig()
        {
            HasKey(p => p.PersonalId);
            Property(p => p.FirstName).IsRequired().HasMaxLength(20);
            Property(p => p.LastName).IsOptional().HasMaxLength(40);
        }
    }
}