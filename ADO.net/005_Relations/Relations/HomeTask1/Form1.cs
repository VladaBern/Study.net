using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HomeTask1
{
    public partial class Form1 : Form
    {
        DataSet universityDB = new DataSet("University");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-1LFDLAB;Initial Catalog=University;Integrated Security=True";
            string commandString = "SELECT StNumber, FName, LName FROM Students; " +
                                   "SELECT Id, FName, LName FROM Teachers; " +
                                   "SELECT * FROM Disciplines; " +
                                   "SELECT Id, Discipline, StudentId, TeacherId, Mark FROM Exams;";

            SqlDataAdapter adapter = new SqlDataAdapter(commandString, connectionString);

            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            adapter.TableMappings.Add("Table", "Students");
            adapter.TableMappings.Add("Table1", "Teachers");
            adapter.TableMappings.Add("Table2", "Disciplines");
            adapter.TableMappings.Add("Table3", "Exams");

            adapter.Fill(universityDB);

            var students = universityDB.Tables["Students"];
            var teachers = universityDB.Tables["Teachers"];
            var disciplines = universityDB.Tables["Disciplines"];
            var exams = universityDB.Tables["Exams"];

            universityDB.Relations.Add("Students_Exams", students.Columns["StNumber"], exams.Columns["StudentId"]);
            universityDB.Relations.Add("Teachers_Exams", teachers.Columns["Id"], exams.Columns["TeacherId"]);
            universityDB.Relations.Add("Disciplines_Exams", disciplines.Columns["Id"], exams.Columns["Discipline"]);

            students.Columns.Add("Number of exams", typeof(int), "COUNT(Child(Students_Exams).StudentId)");
            disciplines.Columns.Add("Number of exams", typeof(int), "COUNT(Child(Disciplines_Exams).Discipline)");
            exams.Columns.Add("Discipline name", typeof(string), "Parent(Disciplines_Exams).Name");
        }

        private void examNumbForSt_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = universityDB.Tables[0];
        }

        private void examNumbOfDisc_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = universityDB.Tables[2];
        }

        private void examInfo_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = universityDB.Tables[3];
        }
    }
}
