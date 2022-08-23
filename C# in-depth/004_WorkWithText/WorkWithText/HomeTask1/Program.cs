using System;
using System.Text.RegularExpressions;

namespace HomeTask1
{
    internal class Program
    {
        static void Main()
        {
            string usernamePattern = @"^[A-Za-z]+$";
            string passwordPattern = @"^[A-Za-z0-9]+$";

            var regexUsername = new Regex(usernamePattern);
            var regexPassword = new Regex(passwordPattern);

            while (true)
            {
                Console.WriteLine("Enter a username:");
                string username = Console.ReadLine();
                Console.WriteLine("Enter a password");
                string password = Console.ReadLine();

                if (regexUsername.IsMatch(username) && regexPassword.IsMatch(password))
                {
                    Console.WriteLine("Registration completed successfully");
                    break;
                }
                else
                {
                    Console.WriteLine("You have entered an incorrect username or password. Try again");
                }
            }
        }
    }
}
