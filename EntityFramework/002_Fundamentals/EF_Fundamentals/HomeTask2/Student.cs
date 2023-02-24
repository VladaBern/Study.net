using System.Collections.Generic;

namespace HomeTask2
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AdmissionYear { get; set; }
        public ICollection<Teacher> Teachers { get; set; }

        public Student()
        {
            Teachers = new List<Teacher>();
        }
    }
}