using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objToSpawn;

    public float radius = 10f;
    public static float interval = 5f;
    //public Transform orgin;
    public GameObject spawnLocation;
    public GameObject greenObj;
    public GameObject redObj;
    public GameObject[] wall;
    public GameObject emptyWall;

    private int count = 0;
    private void Start()
    {
        //InvokeRepeating("Spawn", 0f, interval);
    }

    private void Update()
    {
        if (count < 100)
        {
            Invoke("Spawn", interval);
        }
        interval++;
        count++;
    }

    void Spawn()
    {
        Debug.Log("Spawn");

        GameObject newWall = Instantiate(emptyWall, spawnLocation.transform.position, spawnLocation.transform.rotation);

        for (int i = 0; i < 11; i++)
        {
            int number = Random.Range(1, 3);
            if(number == 1)
            {
                wall[i] = greenObj;
            } else if (number == 2) {
                wall[i] = redObj;
            }
            GameObject wallPiece = Instantiate(wall[i], spawnLocation.transform.position + new Vector3(0,0,i), spawnLocation.transform.rotation);
            wallPiece.transform.parent = newWall.transform;
        }

    }
}
