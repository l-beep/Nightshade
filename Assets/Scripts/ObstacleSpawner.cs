using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.VFX;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;
    public float obstacleSpawnTime = 2f;
    private float timeUntilObstacleSpawn;
    public float obstacleSpeed = 1f;

    private void Update()
    {
        SpawnLoop();
    }


    private void SpawnLoop()
    {
        timeUntilObstacleSpawn += Time.deltaTime;

        if(timeUntilObstacleSpawn >= obstacleSpawnTime)
        {
            Spawn();
            timeUntilObstacleSpawn = 0f;
        }       
    }

    private void Spawn()
    {
        GameObject obstacleToSpawn = obstaclePrefabs[Random.Range(0, obstaclePrefabs.Length)];

        GameObject spawnedObstacles = Instantiate(obstacleToSpawn, transform.position, Quaternion.identity);
        Rigidbody2D obstaclerb = spawnedObstacles.GetComponent<Rigidbody2D>();
        obstaclerb.velocity = Vector2.left * obstacleSpeed;
    }
}


