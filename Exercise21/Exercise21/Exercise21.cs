// See https://aka.ms/new-console-template for more information
void Exercise21()
{
    var listOfString = new List<string>()
    {
        "m","n","o","p","q"
    };  
    
    foreach(var tchar in listOfString)  
    {  
        Console.WriteLine("Char: {0} ", tchar);  
    } 

    listOfString.RemoveRange(1, 3); //from index 1, remove 3 elements
    
    Console.WriteLine("Here is the list after removing the three items starting from the item index 1 from the list :");
    foreach(var rChar in listOfString)  
    {  
        Console.WriteLine("Char: {0} ", rChar);  
    }  

}
Exercise21();