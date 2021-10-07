using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoManager : MonoBehaviour
{
    #region AmmoManager Singleton
    public static AmmoManager ammoManagerSingleton;
    void setUpAmmoManager ()
    {
        Debug.Log("Set up manager");
        if (ammoManagerSingleton == null)
        {
            ammoManagerSingleton = this;
        } else
        {
            Destroy(GetComponent<AmmoManager>());
        }
    }
    #endregion

    public GameObject ammoPrefab;
    public int poolSize = 1;
    public Queue<Transform> ammoQueue = new Queue<Transform>();

    private GameObject[] ammoArray;

    private void Awake()
    {
        setUpAmmoManager();

        if(ammoManagerSingleton == null) { return; }

        ammoArray = new GameObject[poolSize];

        for (int i = 0; i < poolSize; i++)
        {
            ammoArray[i] = Instantiate(ammoPrefab, Vector3.zero, Quaternion.identity, transform) as GameObject;
            Transform objTransform = ammoArray[i].transform;

            ammoQueue.Enqueue(objTransform);
            ammoArray[i].SetActive(false);
        }

    }
    public static Transform spawnAmmo(Vector3 position, Quaternion rotation)
    {
        Transform spawnedAmmo = ammoManagerSingleton.ammoQueue.Dequeue();
        AmmoManager.ammoManagerSingleton.GetComponent<AudioSource>().Play();
        spawnedAmmo.gameObject.SetActive(true);
        spawnedAmmo.position = position;
        spawnedAmmo.localRotation = rotation;
        ammoManagerSingleton.ammoQueue.Enqueue(spawnedAmmo);
        return spawnedAmmo;
    }
}
