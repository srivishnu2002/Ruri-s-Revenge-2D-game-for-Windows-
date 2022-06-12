using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;

public class BossHealth : MonoBehaviour
{
    public HealthBar healthBar;
    public int currenthealth = 1500;
    
    public GameObject deathEffect;
    public GameObject ring;
    public Transform dropPoint;
    public bool drops;

    //[SerializeField] private string sceneName;
    //public float Delay = 1f;
    


    public void TakeDamage(int damage)
    {
        currenthealth -= damage;
        healthBar.SetHealth(currenthealth);
        SoundManagerScript.PlaySound("hitsolid");
        if (currenthealth <= 0)
        {
            //Die();
            SoundManagerScript.PlaySound("playerdead");
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            if (drops) Instantiate(ring, dropPoint.position, dropPoint.rotation); 
            Destroy(gameObject);
            //Invoke("Win", Delay);

            
        }
        


    }
    //void Die()
    //{
        //SoundManagerScript.PlaySound("playerdead");
        //Instantiate(deathEffect, transform.position, Quaternion.identity);
        //Destroy(gameObject);
        
    //}
    //void Win()
    //{
        
        
        //SceneManager.LoadScene(sceneName);
       
    //}






}

