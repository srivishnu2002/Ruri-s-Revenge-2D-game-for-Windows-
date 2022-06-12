using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Restart : MonoBehaviour
{

    public void RestartGame()
    {
        HeartTextScript.heartAmount = 3;
        ScoreTextScript.coinAmount = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads current scene
    }

}
