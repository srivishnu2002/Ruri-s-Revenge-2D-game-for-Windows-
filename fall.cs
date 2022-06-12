using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class fall : MonoBehaviour
{
    public GameObject PlayerDeath;
    public float restartDelay = 1f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SoundManagerScript.PlaySound("playerdie");
            Destroy(collision.gameObject);
            Instantiate(PlayerDeath, collision.transform.position, Quaternion.identity);
            Invoke("Restart", restartDelay);
            
        }
        
    }
    void Restart()
    {
        HeartTextScript.heartAmount = 3;
        ScoreTextScript.coinAmount = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}

