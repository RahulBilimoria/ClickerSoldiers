using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/CreateBoolean")]
public class BooleanVariable : ScriptableObject
{
    public bool value;
    // Start is called before the first frame update
    public void SetValue(BooleanVariable v){
        value = v.value;
    }
}
