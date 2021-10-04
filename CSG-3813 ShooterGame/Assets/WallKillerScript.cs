using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallKillerScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Destroying Wall");
        GameManager.Score += 100;
        Destroy(other.gameObject);
    }
}
