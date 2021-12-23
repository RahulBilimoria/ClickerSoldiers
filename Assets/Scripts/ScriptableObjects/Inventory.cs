using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/CreateInventory")]
public class Inventory : ScriptableObject
{
    public IntegerVariable gold;
    public LinkedList<Item> items = new LinkedList<Item>();

    public void addItem(Item item){
        items.AddLast(item);
    }

    public void removeItem(int id){
        
    }
}
