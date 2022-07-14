using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    /*public Transform enemyPrefab;*/
    public GameObject[] spawnees;

    int randomInt;

    public Transform spawnPoint;

    public float timeBetweenWaves = 5f;

    private float countdown = 2f;

    private int waveNumber = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
        /* SpawnEnemy();*/
        /*Debug.Log("Wave Incomming!");*/
        for (int i = 0; i < waveNumber; i++)
        {
            SpawnEnemy();
        }

        /*SpawnEnemy();*/
    }
    void SpawnEnemy()
    {
        /*Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);*/


        randomInt = Random.Range(0, spawnees.Length);
        Instantiate(spawnees[randomInt], spawnPoint.position, spawnPoint.rotation);


    }
}
