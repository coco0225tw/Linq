// See https://aka.ms/new-console-template for more information

void Exercise11()
{
    var numbers = new List<int>()
    {
        5,
        7,
        13,
        24,
        6 ,
        9 ,
        8 ,
        7
    };

    Console.WriteLine("How many records you want to display?");

    var input = Console.ReadLine();

    if (!int.TryParse(input, out var inputInt))
    {
        Console.WriteLine("Enter an integer!");
    }

    numbers = numbers.OrderByDescending(n => n).ToList();
    Console.WriteLine("The top 3 records from the list are :");
    numbers.Take(inputInt).ToList().ForEach(Console.WriteLine);
}
Exercise11();