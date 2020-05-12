using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody myRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        this.myRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            myRigidBody.AddForce(-10, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            myRigidBody.AddForce(10, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            myRigidBody.AddForce(0, 0, -10);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            myRigidBody.AddForce(0, 0, 10);
        }

    }
}
