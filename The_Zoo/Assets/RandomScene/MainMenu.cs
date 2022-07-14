using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu: SceneManagement
{
    public void PlayGame()
    {
        float m_Ramdom = Random.Range(1, 3);
        if (m_Ramdom == 1)
        {
            SceneManager.LoadScene(1);
            Debug.Log("m_Ramdom " + m_Ramdom);
        }
        else if (m_Ramdom == 2)
        {
            SceneManager.LoadScene(2);
            Debug.Log("m_Ramdom " + m_Ramdom);
        }
    }
    public void SceneManual()
    {
        SceneManager.LoadScene(8);
    }
    public void SceneManualFood()
    {
        SceneManager.LoadScene(7);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
