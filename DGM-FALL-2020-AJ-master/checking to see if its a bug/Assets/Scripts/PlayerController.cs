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
    public GameManager gameManager;

    public bool gameOver = false;
    public bool hasPrize = false;
    public bool youWin = false;
    
    public GameObject enemy;
    private Rigidbody playerRb;

    public AudioSource playerAudio;


    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAudio  = GetComponent<AudioSource>();


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
       if(collider.gameObject.CompareTag("Enemy"))
      {
        Collider enemyCollider = collider.gameObject.GetComponent<Collider>();
        gameOver = true;
        Debug.Log("GAME OVER");
        gameManager.GameOver();
      }

      if(collider.gameObject.CompareTag("EndGame"))
      {
          Collider endGameCollider = collider.gameObject.GetComponent<Collider>();
          youWin=true;
          Debug.Log("YouWin!");
          gameManager.EndGame();
      }
    }
}