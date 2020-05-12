using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveObjectController : MonoBehaviour
{
    private Vector3 lastVelocity;
    private Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        this.rigidbody = this.GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        this.lastVelocity = this.rigidbody.velocity;
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Vector3 reflectVector = Vector3.Reflect(this.lastVelocity, collision.contacts[0].normal);
        this.rigidbody.velocity = reflectVector;
        this.transform.Rotate(0, 180, 0);

    }
}
