using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public AudioClip enemySound;
    public AudioSource enemyAudio;

    public float speed;
    private Rigidbody enemyRb;

    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
       enemyRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter(Collider collider)
    {
    if(collider.gameObject.CompareTag("player"))
      {
        Collider playerCollider = collider.gameObject.GetComponent<Collider>();
        enemyAudio.PlayOneShot(enemySound, 1.0f);
        Vector3 lookDirection = (player.transform.position - transform.position).normalized; 
        enemyRb.AddForce(lookDirection * speed);
        player = GameObject.Find("Player");
      }
    }
   
}