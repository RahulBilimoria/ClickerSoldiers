using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/CreateUpgradeData")]
public class Upgrades : ScriptableObject
{
    [SerializeField] AnimationCurve weaponDamageCurve;
    [SerializeField] AnimationCurve attacksPerSecondCurve;
    [SerializeField] AnimationCurve weaponDamageMultiplierCurve;
    [SerializeField] AnimationCurve baseGoldCurve;
    [SerializeField] AnimationCurve goldMultiplierCurve;
    [SerializeField] AnimationCurve monsterHPMultiplierCurve;
    [SerializeField] AnimationCurve lowCostCurve;
    //public AnimationCurve mediumCostCurve;
    //public AnimationCurve highCostCurve;
    [SerializeField] IntegerVariable weaponDamage;
    [SerializeField] FloatVariable attacksPerSecond;
    [SerializeField] FloatVariable weaponDamageMultiplier;
    [SerializeField] IntegerVariable baseGold;
    [SerializeField] FloatVariable goldMultiplier;
    [SerializeField] FloatVariable monsterHPMultiplier;
    [SerializeField] IntegerVariable playerGold;
    [SerializeField] GameEvent onGoldChange;
    private int[] upgradeIndex;
    public bool BuyUpgrade(int index){
        int cost = GetCostValue(index);
        if (playerGold.value < cost) return false;
        playerGold.value -= cost;
        onGoldChange.Raise();
        return true;
    }
    public void Upgrade(int index){
        int limit;
        switch (index){
            case 1: limit = 25;
                break;
                case 4:
                case 5: limit = 50;
                    break;
            default: limit = 100;
                break;
        }
        if (upgradeIndex[index] >= limit) return;
        upgradeIndex[index]++;
        LoadValuesIntoVariables();
    }
    public int GetCostValue(int index){
        return GetValueFromCurve(upgradeIndex[index]+1, lowCostCurve);
    }

    public int GetUpgradeValue(int index, bool nextLevel){
        int offset = nextLevel ? 1:0;
        AnimationCurve ac;
        switch(index){
            case 0: ac = weaponDamageCurve;
                break;
            case 1: ac = attacksPerSecondCurve;
                break;
            case 2: ac = weaponDamageMultiplierCurve;
                break;
            case 3: ac = baseGoldCurve;
                break;
            case 4: ac = goldMultiplierCurve;
                break;
            case 5: ac = monsterHPMultiplierCurve;
                break;
            default: return -1;
        }
        return GetValueFromCurve(upgradeIndex[index]+offset, ac);
    }

    int GetValueFromCurve(int index, AnimationCurve curve){
        int value = (int)curve.Evaluate(index);
        return value;
    }

    public void LoadValues(int[] ui){
        upgradeIndex = ui;
        LoadValuesIntoVariables();
    }

    public void LoadDefaultValues(){
        upgradeIndex = new int[6];
        for (int x = 0; x < upgradeIndex.Length; x++){
            upgradeIndex[x] = 0;
        }
        LoadValuesIntoVariables();
    }

    private void LoadValuesIntoVariables(){
        weaponDamage.value = (int)weaponDamageCurve.Evaluate(upgradeIndex[0]);
        attacksPerSecond.value = attacksPerSecondCurve.Evaluate(upgradeIndex[1]);
        weaponDamageMultiplier.value = weaponDamageMultiplierCurve.Evaluate(upgradeIndex[2]);
        baseGold.value = (int)baseGoldCurve.Evaluate(upgradeIndex[3]);
        goldMultiplier.value = goldMultiplierCurve.Evaluate(upgradeIndex[4]);
        monsterHPMultiplier.value = monsterHPMultiplierCurve.Evaluate(upgradeIndex[5]);
    }
}
