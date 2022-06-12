using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreTextScript : MonoBehaviour
{
    [SerializeField] private string sceneName;
    public TextMeshProUGUI text;
    public static int coinAmount;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "X" + coinAmount.ToString();
        if(coinAmount >= 5)
        {
            SceneManager.LoadScene(sceneName);
            coinAmount = 0;
            
        }
    }

}
