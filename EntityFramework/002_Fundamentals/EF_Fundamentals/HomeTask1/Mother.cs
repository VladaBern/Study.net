using System.Collections.Generic;

namespace HomeTask1
{
    public class Mother
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public ICollection<Child> Children { get; set; }

        public Mother()
        {
            Children = new List<Child>();
        }
    }
}