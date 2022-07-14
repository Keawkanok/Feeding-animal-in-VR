using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public void RandomSceneMapTwos()
    {
        float m_Ramdom = Random.Range(3, 6);
        Debug.Log(m_Ramdom);
        if (m_Ramdom == 3)
        {
            SceneManager.LoadScene(3);
        }
        else if (m_Ramdom == 4)
        {
            SceneManager.LoadScene(4);
        }
        else if (m_Ramdom == 5)
        {
            SceneManager.LoadScene(5);
        }
    }


    public void RePlay()
    {
        float m_Ramdom = Random.Range(3, 6);
        if (m_Ramdom == 3)
        {
            SceneManager.LoadScene(3);
            time.timeValue = 301;
        }
        else if (m_Ramdom == 4)
        {
            SceneManager.LoadScene(4);
            time.timeValue = 301;

        }
        else if (m_Ramdom == 5)
        {
            SceneManager.LoadScene(5);
            time.timeValue = 301;
        }
    }
    public void ResetScoreM1()
    {
        RandomFood.waveNumber = 1;
        Vemon_Sc_Zebra.GameOver = 0;
        ScoreZebra.score = 0;
        RandomFood.waveNumber = 1;
        Vemon_Sc_Lion.GameOver = 0;
        ScoreLion.score = 0;
        RandomFood.waveNumber = 1;
        Vemon_Sc_Boar.GameOver = 0;
        ScoreBoar.score = 0;
        RandomFood.waveNumber = 1;
        Vemon_Sc_Deer.GameOver = 0;
        ScoreDeer.score = 0;
    }
  
    public void Back()
    {
        SceneManager.LoadScene(0);
    }

    public void SceneSix()
    {
        SceneManager.LoadScene(6);
    }
    public void SceneZero()
    {
        SceneManager.LoadScene(0);
    }
}
