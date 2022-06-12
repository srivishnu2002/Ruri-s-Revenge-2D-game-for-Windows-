using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{


    public int health = 100;
    public GameObject deathEffect;
    

    public void TakeDamage(int damage)
    {
        

        health -= damage;
        SoundManagerScript.PlaySound("hitsolid");
        if (health <= 0)
        {
            
            Die();
        }


    }
    void Die()
    {
        SoundManagerScript.PlaySound("playerdead");
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);



    }


}