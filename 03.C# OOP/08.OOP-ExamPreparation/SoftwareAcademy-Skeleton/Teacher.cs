namespace SoftwareAcademy
{
    using System.Collections.Generic;
    using System.Text;

    public class Teacher : ITeacher
    {
        private List<ICourse> courseList;

        public Teacher(string name)
        {
            this.Name = name;
            courseList = new List<ICourse>();
        }

        public string Name { get; set; }

        public void AddCourse(ICourse course)
        {
            courseList.Add(course);
        }

        public override string ToString()
        {
            StringBuilder report = new StringBuilder();
            report.Append(this.GetType().Name + ":");
            report.AppendFormat(" Name={0}", this.Name);
            if (this.courseList.Count != 0)
            {
                report.Append("; Courses=[");
                foreach (var course in this.courseList)
                {
                    report.Append(course.Name + ", ");
                }
                report.Remove(report.Length - 2, 2);
                report.Append("]");
            }

            return report.ToString();      
        }
    }
}