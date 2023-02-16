using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HomeTask1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-1LFDLAB;Initial Catalog=GrandSlamDB;Integrated Security=True";
            string commandString = "SELECT * FROM PlayerInfos";

            DataTable playerInfos = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(commandString, connectionString);
            adapter.Fill(playerInfos);

            DataView residencesMonaco = new DataView(playerInfos, "Residence = 'Monaco'", "PlayerId", DataViewRowState.OriginalRows);
            DataView residencesOtherCountries = new DataView(playerInfos, "NOT Residence = 'Monaco'", "PlayerId", DataViewRowState.OriginalRows);

            dataGridView1.DataSource = residencesMonaco;
            dataGridView2.DataSource = residencesOtherCountries;
        }
    }
}
