using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePreb;
    private Vector3 spawnPos = new Vector3 (25, 0, 0);

    private float startDelay;
    private float repeatDelay;
    
    private PlayerController1 playerController1Script;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating( "SpawnObstacles", startDelay, repeatDelay);
        playerController1Script = GameObject.Find("Player").GetComponent<PlayerController1>();
    }

    void SpawnObstacles()
    {
        if(playerController1Script.gameOver == false)
        {
             Instantiate(obstaclePreb, spawnPos, obstaclePreb.transform.rotation);
        }
         
    }
}
