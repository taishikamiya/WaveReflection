using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform playerTransform;
    private Vector3 cameraOffset;

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.Find("Player").transform;
        cameraOffset = GetComponent<Transform>().position - playerTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //座標にtargetの座標を代入
        GetComponent<Transform>().position = playerTransform.position + cameraOffset;
        
    }
}
