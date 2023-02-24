using System.Collections.Generic;

namespace HomeTask2
{
    public class Discipline
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Teacher> Teachers { get; set; }

        public Discipline()
        {
            Teachers = new List<Teacher>();
        }
    }
}