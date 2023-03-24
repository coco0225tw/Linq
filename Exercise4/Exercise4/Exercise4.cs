// See https://aka.ms/new-console-template for more information

void Exercise4()
{
    int[] arr = new[] { 5, 5, 5, 4, 6, 7, 9, 9, 5, 4 };


    var ans =
        arr
            .GroupBy(num => num)
            .Select(g => new { g.Key, Count = g.Count()});

    foreach (var item in ans)
    {
        Console.WriteLine($"Number {item.Key} appears {item.Count} times \n");
    }
        
    
}
Exercise4();