using System;
using System.Data;
using System.Data.SqlClient;

namespace HomeTask2
{
    internal class Program
    {
        public static void ShowFromTable(DataTable table)
        {
            foreach (DataRow dr in table.Rows)
            {
                foreach (var item in dr.ItemArray)
                    Console.WriteLine(item);

                Console.WriteLine(new String('-', 20));
            }
        }

        public static void LoadWithSchema(DataTable table, SqlDataReader reader)
        {
            table.Load(reader);
        }

        static void Main(string[] args)
        {
            string conStr = @"Data Source=DESKTOP-1LFDLAB; Initial Catalog=University; Integrated Security=True;";

            DataSet university = new DataSet();
            DataTable students = new DataTable("Students");
            DataTable teachers = new DataTable("Teachers");
            DataTable exams = new DataTable("Exams");

            using (SqlConnection connection = new SqlConnection(conStr))
            {
                connection.Open();

                SqlCommand studentsCmd = new SqlCommand("SELECT StNumber, FName, LName FROM Students", connection);
                SqlCommand teachersCmd = new SqlCommand("SELECT Id, FName, LName FROM Teachers", connection);
                SqlCommand examsCmd = new SqlCommand("SELECT Id, StudentId, TeacherId, Mark FROM Exams", connection);

                using (SqlDataReader studentsReader = studentsCmd.ExecuteReader())
                    LoadWithSchema(students, studentsReader);

                using (SqlDataReader teachersReader = teachersCmd.ExecuteReader())
                    LoadWithSchema(teachers, teachersReader);

                using (SqlDataReader examsReader = examsCmd.ExecuteReader())
                    LoadWithSchema(exams, examsReader);
            }

            students.PrimaryKey = new DataColumn[] { students.Columns[0] };
            teachers.PrimaryKey = new DataColumn[] { teachers.Columns[0] };
            exams.PrimaryKey = new DataColumn[] { exams.Columns[0] };

            university.Tables.AddRange(new DataTable[] { students, teachers, exams });

            var FK_StudentExam = new ForeignKeyConstraint(students.Columns["StNumber"], exams.Columns["StudentId"]);
            exams.Constraints.Add(FK_StudentExam);

            var FK_TeacherExam = new ForeignKeyConstraint(teachers.Columns["Id"], exams.Columns["TeacherId"]);
            exams.Constraints.Add(FK_TeacherExam);
            
            exams.Rows.Add(30, 369852, 2, 9);

            ShowFromTable(exams);
        }
    }
}
