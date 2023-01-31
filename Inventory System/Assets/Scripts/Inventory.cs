using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{   
    private List<Item> itemlist;

    public Inventory()
    {
        itemlist = new List<Item>();

        AddItem(new Item { itemType = Item.ItemType.Sword, amount = 1 });
        Debug.Log(itemlist.Count);
    }
    public void AddItem(Item item)
    {
        itemlist.Add(item);
    }

}
