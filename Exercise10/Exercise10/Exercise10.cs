// See https://aka.ms/new-console-template for more information

void Exercise10()
{
    var i=0;
    int n,m;
    List<int> templist = new List<int>(); 
    
    Console.WriteLine("Input the number of members on the List : ");  
    n= Convert.ToInt32(Console.ReadLine());             
            
    for(i=0;i<n;i++)
    {
        Console.WriteLine("Member {0} : ",i);  
        var memlist = Convert.ToInt32(Console.ReadLine()); 
        templist.Add(memlist);
    }
            
    Console.WriteLine("Input the value above you want to display the members of the List : ");  
    m = Convert.ToInt32(Console.ReadLine());     

    List<int> FilterList = templist.FindAll(x => x > m);  
    Console.WriteLine("The numbers greater than {0} are : ",m);
    FilterList.ForEach(Console.WriteLine);

}  


Exercise10();