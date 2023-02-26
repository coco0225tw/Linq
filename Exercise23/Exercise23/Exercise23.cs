// See https://aka.ms/new-console-template for more information

void Exercise23()
{
    var chars = new[] { "x", "y", "z" };
    var nums = new[] { 1, 2, 3, 4 };

    var cartesian = 
        (from ch in chars
        from num in nums
        select new
        {
            letterList = ch, numberList = num
        }).ToList();
    Console.WriteLine("The cartesian product are :");
    cartesian.ForEach(Console.WriteLine);
}
Exercise23();