// See https://aka.ms/new-console-template for more information

void Exercise24()
{
    var chars = new[] { "x", "y" };
    var nums = new[] { 1, 2, 3 };
    var colors = new[] { "Green", "Orange"};
    
    var cartesian = 
            (from ch in chars
            from num in nums
            from color in colors
            select new
            {
                letterList = ch, numberList = num, colour = color
            }).ToList();
    Console.WriteLine("The cartesian product are :");
    cartesian.ForEach(Console.WriteLine);
}
Exercise24();