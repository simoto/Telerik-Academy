using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TelerikAcademy
{
    class Program
    {
        static void Main()
        {
            var db = new TelerikAcademy();
            foreach (var employee in db.Employees)
            {
                Console.WriteLine("Employee: {0}; {1}; {2}", employee.FirstName, employee.DepartmentID, employee.Extension);
            }
        }
    }
}

//foreach (var product in context.Products)
//{
//  Console.WriteLine("Product: {0}; {1}; {2}",
//    product.ProductName, product.Supplier.CompanyName,
//    product.Category.CategoryName);
//}

//foreach (var product in context.Products.
//  Include("Supplier").Include("Category"))
//{
//  Console.WriteLine("Product: {0}; {1}; {2}",
//    product.ProductName, product.Supplier.CompanyName,
//    product.Category.CategoryName);
//}
