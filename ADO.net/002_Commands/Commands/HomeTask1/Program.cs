using System;
using System.Data.SqlClient;

namespace HomeTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conStr = @"Data Source=DESKTOP-1LFDLAB; Initial Catalog=GrandSlamDB; Integrated Security=True;";
            using (SqlConnection sqlConnection = new SqlConnection(conStr))
            {
                sqlConnection.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Players", sqlConnection);

                using (SqlDataReader dataReader = cmd.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        for (int i = 0; i < dataReader.FieldCount; i++)
                            Console.WriteLine(dataReader.GetName(i) + " : " + dataReader[i]);

                        Console.WriteLine(new string('_', 20));
                    }
                }
            }
        }
    }
}
