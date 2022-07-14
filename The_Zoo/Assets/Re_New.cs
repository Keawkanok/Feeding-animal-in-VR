using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class Re_New : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        float m_Ramdom = Random.Range(3, 5);
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
    
        /*SceneManager.LoadScene(3);*/
    }
}
