using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    public GameEvent onHealthChange;
    public GameEvent onDeath;
    public IntegerVariable baseMaxHealth;
    public IntegerVariable maxHealth;
    public IntegerVariable health;
    public IntegerVariable damage;
    public void TakeDamage(IntegerVariable enemyDamage){
        health.Value -= enemyDamage.Value;
        onHealthChange.Raise();

        if (health.Value <= 0){
            onDeath.Raise();
        }
    }
}
