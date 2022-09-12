using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// Создайте пользовательский атрибут AccessLevelAttribute, позволяющий определить
// уровень доступа пользователя к системе. Сформируйте состав сотрудников некоторой фирмы
// в виде набора классов, например, Manager, Programmer, Director. При помощи атрибута
// AccessLevelAttribute распределите уровни доступа персонала и отобразите на экране
// реакцию системы на попытку каждого сотрудника получить доступ в защищенную секцию. 

namespace HomeTask1
{
    internal class Program
    {
        const string FileName = "Users.txt";
        private static List<User> users = new List<User>() { new Admin("root", "010203") };
        private static User currentUser;

        static User GetUser()
        {
            Console.WriteLine("Enter login");
            string login = Console.ReadLine();
            var user = users.FirstOrDefault(x => x.IsLoginEquel(login));
            return user;
        }

        static void LoadUsers()
        {
            if (File.Exists(FileName) == true)
            {
                var lines = File.ReadAllLines(FileName);

                foreach (var line in lines)
                {
                    var words = line.Split(' ');
                    users.Add(CreateUser(words[0], words[1], words[2]));
                }
            }
        }

        static void Login()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Enter login");
                string login = Console.ReadLine();
                Console.WriteLine("Enter password");
                string password = Console.ReadLine();

                foreach (var user in users)
                {
                    if (user.IsValid(login, password) == true)
                    {
                        currentUser = user;
                        return;
                    }
                }

                Console.WriteLine("Invalid login or password!");
                Console.ReadKey();
            }
        }

        static int ChooseCommand()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1.Add new user.");
                Console.WriteLine("2.Delete user.");
                Console.WriteLine("3.Change password.");
                Console.WriteLine("4.Change position.");
                Console.WriteLine("5.Exit.");
                Console.WriteLine("\nEnter the number of operation");
                int operation = Convert.ToInt32(Console.ReadLine());

                if (operation > 0 && operation < 6)
                    return operation;
                else
                {
                    Console.WriteLine("Invalid command");
                    Console.ReadKey();
                }
            }
        }

        static User CreateUser(string login, string password, string position)
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

        static void AddUser()
        {
            HaveAccess(Access.AddUser);

            Console.WriteLine("Enter login");
            string login = Console.ReadLine();
            Console.WriteLine("Enter password");
            string password = Console.ReadLine();
            Console.WriteLine("Enter position");
            string position = Console.ReadLine();

            users.Add(CreateUser(login, password, position));
            Console.WriteLine("User added!");
        }

        static void DeleteUser()
        {
            HaveAccess(Access.DeleteUser);

            var user = GetUser();

            if (user != null)
            {
                if (user is Admin)
                {
                    Console.WriteLine("It is forbidden to delete and change the admin");
                }
                else
                {
                    users.Remove(user);
                    Console.WriteLine("User deleted!");
                }
            }
            else
            {
                Console.WriteLine("User doesn't exist");
            }
        }

        static void ChangePassword()
        {
            HaveAccess(Access.ChangePassword);

            var user = GetUser();

            if (user != null)
            {
                if (user is Admin)
                {
                    Console.WriteLine("It is forbidden to delete and change the admin");
                }
                else
                {
                    Console.WriteLine("Enter new password");
                    string newPassword = Console.ReadLine();
                    user.ChangePassword(newPassword);
                    Console.WriteLine("Password changed!");
                }
            }
            else
            {
                Console.WriteLine("User doesn't exist");
            }
        }

        static void ChangePosition()
        {
            HaveAccess(Access.ChangePosition);

            var user = GetUser();

            if (user != null)
            {
                if (user is Admin)
                {
                    Console.WriteLine("It is forbidden to delete and change the admin");
                }
                else
                {
                    Console.WriteLine("Enter new position");
                    string newPosition = Console.ReadLine();
                    users.Add(user.ChangePosition(newPosition));
                    users.Remove(user);
                    Console.WriteLine("Position changed!");
                }
            }
            else
            {
                Console.WriteLine("User doesn't exist");
            }
        }

        static void SaveToFile()
        {
            File.Delete(FileName);

            if (users.Count > 1)
            {
                File.AppendAllLines(FileName, users.Where(x => !(x is Admin)).Select(x => x.ToString()));
            }
        }

        static void HaveAccess(Access access)
        {
            var attributes = currentUser.GetType().GetCustomAttributes(typeof(AccessLevelAttribute), true);
            foreach (AccessLevelAttribute attribute in attributes)
            {
                if (attribute.Access == access)
                {
                    return;
                }
            }
            throw new Exception("No permission!");
        }

        static void Main()
        {
            LoadUsers();
            Login();

            while (true)
            {
                try
                {
                    int command = ChooseCommand();
                    switch (command)
                    {
                        case 1:
                            {
                                AddUser();
                                break;
                            }
                        case 2:
                            {
                                DeleteUser();
                                break;
                            }
                        case 3:
                            {
                                ChangePassword();
                                break;
                            }
                        case 4:
                            {
                                ChangePosition();
                                break;
                            }
                        case 5:
                            {
                                SaveToFile();
                                return;
                            }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.ReadKey();
            }
        }
    }
}
