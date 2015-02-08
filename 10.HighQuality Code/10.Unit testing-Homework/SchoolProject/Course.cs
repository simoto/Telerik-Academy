namespace SchoolProject
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        private string name;
        private List<Student> students;

        public Course(string name, List<Student> students)
        {
           this.Name = name;
           this.Students = students;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null || value == string.Empty)
                {
                    throw new ArgumentNullException("Course name can't be null or empty!");
                }

                this.name = value;
            }
        }

        public List<Student> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                if (value.Count > 30 || value == null)
                {
                    throw new ArgumentOutOfRangeException("Students must be less than 30, and can't be null!");
                }

                this.students = value;
            }
        }

        public void AddStudent(Student student)
        {
            if (this.students.Count == 30)
            {
                throw new ArgumentOutOfRangeException("Can't add more than 30 students");
            }

            this.students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (this.students.Count == 0)
            {
                throw new ArgumentOutOfRangeException("There aren't students in this course!");
            }

            this.students.Remove(student);
        }
    }
}