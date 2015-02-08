namespace SchoolProject.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void CreateSimpleStudent()
        {
            Student simpleStudent = new Student("Jivko", 11000);
            Assert.IsNotNull(simpleStudent);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ErrorCreateStudentNullName()
        {
            Student simpleStudent = new Student(null, 11000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ErrorCreateStudentOutOfIndex()
        {
            Student simpleStudent = new Student("Jivko", 111000);
        }

        [TestMethod]
        public void GetStudentName()
        {
            Student simpleStudent = new Student("Jivko", 11100);
            Assert.IsNotNull(simpleStudent.Name);
        }

        [TestMethod]
        public void GetStudentNumber()
        {
            Student simpleStudent = new Student("Jivko", 11100);
            Assert.IsNotNull(simpleStudent.UniqueNumber);
        }
    }
}
