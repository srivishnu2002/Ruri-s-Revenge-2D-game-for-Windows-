using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartScript : MonoBehaviour
{

    bool destroyed = false;
    public GameObject CollectedAnimation;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            SoundManagerScript.PlaySound("collect");
            SoundManagerScript.PlaySound("extralife");
            if (destroyed == false)
            {
                destroyed = true;
                Destroy(gameObject);
                HeartTextScript.heartAmount += 1;

            }

            Instantiate(CollectedAnimation, transform.position, transform.rotation);
        }


    }
}
