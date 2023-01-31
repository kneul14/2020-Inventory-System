using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item //Script for the items.
{  
    public enum ItemType //The items I currently have in my scene.
    {
        Sword,
        Potion,
        Key,
    }

    public ItemType itemType;
    public int amount;

}
