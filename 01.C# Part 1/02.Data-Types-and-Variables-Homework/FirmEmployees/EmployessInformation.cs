//A marketing firm wants to keep record of its employees. 
//Each record would have the following characteristics – 
//first name, family name, age, gender (m or f), ID number, unique employee number (27560000 to 27569999). 
//Declare the variables needed to keep the information for a single employee using appropriate data types 
//and descriptive names.
using System;

class EmployessInformation
{
    static void Main()
    {
        string firstName = "Darth";
        string lastName = "Vader";
        byte age = 100;
        char genderMale = 'm';
        uint idNumber = 3456u;
        uint uniqueNumber = 27566534u;

        Console.WriteLine("First name : " + firstName);
        Console.WriteLine("Last name : " + lastName);
        Console.WriteLine("Age : " + age);
        Console.WriteLine("Gender : " + genderMale);
        Console.WriteLine("ID Number : " + idNumber);
        Console.WriteLine("Unique number : " + uniqueNumber);
    }
}
