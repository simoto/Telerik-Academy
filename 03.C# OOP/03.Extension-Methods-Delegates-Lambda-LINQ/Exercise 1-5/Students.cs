namespace Homework
{
    public class Students
    {
        private string name;
        private string family;
        private int age;

        public Students()
        {
        }

        public Students(string name,string family, int age)
        {
            this.name = name;
            this.family = family;
            this.age = age;
        }

        public string Name
        {
            get { return this.name; }         
        }

        public int Age
        {
            get { return this.age; }            
        }
        public string Family
        {
            get { return this.family; }
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}