namespace Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MainMenu
    {
        static void Main()
        {
            List<Animal> animalList = new List<Animal>() 
            {
                new Dog("Djoni",5,Sex.Male),
                new Cat("Kotence", 3,Sex.Female), 
                new Frog("Jabcho", 1, Sex.Male),
                new Kitten("Pussy", 1),
                new Tomcat("Tomcat", 4)           
            };

            foreach (var animal in animalList)
            {
                animal.SaySomething();
            }

            var avarage = animalList.Average(x => x.Age);
            Console.WriteLine(avarage);
                          
        }
    }
}
