//Declare a boolean variable called isFemale and assign an appropriate value corresponding to your gender.
using System;

class IsFemale
{
    static void Main()
    {
        string female = "female";
        Console.Write("What is your gender?(You can use only 'male' or 'female'): ");

        string myGender = Console.ReadLine();
        bool isFemale = (female == myGender);

        if (myGender == "female")
        {
            Console.WriteLine("You are female: {0}", isFemale);
        }
        else
        {
            Console.WriteLine("You are female: {0}", isFemale);
        }

    }
}
