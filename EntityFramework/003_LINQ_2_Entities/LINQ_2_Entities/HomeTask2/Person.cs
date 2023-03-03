using System.Collections.Generic;

namespace HomeTask2
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public ICollection<Car> Cars { get; set; }

        public Person()
        {
            Cars = new List<Car>();
        }
    }
}