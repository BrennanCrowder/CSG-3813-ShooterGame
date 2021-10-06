using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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

    private static int nextLevel = 1;
    public string ScorePrefix = "Score: ";
    public TMP_Text scoreText;
    public TMP_Text gameOverText;
    public TMP_Text levelCompleteText;
    public TMP_Text targetText;
    public static int Score = 0;
    public static int target;
    private static bool isRunning = true;

    // Start is called before the first frame update
    void Awake()
    {
        checkGameManagerInScene();
    }

    private void OnLevelWasLoaded(int level)
    {
        Score = 0;
        isRunning = true;
        if (nextLevel == 1)
        {
            nextLevel = 2;
        }
        else
        {
            nextLevel = 1;
        }
        if (targetText != null)
        {
           targetText.text = "Target: " + target;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isRunning)
        {
            if (scoreText != null)
            {
                scoreText.text = ScorePrefix + Score.ToString();
            }
            if (Score >= target)
            {
                LevelWin();
            }
        }
        
    }

    public bool getRunning()
    {
        return isRunning;
    }
    public static void LevelWin()
    {
        if(gm.levelCompleteText != null)
        {
           gm.levelCompleteText.gameObject.SetActive(true);
           isRunning = false;
        }
        
    }

    public static void GameOver()
    {
        if(gm.gameOverText != null && isRunning)
        {
            gm.gameOverText.gameObject.SetActive(true);
            isRunning = false;
        }
        
    }

    public static void Reset()
    {
       // Debug.Log("Resetting Scene...");
        
    }

    public static void NextLevel()
    {
        Debug.Log(nextLevel);
        if (nextLevel == 1 || nextLevel == 2)
        {
           Debug.Log("Loading Next Level..." + nextLevel.ToString());
           //Reset();
           SceneManager.LoadScene("Level" + nextLevel.ToString());
           
        }
        
    }

    public void setTarget(int itarget)
    {
        target = itarget;
    }
}
