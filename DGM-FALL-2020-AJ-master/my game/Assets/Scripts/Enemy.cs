using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
public GameObject player;
public bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void onCollisionEnter(Collision collision)
       {   

           if(collision.collider.gameObject == player)
           {
               gameObject.SetActive(true);
               gameOver = true;               
               Debug.Log("GAME OVER!");
              
           }
       }
}