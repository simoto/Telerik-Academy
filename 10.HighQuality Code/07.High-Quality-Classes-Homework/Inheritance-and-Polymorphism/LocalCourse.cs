namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class LocalCourse : Course
    {
        
        public LocalCourse(string name)
            :base(name)
        {
            
        }

        public LocalCourse(string courseName, string teacherName)
            :base(courseName,teacherName)
        {
            
        }

        public LocalCourse(string courseName, string teacherName, IList<string> students)
            :base(courseName, teacherName, students)
        {
            
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(base.ToString());
            if (this.Lab != null)
            {
                result.Append("; Lab = ");
                result.Append(this.Lab);
            }
            result.Append(" }");
            return result.ToString();
        }
    }
}
