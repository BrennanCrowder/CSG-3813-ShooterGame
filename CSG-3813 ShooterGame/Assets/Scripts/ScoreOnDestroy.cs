using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreOnDestroy : MonoBehaviour
{
    public int points = 1;

    private void OnDestroy()
    {
        GameManager.Score += points;    
    }
}
