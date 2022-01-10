using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class AutoAttack : MonoBehaviour
{
    [SerializeField] BooleanVariable isUnlocked;
    [SerializeField] FloatVariable attacksPerSecond;
    [SerializeField] IntegerVariable damage;
    [SerializeField] Button unlock;
    private UnityAction action;
    public Enemy enemy;
    public void AssignButtonHandler(){
        if(isUnlocked.value) return;
        action = new UnityAction(UnlockAps);
        unlock.onClick.AddListener(action);
    }

    private void UnlockAps(){
        StartCoroutine(Attack());
        unlock.onClick.RemoveListener(action);
    }

    IEnumerator Attack(){
        while(true){
            yield return new WaitForSeconds(1/attacksPerSecond.value);
            enemy.TakeDamage(damage);
        }
    }
}
