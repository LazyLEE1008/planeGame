﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockingBox : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.transform.name + "막았어 이게 무자시가");
    }
}
