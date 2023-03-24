﻿// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;

void Exercise12()
{
    Console.WriteLine("Input the string");
    var input = Console.ReadLine();
    var parsedInput = input!.Split(new char[] { ' ' });
    Console.WriteLine("The UPPER CASE words are :");

    foreach (string word in parsedInput)
    {
        if (String.CompareOrdinal(word, word.ToUpper()) == 0)
        {
            Console.WriteLine(word);
        } else Console.WriteLine("No corresponded string");
    }
}
Exercise12();