using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    private float bulletSpeed = 1f; //  the bulet speed
    public PlayerController playerController;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BulletMove();
        BulletDestroy();
    }

    void BulletMove() // For move the bullte with a speed
    {
        transform.Translate(Vector3.up * Time.deltaTime * bulletSpeed);
    }

    private void OnTriggerEnter(Collider other) // For Collion of bullet and primitive
    {
        score++;
        Destroy(gameObject);  // Destroying the bullet
        Destroy(other.gameObject); // Destroying the primitive
        ScoreDisplay();
    }


    void BulletDestroy()
    {
        if(transform.position.y > 2.5f)
        {
            Destroy(gameObject);
        }
    }

    void ScoreDisplay()
    {
        Debug.Log("Score: " + score);
    }

}
