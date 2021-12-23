using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/FloatVariable")]
public class FloatVariable : ScriptableObject, ISerializationCallbackReceiver
{
    public float value;

    [System.NonSerialized]
    public float runtimeValue;

    public void OnAfterDeserialize()
    {
		runtimeValue = value;
    }

    public void OnBeforeSerialize() { }
}
