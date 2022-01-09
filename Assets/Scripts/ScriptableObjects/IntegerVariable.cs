using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/CreateInteger")]
public class IntegerVariable : ScriptableObject
{
    public int value;

    public void SetValue(IntegerVariable v){
        value = v.value;
    }

    public void IncreaseBy(int x){
        value += x;
    }
}
