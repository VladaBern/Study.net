using System.Collections.Generic;

namespace HomeTask2
{
    public class Woman
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public ICollection<Ring> Rings { get; set; }

        public Woman()
        {
            Rings = new List<Ring>();
        }
    }
}