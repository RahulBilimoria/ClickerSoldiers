using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class FloatReference
{
    public bool useConstant = true;
    public float constantValue;
    public FloatVariable variable;

    public float Value {
        get { return useConstant ? constantValue : variable.runtimeValue;}
    }
}
