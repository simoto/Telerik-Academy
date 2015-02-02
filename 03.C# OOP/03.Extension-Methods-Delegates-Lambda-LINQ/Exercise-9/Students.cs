//Create a class student with properties FirstName, LastName, FN, Tel, Email, Marks (a List<int>), 
    //GroupNumber. Create a List<Student> with sample students. Select only the students that are from group number 2. 
    //Use LINQ query. Order the students by FirstName.

namespace Exercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        public string FirstName {get; set;}
        public string LastName { get; set; }
        public string FN { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public List<int> Marks { get; set; }
        public int GroupNumber { get; set; }   
    }

    class Program
    {
        static void Main()
        {
            List<Student> studentList = new List<Student>();
            studentList.Add(new Student
            {
                FirstName = "Joro",
                LastName = "Jorkov",
                FN = "3423053432",
                Phone = "089345643405",
                Mail = "sample@mail.com",
                GroupNumber = 1,
                Marks = new List<int>() { 2, 3, 4, 5, 4, 3 },
            });

            studentList.Add(new Student
            {
                FirstName = "Kiro",
                LastName = "Skalata",
                FN = "123406445",
                Phone = "023452321",
                Mail = "example@abv.bg",
                GroupNumber = 2,
                Marks = new List<int>() { 3, 6, 4, 5, 4, 3 },
            });

            var onlyGroupTwo = from student in studentList
                               where student.GroupNumber == 2
                               select student;

            foreach (var item in onlyGroupTwo)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }

            var orderByFirstName = from student in studentList
                                   orderby student.FirstName
                                   select student;

            foreach (var item in orderByFirstName)
            {
                Console.WriteLine(item.FirstName);
            }

            Console.WriteLine();

            //Implement the previous using the same query expressed with extension methods.
            var onlyGroupTwo2 = studentList.Where(student => student.GroupNumber == 2);
            var orderByFirstName2 = studentList.OrderBy(student => student.FirstName);

            foreach (var item in onlyGroupTwo2)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }

            foreach (var item in orderByFirstName2)
            {
                Console.WriteLine(item.FirstName);
            }

            Console.WriteLine();

            //Extract all students that have email in abv.bg. Use string methods and LINQ.
            var onlyAbvMail = from student in studentList
                              where student.Mail.Contains("abv.bg")
                              select student;

            foreach (var item in onlyAbvMail)
            {
                Console.WriteLine(item.FirstName +" "+ item.Mail);
            }

            Console.WriteLine();

            //Extract all students with phones in Sofia. Use LINQ.
            var onlySofiaNubmers = from student in studentList
                                   where student.Phone.IndexOf("02", 0) == 0
                                   select student;

            foreach (var item in onlySofiaNubmers)
            {
                Console.WriteLine(item.FirstName + " " + item.Phone);
            }

            Console.WriteLine();

            //Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks. Use LINQ.
            var hasExcellent = from student in studentList
                               where student.Marks.Contains(6)
                               select student;

            List<dynamic> anonymousType = new List<dynamic>(); 
            foreach (var item in hasExcellent)
            {
                anonymousType.Add(new { FullName = item.FirstName + " " + item.LastName, Marks = item.Marks });
            }

            foreach (var item in anonymousType)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            //Write down a similar program that extracts the students with exactly  two marks "2". Use extension methods.
            var hasBad = studentList.Where(student => student.Marks.Contains(2));

            List<dynamic> anType = new List<dynamic>();
            foreach (var item in hasBad)
            {
                anType.Add(new { FullName = item.FirstName + " " + item.LastName, Marks = item.Marks });
            }

            foreach (var item in anType)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            //Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
            var studentFrom06 = from student in studentList
                                where student.FN[4] == '0' && student.FN[5] == '6'
                                select student;

            foreach (var item in studentFrom06)
            {
                Console.Write(item.FirstName + " " + item.LastName + ": ");
                foreach (var mark in item.Marks)
                {
                    Console.Write(mark + " ");
                }

                Console.WriteLine();
            }
        }
    }
}