
namespace test1;

using System;
//using System.Linq;
public class Class1
{
    public static void E1()
    {
        var arr = new int[5] {0,1,2,3,4};
    
        //Linq
        var evenNum = arr.Where(num => num % 2 == 0).Select(num => num);
        Console.WriteLine("The numbers which produce the remainder 0 after divided by 2 are : ");
        foreach (var num in evenNum)
        {
            Console.WriteLine(num);
        }
    }
}

Class1.E1();


