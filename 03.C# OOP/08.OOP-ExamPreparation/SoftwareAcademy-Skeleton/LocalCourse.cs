namespace SoftwareAcademy
{
    using System.Text;

    public class LocalCourse : Course, ILocalCourse
    {
        public LocalCourse(string name, ITeacher teacher, string lab)
            : base(name,teacher)
        {
            this.Lab = lab;
        }

        public string Lab { get; set; }

        public override string ToString()
        {
            StringBuilder localReport = new StringBuilder();
            localReport.Append(base.ToString());
            localReport.AppendFormat("; Lab={0}",this.Lab);

            return localReport.ToString();
        }
    }
}