//A bank account has a holder name (first name, middle name and last name), 
//available amount of money (balance), bank name, IBAN, BIC code and 3 credit card numbers associated with the account. 
//Declare the variables needed to keep the information for a single bank account using the appropriate data types 
//and descriptive names.
using System;

class BankBalance
{
    static void Main()
    {
        string firstName, MiddleName, lastName;
        decimal balance;
        string bankName, bicCode;
        ulong cardNumber;
        Console.WriteLine("First,middle and last name are string.");
        Console.WriteLine("Balance is decimal.");
        Console.WriteLine("Bank name and BIC code are string.");
        Console.WriteLine("Card number is ulong.");
    }
}

