// See https://aka.ms/new-console-template for more information

void Exercise28()
{
    string[] cities =  
    {  
        "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"  
    };  
    
    Console.WriteLine("Here is the arranged list :");
    IEnumerable<string> cityOrder =
        cities
            .OrderBy(str => str.Length)
            .ThenBy(str => str);
    
    foreach (string city in cityOrder)
        Console.WriteLine(city);
}

Exercise28();