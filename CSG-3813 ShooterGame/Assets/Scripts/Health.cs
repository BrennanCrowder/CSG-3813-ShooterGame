/*
 * Created by: Brennan Crowder
 * Date Created: 9/20/21
 * 
 * Last Edited by: Brennan Crowder
 * Last Updated: 9/20/21
 * 
 * Description: Controls GameObject Health 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public bool destroyOnDeath = true;
    public GameObject deathParticlesPrefab;// = null;

    public float healthPoints
    {
        get
        {
            return _healthPoints;
        }
        set
        {
            _healthPoints = value;
            if (healthPoints <= 0)
            {
                SendMessage("Die", SendMessageOptions.DontRequireReceiver);
                if (deathParticlesPrefab != null)
                {
                    Instantiate(deathParticlesPrefab, transform.position, transform.rotation);
                }
                if (destroyOnDeath)
                {
                    Destroy(gameObject);
                }
            }
        }
    }

    [SerializeField] float _healthPoints = 100f;

    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            healthPoints = 0;
        }
    }



}
