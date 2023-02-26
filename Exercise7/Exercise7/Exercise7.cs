// See https://aka.ms/new-console-template for more information

void Exercise7()
{
    int[] arr = new[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };

    var freq = from int num in arr
        group num by num
        into newGroup
        select newGroup ;
    foreach (var ans in freq)
    {
        Console.WriteLine($"{ans.Key} {ans.Key * ans.Count()} {ans.Count()} ");
    }
}
Exercise7();