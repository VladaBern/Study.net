using System;
using System.Data;
using System.Data.SqlClient;

namespace HomeTask1
{
    internal class Program
    {
        private static DataTable CreateSchemaFromReader(SqlDataReader reader, string tableName)
        {
            DataTable table = new DataTable(tableName);

            for (int i = 0; i < reader.FieldCount; i++)
                table.Columns.Add(new DataColumn(reader.GetName(i), reader.GetFieldType(i)));

            return table;
        }

        private static void WriteDataFromReader(DataTable table, SqlDataReader reader)
        {
            while (reader.Read())
            {
                DataRow row = table.NewRow();

                for (int i = 0; i < reader.FieldCount; i++)
                    row[i] = reader[i];

                table.Rows.Add(row);
            }
        }

        static void Main(string[] args)
        {
            string conStr = @"Data Source = DESKTOP-1LFDLAB; Initial Catalog = GrandSlamDB; Integrated Security = True;";

            using (SqlConnection connection = new SqlConnection(conStr))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM PlayerInfos", connection);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable table = CreateSchemaFromReader(reader, "PlayerInfos");

                    foreach (DataColumn column in table.Columns)
                        Console.WriteLine($"{column.ColumnName} : {column.DataType}");

                    WriteDataFromReader(table, reader);
                    Console.WriteLine();

                    foreach (DataRow row in table.Rows)
                    {
                        foreach (DataColumn column in table.Columns)
                            Console.WriteLine($"{column.ColumnName} : {row[column]}");

                        Console.WriteLine();
                    }
                }
            }            
        }
    }
}
