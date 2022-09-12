using System;

namespace HomeTask1
{
    internal class User
    {
        private string login;
        private string password;

        public User(string login, string password)
        {
            this.login = login;
            this.password = password;
        }

        public bool IsValid(string login, string password)
        {
            return login == this.login && password == this.password;
        }

        public bool IsLoginEquel(string login)
        {
            return login == this.login;
        }

        public void ChangePassword(string password)
        {
            if (password != null)
            {
                this.password = password;
            }
            else
            {
                Console.WriteLine("Invalid password");
            }
        }

        public User ChangePosition(string position)
        {
            switch (position)
            {
                case "manager":
                    {
                        return new Manager(login, password);
                    }
                case "programmer":
                    {
                        return new Programmer(login, password);
                    }
                case "director":
                    {
                        return new Director(login, password);
                    }
                default:
                    {
                        throw new Exception("Invalid position");
                    }
            }
        }

        public override string ToString()
        {
            return $"{login} {password} {this.GetType().Name.ToLower()}";
        }
    }
}
