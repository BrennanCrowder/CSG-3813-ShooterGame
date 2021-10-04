using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    #region GameManager Singleton
    static GameManager gm;
    public static GameManager GM
    {
        get
        {
            return gm;
        }
    }
    void checkGameManagerInScene()
    {
        if(gm == null)
        {
            gm = this;
        } else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
    #endregion

    public string ScorePrefix = "Score: ";
    public TMP_Text scoreText;
    public TMP_Text gameOverText;
    public TMP_Text levelCompleteText;
    public static int Score = 0;


    // Start is called before the first frame update
    void Awake()
    {
        checkGameManagerInScene();
    }

    // Update is called once per frame
    void Update()
    {
        if( scoreText != null)
        {
            scoreText.text = ScorePrefix + Score.ToString();
        }
        if (Score >= 10000)
        {
            LevelWin();
        }
    }
    public static void LevelWin()
    {
        gm.levelCompleteText.gameObject.SetActive(true);
    }

    public static void GameOver()
    {
        if(gm.gameOverText != null)
        {
            gm.gameOverText.gameObject.SetActive(true);
        }
    }
}
