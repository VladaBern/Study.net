using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HomeTask2
{
    public partial class Form1 : Form
    {
        DataSet ds = new DataSet();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-1LFDLAB;Initial Catalog=GrandSlamDB;Integrated Security=True";
            string commandString = "SELECT * FROM PlayerInfos";

            SqlDataAdapter adapter = new SqlDataAdapter(commandString, connectionString);

            adapter.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            dataGridView2.DataSource = ds.GetChanges(DataRowState.Modified).Tables[0];
        }
    }
}
