using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopTheWalls : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
    }
}
