using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimitiveManager : MonoBehaviour
{
    public GameObject primitiveType;
    private float startDelay =2f;
    private float timeInterval = 2f;
    private Vector3 spawnLocation;
    private Rigidbody rbPrimitive;
    public int score = 0;

    void Start()
    {
        InvokeRepeating("PrimitiveSpawn", startDelay, timeInterval); // For calling "PrimitiveSpawn" after a delay and then repeating for a time
    }

    // Update is called once per frame
    void Update()
    {
        //PrimitiveBounce();
    }

    void PrimitiveSpawn() // For the spawing of sphere prefab
    {

        spawnLocation = new Vector3(Random.Range(-1.5f,1.5f), Random.Range(0.8f, 1.6f), -0.5f);  // for random spawn location on X and Y
        Instantiate(primitiveType, spawnLocation, primitiveType.transform.rotation); // Instantiating primitive prefab at random location and rotation
    }
}
