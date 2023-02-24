using System.Data.Entity;

namespace HomeTask1
{
    public class MotherChildrenModel : DbContext
    {
        public MotherChildrenModel()
            : base("name=MotherChildrenModel")
        {
        }

        public virtual DbSet<Mother> Mothers { get; set; }
        public virtual DbSet<Child> Children { get; set; }
    }
}