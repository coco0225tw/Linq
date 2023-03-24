﻿// See https://aka.ms/new-console-template for more information
//The numbers which produce the remainder 0 after divided by 2 are :0 2 4 6 8
void Exercise1()
    {
        int[] arr = new int[5] {0,1,2,3,4};
        
        //Linq
        var evenNum = arr.Where(num => num % 2 == 0).Select(num => num);
        Console.WriteLine("The numbers which produce the remainder 0 after divided by 2 are : ");
        foreach (var num in evenNum)
        {
            Console.WriteLine(num);
        }
    }


Exercise1();