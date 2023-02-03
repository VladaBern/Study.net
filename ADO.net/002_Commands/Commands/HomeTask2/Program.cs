using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace HomeTask2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string conStr = @"Data Source=DESKTOP-1LFDLAB; Initial Catalog=GrandSlamDB; Integrated Security=True;";
            using (SqlConnection sqlConnection = new SqlConnection(conStr))
            {

                Console.WriteLine("Enter playerID");
                int playerID = int.Parse(Console.ReadLine());

                await sqlConnection.OpenAsync();

                SqlCommand cmd = new SqlCommand("selectAthlete", sqlConnection) { CommandType = System.Data.CommandType.StoredProcedure };

                SqlParameter parameter = cmd.Parameters.Add(new SqlParameter("@playerId", SqlDbType.Int));
                parameter.Direction = System.Data.ParameterDirection.Input;
                parameter.Value = playerID;

                await cmd.ExecuteNonQueryAsync();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                            Console.WriteLine("{0}: {1}", reader.GetName(i), reader[i]);

                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
