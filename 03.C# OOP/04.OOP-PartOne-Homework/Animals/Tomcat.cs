namespace Animals
{
    using System;

    public class Tomcat : Cat
    {
        public Tomcat() : base()
        {
            this.Gender = Sex.Male;
        }
        public Tomcat(string name, int age) : base(name,age,Sex.Male)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = Sex.Male;
        }

        public override void SaySomething()
        {
            Console.WriteLine("I'm Tomcat");
        }
    }
}