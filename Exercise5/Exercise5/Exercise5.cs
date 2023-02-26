// See https://aka.ms/new-console-template for more information

void Exercise5(string[] args)
{
    Console.Write("Input the string : ");
    var str = Console.ReadLine();
    Console.Write("\n");

    var ans = from word in str
        group word by word
        into newWord
        select newWord;
    Console.WriteLine("The frequency of the characters are :\n");
    foreach (var result in ans)
    {
        Console.WriteLine($"Character {result.Key}  : {result.Count()} times \n");
    }
}


Exercise5(new string[] { });
