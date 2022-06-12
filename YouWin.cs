using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YouWin : MonoBehaviour
{
    [SerializeField] private string sceneName;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            HeartTextScript.heartAmount = 3;
            ScoreTextScript.coinAmount = 0;

            SceneManager.LoadScene(sceneName);
        }
    }
}
