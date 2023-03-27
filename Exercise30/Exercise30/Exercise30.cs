// See https://aka.ms/new-console-template for more information

void Exercise30()
{
    var list = new List<string>()
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

    list = list.Distinct().ToList(); //choose distinct

    list.Sort(); //sort in ascending a-z

    list.ForEach(Console.WriteLine);
}
Exercise30();