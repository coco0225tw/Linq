// See https://aka.ms/new-console-template for more information

void Exercise28()
{
    var cities =  new string[]
    {  
        "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"  
    };  
    
    Console.WriteLine("Here is the arranged list :");
    var cityOrder =
        cities
            .OrderBy(str => str.Length) //first length
            .ThenBy(str => str); //second str
    
    foreach (string city in cityOrder)
        Console.WriteLine(city);
}

Exercise28();