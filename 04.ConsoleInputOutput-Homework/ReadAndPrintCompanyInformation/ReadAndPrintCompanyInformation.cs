/* A company has name, address, phone number, fax number, web site and manager.
The manager has first name, last name, age and a phone number. 
Write a program that reads the information about a company and its manager and prints them on the console.
 * */

using System;

class ReadAndPrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Enter company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Enter company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Enter phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Enter fax number: ");
        string faxNumber = Console.ReadLine();
        Console.Write("Enter website: ");
        string webSite = Console.ReadLine();

        Console.WriteLine("------Enter manager information-----");
        Console.Write("First Name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Last Name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Age: ");
        int managerAge = int.Parse(Console.ReadLine());
        Console.Write("Phone number: ");
        string managerPhone = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("Company {0}\nAddress: {1}\nPhone number: {2}\nFax number: {3}\nWebsite: {4}",
            companyName, companyAddress, phoneNumber, faxNumber, webSite);
        Console.WriteLine("  Manager information");
        Console.WriteLine("First name: {0}\nLast name: {1}\nAge: {2}\nPhone number: {3}", managerFirstName, managerLastName, managerAge, managerPhone);
    }
}
