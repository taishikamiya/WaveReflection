﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWallController : MonoBehaviour
{
    private float rotSpeed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0, this.rotSpeed, 0);
        
    }
}
