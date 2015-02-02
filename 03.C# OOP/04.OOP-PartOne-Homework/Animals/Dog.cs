namespace Animals
{
    using System;

    public class Dog : Animal
    {    
        public Dog(string name, int age, Sex gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public override void SaySomething()
        {
            Console.WriteLine("Bau-Bau!");
        }
    }
}