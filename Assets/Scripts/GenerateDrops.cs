using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/DropGenerator")]
public class GenerateDrops : ScriptableObject
{
    public GameEvent onGoldChange;
    public IntegerVariable baseGoldDropped;
    public FloatVariable goldMulti;
    public IntegerVariable gold;
    public IntegerVariable monsterCount;
    public IntegerVariable rarity;
    public void GenerateGold(){
        gold.value += (int)(((baseGoldDropped.value * rarity.value) * (monsterCount.value!=10?1:5)) * goldMulti.value);
        onGoldChange.Raise();
    }
}
