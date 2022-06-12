using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChange : MonoBehaviour
{
    public int nextSceneLoad;


    //[SerializeField] private string sceneName;
    void start()
    {
        nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            HeartTextScript.heartAmount = 3;
            ScoreTextScript.coinAmount = 0;
            SceneManager.LoadScene(nextSceneLoad);
            //SceneManager.LoadScene(sceneName);
            if(nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
            {
                PlayerPrefs.SetInt("levelAt", nextSceneLoad);
            }
        }
    }
}

