namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class OffsiteCourse : Course
    {
        public string Town { get; set; }
        public OffsiteCourse(string name, string town)
            :base(name)
        {
            this.Town = town;
        }

        public OffsiteCourse(string courseName, string teacherName, string town)
            :base(courseName,teacherName)
        {
            this.Town = town;
        }

        public OffsiteCourse(string courseName, string teacherName, IList<string> students, string town)
            :base(courseName, teacherName, students)
        {
            this.Town = town;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(base.ToString());
            if (this.Town != null)
            {
                result.Append("; Town = ");
                result.Append(this.Town);
            }
            result.Append(" }");
            return result.ToString();
        }
    }
}
