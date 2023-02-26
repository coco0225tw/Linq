// See https://aka.ms/new-console-template for more information

void Exercise17()
{
    List<char> chars = new List<char>()
    {
        'm',
        'n',
        'o',
        'p',
        'q'
    };
    foreach(var tchar in chars)  
    {  
        Console.WriteLine("Char: {0} ", tchar);  
    } 
    Console.WriteLine("Here is the list after removing the item 'o' from the list : ");
    chars.Remove('o');
    foreach(var tchar in chars)  
    {  
        Console.WriteLine("Char: {0} ", tchar);  
    } 
}
Exercise17();