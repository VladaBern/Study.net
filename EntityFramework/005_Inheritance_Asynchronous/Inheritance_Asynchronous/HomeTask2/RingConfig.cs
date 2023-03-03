using System.Data.Entity.ModelConfiguration;

namespace HomeTask2
{
    internal class RingConfig : EntityTypeConfiguration<Ring>
    {
        public RingConfig()
        {
            HasKey(r => r.SerialNumber);
            Property(r => r.Material).IsRequired().HasMaxLength(30);
            Property(r => r.Size).IsRequired();
        }
    }
}