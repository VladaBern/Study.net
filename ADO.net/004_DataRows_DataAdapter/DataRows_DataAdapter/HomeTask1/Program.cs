using System;
using System.Data;

namespace HomeTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add(new DataColumn("Name"));

            DataRow row = dataTable.NewRow();
            row[0] = "Anna";
            Console.WriteLine(row.RowState);

            dataTable.Rows.Add(row);
            Console.WriteLine(row.RowState);

            dataTable.AcceptChanges();
            Console.WriteLine(row.RowState);

            dataTable.Rows[0].SetModified();
            Console.WriteLine(row.RowState);

            dataTable.Rows[0].Delete();
            Console.WriteLine(row.RowState);

            Console.ReadKey();
        }
    }
}
