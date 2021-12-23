using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateLabels : MonoBehaviour
{
    public IntegerVariable zoneArea;
    public IntegerVariable monsterCount;
    public Text Zone;
    public Text Gold;

    public void updateZoneText(){
        if (monsterCount.Value > 10){
            monsterCount.Value = 1;
            zoneArea.Value++;
        }
        Zone.text = "Zone " + zoneArea.Value + " - " + monsterCount.Value + "/10";
    }

    public void updateGoldText(IntegerVariable goldAmount){
        Gold.text = "Gold: " + goldAmount.Value;
    }
}
