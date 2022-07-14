using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomFood : MonoBehaviour
{
    public GameObject[] spawnees;
    int randomInt;
    public Transform spawnPoint;
    public static float timeBetweenWaves = 5f;
    public float countdown = 0f;
    public static int waveNumber = 1;

    void Update()
    {
        Countdown();
    }

    public void Countdown()
    {
        if (countdown <= 0f)
        {
            RandomWaveNumber();
            countdown = timeBetweenWaves;
        }
        countdown -= Time.deltaTime;
    }

    void RandomWaveNumber()
    {
        for (int i = 0; i < waveNumber; i++)
        {
            RandomObj();
        }
    }
    void RandomObj()
    {
        randomInt = Random.Range(0, spawnees.Length);
        Instantiate(spawnees[randomInt], spawnPoint.position, spawnPoint.rotation);
    }
}
