using System;
using System.Data.SqlClient;

//Write a program that retrieves the name and description of all categories in the Northwind DB.

class Program
{
    static void Main()
    {
        SqlConnection dbCon = new SqlConnection("Server=SIMEON-PC; " +
            "Database=northwind; Integrated Security=true");
        dbCon.Open();
        using (dbCon)
        {
            Console.WriteLine("All categories in northwind: ");
            SqlCommand cmdAllEmployees = new SqlCommand(
              "SELECT * FROM Categories", dbCon);
            SqlDataReader reader = cmdAllEmployees.ExecuteReader();
            using (reader)
            {
                while (reader.Read())
                {
                    string categoryName = (string)reader["CategoryName"];
                    string description = (string)reader["Description"];
                    Console.WriteLine("{0} - {1}", categoryName, description);
                }
            }
        }
    }
}
