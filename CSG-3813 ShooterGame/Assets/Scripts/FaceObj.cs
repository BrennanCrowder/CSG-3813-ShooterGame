/*
 * Created by: Brennan Crowder
 * Date Created: 9/20/21
 * 
 * Last Edited by: Brennan Crowder
 * Last Updated: 9/20/21
 * 
 * Description: What object to face 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceObj : MonoBehaviour
{
    public Transform objToFace;
    public bool facePlayer = false;

    private void Awake()
    {
        if(!facePlayer) { return; }
        GameObject PlayerObj = GameObject.FindGameObjectWithTag("Player");

        if (PlayerObj != null)
        {
            objToFace = PlayerObj.transform;
        }
    }

    private void Update()
    {
        if (objToFace == null) { return; }

        Vector3 dirToObj = objToFace.position - transform.position;

        if (dirToObj != Vector3.zero)
        {
            transform.localRotation = Quaternion.LookRotation(dirToObj.normalized, Vector3.up);
        }
    }

}
