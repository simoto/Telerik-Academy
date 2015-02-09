using System;
using System.Data.SqlClient;

//Write a program that retrieves from the Northwind database all product categories and the names of the products in each category.
//Can you do this with a single SQL query (with table join)?

class Program
{
    static void Main()
    {
        SqlConnection dbCon = new SqlConnection("Server=SIMEON-PC; " +
        "Database=northwind; Integrated Security=true");
        dbCon.Open();
        using (dbCon)
        {
            Console.WriteLine("All products with categories in northwind: ");
            SqlCommand cmdAllEmployees = new SqlCommand(
              "SELECT p.ProductName, c.CategoryName FROM Products p, Categories c WHERE p.CategoryID = c.CategoryID", dbCon);
            SqlDataReader reader = cmdAllEmployees.ExecuteReader();
            using (reader)
            {
                while (reader.Read())
                {
                    string categoryName = (string)reader["ProductName"];
                    string description = (string)reader["CategoryName"];
                    Console.WriteLine("{0} - {1}", categoryName, description);
                }
            }
        }
    }
}
