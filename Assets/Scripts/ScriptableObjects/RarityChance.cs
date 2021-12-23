using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/RarityChance")]
public class RarityChance : ScriptableObject
{
    public FloatReference normal;
    public FloatReference magic;
    public FloatReference rare;
    public FloatReference unique;
    public IntegerVariable currentRarity;
    public Color[] rarityColor = new Color[4];

    public int GetRarity(){
        float r = Random.Range(0.0f, 1.0f);
        if (r < unique.Value){
            currentRarity.Value = 3;
        } else if (r < rare.Value){
            currentRarity.Value = 2;
        } else if (r < magic.Value){
            currentRarity.Value = 1;
        } else {
            currentRarity.Value = 0;
        }
        return currentRarity.Value;
    }

    public Color GetColor(int rarity){
        return rarityColor[rarity];
    }
}
