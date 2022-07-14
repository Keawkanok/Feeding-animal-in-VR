using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NextScene : MonoBehaviour
{
    private int next;
    void Start()
    {
        next = SceneManager.GetActiveScene().buildIndex + 1;
    }

    void Update()
    {
        
    }
}
