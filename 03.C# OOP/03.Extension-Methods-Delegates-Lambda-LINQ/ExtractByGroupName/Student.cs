//Create a program that extracts all students grouped by GroupName and then prints them to the console. Use LINQ.
//Rewrite the previous using extension methods.

namespace ExtractByGroupName
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Student
    {
        private string name;
        private string group;

        public Student()
        {
        }

        public Student(string name, string group)
        {
            this.name = name;
            this.group = group;
        }

        public string GroupName
        {
            get { return this.group; }
        }

        public string Name
        {
            get { return this.name; }
        }

        public override string ToString()
        {
            return string.Format("Name: {0}\nGroup: {1}", this.Name, this.GroupName);
        }

        static void Main()
        {
            List<Student> someStudents = new List<Student>() 
            { 
                new Student("Petur Petrov","Apples"),
                new Student("Atanas Atanasov","Priests"),
                new Student("Qnko Qnkov","Killers"),
                new Student("Misho Mishev","Losers"),
                new Student("Lucho Luchev","Winners")
            };

            //Exercise 18 with LINQ
            var sortedByGroup = from student in someStudents
                                orderby student.GroupName
                                select student;

            foreach (var stud in sortedByGroup)
            {
                Console.WriteLine(stud);
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            //Exercise 19 with extension method
            var extensionGroup = someStudents.OrderBy(student => student.GroupName);

            foreach (var item in extensionGroup)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }
        }
    }
}