using System.Data.Entity;

namespace HomeTask2
{
    public class UniversityModel : DbContext
    {        
        public UniversityModel()
            : base("name=UniversityModel")
        {
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Discipline> Disciplines { get; set; }
    }
}