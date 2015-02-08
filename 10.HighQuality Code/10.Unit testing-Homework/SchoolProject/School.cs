namespace SchoolProject
{
    using System;
    using System.Collections.Generic;

    public class School
    {
        private string name;
        private List<Course> courses;

        public School(string name)
        {
            this.Name = name;
            this.courses = new List<Course>();
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
                    throw new ArgumentNullException("School must have name!");
                }
                this.name = value;
            }
        }

        public List<Course> Courses
        {
            get
            {
                return this.courses;
            }
            set
            {
                this.courses = value;
            }
        }
    }
}