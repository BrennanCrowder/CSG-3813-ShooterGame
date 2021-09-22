using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objToSpawn;


    public float radius = 10f;
    public float interval = 5f;
    public Transform orgin;

    private void Awake()
    {
        orgin = GameObject.FindGameObjectWithTag("Player").transform;

    }
    private void Start()
    {
        InvokeRepeating("Spawn", 0f, interval);
    }


    void Spawn()
    {
        if(orgin == null) { return; }

        Vector3 SpawnPos = orgin.position + Random.onUnitSphere * radius;
        SpawnPos = new Vector3(SpawnPos.x, 0f, SpawnPos.z);
        Instantiate(objToSpawn, SpawnPos, Quaternion.identity);
    }
}
