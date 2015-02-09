namespace SixthExercise
{
    using System;
    using System.Data.OleDb;

    class ExcelRead
    {
        static void Main()
        {
            OleDbConnection dbConnection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;" +
                @"Data Source=..\..\file.xls;Extended Properties=""Excel 12.0 XML;HDR=Yes""");

            OleDbCommand command = new OleDbCommand("SELECT * FROM [Sheet1$]", dbConnection);

            dbConnection.Open();

            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string name = (string)reader["Name"];
                double score = (double)reader["Score"];

                Console.WriteLine("Name: {0}, Score: {1}", name, score);
            }
        }
    }
}
