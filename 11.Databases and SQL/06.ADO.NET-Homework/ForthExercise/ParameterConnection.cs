using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;

namespace ForthExercise
{
    class ParameterConnection
    {
        private SqlConnection dbCon;

        static void Main()
        {
            ParameterConnection example = new ParameterConnection();

            decimal price = 10.000m;
            int newProjectId = example.InsertProduct("Milka", 1, 3, "10 per 1", price, 20, 5);
            Console.WriteLine("Inserted new project. " +
                "ProjectID = {0}", newProjectId);


        }

        private int InsertProduct(string productName, int suppliedID, int categoryID, string quantityPerUnit, decimal unitPrice, int unitsInStock, int unitsOnOrder)
        {
            SqlConnection dbCon = new SqlConnection("Server=SIMEON-PC; " +
                "Database=northwind; Integrated Security=true");
            dbCon.Open();
            using (dbCon)
            {
                SqlCommand cmdInsertProduct = new SqlCommand(
                "INSERT INTO Products(ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder) " +
                "VALUES (@productName, @supplierID, @categoryID, @quantityPerUnit, @unitPrice, @unitsInStock, @unitsOnOrder)", dbCon);
                cmdInsertProduct.Parameters.AddWithValue("@productName", productName);
                cmdInsertProduct.Parameters.AddWithValue("@supplierID", suppliedID);
                cmdInsertProduct.Parameters.AddWithValue("@categoryID", categoryID);
                cmdInsertProduct.Parameters.AddWithValue("@quantityPerUnit", quantityPerUnit);
                cmdInsertProduct.Parameters.AddWithValue("@unitPrice", unitPrice);
                cmdInsertProduct.Parameters.AddWithValue("@unitsInStock", unitsInStock);
                cmdInsertProduct.Parameters.AddWithValue("@unitsOnOrder", unitsOnOrder);
                cmdInsertProduct.ExecuteNonQuery();

                SqlCommand cmdSelectIdentity = new SqlCommand("SELECT @@Identity", dbCon);
                int insertedRecordId = (int)(decimal)cmdSelectIdentity.ExecuteScalar();
                return insertedRecordId;
            }

        }
    }
}
