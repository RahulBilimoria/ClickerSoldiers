using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/RarityChance")]
public class RarityChance : ScriptableObject
{
    public FloatVariable normal;
    public FloatVariable magic;
    public FloatVariable rare;
    public FloatVariable unique;
    public IntegerVariable currentRarity;
    public Color[] rarityColor = new Color[4];

    public int GetRarity(){
        float r = Random.Range(0.0f, 1.0f);
        if (r < unique.value){
            currentRarity.value = 3;
        } else if (r < rare.value){
            currentRarity.value = 2;
        } else if (r < magic.value){
            currentRarity.value = 1;
        } else {
            currentRarity.value = 0;
        }
        return currentRarity.value;
    }

    public Color GetColor(int rarity){
        return rarityColor[rarity];
    }
}
