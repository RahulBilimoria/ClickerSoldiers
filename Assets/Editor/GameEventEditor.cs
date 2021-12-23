using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(GameEvent))]
public class GameEventEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        GameEvent e = (GameEvent)target;
        if(GUILayout.Button("Raise")){
            e.Raise();
        }
    }
}
