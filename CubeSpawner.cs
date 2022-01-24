using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public Rigidbody projectile;
    public Transform dropperEnd;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;


    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }
    void Update()
    {
        /* if (Input.GetKeyDown("space"))
         {
             Instantiate(projectile, dropperEnd.position,dropperEnd.rotation);
         }*/

    }
    public void SpawnObject()
    {
        Instantiate(projectile, dropperEnd.position, dropperEnd.rotation);
        if (stopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
    }
}
