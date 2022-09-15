namespace HomeTask1
{
    [AccessLevel(Access.AddUser)]
    [AccessLevel(Access.DeleteUser)]
    [AccessLevel(Access.ChangePosition)]
    internal class Director : User
    {
        public Director(string login, string password) : base(login, password) { }
    }
}
