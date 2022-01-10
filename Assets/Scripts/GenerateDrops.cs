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
        gold.value += (int)(((baseGoldDropped.value * (1+rarity.value)) * (monsterCount.value!=10?1:5)) * (1+goldMulti.value/100));
        onGoldChange.Raise();
    }
}
