namespace SoftwareAcademy
{
    using System.Collections.Generic;
    using System.Text;

    public abstract class Course : ICourse
    {
        private Queue<string> topics;

        public Course(string name, ITeacher teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.topics = new Queue<string>();
        }

        public string Name { get; set; }

        public ITeacher Teacher { get; set; }

        public void AddTopic(string topic)
        {
            this.topics.Enqueue(topic);
        }

        public override string ToString()
        {
            StringBuilder courseReport = new StringBuilder();

            courseReport.Append(this.GetType().Name + ":");
            courseReport.AppendFormat(" Name={0}", this.Name);
            if (this.Teacher != null)
            {
                courseReport.AppendFormat("; Teacher={0}", this.Teacher.Name);
            }

            if (this.topics.Count != 0)
            {
                courseReport.Append("; Topics=[");
                foreach (var topic in this.topics)
                {
                    courseReport.Append(topic + ", ");
                }
                courseReport.Remove(courseReport.Length - 2, 2);
                courseReport.Append("]");
            }

            return courseReport.ToString();
        }
    }
}