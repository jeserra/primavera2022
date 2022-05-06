// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

 List<Item_mast> itemlist = new List<Item_mast>
	        {  
           new Item_mast { ItemId = 1, ItemDes = "Biscuit  " }, 
           new Item_mast { ItemId = 2, ItemDes = "Chocolate" }, 
           new Item_mast { ItemId = 3, ItemDes = "Butter   " },  
           new Item_mast { ItemId = 4, ItemDes = "Brade    " },  
           new Item_mast { ItemId = 5, ItemDes = "Honey    " }  
            }; 

    List<Purchase> purchlist = new List<Purchase>
	        {  
           new Purchase { InvNo=100, ItemId = 3,  PurQty = 800 }, 
           new Purchase { InvNo=101, ItemId = 2,  PurQty = 650 }, 
           new Purchase { InvNo=102, ItemId = 3,  PurQty = 900 },  
           new Purchase { InvNo=103, ItemId = 4,  PurQty = 700 },
		   new Purchase { InvNo=104, ItemId = 3,  PurQty = 900 },  
           new Purchase { InvNo=105, ItemId = 4,  PurQty = 650 },  		   
           new Purchase { InvNo=106, ItemId = 1,  PurQty = 458 }  
            }; 
        
    var innerJoin = from e in itemlist 
        join d in purchlist 
        on e.ItemId equals d.ItemId
        select new { e.ItemId, e.ItemDes, d.PurQty };
        
    foreach (var item in innerJoin)
    {
        Console.WriteLine("{0} {1} {2}", item.ItemId, item.ItemDes, item.PurQty);
    }

public class Item_mast
{
    public int ItemId { get; set; }
    public string ItemDes { get; set; }
}

public class Purchase
{
    public int InvNo { get; set; }
    public int ItemId { get; set; }
    public int PurQty { get; set; }
}