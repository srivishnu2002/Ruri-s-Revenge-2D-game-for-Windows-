using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Level1");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void HowToPlay()
    {
        SceneManager.LoadScene("howtoplay");
    }
    public void WhoMadeThisGame()
    {
        SceneManager.LoadScene("whomadethisgame");
    }
    public void BacktoFirst()
    {
        HeartTextScript.heartAmount = 3;
        ScoreTextScript.coinAmount = 0;
        SceneManager.LoadScene("Menu");
    }
    public void LevelTwo()
    {
        SceneManager.LoadScene("Level2");
    }
    public void LevelThree()
    {
        SceneManager.LoadScene("Level3");
    }
    public void LevelFour()
    {
        SceneManager.LoadScene("Level4");
    }
    public void LevelFive()
    {
        SceneManager.LoadScene("Level5");
    }
    public void BossBattle()
    {
        SceneManager.LoadScene("BossBattle");
    }
    public void LevelMenu()
    {
        SceneManager.LoadScene("Level Menu");
    }
    public void StoryLine()
    {
        SceneManager.LoadScene("story");
    }
    public void Rules()
    {
        SceneManager.LoadScene("Rules");
    }
    public void Tutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
    public void StoryLine2()
    {
        SceneManager.LoadScene("story2");
    }
    public void StoryLine3()
    {
        SceneManager.LoadScene("story3");
    }
    public void ThankYou()
    {
        SceneManager.LoadScene("ThankYou");
    }
}
