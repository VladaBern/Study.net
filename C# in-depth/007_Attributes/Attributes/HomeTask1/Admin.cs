namespace HomeTask1
{
    [AccessLevel(Access.AddUser)]
    [AccessLevel(Access.DeleteUser)]
    [AccessLevel(Access.ChangePassword)]
    [AccessLevel(Access.ChangePosition)]
    internal class Admin : User
    {
        public Admin(string login, string password) : base(login, password) { }
    }
}
