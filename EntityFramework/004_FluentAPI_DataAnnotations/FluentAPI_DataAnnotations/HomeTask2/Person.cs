using System.Collections.Generic;

namespace HomeTask2
{
    public class Person
    {
        public int PersonalId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Mail> Mails { get; set; }

        public Person()
        {
            Mails = new List<Mail>();
        }
    }
}