﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectObjects : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        print("Collision with object");
    }
}
