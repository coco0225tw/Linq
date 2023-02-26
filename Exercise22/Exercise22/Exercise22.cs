// See https://aka.ms/new-console-template for more information

void Exercise22()
{
    Console.WriteLine("Input number of strings to store in the array");
    var arrLength = Convert.ToInt32(Console.ReadLine());

    var arr = new string[arrLength];

    for (var i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Element[{i}] :");
        var ans = Console.ReadLine();
        arr[i] = ans;
    }
    Console.WriteLine("Input the minimum length of the item you want to find");
    var inputLength = Convert.ToInt32(Console.ReadLine());

    var findAllStr = arr.ToList().FindAll(str => str.Length >= inputLength);
    if (findAllStr.Any())
    {
        Console.WriteLine($"The items of minimum {inputLength} characters are :");
        findAllStr.ForEach(w => Console.WriteLine($"item: {w}"));
    }
    else
    {
        Console.WriteLine("No corresponded ans");
    }


}
Exercise22();