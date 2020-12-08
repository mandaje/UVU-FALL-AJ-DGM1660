﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Sets the target for the camera
    public GameObject player;
    public Vector3 offset = new Vector3(0, 5, -10);
    public GameObject thePlayer;

    // Update is called once per frame
    void Update()
    {
        // Makes the main camera follow the players position
        transform.position = player.transform.position + offset;
            // Update is called once per frame
    }
}