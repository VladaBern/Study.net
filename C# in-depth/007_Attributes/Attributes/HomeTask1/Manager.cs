namespace HomeTask1
{
    [AccessLevel(Access.DeleteUser)]
    internal class Manager : User
    {
        public Manager(string login, string password) : base(login, password) { }
    }
}
