using System.Collections.Generic;

namespace HomeTask2
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Discipline> Disciplines { get; set; }

        public Teacher()
        {
            Students = new List<Student>();
            Disciplines = new List<Discipline>();
        }
    }
}