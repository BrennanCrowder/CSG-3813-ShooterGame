using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SceneManager1Script : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text gameOverText;
    public TMP_Text levelCompleteText;
    public TMP_Text targetText;
    public int target;

    void Awake()
    {
        GameManager.GM.scoreText = scoreText;
        GameManager.GM.gameOverText = gameOverText;
        GameManager.GM.levelCompleteText = levelCompleteText;
        GameManager.GM.targetText = targetText;

        GameManager.GM.setTarget(target);
    }

}
