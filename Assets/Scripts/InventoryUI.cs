using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public Inventory inventory;
    public GameObject itemPrefab;
    void Start()
    {
        DisplayInventory();
    }

    public void DisplayInventory(){
        print (inventory.items.Count);
        foreach(Item i in inventory.items){
            GameObject o = Instantiate(itemPrefab, this.gameObject.transform);
            o.name = "0";
        }
    }
}
