namespace HomeWork2
{
    abstract class Citizen
    {
        private string passportNumber;
        private string name;
        private string surname;
        private int age;

        public Citizen(string passportNumber, string name, string surname, int age)
        {
            this.passportNumber = passportNumber;
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            var citizen = obj as Citizen;
            if (citizen == null)
                return false;

            return passportNumber.Equals(citizen.passportNumber);
        }

        public override int GetHashCode()
        {
            return passportNumber.GetHashCode();
        }
    }
}
