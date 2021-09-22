/*
 * Created by: Brennan Crowder
 * Date Created: 9/20/21
 * 
 * Last Edited by: Brennan Crowder
 * Last Updated: 9/20/21
 * 
 * Description: Continue move GameObject
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float maxSpeed = 10f;

    private void Update()
    {
        transform.position += transform.forward * maxSpeed * Time.deltaTime;
    }

    

}
