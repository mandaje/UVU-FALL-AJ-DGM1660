using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
 
 {
    private int speed = 30;
    private float turnSpeed = 100;

    private float hInput;
    private float fInput;
    public GameObject projectile;

    public bool gameOver = false;
    public bool hasPrize = false;
    
    public GameObject enemy;
    private Rigidbody playerRb;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        fInput = Input.GetAxis("Vertical");

        // Move the Player forward base on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * fInput * speed);
        //Rotated the Player left and right based on horizontal input
        transform.Rotate(Vector3.up * Time.deltaTime * hInput * turnSpeed);
    }
    
      private void OnTriggerEnter(Collider collider)
    {
      if(collider.CompareTag("Prize"))
      {
        hasPrize = true;
        Debug.Log("Prize = " + hasPrize);
        Destroy(collider.gameObject);
      }
    }

    private void OnCollisionEnter(Collision collision)
    {
      if(collision.gameObject.CompareTag("Enemy"))
      {
        Rigidbody enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>();
        gameOver = true;
        Debug.Log(gameOver);
        Destroy(collider.gameObject);
      }
    }
}

