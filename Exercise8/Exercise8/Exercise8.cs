// See https://aka.ms/new-console-template for more information

void Exercise8()
{
    string[] cities =
        { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS"};
    Console.WriteLine("Input starting character for the string : ");
    var startChar = Console.ReadLine();
    Console.WriteLine("Input ending character for the string : ");
    var endChar = Console.ReadLine();

    var ans = from city in cities
        where city.StartsWith(startChar)
        where city.EndsWith(endChar)
        select city;

    if (ans.Any())
    {
        Console.WriteLine($"The city starting with {startChar} and ending with {endChar} is : {string.Join(",", ans.ToArray() )}");
    }
    else
    {
        Console.WriteLine("No corresponded answer");

    }
}
Exercise8();