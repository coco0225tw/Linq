﻿// See https://aka.ms/new-console-template for more information

void Exercise19()
{
    var listOfString = new List<string>()
    {
        "m","n","o","p","q","q"
    };  
    
    foreach(var tchar in listOfString)  
    {  
        Console.WriteLine("Char: {0} ", tchar);  
    } 
    // by passing filters
    listOfString.RemoveAll(en => en == "q");
    //var result = listOfString.Where(c => c != "q");
    Console.WriteLine("Here is the list after removing item 'q' from the list : ");
    foreach(var rChar in listOfString)  
    {  
        Console.WriteLine("Char: {0} ", rChar);  
    }  
  

}
Exercise19();