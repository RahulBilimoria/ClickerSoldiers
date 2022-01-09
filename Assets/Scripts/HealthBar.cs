using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;

    public void SetHealth(IntegerVariable health){
        slider.value = health.value;
    }

    public void SetMaxHealth(IntegerVariable maxHealth){
        slider.maxValue = maxHealth.value;
        slider.value = maxHealth.value;
    }
}
