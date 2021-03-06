﻿using System;
using System.Text;

//Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters. The encoding/decoding is done by performing XOR (exclusive or)
//operation over the first letter of the string with the first of the key, the second – with the second, etc.
//When the last key character is reached, the next is the first.

class EncryptDecrypt
{
    static void Main()
    {
        Console.Write("Enter your text: ");
        string str = Console.ReadLine();
        Console.Write("Enter your key: ");
        string key = Console.ReadLine();

        string encrypted = Encrypt(str, key);
        Console.WriteLine("Encrypted: {0}", encrypted);

        Console.WriteLine("Decrypted: {0}",DeCrypt(encrypted, key));
    }

    static string Encrypt(string str, string key)
    {
        char[] strArr = str.ToCharArray();
        char[] keyArr = new char[strArr.Length];

        StringBuilder encrypted = new StringBuilder();

        for (int i = 0, k = 0; i < keyArr.Length; k++, i++)
        {
            if (!(k < key.Length))
            {
                k = 0;
            }
            keyArr[i] = key[k];
        }
        for (int i = 0; i < strArr.Length; i++)
        {
            encrypted.Append((char)(strArr[i] ^ keyArr[i]));
        }
        return encrypted.ToString();
    }

    static string DeCrypt(string str, string key)
    {
        return Encrypt(str, key).ToString();
    }
}