using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMoving : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(!GameManager.GM.getRunning())
        {
            gameObject.GetComponent<Mover>().maxSpeed = 0f;
        }
    }
}
