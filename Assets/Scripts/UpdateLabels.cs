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
        if (monsterCount.value > 10){
            monsterCount.value = 0;
            zoneArea.value++;
        }
        Zone.text = "Zone " + zoneArea.value + " - " + monsterCount.value + "/10";
    }

    public void updateGoldText(IntegerVariable goldAmount){
        Gold.text = "Gold: " + goldAmount.value;
    }
}
