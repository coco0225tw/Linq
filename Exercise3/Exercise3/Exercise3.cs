// See https://aka.ms/new-console-template for more information

void Exercise3()
{
    int[] arr = new[] {9, 8, 6, 5 };
    Console.WriteLine("Find the number and its square of an array : ");

    var sq = from int Number in arr
        let sqNo = Number * Number
        select new
        {
            Number, sqNo
        };
    foreach (var obj in sq)
    {
        Console.WriteLine(obj);
    }
}
Exercise3();