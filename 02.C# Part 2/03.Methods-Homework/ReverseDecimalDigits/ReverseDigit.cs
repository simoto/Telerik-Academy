using System;

//Write a method that reverses the digits of given decimal number. Example: 256  652

class ReverseDigit
{
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

    static void Main()
    {
        decimal number = 0;
        
        try
        {
             number = decimal.Parse(Console.ReadLine());
        }
        catch (Exception)
        {
            //experiment with catch exemption
            Console.WriteLine("Your input is invalid enter new number: ");
            Main(); return;
        }
               
        Console.WriteLine(ReverseDigits(number));
    }
}