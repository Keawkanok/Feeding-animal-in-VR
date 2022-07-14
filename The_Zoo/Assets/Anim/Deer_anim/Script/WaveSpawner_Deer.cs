using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class WaveSpawner_Deer : MonoBehaviour
{
    public GameObject[] spawnees;

    int randomInt;

    public Transform spawnPoint;

    public static float timeBetweenWaves = 5f;

    private float countdown = 2f;

    public static int waveNumber = 1;

    public List<int> intlist = new List<int>();


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


        for (int l = 0; l < spawnees.Length; l++)
        {
            /*intlist.Add(i);*/
            if (!intlist.Contains(l))
            {
                intlist.Add(l);
            }
        }
        intlist = intlist.OrderBy(tvz => System.Guid.NewGuid()).ToList();

       /* for (int k = 0; k < intlist.Count; k++)
        {
            Debug.Log("the unique random value" + intlist[k]);
        }*/

        randomInt = Random.Range(0, spawnees.Length);

        Instantiate(spawnees[randomInt], spawnPoint.position, spawnPoint.rotation);
    }


}
