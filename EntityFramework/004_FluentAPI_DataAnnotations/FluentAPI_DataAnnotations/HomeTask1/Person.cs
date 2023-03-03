using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HomeTask1
{
    public class Person
    {
        [Key]
        public int PersonalNumber { get; set; }

        [Required, MinLength(3), MaxLength(20)]
        public string FirstName { get; set; }

        [MaxLength(30)]
        public string LastName { get; set; }

        public ICollection<Phone> Phones { get; set; }

        public Person()
        {
            Phones = new List<Phone>();
        }
    }
}