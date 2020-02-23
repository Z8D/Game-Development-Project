﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForestBossHealth : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth;
    public GameObject healthBar;
    public float scale;

    //enemy takes damage
    public void damageEnemy(int playerDamage)
    {
        currentHealth -= playerDamage;

        if (currentHealth <= 0)
        {
            //Destroy(gameObject);
        }
    }


    // Update is called once per frame
    void Update()
    {
        scale = (float)currentHealth / (float)maxHealth;
        healthBar.transform.localScale = new Vector3(scale, 1, 1);
    }
}