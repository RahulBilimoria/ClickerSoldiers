using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    public GameEvent onHealthChange;
    public GameEvent onDeath;
    public GenerateDrops dropGenerator;
    public FloatVariable weaponDamMulti;
    public IntegerVariable baseMaxHealth;
    public IntegerVariable maxHealth;
    public IntegerVariable health;
    public void TakeDamage(IntegerVariable damageTaken){
        health.value -= (int)(damageTaken.value * (1 + (weaponDamMulti.value/100)));
        onHealthChange.Raise();

        if (health.value <= 0){
            onDeath.Raise();
            dropGenerator.GenerateGold();
        }
    }
}
