using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/FloatVariable")]
public class FloatVariable : ScriptableObject
{
    public float value;

    public void SetValue(IntegerVariable v){
        value = v.value;
    }

    public void IncreaseBy(float f){
        value += f;
    }
}
