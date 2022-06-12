using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CoinScript : MonoBehaviour
{
    
    bool destroyed = false;
    public GameObject CollectedAnimation;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            SoundManagerScript.PlaySound("collect");
            if (destroyed == false)
            {
                destroyed = true;
                Destroy(gameObject);
                ScoreTextScript.coinAmount += 1;
                
            }

            Instantiate(CollectedAnimation, transform.position, transform.rotation);
        }

        
    }

}
