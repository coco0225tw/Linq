// See https://aka.ms/new-console-template for more information


void Exercise2()
{
    int[] arr = { 0, 3, 25, 4, -3, 6, 50, 100, 101, 11 };

        var numBetween1to11 =
            from t in arr
            where t < 12
            where t > 0
            select t;
        Console.Write("\nThe numbers within the range of 1 to 11 are : \n");			
        foreach (var num in numBetween1to11)
        {
            Console.WriteLine(num + "\n");
        }
}
Exercise2();