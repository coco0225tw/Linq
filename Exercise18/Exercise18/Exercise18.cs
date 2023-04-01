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
    //creating an object internally by filtering
    
    var item = listOfString.FirstOrDefault(en => en == "p");
    //if no corresponded(first), null (String default value)
    //singleordefault => throw exception
    
    listOfString.Remove(item); 
    

    Console.WriteLine("Here is the list after removing the item 'p' from the list : ");
    foreach(var rChar in listOfString)  
    {  
        Console.WriteLine("Char: {0} ", rChar);  
    }
}
Exercise18();