using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //public GameObject objToSpawn;

    //public float radius = 10f;
    public static float interval = 5f;
    //public Transform orgin;
    public GameObject spawnLocation;
    public GameObject greenObj;
    public GameObject redObj;
    public GameObject[] wall;
    public GameObject emptyWall;

    //private int count = 0;
    private void Start()
    {
        interval = 5f;
        Debug.Log("Interval: " + interval);
        for (int count = 0; count <= GameManager.target / 100; count++)
        {
            Invoke("Spawn", interval);
            
            interval++;
        }
    }

    private void Update()
    {

        if (!GameManager.GM.getRunning())
        {
            Debug.Log("Stopping Spawn...");
            CancelInvoke();
        }
    }

    void Spawn()
    {
        Debug.Log("Spawn");
        int greenCount = 0;
        GameObject newWall = Instantiate(emptyWall, spawnLocation.transform.position, spawnLocation.transform.rotation);

        for (int i = 0; i < 11; i++)
        {
            int number = Random.Range(1, 3);
            if(number == 1)
            {
                wall[i] = greenObj;
                greenCount++;
            } else if (number == 2) {
                wall[i] = redObj;
                
            }
            GameObject wallPiece = Instantiate(wall[i], spawnLocation.transform.position + new Vector3(0,0,i), spawnLocation.transform.rotation);
            wallPiece.transform.parent = newWall.transform;
        }
        if (greenCount == 0)
        {
            Destroy(newWall);
            Debug.Log("Unlucky...");
            Spawn();
        }

    }
}
