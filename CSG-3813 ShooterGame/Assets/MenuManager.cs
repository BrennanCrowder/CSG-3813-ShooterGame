using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class MenuManager : MonoBehaviour
{
    public TMP_Text highScoreText;

    private void Awake()
    {
        
        GameManager.target = 100000;
        GameManager.GM.highScoreText = highScoreText;
        
    }
    private void Start()
    {
        GameManager.GM.setNextLevel(1);
    }

    public void setNextLevel(int ilevel)
    {
        GameManager.GM.setNextLevel(ilevel);
    }

    public void nextLevel()
    {
        GameManager.NextLevel();
    }

    public void quitGame()
    {
        Debug.Log("Exiting Game...");
        Application.Quit();
    }
}
