namespace SoftwareAcademy
{
    using System.Text;

    public class OffsiteCourse : Course, IOffsiteCourse
    {
        public OffsiteCourse(string name, ITeacher teacher, string town)
            :base(name, teacher)
        {
            this.Town = town;
        }

        public string Town { get; set; }

        public override string ToString()
        {
            StringBuilder offsiteReport = new StringBuilder();
            offsiteReport.Append(base.ToString());
            offsiteReport.AppendFormat("; Town={0}", this.Town);

            return offsiteReport.ToString();
        }
    }
}