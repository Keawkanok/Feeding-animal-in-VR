using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PanelOpener : MonoBehaviour
{
    public GameObject Panel;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OpenPanel()
    {
        if (Panel != null)
        {
            Panel.SetActive(true);
        }
    }
}
