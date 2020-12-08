﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    //Sets the target for the camera
    public GameObject player;
    public Vector3 offset = new Vector3(0, 0, 0);

    // Update is called once per frame
    void Update()
    {
        //Makes the main camera follow the players position
        transform.position = player.transform.position + offset;
    
    }
}
