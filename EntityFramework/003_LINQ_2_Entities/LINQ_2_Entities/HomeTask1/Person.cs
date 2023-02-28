using System.Collections.Generic;

namespace HomeTask1
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public ICollection<Dog> Dogs { get; set; }

        public Person()
        {
            Dogs = new List<Dog>();
        }
    }
}