namespace TelerikAcademyEntities
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {

            FirstExercise();

            ExerciseTwo();
        }

        static void FirstExercise()
        {
            using (var db = new TelerikAcademyEntities())
            {
                //without Include()
                foreach (var employee in db.Employees)
                {
                    Console.WriteLine("Employee: {0}; {1}; {2}",
                      employee.FirstName, employee.Department.Name,
                      employee.Address.Town.Name);
                }

                Console.WriteLine("--------------------------------------");

                //with Include()
                foreach (var employee in db.Employees.Include("Department").Include("Address"))
                {
                    Console.WriteLine("Product: {0}; {1}; {2}",
                      employee.FirstName, employee.Department.Name,
                      employee.Address.Town.Name);
                }
            }
        }

        static void ExerciseTwo()
        {
            using (var db = new TelerikAcademyEntities())
            {
                var wrongQuery = db.Employees.ToList().Select(x => x.Address).ToList().Select(y => y.Town).Where(t => t.Name == "Sofia");

                foreach (var item in wrongQuery)
                {
                    Console.WriteLine(item.Name);
                }


                var optimizedQuery = db.Employees.Select(x => x.Address).Select(y => y.Town).Where(t => t.Name == "Sofia");

                foreach (var item in optimizedQuery)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }
    }
}
