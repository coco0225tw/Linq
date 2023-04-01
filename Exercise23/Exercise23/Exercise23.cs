// See https://aka.ms/new-console-template for more information

void Exercise23()
{
    var chars = new[] { "x", "y", "z" };
    var nums = new[] { 1, 2, 3, 4 };
    //cross join/Cartesian join => selectMany(from multiple collection)
    var cartesian = 
        chars.SelectMany(ch => nums, (ch, num) => new { letterList = ch, numberList = num });
    Console.WriteLine("The cartesian product are :");
    cartesian.ToList().ForEach(Console.WriteLine);
}
Exercise23();