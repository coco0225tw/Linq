// See https://aka.ms/new-console-template for more information

void Exercise29()
{
    var cities =  new string[]
    {  
        "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"  
    };  
    
    var cityGroup = 
       from i in Enumerable.Range(0, cities.Length)
       group cities[i] by i / 3;
    var group = cityGroup.ToArray();
    foreach (var city in group)
    {
        Console.WriteLine(String.Join(";", city));
        Console.WriteLine("-- here is a group of cities --\n");
    }

    
}

Exercise29();