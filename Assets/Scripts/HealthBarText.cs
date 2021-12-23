using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarText : Text
{
    public void UpdateText(IntegerVariable health){
        text = health.Value + " HP";
    }
}
