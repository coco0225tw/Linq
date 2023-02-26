// See https://aka.ms/new-console-template for more information

void Exercise5(string[] args)
{
    Console.WriteLine("Input the string : ");
    var str = Console.ReadLine();

    var ans = from word in str
        group word by word
        into newWord
        select newWord;
    Console.WriteLine("The frequency of the characters are :");
    foreach (var result in ans)
    {
        Console.WriteLine($"Character {result.Key}  : {result.Count()} times ");
    }
}


Exercise5(new string[] { });
