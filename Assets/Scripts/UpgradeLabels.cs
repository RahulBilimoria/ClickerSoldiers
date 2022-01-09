using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeLabels : MonoBehaviour
{
    public Upgrades upgradeData;
    public Text[] statText;
    public Text[] costText;

    public void BuyUpgrade(int index){
        if (!upgradeData.BuyUpgrade(index)) return;
        upgradeData.Upgrade(index);
        UpdateStatText(index);
        UpdateCostText(index);
    }

    public void UpdateText(){
        for (int x = 0; x < statText.Length; x++){
            UpdateStatText(x);
            UpdateCostText(x);
        }
    }

    private void UpdateStatText(int index){
        string text = upgradeData.GetUpgradeValue(index, false) +"";
        switch(index){
            case 5: text += "(-";
                break;
            default: text += "(+";
                break;
        }
        text += (upgradeData.GetUpgradeValue(index, true) - upgradeData.GetUpgradeValue(index, false));
        switch(index){
            case 0: text += ") Damage";
                break;
            case 1: text += ") APS";
                break;
            case 2: text += "%) Damage";
                break;
            case 3: text += ") Gold";
                break;
            case 4: text += "%) Gold";
                break;
            case 5: text += "%) HP";
                break;
            default:
                break;
        }
        statText[index].text = text;
    }

    private void UpdateCostText(int index){
        costText[index].text = upgradeData.GetCostValue(index)+"";
    }
}
