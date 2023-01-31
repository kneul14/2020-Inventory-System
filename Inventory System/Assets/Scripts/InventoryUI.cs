using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    private Inventory inventory; //Reference to the inventory script and below is too.

    public void SetInventory(Inventory inventory)
    {
        this.inventory = inventory;
    }
}
