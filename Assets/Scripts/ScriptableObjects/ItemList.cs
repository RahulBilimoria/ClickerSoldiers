using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/CreateItemList")]
public class ItemList : ScriptableObject
{
    public Item[] items;
}

[System.Serializable]
public class Item{
    public string name;
    public string description;
    public Sprite icon;
    public Stat stats;
}

[System.Serializable]
public class Stat{
    public int damage;
    public float attackSpeed;
    public float critChance;
    public float critMultiplier;

}