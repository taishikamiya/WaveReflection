using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveObjectController : MonoBehaviour
{
    private Vector3 lastVelocity;
    private Rigidbody rigidbody;

    public AudioClip rectSound;
    public AudioClip triangleSound;
    public AudioClip tipSound;
    public AudioClip enemySound;

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
        if (collision.gameObject.tag == "rect")
        {
            Vector3 reflectVector = Vector3.Reflect(this.lastVelocity, collision.contacts[0].normal);
            this.rigidbody.velocity = reflectVector;

            //GameObjectのz方向ベクトルを反射ベクトル方向に向ける。
            this.transform.forward = reflectVector;

            AudioSource.PlayClipAtPoint(rectSound, this.transform.position);
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
            AudioSource.PlayClipAtPoint(triangleSound, this.transform.position);
            
        }

        //tag判定 triangle-tip        
        if (collision.gameObject.tag == "tip")
        {

            Vector3 reflectVector = Vector3.Reflect(this.lastVelocity, collision.contacts[0].normal);
            this.rigidbody.velocity = reflectVector;
            this.transform.forward = reflectVector;
            Debug.Log("tip");
            AudioSource.PlayClipAtPoint(tipSound, this.transform.position);
        }

        //enemy       
        if (collision.gameObject.tag == "enemy")
        {

            Vector3 reflectVector = Vector3.Reflect(this.lastVelocity, collision.contacts[0].normal);
            this.rigidbody.velocity = reflectVector;
            this.transform.forward = reflectVector;
            AudioSource.PlayClipAtPoint(enemySound, this.transform.position);
        }

        //waveObject同士の接触
        if (collision.gameObject.tag == "waveObject")
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }

        //周囲のWall接触
        if (collision.gameObject.tag == "wall")
        {
            Destroy(this.gameObject);
        }

    }
}
