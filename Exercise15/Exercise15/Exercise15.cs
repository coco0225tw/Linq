// See https://aka.ms/new-console-template for more information

void Exercise15()
{
    var files = new List<string>() {
        "aaa.frx",
        "bbb.TXT",
        "xyz.dbf",
        "abc.pdf",
        "aaaa.PDF",
        "xyz.frt",
        "abc.xml",
        "ccc.txt",
        "zzz.txt"};
    var extensions = files.Select(s =>
        {
            var split = s.Split(new char[] { '.' });
            return split[^1].ToUpper(); //last index
        }
    ).ToList();

    var groupExtensions = from file in extensions
        group file by file
        into f
        select new{ file = f.Key, count = f.Count()
    }
    ;
    
    groupExtensions.ToList().ForEach(ext =>
        Console.WriteLine($"number of extension {ext.file} is {ext.count}")
    );
}
Exercise15();