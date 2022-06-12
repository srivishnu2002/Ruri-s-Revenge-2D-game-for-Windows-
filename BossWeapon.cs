using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossWeapon : MonoBehaviour
{
    bool canshoot = false;
    public Transform player;
    public Transform bossfire;
    public GameObject cherryPrefab;
    public float attackRange = 7f;
    Rigidbody2D rb;
    public float speed = 5.0f;

    public void Attack()
    {
        

        if (Vector2.Distance(player.position, rb.position) <= attackRange)
        {
            StartCoroutine(Shoot());
        }

    }
    IEnumerator Shoot()
    {

        canshoot = true;
        Instantiate(cherryPrefab, bossfire.position, bossfire.rotation);
        yield return new WaitForSeconds(0.5f);
        canshoot = false;
    }
       // public void Shoot()
       // {
       // Instantiate(cherryPrefab, bossfire.position, bossfire.rotation);
        //}
}
