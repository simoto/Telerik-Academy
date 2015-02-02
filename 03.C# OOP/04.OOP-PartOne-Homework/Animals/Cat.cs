namespace Animals
{
    using System;

    public class Cat : Animal
    {
        public Cat()
        {
        }
        public Cat(string name, int age, Sex gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
             
        public override void SaySomething()
        {
            Console.WriteLine("Miaauuu!");
        }
    }
}