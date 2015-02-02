namespace Homework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main()
        {
            //Demo Exercise 1-2
            string a = "I am crazy!";
            StringBuilder test = new StringBuilder();
            test.Append(a);
            test = test.Substring(3, 7);
            Console.WriteLine(test.ToString());

            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
            int sumOfNumbers = numbers.Sum<int>();
            Console.WriteLine(sumOfNumbers);

            int averageNum = numbers.Average<int>();
            Console.WriteLine(averageNum);

            List<string> students = new List<string>() { "Pesho", "Gesho", "Kiro", "Miro", "Vampiro" };

            //Exercise 3
            var SortedStudents = Order(students);

            foreach (var item in SortedStudents)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Students[] studentss = {
                    new Students("Pesho", "Geshev", 15),
                    new Students("Gesho", "Peshkata", 18),
                    new Students("Veselin", "Marinov", 20)};

            //Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
            var titles =
                 from stud in studentss
                 where stud.Age < 24 && stud.Age > 18 
                 select stud;

            foreach (var item in titles)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            //Using the extension methods OrderBy() and ThenBy() with lambda expressions sort 
            //the students by first name and last name in descending order. Rewrite the same with LINQ.
            IEnumerable<Students> query = studentss.OrderBy(stud => stud.Name).ThenBy(stud => stud.Family);

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

        }

        public static IOrderedEnumerable<string> Order(List<string> input)
        {
            //Write a method that from a given array of students finds all students
            //whose first name is before its last name alphabetically. Use LINQ query operators.

            var ordered = from student in input
                      orderby student
                      select student;

            return ordered;
        }
    }
}