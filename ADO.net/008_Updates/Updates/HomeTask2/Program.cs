using System;
using System.Data;
using System.Data.SqlClient;

namespace HomeTask2
{
    internal class Program
    {
        static void ShowStudents(DataTable students)
        {
            foreach (DataRow row in students.Rows)
            {
                foreach (DataColumn column in students.Columns)
                    Console.WriteLine("{0}: {1}", column.ColumnName, row[column]);

                Console.WriteLine();
            }

            Console.WriteLine(new string('-', 25));
        }

        private static void ConfigureStudentsAdapter(SqlDataAdapter studentsAdapter)
        {
            string commandString = "UPDATE Students " +
                              "SET FName = @FName," +
                              "LName= @LName," +
                              "AdmissionYear = @AdmissionYear," +
                              "Faculty = @Faculty," +
                              "WHERE StNumber = @StNumber";

            studentsAdapter.UpdateCommand = new SqlCommand(commandString, studentsAdapter.SelectCommand.Connection);

            var updateParameters = studentsAdapter.UpdateCommand.Parameters;
            updateParameters.Add("StNumber", SqlDbType.Int, 0, "StNumber");
            updateParameters.Add("FName", SqlDbType.NVarChar, 20, "FName");
            updateParameters.Add("LName", SqlDbType.NVarChar, 20, "Lname");
            updateParameters.Add("AdmissionYear", SqlDbType.Date, 10, "AdmissionYear");
            updateParameters.Add("Faculty", SqlDbType.Int, 0, "Faculty");

            studentsAdapter.DeleteCommand = new SqlCommand("DELETE Students WHERE StNumber = @StNumber", studentsAdapter.SelectCommand.Connection);

            var deleteParameters = studentsAdapter.DeleteCommand.Parameters;
            deleteParameters.Add("@StNumber", SqlDbType.Int, 0, "StNumber");

            studentsAdapter.InsertCommand =
                        new SqlCommand("INSERT Students " +
                                       "VALUES (@StNumber, @FName, @LName, @AdmissionYear, @Faculty);",
                                       studentsAdapter.SelectCommand.Connection);

            var insertParameters = studentsAdapter.InsertCommand.Parameters;
            insertParameters.Add("StNumber", SqlDbType.Int, 0, "StNumber");
            insertParameters.Add("FName", SqlDbType.NVarChar, 20, "FName");
            insertParameters.Add("LName", SqlDbType.NVarChar, 20, "Lname");
            insertParameters.Add("AdmissionYear", SqlDbType.Date, 10, "AdmissionYear");
            insertParameters.Add("Faculty", SqlDbType.Int, 0, "Faculty");
        }

        static void Main(string[] args)
        {
            string connectionString = @"Data Source=DESKTOP-1LFDLAB;Initial Catalog=University;Integrated Security=True";
            string commandString = "SELECT * FROM Students";

            DataTable students = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(commandString, connectionString);
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            adapter.Fill(students);

            Console.WriteLine("Students before changing\n");

            ShowStudents(students);

            ConfigureStudentsAdapter(adapter);

            students.LoadDataRow(new object[] { 11111, "TEST", "TEST", "9999/12/31", 1}, false);

            adapter.Update(students);

            students.Clear();

            adapter.Fill(students);

            Console.WriteLine("\nStudents after adding\n");
            ShowStudents(students);

            ConfigureStudentsAdapter(adapter);

            DataRow[] rowsToDelete = students.Select("FName = 'TEST'");

            foreach (var row in rowsToDelete)
            {
                row.Delete();
            }

            adapter.Update(students);

            Console.WriteLine("\nStudents after deleting\n");
            ShowStudents(students);
        }
    }
}
