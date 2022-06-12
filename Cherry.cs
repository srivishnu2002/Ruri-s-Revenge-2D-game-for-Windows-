using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cherry : MonoBehaviour
{
    
    public Rigidbody2D rb;
    public GameObject impactEffect;
    public float speed = 20f;
    public GameObject PlayerDeath;
    double damage = 0.1;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "Player")
        {
            SoundManagerScript.PlaySound("hitsolid");
            Instantiate(impactEffect, transform.position, transform.rotation);
            Destroy(gameObject);
            HeartTextScript.heartAmount -= damage;
            
        }

        if (HeartTextScript.heartAmount <= 1)
        {
            HeartTextScript.heartAmount = 0;
            SoundManagerScript.PlaySound("playerdie");
            Destroy(collision.gameObject);
            Instantiate(PlayerDeath, collision.transform.position, Quaternion.identity);
            
        }
        
        
        
        

    }
}
