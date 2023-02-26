// See https://aka.ms/new-console-template for more information

void Exercise29()
{
    string[] cities =  
    {  
        "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"  
    };  
    
    var cityGroup = from i in Enumerable.Range(0, cities.Length)
        group cities[i] by i / 3;

    var enumerable = cityGroup as IGrouping<int, string>[] ?? cityGroup.ToArray();
    foreach (var city in enumerable)
        if (enumerable != null)
        {
            Console.WriteLine(String.Join(";", city));
            Console.WriteLine("-- here is a group of cities --\n");
        }

    
}

Exercise29();