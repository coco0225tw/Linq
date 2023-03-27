// See https://aka.ms/new-console-template for more information
void Exercise20()
{
    var listOfString = new List<string>()
    {
        "m","n","o","p","q"
    };  
    
    foreach(var tchar in listOfString)  
    {  
        Console.WriteLine("Char: {0} ", tchar);  
    } 

    listOfString.RemoveAt(3); 
    
    Console.WriteLine("Here is the list after removing item index 3 from the list :");
    foreach(var rChar in listOfString)  
    {  
        Console.WriteLine("Char: {0} ", rChar);  
    }  

}
Exercise20();