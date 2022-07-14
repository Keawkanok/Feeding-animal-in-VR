using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : SceneManagement
{
    [SerializeField]
    public float delayLoading = 15f;
    [SerializeField]
    public GameObject UIObject_TextGameOver;
    private float timeElapsed;
    public void Start()
    {
        UIObject_TextGameOver.SetActive(false);
    }
    public void Update()
    {
        GameOverScene01();
        GameOverScene02();
    }

    public void GameOverScene01()
    {
        timeElapsed += Time.deltaTime;

        if (Vemon_Sc_Deer.GameOver == 3)
        {
            UIObject_TextGameOver.SetActive(true);
            RandomFood.waveNumber = 0;
            if (timeElapsed > delayLoading)
            {
                RandomFood.waveNumber = 1;
                Vemon_Sc_Deer.GameOver = 0;
                ScoreDeer.score = 0;
                SceneZero();
            }
        }
        else if (Vemon_Sc_Boar.GameOver == 3)
        {
            UIObject_TextGameOver.SetActive(true);
            RandomFood.waveNumber = 0;

            if (timeElapsed > delayLoading)
            {
                RandomFood.waveNumber = 1;
                Vemon_Sc_Boar.GameOver = 0;
                ScoreBoar.score = 0;
                SceneZero();
            }
        }
    }

    public void GameOverScene02()
    {
        timeElapsed += Time.deltaTime;

        if (Vemon_Sc_Lion.GameOver == 3)
        {
            UIObject_TextGameOver.SetActive(true);
            RandomFood.waveNumber = 0;

            if (timeElapsed > delayLoading)
            {
                RandomFood.waveNumber = 1;
                Vemon_Sc_Lion.GameOver = 0;
                ScoreLion.score = 0;
                SceneZero();
            }
        }
        else if (Vemon_Sc_Zebra.GameOver == 3)
        {
            UIObject_TextGameOver.SetActive(true);
            RandomFood.waveNumber = 0;

            if (timeElapsed > delayLoading)
            {
                RandomFood.waveNumber = 1;
                Vemon_Sc_Zebra.GameOver = 0;
                ScoreZebra.score = 0;
                SceneZero();

            }
        }
    }
}
