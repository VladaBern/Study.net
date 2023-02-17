using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HomeTask1
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=DESKTOP-1LFDLAB;Initial Catalog=University;Integrated Security=True";
        string commandString = "SELECT * FROM Students";
        SqlConnection connection;
        SqlDataAdapter adapter;
        SqlCommandBuilder builder;
        DataSet students;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(commandString, connection);
            builder = new SqlCommandBuilder(adapter);

            connection.Open();

            students = new DataSet();
            adapter.Fill(students);

            dataGridView1.DataSource = students.Tables[0];

            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();

            builder.GetUpdateCommand();
            adapter.Update(students);

            connection.Close();
        }
    }
}
