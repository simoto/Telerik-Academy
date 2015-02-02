namespace Animals
{
    using System;

    public abstract class Animal : ISound
    {
        private int age;
        private string name;
        private Sex gender;

        public Animal()
        {       
        }

        public Animal(string name, int age, Sex gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public string Name
        {
            get { return this.name;}
            set { this.name = value;}
        }

        public Sex Gender
        {
            get{ return this.gender;}
            set { this.gender = value;}
        }

        public virtual void SaySomething()
        {
            Console.WriteLine("I'am an animal");
        }
    }
}