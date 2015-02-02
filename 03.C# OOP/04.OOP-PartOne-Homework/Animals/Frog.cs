namespace Animals
{
    using System;

    public class Frog : Animal
    {
        public Frog(string name, int age, Sex gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public override void SaySomething()
        {
            Console.WriteLine("Kva-Kva!");
        }
    }
}
