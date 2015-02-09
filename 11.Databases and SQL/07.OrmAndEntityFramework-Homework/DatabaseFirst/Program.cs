//1.Using the Visual Studio Entity Framework designer create a DbContext for the Northwind database

namespace DatabaseFirst
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new northwindEntities())
            {               
            }
        }
    }
}
