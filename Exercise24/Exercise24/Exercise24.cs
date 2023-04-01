// See https://aka.ms/new-console-template for more information

void Exercise24()
{
    var chars = new[] { "x", "y" };
    var nums = new[] { 1, 2, 3 };
    var colors = new[] { "Green", "Orange"};

    var cartesian =
        chars.SelectMany(ch =>
            nums.SelectMany(num =>
                colors.Select(color => new { letterList = ch, numberList = num, colour = color })));
    Console.WriteLine("The cartesian product are :");
    cartesian.ToList().ForEach(Console.WriteLine);
}
Exercise24();