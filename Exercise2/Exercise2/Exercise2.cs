﻿// See https://aka.ms/new-console-template for more information


void Exercise2()
{
    var arr = new int[]{ 0, 3, 25, 4, -3, 6, 50, 100, 101, 11 };

    var numBetween1To11 = 
        arr
            .Where(t => t is < 12 and > 0)
            .Select(t => t);
    Console.WriteLine("The numbers within the range of 1 to 11 are : ");			
        foreach (var num in numBetween1To11)
        {
            Console.WriteLine(num);
        }
}
Exercise2();