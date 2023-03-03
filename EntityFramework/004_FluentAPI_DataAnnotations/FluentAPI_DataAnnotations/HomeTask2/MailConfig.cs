using System.Data.Entity.ModelConfiguration;

namespace HomeTask2
{
    internal class MailConfig : EntityTypeConfiguration<Mail>
    {
        public MailConfig()
        {
            HasKey(m => m.Id);
            Property(m => m.Address).IsRequired().HasColumnName("MailAddress");
        }
    }
}