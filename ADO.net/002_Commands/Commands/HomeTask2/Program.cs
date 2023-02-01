using System;
using System.Data.SqlClient;

namespace HomeTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string conStr = @"Data Source=DESKTOP-1LFDLAB; Initial Catalog=GrandSlamDB; Integrated Security=True;";
            SqlConnection sqlConnection = new SqlConnection(conStr);

            Console.WriteLine("Enter playerID");
            int playerID = int.Parse(Console.ReadLine());

            SqlCommand cmd = new SqlCommand("selectAthlete", sqlConnection) { CommandType = System.Data.CommandType.StoredProcedure };

            cmd.Parameters.AddWithValue("@playerId", playerID);

            sqlConnection.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                    Console.WriteLine("{0}: {1}", reader.GetName(i), reader[i]);

                Console.WriteLine();
            }

            sqlConnection.Close();
        }
    }
}
