using System.Data.Entity.ModelConfiguration;

namespace HomeTask2
{
    internal class WomanConfig : EntityTypeConfiguration<Woman>
    {
        public WomanConfig()
        {
            HasKey(w => w.Id);
            Property(w => w.Name).IsRequired().HasMaxLength(50);
            Property(w => w.Phone).IsOptional();
        }
    }
}