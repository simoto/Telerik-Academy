namespace SchoolProject.Tests
{
    using System;
    using System.Collections.Generic;

    using Microsoft.VisualStudio.TestTools.UnitTesting;
    
    [TestClass]
    public class CourseTests
    {
        [TestMethod]
        public void CreateSimpleCourse()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Pesho", 11000));
            students.Add(new Student("Gosho", 12000));
            students.Add(new Student("Maria", 13000));
            students.Add(new Student("Petkana", 14000));

            Course simpleCourse = new Course("JavaScript", students);

            Assert.IsNotNull(simpleCourse);
        }

        [TestMethod]
        public void AddCourseStudentTest()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Pesho", 11000));
            students.Add(new Student("Gosho", 12000));
            students.Add(new Student("Maria", 13000));
            students.Add(new Student("Petkana", 14000));

            Course simpleCourse = new Course("JavaScript", students);

            simpleCourse.AddStudent(new Student("Dragan", 15000));
            Assert.IsNotNull(simpleCourse);
        }

        [TestMethod]
        public void RemoveCourseStudentTest()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Pesho", 11000));
            students.Add(new Student("Gosho", 12000));
            students.Add(new Student("Maria", 13000));
            students.Add(new Student("Petkana", 14000));

            Course simpleCourse = new Course("JavaScript", students);

            simpleCourse.RemoveStudent(new Student("Pesho", 11000));
            Assert.IsNotNull(simpleCourse);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ErrorNullNameCourse()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Pesho", 11000));
            students.Add(new Student("Gosho", 12000));
            students.Add(new Student("Maria", 13000));
            students.Add(new Student("Petkana", 14000));

            Course simpleCourse = new Course(null, students);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ErrorMoreThan30Students()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Pesho", 11000));
            students.Add(new Student("Gosho", 12000));
            students.Add(new Student("Maria", 13000));
            students.Add(new Student("Petkana", 15000));
            students.Add(new Student("Pesho1", 16000));
            students.Add(new Student("Gosho1", 17000));
            students.Add(new Student("Maria1", 18000));
            students.Add(new Student("Petkana1", 19000));
            students.Add(new Student("Pesho2", 10300));
            students.Add(new Student("Gosho2", 12200));
            students.Add(new Student("Maria2", 13500));
            students.Add(new Student("Petkana2", 14700));
            students.Add(new Student("Pesho3", 11110));
            students.Add(new Student("Gosho3", 12220));
            students.Add(new Student("Maria3", 13030));
            students.Add(new Student("Petkana3", 14330));
            students.Add(new Student("Pesho4", 11200));
            students.Add(new Student("Gosho4", 12120));
            students.Add(new Student("Maria4", 13456));
            students.Add(new Student("Petkana4", 14567));
            students.Add(new Student("Pesho5", 21000));
            students.Add(new Student("Gosho5", 22000));
            students.Add(new Student("Maria5", 23000));
            students.Add(new Student("Petkana5", 24000));
            students.Add(new Student("Pesho6", 31000));
            students.Add(new Student("Gosho6", 32000));
            students.Add(new Student("Maria6", 33000));
            students.Add(new Student("Petkana6", 34000));
            students.Add(new Student("Pesho7", 61000));
            students.Add(new Student("Gosho7", 62000));
            students.Add(new Student("Maria7", 613000));
            students.Add(new Student("Petkana7", 64000));
            Course simpleCourse = new Course("Java", students);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ErrorMoreThan30Students2()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Pesho", 11000));
            students.Add(new Student("Gosho", 12000));
            students.Add(new Student("Maria", 13000));
            students.Add(new Student("Petkana", 15000));
            students.Add(new Student("Pesho1", 16000));
            students.Add(new Student("Gosho1", 17000));
            students.Add(new Student("Maria1", 18000));
            students.Add(new Student("Petkana1", 19000));
            students.Add(new Student("Pesho2", 10300));
            students.Add(new Student("Gosho2", 12200));
            students.Add(new Student("Maria2", 13500));
            students.Add(new Student("Petkana2", 14700));
            students.Add(new Student("Pesho3", 11110));
            students.Add(new Student("Gosho3", 12220));
            students.Add(new Student("Maria3", 13030));
            students.Add(new Student("Petkana3", 14330));
            students.Add(new Student("Pesho4", 11200));
            students.Add(new Student("Gosho4", 12120));
            students.Add(new Student("Maria4", 13456));
            students.Add(new Student("Petkana4", 14567));
            students.Add(new Student("Pesho5", 21000));
            students.Add(new Student("Gosho5", 22000));
            students.Add(new Student("Maria5", 23000));
            students.Add(new Student("Petkana5", 24000));
            students.Add(new Student("Pesho6", 31000));
            students.Add(new Student("Gosho6", 32000));
            students.Add(new Student("Maria6", 33000));
            students.Add(new Student("Petkana6", 34000));
            students.Add(new Student("Pesho7", 61000));
            students.Add(new Student("Gosho7", 62000));
            students.Add(new Student("Maria7", 61300));
            Course simpleCourse = new Course("Java", students);
            simpleCourse.AddStudent(new Student("Maria8", 61330));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ErrorRemoveFrom0Students()
        {
            List<Student> students = new List<Student>();            
            Course simpleCourse = new Course("Java", students);
            simpleCourse.RemoveStudent(new Student("Maria8", 61330));
        }
    }
}
