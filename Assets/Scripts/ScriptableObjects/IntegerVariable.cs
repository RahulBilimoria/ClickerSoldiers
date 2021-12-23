using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/CreateInteger")]
public class IntegerVariable : ScriptableObject
{
    public int Value;

    public void SetValue(IntegerVariable v){
        Value = v.Value;
    }

    public void IncreaseBy(int x){
        Value += x;
    }
}
