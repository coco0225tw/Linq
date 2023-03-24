// See https://aka.ms/new-console-template for more information

List<Students> GetData()  
{  
    List<Students> stulist = new List<Students>();  
    stulist.Add(new Students { StuId = 1, StuName = " Joseph ", GrPoint = 800 });  
    stulist.Add(new Students { StuId = 2, StuName = "Alex", GrPoint = 458 });  
    stulist.Add(new Students { StuId = 3, StuName = "Harris", GrPoint = 900 });  
    stulist.Add(new Students { StuId = 4, StuName = "Taylor", GrPoint = 900 });  
    stulist.Add(new Students { StuId = 5, StuName = "Smith", GrPoint = 458 });  
    stulist.Add(new Students { StuId = 6, StuName = "Natasa", GrPoint = 700 });  
    stulist.Add(new Students { StuId = 7, StuName = "David", GrPoint = 750 });  
    stulist.Add(new Students { StuId = 8, StuName = "Harry", GrPoint = 700 });  
    stulist.Add(new Students { StuId = 9, StuName = "Nicolash", GrPoint = 597 });  
    stulist.Add(new Students { StuId = 10, StuName = "Jenny", GrPoint = 750 });  
    return stulist;  
}  

void Exercise14()
{
    var studentRec = GetData();
    Console.WriteLine("Which maximum grade point(1st, 2nd, 3rd, ...) you want to find  : ");
    var inputRank = Convert.ToInt32(Console.ReadLine());
    var ans =
        studentRec
            .GroupBy(rec => rec.GrPoint)
            .OrderByDescending(grade => grade.Key)
            .Select(g => new { record = g.ToList() }).ToList();
    ans[inputRank - 1].record.ForEach(i => Console.WriteLine(" Id : {0},  Name : {1},  achieved Grade Point : {2}",i.StuId, i.StuName, i.GrPoint));  
    
}

Exercise14();
public class Students
{
    public string StuName { get; set; }  
    public int GrPoint { get; set; }  
    public int StuId { get; set; }  
}