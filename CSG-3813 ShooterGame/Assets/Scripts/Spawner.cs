using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public static int enemyAmnt;
    public GameObject player;
    // Update is called once per frame
    void Update()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-1f, 1f)*5, 0, Random.Range(-1f, 1f)*20);
        if (enemyAmnt <= 8)
        {
            Instantiate(enemyPrefab, spawnPos, enemyPrefab.transform.rotation);
            enemyAmnt++;
        }
    }
}
