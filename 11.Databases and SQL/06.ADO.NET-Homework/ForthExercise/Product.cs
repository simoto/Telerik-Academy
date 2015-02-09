namespace ForthExercise
{
    using System;

    public class Product
    {
        public Product(string name, int suppliedID, int categoryID, string quantityPerUnit, decimal unitPrice, int unitsInStock, int unitsOnOrder)
        {
            this.Name = name;
            this.SuppliedID = suppliedID;
            this.CategoryID = categoryID;
            this.QuantityPerUnit = quantityPerUnit;
            this.UnitPrice = unitPrice;
            this.UnitsInStock = unitsInStock;
            this.UnitsOnOrder = UnitsOnOrder;
        }

        public string Name { get; set; }

        public int SuppliedID { get; set; }

        public int CategoryID { get; set; }

        public string QuantityPerUnit { get; set; }

        public decimal UnitPrice { get; set; }

        public int UnitsInStock { get; set; }

        public int UnitsOnOrder { get; set; }

        public override string ToString()
        {
            string text = String.Format(
                "Product(ProductName = {0}, \n\tSuppliedID = {1}, \n\tCategoryID = {2}, \n\tQuantityPerUnit = {3}, \n\tUnitPrice = {4}, \n\tUnitInStock = {5}, \n\tUnitsOnOrder = {6})",
                this.Name, this.SuppliedID, this.CategoryID, this.QuantityPerUnit, this.UnitPrice, this.UnitsInStock, this.UnitsOnOrder);
            return text;
        }
    }
}