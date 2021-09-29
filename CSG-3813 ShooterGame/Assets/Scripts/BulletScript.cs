using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float damage = 100f;
    public float lifeTime = 2f;
    

    private void OnEnable()
    {
        CancelInvoke();
        Invoke("Die", lifeTime);
        
    }

    void Die()
    {
        
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        Health H = other.GetComponent<Health>();
        if (H == null) 
        {
            Die();
            return; 
        }

        H.healthPoints -= damage;

        Die();
    }
   
}
