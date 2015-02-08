namespace SchoolProject.Tests
{
    using System;
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SchoolTests
    {
        [TestMethod]
        public void CreateSimpleSchool()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Pesho", 11000));
            students.Add(new Student("Gosho", 12000));
            students.Add(new Student("Maria", 13000));
            students.Add(new Student("Petkana", 14000));

            Course simpleCourse = new Course("JavaScript", students);

            School simpleSchool = new School("TelerikAcademy");
            simpleSchool.Courses.Add(simpleCourse);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ErrorCreateNullNameSchool()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Pesho", 11000));
            students.Add(new Student("Gosho", 12000));
            students.Add(new Student("Maria", 13000));
            students.Add(new Student("Petkana", 14000));

            Course simpleCourse = new Course("JavaScript", students);

            School simpleSchool = new School(null);
        }

        [TestMethod]
        public void GetSchoolName()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Pesho", 11000));
            students.Add(new Student("Gosho", 12000));
            students.Add(new Student("Maria", 13000));
            students.Add(new Student("Petkana", 14000));

            Course simpleCourse = new Course("JavaScript", students);

            School simpleSchool = new School("TelerikAcademy");
            simpleSchool.Courses.Add(simpleCourse);
            Assert.IsNotNull(simpleSchool.Name);
        }
    }
}
