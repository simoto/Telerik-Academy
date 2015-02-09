using System;
using System.Data.SqlClient;

//Write a program that retrieves from the Northwind sample database in MS SQL Server the number of  rows in the Categories table.

class CountCategories
{
    static void Main()
    {
        SqlConnection dbCon = new SqlConnection("Server=SIMEON-PC; " +
            "Database=northwind; Integrated Security=true");
        dbCon.Open();
        using (dbCon)
        {
            SqlCommand cmdCount = new SqlCommand(
                "SELECT COUNT(*) FROM Categories", dbCon);
            int employeesCount = (int)cmdCount.ExecuteScalar();
            Console.WriteLine("Categories count: {0} ", employeesCount);
            Console.WriteLine();          
        }
    }
}