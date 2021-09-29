/*
 * Created by: Brennan Crowder
 * Date Created: 9/20/21
 * 
 * Last Edited by: Brennan Crowder
 * Last Updated: 9/20/21
 * 
 * Description: Deal damage to obj 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProxyDamage : MonoBehaviour
{
    public float damageRate = 25f; // DPS



    private void OnTriggerStay(Collider other)
    {
        Health hlth = other.GetComponent<Health>();

        if (hlth == null) { return; }

        hlth.healthPoints -= damageRate;
    }
}
