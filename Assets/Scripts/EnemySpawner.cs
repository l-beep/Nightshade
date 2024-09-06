using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemies;
    public Transform[] enemySpawnPos;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Spawn();
        }
    }


    void Spawn()
    {
        int randomEnemyIndex = Random.Range(0, enemies.Length);
        int randomPositionIndex = Random.Range(0,enemySpawnPos.Length);
        Instantiate(enemies[randomEnemyIndex], enemySpawnPos[randomPositionIndex].position, Quaternion.identity);
    }
}

