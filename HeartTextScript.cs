using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class HeartTextScript : MonoBehaviour
{
    public TextMeshProUGUI Hearttext;
    public static double heartAmount = 3;
    public float restartDelay = 1f;
    // Start is called before the first frame update
    void Start()
    {
        Hearttext = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        Hearttext.text = "X" + heartAmount.ToString();
        if (heartAmount <= 0)
        {
            SoundManagerScript.PlaySound("playerdead");
            Invoke("Restart", restartDelay);
            
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        heartAmount = 3;
    }

}
