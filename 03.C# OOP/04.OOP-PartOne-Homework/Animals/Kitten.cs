namespace Animals
{
    using System;

    public class Kitten : Cat
    {
        public Kitten()
            : base()
        {
            this.Gender = Sex.Female;
        }
        public Kitten(string name, int age)
            : base(name, age, Sex.Female)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = Sex.Female;
        }

        public override void SaySomething()
        {
            Console.WriteLine("I'm a kitten");
        }
    }
}