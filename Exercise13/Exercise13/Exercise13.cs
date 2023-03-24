// See https://aka.ms/new-console-template for more information

void Exercise13()
{
    Console.WriteLine("Input number of strings to store in the array :");
    var arrayLength = Int32.Parse(Console.ReadLine()!);
    var arr = new string[arrayLength];

    for (var i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Element[{i}]: ");
        var input = Console.ReadLine();
        arr[i] = input!;
    }


    Console.WriteLine("Here is the string below created with elements of the above array :");
    var joinStr = string.Join(", ", arr);
    Console.WriteLine(joinStr);
}
Exercise13();