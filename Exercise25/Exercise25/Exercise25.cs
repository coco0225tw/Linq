﻿// See https://aka.ms/new-console-template for more information

void Exercise25()
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
           new TPurchase { No=101, ItemId = 5,  Qty = 650 }, 
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
			 //innerJoin
			 var join = itemList.Join(purchaseList,
				 i => i.ItemId,
				 p => p.ItemId,
				 (i, p) => new
				 {
					 itid = i.ItemId,
					 itdes = i.ItemDes,
					 prqty = p.Qty

				 });

			 Console.WriteLine("Item ID\t\tItem Name\tPurchase Quantity");
			 Console.WriteLine("-------------------------------------------------------");
			 foreach (var data in join )  
			 {  
				 Console.WriteLine(data.itid + "\t\t" + data.itdes + "\t\t" + data.prqty);  
			 }  

}

Exercise25();
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
