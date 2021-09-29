using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireWeapon : MonoBehaviour
{
    public GameObject bulletPrefab;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            AmmoManager.spawnAmmo(transform.position, transform.rotation);
        }

    }
}
