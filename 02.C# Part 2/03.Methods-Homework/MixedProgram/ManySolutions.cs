using System;

//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//        Create appropriate methods.
//        Provide a simple text-based menu for the user to choose which task to solve.
//        Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0

class ManySolutions
{
    static void Main()
    {
        MenuStart();

        byte choise = byte.Parse(Console.ReadLine());
        if (choise == 1)
        {
            //reverse digits
            Console.Write("Enter your digit here: ");
            decimal integer = decimal.Parse(Console.ReadLine());
            integer = PositiveCheck(integer);
            Console.WriteLine(ReverseDigits(integer));
        }
        else if (choise == 2)
        {
            Console.WriteLine("Please enter the numbers like one integer.");
            Console.Write("Enter the integers in one row: ");
            string integer = Console.ReadLine();
            Console.WriteLine(Avarage(integer));
            //average
        }
        else if (choise == 3)
        {
            //lineal equation
            Console.Write("Enter value for \"a\": ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter value for \"b\": ");
            int b = int.Parse(Console.ReadLine());
            LinealEquation(a, b);
        }
        else
        {
            Console.WriteLine("Invalid Input!");
            Main();
        }
    }

    static void MenuStart()
    {
        Console.WriteLine("Enter what are you want.");
        Console.WriteLine("To reverse digit number press \"1\".");
        Console.WriteLine("To calculate average of sequence of integers press \"2\".");
        Console.WriteLine("To solve lineal equation press \"3\".");
    }

    static decimal ReverseDigits(decimal digit)
    {
        string digits = digit.ToString();
        char[] digitArr = digits.ToCharArray();

        int start = 0;
        char[] revers = new char[digitArr.Length];
        string result = "";
        for (int i = digitArr.Length - 1; i >= 0; i--)
        {
            revers[start] = digitArr[i];
            start++;
        }

        foreach (var num in revers)
        {
            result += num.ToString();
        }

        decimal reversed = decimal.Parse(result);

        return reversed;
    }

    static decimal PositiveCheck(decimal num)
    {
        if (num < 0)
        {
            Console.WriteLine("The integer must be positive number!");
            Console.Write("Enter positive number: ");
            decimal another = decimal.Parse(Console.ReadLine());
            PositiveCheck(another);
            return another;
        }
        else
        {
            return num;
        }
    }

    static decimal Avarage(string input)
    {
        //this not working for integer that have more than one digit :(
        char[] arr = input.ToCharArray();
        decimal sum = 0;

        string[] convr = new string[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            convr[i] = arr[i].ToString();
            sum += int.Parse(convr[i]);
        }

        sum /= arr.Length;
        if (sum == 0)
        {
            Console.WriteLine("Invalid Input!");           
        }
        return sum;
    }

    static void LinealEquation(int a, int b)
    {
        Console.WriteLine("{0}*x + ({1}) = 0 ---> x = {2}/{3}",a , b, b, a); 
    }
}