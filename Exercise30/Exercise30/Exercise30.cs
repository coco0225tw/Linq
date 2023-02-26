// See https://aka.ms/new-console-template for more information

void Exercise30()
{
    List<string> list = new List<string>()
    {
        "Biscuit",
        "Brade",
        "Butter",
        "Honey",
        "Biscuit",
        "Brade",
        "Butter",
        "Honey"
    };

    list = list.Distinct().ToList();

    list.Sort();

    list.ForEach(Console.WriteLine);
}
Exercise30();