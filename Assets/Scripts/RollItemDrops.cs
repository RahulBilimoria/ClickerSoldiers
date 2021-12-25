using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class RollItemDrops : MonoBehaviour
{
    public GameEvent inventoryChanged;
    public ItemList itemList;
    public Inventory inventory;
    public bool hasItemDropped;
    void Start()
    {
        hasItemDropped = false;
    }

    public void RollForDrops(){
        Item x = new Item();
        x.name = "TEST";
        x.description = "TEST DESCRIPTION";
        x.icon = AssetDatabase.LoadAssetAtPath<Sprite>("Assets/PNG/RPG_inventory_icons/apple.png");
        inventory.items.AddLast(x);
        hasItemDropped = true;
        if (hasItemDropped){
            hasItemDropped = false;
            inventoryChanged.Raise();
        }
    }

}
