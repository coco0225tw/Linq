// See https://aka.ms/new-console-template for more information

void Exercise18()
{
    var listOfString = new List<string?>()
    {
        "m","n","o","p","q"
    };  
    
    foreach(var tchar in listOfString)  
    {  
        Console.WriteLine("Char: {0} ", tchar);  
    } 
 
    listOfString.Remove(listOfString.FirstOrDefault(en => en == "p")); //if no corresponded, null (String default value)
           
    
    Console.WriteLine("Here is the list after removing the item 'p' from the list : ");
    foreach(var rChar in listOfString)  
    {  
        Console.WriteLine("Char: {0} ", rChar);  
    }
}
Exercise18();