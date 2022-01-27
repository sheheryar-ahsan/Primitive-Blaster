using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float playerSpeed = 5f; // player moving speed
    private float horizontalInput; // player horizontal input value
    public GameObject bulletPrefab; // for bullet prefab
    private float startDelay = 0.5f;
    private float timeInterval = 0.25f;
    private Vector3 spawnLocation;
    public int score = 0;

    void Start()
    {
        InvokeRepeating("BulletFire", startDelay, timeInterval); // For calling "BulletFire" after a delay and then repeating for a time
    }

    void Update()
    {
        MovementInput();
        ScoreDisplay();
    }

    void MovementInput() // For the left/right movement of the player
    { 
        
        if(transform.position.x > 1.5f ) // Restricting the player not to go more than value of 1.5
        {
            transform.position = new Vector3(1.5f, transform.position.y, transform.position.z); // Setting the new X location
        }
        else if (transform.position.x < -1.5f) // Restricting the player not to go more than value of -1.5
        {
            transform.position = new Vector3(-1.5f, transform.position.y, transform.position.z); // Setting the new -X location
        }
        horizontalInput = Input.GetAxis("Horizontal"); // Getting horizontal input
        transform.Translate(Vector3.right * -horizontalInput * Time.deltaTime * playerSpeed); // transforming left/right on the bases of input
    }

    void BulletFire() // For the spawing of bullet prefab
    {
        spawnLocation = new Vector3(this.transform.position.x, 0.35f , -0.5f);  // for bullet spawn location, fixed to player X axis position
        Instantiate(bulletPrefab, spawnLocation, bulletPrefab.transform.rotation); // Instantiating bullet prefab at given location and rotation
    }

    public void ScoreDisplay()
    {
        
    }
}
