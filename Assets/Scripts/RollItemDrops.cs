using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class RollItemDrops : MonoBehaviour
{
    public ItemList itemList;
    public Inventory inventory;
    void Start()
    {
        Item x = new Item();
        x.name = "TEST";
        x.description = "TEST DESCRIPTION";
        x.icon = AssetDatabase.LoadAssetAtPath<Sprite>("Assets/PNG/RPG_inventory_icons/apple.png");
        inventory.items.AddLast(x);
    }

}
