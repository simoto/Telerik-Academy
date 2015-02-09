namespace DataAccess
{
    using DatabaseFirst;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Customers
    {
        private static northwindEntities db;

        static void Main()
        {

        }

        public static void Insert(Customer person)
        {
            using(db = new northwindEntities())
            {
                db.Customers.Add(person);
                db.SaveChanges();
            }
        }
        
        public static void Modify(Customer person, Customer modified)
        {
            using(db = new northwindEntities())
            {
                var customer = db.Customers.FirstOrDefault(x => x.CustomerID == person.CustomerID);
                customer.Address = modified.Address;
                customer.City = modified.City;
                customer.CompanyName = modified.CompanyName;
                customer.ContactName = modified.ContactName;
                customer.ContactTitle = modified.ContactTitle;
                customer.Country = modified.Country;
                customer.CustomerDemographics = modified.CustomerDemographics;
                customer.CustomerID = modified.CustomerID;
                customer.Fax = modified.Fax;
                customer.Orders = modified.Orders;
                customer.Phone = modified.Phone;
                customer.PostalCode = modified.PostalCode;
                customer.Region = modified.Region;

                db.SaveChanges();
            }
        }

        public static void Delete(Customer person)
        {
            using(db = new northwindEntities())
            {
                db.Customers.Remove(person);
                db.SaveChanges();
            }
        }
    }
}
