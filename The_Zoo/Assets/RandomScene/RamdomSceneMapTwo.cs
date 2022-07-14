using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomSceneMapTwo : MonoBehaviour
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
}
