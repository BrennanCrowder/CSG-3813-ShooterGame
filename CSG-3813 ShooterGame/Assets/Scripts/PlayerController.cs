/*
 * Created by: Brennan Crowder
 * Date Created: 9/13/21
 * 
 * Last Edited by: Brennan Crowder
 * Last Updated: 9/12/21
 * 
 * Description: Controls the player's movements 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // [SerializeField] float speed = 5f;
    public bool mouseLook = true;
    public string horzAxis = "Horizontal";
    public string vertAxis = "Vertical";
    public string fireAxis = "Fire1";
    public float maxSpeed = 5f;

    Rigidbody rb = null;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horz = Input.GetAxis(horzAxis);
        float vert = Input.GetAxis(vertAxis);

        Vector3 moveDirection = new Vector3(horz, 0f, vert);
        rb.AddForce(moveDirection.normalized * maxSpeed);

        rb.velocity = new Vector3(Mathf.Clamp(rb.velocity.x, -maxSpeed, maxSpeed), //x
                                  Mathf.Clamp(rb.velocity.y,-maxSpeed,maxSpeed), //y
                                  Mathf.Clamp(rb.velocity.z, -maxSpeed, maxSpeed)); //z
        if(mouseLook)
        {
            Vector3 mousePosWorld = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0f));

            mousePosWorld = new Vector3(mousePosWorld.x, 0, mousePosWorld.z);

            Vector3 lookDirection = mousePosWorld - transform.position;
            
            transform.localRotation = Quaternion.LookRotation(lookDirection.normalized, Vector3.up);
        }

    }
}
