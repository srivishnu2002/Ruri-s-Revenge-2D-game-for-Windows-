using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperOrb : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 25;
    public Rigidbody2D rb;
    public GameObject impactEffect;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        BossHealth BossHealth = hitInfo.GetComponent<BossHealth>();
        enemy enemy = hitInfo.GetComponent<enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
            Destroy(gameObject);
        }
        if (BossHealth != null)
        {
            BossHealth.TakeDamage(damage);
            Destroy(gameObject);
        }
        Instantiate(impactEffect, transform.position, transform.rotation);




    }


}
