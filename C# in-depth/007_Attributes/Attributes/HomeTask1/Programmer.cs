namespace HomeTask1
{
    [AccessLevel(Access.ChangePassword)]
    internal class Programmer : User
    {
        public Programmer(string login, string password) : base(login, password) { }
    }
}
