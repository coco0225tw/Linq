// See https://aka.ms/new-console-template for more information


using System.Diagnostics;

void Exercise26()
{
    var itemList = new List<TItem>
    {  
        new TItem { ItemId = 1, ItemDes = "Biscuit" }, 
        new TItem { ItemId = 2, ItemDes = "Chocolate" }, 
        new TItem { ItemId = 3, ItemDes = "Butter" },  
        new TItem { ItemId = 4, ItemDes = "Brade" },  
        new TItem { ItemId = 5, ItemDes = "Honey" }  
    }; 
		  
    var purchaseList = new List<TPurchase>
    {  
        new TPurchase { No=100, ItemId = 3,  Qty = 800 }, 
        new TPurchase { No=101, ItemId = 2,  Qty = 650 }, 
        new TPurchase { No=102, ItemId = 3,  Qty = 900 },  
        new TPurchase { No=103, ItemId = 4,  Qty = 700 },
        new TPurchase { No=104, ItemId = 3,  Qty = 900 },  
        new TPurchase { No=105, ItemId = 4,  Qty = 650 },  		   
        new TPurchase { No=106, ItemId = 1,  Qty = 458 }  
    }; 
        
			
    foreach (var item in itemList)
    {Console.WriteLine(
        $"Item Id: {item.ItemId}, Description: {item.ItemDes}"); }

    Console.WriteLine("Here is the Purchase List : ");

    foreach (var item in purchaseList)
    {
        Console.WriteLine(
            $"Invoice No: {item.No}, Item Id : {item.ItemId},  Quantity : {item.Qty}");
    }

    Console.WriteLine("Here is the list after joining  : ");

    var join = itemList.GroupJoin(purchaseList,
        i => i.ItemId,
        p => p.ItemId,
        (i, p) => new
        {
            itemId = i.ItemId,
            itDes = i.ItemDes,
            p //GroupJoin 不能列舉屬性
        }).SelectMany(i => i.p.DefaultIfEmpty(new TPurchase()), (i, p) => new
        {
        i.itemId,
        i.itDes,
        prqty = p.Qty   
        });
        
    Console.WriteLine(
        join.Select(s => new
            {
                ItemId = s.itemId,
                ItemName = s.itDes,
                PurchaseQuantity = s.prqty,
            })
            .ToMarkdownTable());
}

Exercise26();
public class TItem
{
    public int ItemId { get; set; }
    public string ItemDes { get; set; }
}

public class TPurchase
{
    public int No { get; set; }
    public int ItemId { get; set; }
    public int Qty { get; set; }
}