using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity
{
    public IntegerVariable gold;
    public IntegerVariable monsterCount;
    public IntegerVariable rarity;
    public void IncreaseGold(IntegerVariable baseGoldDropped){
        gold.Value += (baseGoldDropped.Value + rarity.Value) * (monsterCount.Value!=9?1:5);
    }
}
