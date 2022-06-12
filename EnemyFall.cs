using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFall : MonoBehaviour
{
    bool destroyed = false;

    public GameObject TouchEffect;
    public GameObject PlayerDeath;

    

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SoundManagerScript.PlaySound("orb");
            if (destroyed == false)
            {
                destroyed = true;
                HeartTextScript.heartAmount -= 1;
                Destroy(gameObject);
                Instantiate(TouchEffect, transform.position, Quaternion.identity);
                if (HeartTextScript.heartAmount <= 0)
                {
                    SoundManagerScript.PlaySound("playerdie");
                    Destroy(collision.gameObject);
                    Instantiate(PlayerDeath, collision.transform.position, Quaternion.identity);
                    ScoreTextScript.coinAmount = 0;
                    

                }
                
            }
        }
        
    }
    
    


}

