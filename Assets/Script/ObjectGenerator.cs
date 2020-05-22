using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGenerator : MonoBehaviour
{
    public GameObject mRectPrefab;
    public GameObject trianglePrefab;
    public GameObject enemyPrefab;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 5; i++)
        {
            //rectの生成
            GameObject mRect = Instantiate(mRectPrefab) as GameObject;
            mRect.GetComponent<Transform>().transform.position = new Vector3(Random.Range(-20.0f, 20.0f), 0.5f, Random.Range(-20.0f, 20.0f));
            mRect.GetComponent<Transform>().transform.Rotate(0, Random.Range(-90.0f, 90.0f), 0.0f);
            mRect.GetComponent<Transform>().transform.localScale = new Vector3(Random.Range(1.0f, 10.0f), 1.0f, 1.0f);

            //triangle
            GameObject triangle = Instantiate(trianglePrefab) as GameObject;
            triangle.GetComponent<Transform>().transform.position = new Vector3(Random.Range(-20, 20), 0.5f, Random.Range(-20, 20));
            triangle.GetComponent<Transform>().transform.Rotate(0, Random.Range(-90, 90), 0);

            //enemy
            GameObject enemy = Instantiate(enemyPrefab) as GameObject;
            enemy.GetComponent<Transform>().transform.position = new Vector3(Random.Range(-20, 20), 0.5f, Random.Range(-20, 20));
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
