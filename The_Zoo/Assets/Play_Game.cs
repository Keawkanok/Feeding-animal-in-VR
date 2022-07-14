using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Play_Game : MonoBehaviour , IPointerClickHandler
{
    void Update()
    {
        
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("¡´");
        Ramdom_playe();
    }
    public void Ramdom_playe()
    {
        float m_Ramdom = Random.Range(1, 3);
        if (m_Ramdom == 1)
        {
            // 1
            SceneManager.LoadScene(1);
            Debug.Log("m_Ramdom " + m_Ramdom);
        }
        else if (m_Ramdom == 2)
        {
            // 2
            SceneManager.LoadScene(2);
            Debug.Log("m_Ramdom " + m_Ramdom);
        }
    }
}
