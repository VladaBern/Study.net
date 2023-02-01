using System;
using System.Data.SqlClient;

namespace HomeTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();

            stringBuilder.DataSource = @"DESKTOP-1LFDLAB";
            stringBuilder.InitialCatalog = "MyDB";

            Console.WriteLine("Enter user Id");
            string userId = Console.ReadLine();
            stringBuilder.UserID = userId;

            Console.WriteLine("Enter a password");
            string password = Console.ReadLine();
            stringBuilder.Password = password;

            using (SqlConnection connection = new SqlConnection(stringBuilder.ConnectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine(connection.State);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.ReadKey();
        }
    }
}
