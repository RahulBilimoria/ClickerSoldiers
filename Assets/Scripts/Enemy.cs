using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Entity
{
    public Sprite[] enemySpriteList;
    public SpriteRenderer sr;
    public RarityChance enemyRarityType;
    public FloatVariable attacksPerSecond;
    private float attackSpeed;
    private float size;
    private int rarity;
    private int mobType;

    public void SpawnEnemy(){
        rarity = enemyRarityType.GetRarity();
        //sr.sprite = enemySpriteList[(int)Random.Range(0,15)];
        sr.material.color = enemyRarityType.GetColor(rarity);
        //maxHealth.Value = 
    }

    public void SetMonsterHP(FloatVariable HPMulti){
        maxHealth.value = (int)(baseMaxHealth.value - (baseMaxHealth.value * (HPMulti.value/100)));
    }
}
