using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objToSpawn;

    public float radius = 10f;
    public float interval = 3f;
    //public Transform orgin;
    public GameObject[] spawnLocations;
    public GameObject greenObj;
    public GameObject redObj;
    public GameObject[] wall;

    private void Start()
    {
        InvokeRepeating("Spawn", 0f, interval);
    }


    void Spawn()
    {
        Debug.Log("Spawn");
        for(int i = 0; i < spawnLocations.Length; i++)
        {
            int number = Random.Range(1, 3);
            if(number == 1)
            {
                wall[i] = greenObj;
            } else if (number == 2) {
                wall[i] = redObj;
            }
        }
        for (int i = 0; i < spawnLocations.Length; i++)
        {
            Instantiate(wall[i], spawnLocations[i].transform.position, spawnLocations[i].transform.rotation);

        }
    }
}
