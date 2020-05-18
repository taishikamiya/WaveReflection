using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveObjectController : MonoBehaviour
{
    private Vector3 lastVelocity;
    private Rigidbody rigidbody;

    public AudioClip sound; 

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
        //tag判定
        if (collision.gameObject.tag == "wall")
        {
            Vector3 reflectVector = Vector3.Reflect(this.lastVelocity, collision.contacts[0].normal);
            this.rigidbody.velocity = reflectVector;

            //GameObjectのz方向ベクトルを反射ベクトル方向に向ける。
            this.transform.forward = reflectVector;
            //        this.transform.Rotate(0, 180, 0);

            AudioSource.PlayClipAtPoint(sound, this.transform.position);
        }

        //tag判定
        if (collision.gameObject.tag == "Player")
        {
            Vector3 reflectVector = Vector3.Reflect(this.lastVelocity, collision.contacts[0].normal);
            this.rigidbody.velocity = reflectVector;
            this.transform.forward = reflectVector;

        }

        //tag判定 triangle
        
        if (collision.gameObject.tag == "triangle")
        {

            Vector3 reflectVector = Vector3.Reflect(this.lastVelocity, collision.contacts[0].normal);
            this.rigidbody.velocity = reflectVector;
            this.transform.forward = reflectVector;
            Debug.Log("tip");

        }

    }
}
