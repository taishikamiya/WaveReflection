using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody myRigidBody;
    private Vector3 PlayerPos;
    private float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        this.myRigidBody = GetComponent<Rigidbody>();
        this.PlayerPos = GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {

        /*
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            myRigidBody.AddForce(-10, 0, 0);
            this.transform.Rotate(0, -10, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            myRigidBody.AddForce(10, 0, 0);
            this.transform.Rotate(0, 10, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            myRigidBody.AddForce(0, 0, -10);
            this.transform.Rotate(0, -10, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            myRigidBody.AddForce(0, 0, 10);
            this.transform.Rotate(0, 10, 0);
        }
        */

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        this.myRigidBody.velocity = new Vector3(x * speed, 0, z * speed);

        Vector3 diff = this.transform.position - this.PlayerPos;

        if(diff.magnitude > 0.01f)
        {
            this.transform.rotation = Quaternion.LookRotation(diff);
        }

        this.PlayerPos = this.transform.position;   // ポジションアップデート
    }
}
