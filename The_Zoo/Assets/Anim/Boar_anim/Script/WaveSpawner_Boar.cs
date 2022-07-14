using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner_Boar : MonoBehaviour
{
    public GameObject[] spawnees;

    int randomInt;

    public Transform spawnPoint;

    public static float timeBetweenWaves = 5f;

    public float countdown = 0f;

    public static int waveNumber = 1;

    void Update()
    {
        if (countdown <= 0f)
        {
            SpawnWave();
            countdown = timeBetweenWaves;
        }
        countdown -= Time.deltaTime;
    }

    void SpawnWave()
    {
        for (int i = 0; i < waveNumber; i++)
        {
            SpawnEnemy();
        }
    }
    void SpawnEnemy()
    {
        /*Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);*/
        randomInt = Random.Range(0, spawnees.Length);
        Instantiate(spawnees[randomInt], spawnPoint.position, spawnPoint.rotation);
    }
}
