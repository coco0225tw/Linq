

void Exercise29()
{
    var cities =  new string[]
    {  
        "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"  
    };
    var cityGroup =    cities.Select((x, i) => new { Index = i, Value = x })
        .GroupBy(x => x.Index / 3)
        .Select(x => x.Select(v => v.Value).ToArray())
        ;
    foreach (var city in cityGroup)
    {
        Console.WriteLine(string.Join(";", city));
        Console.WriteLine("-- here is a group of cities --\n");
    }

    
}

Exercise29();