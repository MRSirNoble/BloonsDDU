using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balloonSpawner : MonoBehaviour
{
    public GameObject blue, red;
    public float spawnRate = 2f;
    float nextSpawn = 0f;
    int whatToSpawn;
    public float minSpawn;
    public float maxSpawn;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            float randomLocation = Random.Range(minSpawn, maxSpawn);
            whatToSpawn = Random.Range(1, 3);
            Debug.Log(whatToSpawn);
            
            switch (whatToSpawn)
            {
                case 1:
                    Instantiate(blue, transform.position = new Vector2(transform.position.x, randomLocation), Quaternion.identity);
                    break;

                case 2:
                    Instantiate(red, transform.position = new Vector2(transform.position.x, randomLocation), Quaternion.identity);
                    break;
            }

            nextSpawn = Time.time + spawnRate;
        }
        
    }
}
