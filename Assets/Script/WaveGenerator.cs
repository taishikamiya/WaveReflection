using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveGenerator : MonoBehaviour
{
    public GameObject wavePrefab;

    public GameObject waveObjectPrefab;

    private Transform playerTrans;
    private Vector3 playerPosition;

    private float speed = 100.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Playerの位置を取得
            playerTrans = GameObject.Find("Player").GetComponent<Transform>().transform;
            playerPosition = playerTrans.position;

            //wave生成
            GameObject wave = Instantiate(wavePrefab) as GameObject;
            wave.GetComponent<Rigidbody>().AddForce(0,0,speed);
            wave.GetComponent<Transform>().transform.position = new Vector3(playerPosition.x,playerPosition.y,playerPosition.z+1);

        }

        //WAVE OBJECT
        if (Input.GetKeyDown(KeyCode.Z))
        {
            //Playerの位置を取得
            playerTrans = GameObject.Find("Player").GetComponent<Transform>().transform;
            playerPosition = playerTrans.position;

            //wave Objの生成
            GameObject waveObject = Instantiate(waveObjectPrefab) as GameObject;
            waveObject.GetComponent<Rigidbody>().AddForce(0, 0, speed);
            waveObject.GetComponent<Transform>().transform.position = new Vector3(playerPosition.x, playerPosition.y, playerPosition.z + 2);

        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            //Playerの位置を取得
            playerTrans = GameObject.Find("Player").GetComponent<Transform>().transform;
            playerPosition = playerTrans.position;

            for(int r = 0; r < 360; r += 45)
            {
                GameObject wave = Instantiate(wavePrefab) as GameObject;
                wave.GetComponent<Rigidbody>().AddForce(Mathf.Sin(r * Mathf.Deg2Rad)*speed, 0, Mathf.Cos(r * Mathf.Deg2Rad)*speed);
                wave.GetComponent<Transform>().transform.position = new Vector3(playerPosition.x+1* Mathf.Sin(r * Mathf.Deg2Rad), playerPosition.y, playerPosition.z + 1* Mathf.Cos(r * Mathf.Deg2Rad));
            }
        }
    }
}
