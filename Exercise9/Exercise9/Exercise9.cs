// See https://aka.ms/new-console-template for more information

void Exercise9()
{
    List<int> numbers = new List<int>() { 55, 200, 740, 76, 230, 482, 95 };
    var numberGreaterThan80 = numbers.Where(x => x > 80);

    Console.WriteLine("The numbers greater than 80 are :");
    foreach (var num in numberGreaterThan80)
    {
        Console.WriteLine(num);
    }
}

Exercise9();