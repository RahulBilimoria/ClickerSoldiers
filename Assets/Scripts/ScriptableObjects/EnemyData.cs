using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemy Data", menuName = "ScriptableObjects/CreateEnemyData")]
public class EnemyData : ScriptableObject
{
    public IntegerVariable maxHealth;
    public IntegerVariable health;
    public IntegerVariable damage;
}
