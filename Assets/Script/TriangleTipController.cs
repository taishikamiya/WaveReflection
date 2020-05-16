using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleTipController : MonoBehaviour
{
    public GameObject waveObjectPrefab;
    private Vector3 lastVelocity;
    private Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {

        //tag判定
//        if (GameObject.Find("triangle").gameObject.tag == "waveObject")
        if (collision.gameObject.tag == "waveObject")
            {
                Vector3 reflectVector = Vector3.Reflect(this.lastVelocity, collision.contacts[0].normal);
            collision.rigidbody.velocity = reflectVector;
            collision.transform.forward = reflectVector;

            Debug.Log("test");
            //wave Objの生成
            GameObject waveObject = Instantiate(waveObjectPrefab) as GameObject;
            waveObject.GetComponent<Transform>().transform.position = collision.transform.position + collision.transform.forward;
            waveObject.GetComponent<Transform>().rotation = Quaternion.LookRotation(collision.transform.forward);
            waveObject.GetComponent<Rigidbody>().velocity = collision.transform.forward * 10;
            //wave Objの生成
//            waveObject = Instantiate(waveObjectPrefab) as GameObject;
  //          waveObject.GetComponent<Transform>().transform.position = collision.transform.position + collision.transform.forward;
    //        waveObject.GetComponent<Transform>().rotation = Quaternion.LookRotation(collision.transform.forward);
      //      waveObject.GetComponent<Rigidbody>().velocity = collision.transform.forward * 10;

        }
    }
}
